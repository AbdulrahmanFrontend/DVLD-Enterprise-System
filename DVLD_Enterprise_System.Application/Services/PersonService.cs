using DVLD_Enterprise_System.Application.Common;
using DVLD_Enterprise_System.Application.DTOs.People;
using DVLD_Enterprise_System.Application.Exceptions;
using DVLD_Enterprise_System.Application.Interfaces;
using DVLD_Enterprise_System.Domain.Entities;
using FluentValidation;
using Mapster;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace DVLD_Enterprise_System.Application.Services;

/// <summary>
/// Coordinates application operations related to Person entities.
///
/// This layer contains application rules such as:
///
/// - Checking whether referenced countries exist.
/// - Checking duplicate National Numbers.
/// - Checking duplicate phone numbers.
/// - Creating and updating Domain entities.
/// - Coordinating persistence through repositories and Unit of Work.
/// - Mapping Domain entities to Application DTOs.
///
/// It does not know how data is stored because it depends only
/// on repository abstractions.
/// </summary>
public class PersonService : IPersonService
{
    private readonly IAppDbContext _context;
    private readonly IValidator<CreatePersonDto> _createValidator;
    private readonly IValidator<UpdatePersonDto> _updateValidator;
    private readonly ILogger<PersonService> _logger;
    private readonly IFileStorageService _fileStorageService;

    public PersonService(
        IAppDbContext context,
        IValidator<CreatePersonDto> createValidator,
        IValidator<UpdatePersonDto> updateValidator,
        ILogger<PersonService> logger,
        IFileStorageService fileStorageService)
    {
        _context = context;
        _createValidator = createValidator;
        _updateValidator = updateValidator;
        _logger = logger;
        _fileStorageService = fileStorageService;
    }

    public async Task<PagedResult<FilteredPeopleDto>> GetFilteredPeopleAsync(
        GetPeopleQueryDto queryDto,
        CancellationToken cancellation = default)
    {
        if (queryDto is null)
            throw new ArgumentNullException(nameof(queryDto));

        // 1. اجعل الـ Query يبدأ كـ IQueryable (لا يتم التنفيذ على الداتابيز الآن)
        var query = _context.People
            .Include(p => p.NationalityCountry)
            .AsNoTracking()
            .AsQueryable();

        // 2. تطبيق الفلترة الديناميكية (Dynamic Where Clauses)

        if (!string.IsNullOrWhiteSpace(queryDto.nationalNo))
            query = query.Where(p => p.NationalNo.StartsWith(queryDto.nationalNo));

        if (!string.IsNullOrWhiteSpace(queryDto.firstName))
            query = query.Where(p => p.FirstName.StartsWith(queryDto.firstName));

        if (!string.IsNullOrWhiteSpace(queryDto.lastName))
            query = query.Where(p => p.LastName.StartsWith(queryDto.lastName));

        if (!string.IsNullOrWhiteSpace(queryDto.phoneNumber))
            query = query.Where(p => p.Phone.StartsWith(queryDto.phoneNumber));

        if (!string.IsNullOrWhiteSpace(queryDto.email))
            query = query
                .Where(p => p.Email != null && p.Email.StartsWith(queryDto.email));

        if (queryDto.gender.HasValue)
            query = query.Where(p => p.Gender == queryDto.gender.Value);

        if (queryDto.nationalityCountryId.HasValue)
            query = query
                .Where(
                p => p.NationalityCountryID == queryDto.nationalityCountryId.Value);

        // 3. حساب العدد الكلي للنتائج المطابقة للفلترة (قبل تطبيق الـ Skip و Take)
        var totalCount = await query.CountAsync();

        int pageNumber = Math.Max(1, queryDto.pageNumber);
        int pageSize = Math.Max(1, queryDto.pageSize);

        // 4. تطبيق الـ Pagination وترتيب النتائج
        var items = await query
            .OrderByDescending(p => p.PersonID) // ترتيب تنازلي للأحدث أوالأبجدي بحسب الحاجة
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ProjectToType<FilteredPeopleDto>()
            .ToListAsync();

        // 5. إرجاع النتيجة مغلفة مع تفاصيل الصفحات
        return new PagedResult<FilteredPeopleDto>(
            items,
            totalCount,
            queryDto.pageNumber,
            queryDto.pageSize);
    }

    public async Task<PersonDto?> GetByIdAsync(
        int id,
        CancellationToken cancellation = default)
    {
        var Person = await _context.People
            .AsNoTracking()
            .FirstOrDefaultAsync(p => p.PersonID == id, cancellation);

        if (Person == null)
            return null;

        return Person.Adapt<PersonDto?>();
    }

    public async Task<PersonDto?> GetByNationalNoAsync(
        string nationalNo,
        CancellationToken cancellation = default)
    {
        var Person = await _context.People
            .AsNoTracking()
            .FirstOrDefaultAsync(p => p.NationalNo == nationalNo, cancellation);

        if (Person == null)
            return null;

        return Person.Adapt<PersonDto?>();
    }

    private async Task ValidationAsync(
        CreatePersonDto dto,
        CancellationToken cancellation = default)
    {
        if (dto is null)
            throw new ArgumentNullException(nameof(dto));

        var validationResult = await _createValidator.ValidateAsync(dto, cancellation);

        if (!validationResult.IsValid)
            throw new ValidationException(validationResult.Errors);

        bool exists = await _context.People
            .AnyAsync(p => p.NationalNo == dto.NationalNo, cancellation);

        if (exists)
            throw new ConflictException($"National Number '{dto.NationalNo}' " +
                $"is already used by another person.");

        exists = await _context.People
            .AnyAsync(p => p.Phone == dto.Phone, cancellation);

        if (exists)
            throw new ConflictException(
                $"Phone Number '{dto.Phone}' is already used by another person.");

        exists = await _context.People
            .AnyAsync(p => p.Email == dto.Email && dto.Email != null,
            cancellation);

        if (exists)
            throw new ConflictException(
                $"Email Address '{dto.Email}' is already used by another person.");

        exists = await _context.Countries
            .AnyAsync(c => c.CountryID == dto.NationalityCountryID, cancellation);

        if (!exists)
            throw new NotFoundException(nameof(Country), dto.NationalityCountryID);
    }

    public async Task<int> CreateAsync(
        CreatePersonDto dto,
        CancellationToken cancellation = default)
    {
        if (dto is null)
            throw new ArgumentNullException(nameof(dto));

        // 1. التحقق عبر FluentValidation ورمي الاستثناء تلقائياً إذا فشل
        await ValidationAsync(dto, cancellation);

        string imagePath = string.Empty;
        if (dto.ImageStream != null && !string.IsNullOrEmpty(dto.ImageFileName))
            imagePath = await _fileStorageService.SaveFileAsync(
                dto.ImageStream,
                dto.ImageFileName,
                "uploads/people");

        var person = dto.Adapt<Person>();
        person.ImagePath = imagePath;

        await _context.People.AddAsync(person, cancellation);
        await _context.SaveChangesAsync(cancellation);

        _logger.LogInformation(
            "New person with ID {PersonID} saved successfully.", 
            person.PersonID);
        return person.PersonID; // إرجاع المعرف مباشرة
    }

    private async Task ValidationAsync(
        int id,
        UpdatePersonDto dto,
        CancellationToken cancellation = default)
    {
        if (dto is null)
            throw new ArgumentNullException(nameof(dto));

        var validationResult = await _updateValidator.ValidateAsync(dto, cancellation);

        if (!validationResult.IsValid)
            throw new ValidationException(validationResult.Errors);

        bool exists = await _context.People
            .AnyAsync(
                p => p.NationalNo == dto.NationalNo && p.PersonID != id,
                cancellation);

        if (exists)
            throw new ConflictException($"National Number '{dto.NationalNo}' " +
                $"is already used by another person.");

        exists = await _context.People
            .AnyAsync(p => p.Phone == dto.Phone && p.PersonID != id, cancellation);

        if (exists)
            throw new ConflictException(
                $"Phone Number '{dto.Phone}' is already used by another person.");

        exists = await _context.People
            .AnyAsync(
                p => p.Email == dto.Email && p.PersonID != id && dto.Email != null,
                cancellation);

        if (exists)
            throw new ConflictException(
                $"Email Address '{dto.Email}' is already used by another person.");

        exists = await _context.Countries
            .AnyAsync(c => c.CountryID == dto.NationalityCountryID, cancellation);

        if (!exists)
            throw new NotFoundException(nameof(Country), dto.NationalityCountryID);
    }

    public async Task UpdateAsync(
        int id, 
        UpdatePersonDto dto,
        CancellationToken cancellation = default)
    {
        var person = await _context.People.FindAsync(id, cancellation);
        if (person == null)
            throw new NotFoundException(nameof(Person), id); // سيرمي 404 تلقائياً عبر Middleware

        await ValidationAsync(id, dto, cancellation);

        string? imagePath = person.ImagePath; // الاحتفاظ بالمسار القديم افتراضياً

        // إذا أرسل المستخدم صورة جديدة
        if (dto.ImageStream != null && !string.IsNullOrEmpty(dto.ImageFileName))
        {
            // 1. حفظ الصورة الجديدة والحصول على مسارها
            imagePath = await _fileStorageService.SaveFileAsync(
                dto.ImageStream,
                dto.ImageFileName, 
                "uploads/people");

            // 2. إذا كانت هناك صورة قديمة مخزنة مسبقاً، قم بحذفها من السيرفر نظافةً للمساحة
            if (!string.IsNullOrEmpty(person.ImagePath))
                _fileStorageService.DeleteFile(person.ImagePath);
        }

        dto.Adapt(person);
        person.ImagePath = imagePath;

        await _context.SaveChangesAsync(cancellation);

        _logger.LogInformation($"Person {id} Updated Successfully.");
    }

    public async Task DeleteAsync(
        int id,
        CancellationToken cancellation = default)
    {
        var person = await _context.People.FindAsync(id, cancellation);
        if (person == null)
            throw new NotFoundException(nameof(Person), id);

        if (!string.IsNullOrEmpty(person.ImagePath) && File.Exists(person.ImagePath))
            _fileStorageService.DeleteFile(person.ImagePath);

        _context.People.Remove(person);
        await _context.SaveChangesAsync(cancellation);

        _logger.LogInformation("Person with ID {PersonID} deleted successfully.", id);
    }

    public async Task<PersonDto?> GetByPhoneNumberAsync(
        string phoneNumber,
        CancellationToken cancellation = default)
    {
        var Person = await _context.People
            .AsNoTracking()
            .FirstOrDefaultAsync(p => p.Phone == phoneNumber, cancellation);

        if (Person == null)
            return null;

        return Person.Adapt<PersonDto?>();
    }

    public async Task<PersonDto?> GetByEmailAsync(
        string email,
        CancellationToken cancellation = default)
    {
        var Person = await _context.People
            .AsNoTracking()
            .FirstOrDefaultAsync(p => p.Email == email, cancellation);

        if (Person == null)
            return null;

        return Person.Adapt<PersonDto?>();
    }

    public async Task<bool> ExistsAsync(
        int id, 
        CancellationToken cancellation = default)
    {
        bool exists = await _context.People
            .AnyAsync(p => p.PersonID == id, cancellation);

        return exists;
    }

    public async Task<bool> ExistsAsync(
        string nationalNo,
        CancellationToken cancellation = default)
    {
        bool exists = await _context.People
            .AnyAsync(p => p.NationalNo == nationalNo, cancellation);

        return exists;
    }
}
