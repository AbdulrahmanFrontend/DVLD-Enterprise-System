using DVLD_Enterprise_System.Application.Common;
using DVLD_Enterprise_System.Application.DTOs.Users;
using DVLD_Enterprise_System.Application.Exceptions;
using DVLD_Enterprise_System.Application.Interfaces;
using DVLD_Enterprise_System.Domain.Entities;
using DVLD_Enterprise_System.Domain.Enums;
using FluentValidation;
using Mapster;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace DVLD_Enterprise_System.Application.Services;

public class UserManagementService : IUserManagementService
{
    private readonly IAppDbContext _context;
    private readonly IPasswordHasher _passwordHasher;
    private readonly ICurrentUserService _currentUserService; // 👈 إضافة خدمة المستخدم الحالي
    private readonly IValidator<CreateUserDto> _createUserValidator;
    private readonly IValidator<UpdateUserDto> _updateUserValidator;
    private readonly ILogger<UserManagementService> _logger;

    public UserManagementService(
        IAppDbContext context,
        IPasswordHasher passwordHasher,
        ICurrentUserService currentUserService,
        IValidator<CreateUserDto> createUserValidator,
        IValidator<UpdateUserDto> updateUserValidator,
        ILogger<UserManagementService> logger)
    {
        _context = context;
        _passwordHasher = passwordHasher;
        _currentUserService = currentUserService;
        _createUserValidator = createUserValidator;
        _updateUserValidator = updateUserValidator;
        _logger = logger;
    }

    public async Task<int> CreateAsync(
        CreateUserDto dto,
        CancellationToken cancellation = default)
    {
        // 🔒 التحقق من الصلاحية داخل طبقة الـ Application
        if (!_currentUserService.HasPermission(Permissions.ManageUsers))
            throw new ForbiddenAccessException(
                "You do not have permission to create users!");

        await ValidateCreateUserDtoAsync(dto, cancellation);

        var user = dto.Adapt<User>();

        // استخدام dto.Password بدلاً من PasswordHash القادمة من الـ DTO الخام
        user.PasswordHash = _passwordHasher.HashPassword(user, dto.Password);

        _context.Users.Add(user);
        await _context.SaveChangesAsync(cancellation);

        _logger.LogInformation(
            "User {UserName} created successfully with ID {UserID}.", 
            user.UserName,
            user.UserID);

        return user.UserID;
    }

    private async Task ValidateCreateUserDtoAsync(
        CreateUserDto dto,
        CancellationToken cancellation)
    {
        await ValidateDtoAsync(dto, _createUserValidator);

        var exists = await _context.People.AnyAsync(
            p => p.PersonID == dto.PersonID, 
            cancellation);

        if (!exists)
            throw new NotFoundException(nameof(Person), dto.PersonID);

        exists = await _context.Users.AnyAsync(
            u => u.PersonID == dto.PersonID, 
            cancellation);

        if (exists)
            throw new ConflictException("That Person is already user!");

        exists = await _context.Users.AnyAsync(
            u => u.UserName == dto.UserName, 
            cancellation);

        if (exists)
            throw new ConflictException("Username is already exists!");
    }

    private async Task ValidateDtoAsync<T>(T dto, IValidator<T> validator)
    {
        if (dto is null)
            throw new ArgumentNullException(nameof(dto));

        var validationResult = await validator.ValidateAsync(dto);

        if (!validationResult.IsValid)
            throw new ValidationException(validationResult.Errors);
    }

    public async Task<PagedResult<FilteredUsersDto>> GetFilteredUsersAsync(
        GetUsersQueryDto queryDto,
        CancellationToken cancellationToken = default)
    {
        if (!_currentUserService.HasPermission(Permissions.ManageUsers))
            throw new ForbiddenAccessException("You do not have permission to view users!");

        if (queryDto is null)
            throw new ArgumentNullException(nameof(queryDto));

        var query = _context.Users
            .Include(p => p.Person)
            .AsNoTracking()
            .AsQueryable();

        if (queryDto.IsActive.HasValue)
            query = query.Where(p => p.IsActive == queryDto.IsActive.Value);

        if (!string.IsNullOrWhiteSpace(queryDto.UserName))
            query = query.Where(p => p.UserName.StartsWith(queryDto.UserName));

        // تصحيح مشكلة الـ FullName بالبحث عبر FirstName أو LastName لتجنب أخطاء EF Core الترجمية
        if (!string.IsNullOrWhiteSpace(queryDto.FullName))
            query = query.Where(p => p.Person.FirstName.StartsWith(queryDto.FullName)
            || p.Person.LastName.StartsWith(queryDto.FullName));

        var totalCount = await query.CountAsync(cancellationToken);

        int pageNumber = Math.Max(1, queryDto.PageNumber);
        int pageSize = Math.Max(1, queryDto.PageSize);

        var items = await query
            .OrderByDescending(p => p.UserID)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ProjectToType<FilteredUsersDto>()
            .ToListAsync(cancellationToken);

        return new PagedResult<FilteredUsersDto>(
            items,
            totalCount,
            queryDto.PageNumber,
            queryDto.PageSize);
    }

    public async Task<UserDto> GetByUserIdAsync(
        int id, 
        CancellationToken cancellationToken = default)
    {
        if (!_currentUserService.HasPermission(Permissions.ManageUsers))
            throw new ForbiddenAccessException(
                "You do not have permission to view user details!");

        var user = await _context.Users
            .AsNoTracking()
            .Include(u => u.Person)
            .FirstOrDefaultAsync(u => u.UserID == id, cancellationToken);

        if (user is null)
            throw new NotFoundException(nameof(User), id);

        return user.Adapt<UserDto>();
    }

    public async Task UpdateAsync(
        int id, 
        UpdateUserDto dto, 
        CancellationToken cancellationToken = default)
    {
        if (!_currentUserService.HasPermission(Permissions.ManageUsers))
            throw new ForbiddenAccessException(
                "You do not have permission to update users!");

        var user = await _context.Users.FindAsync(new object[] { id }, cancellationToken);
        if (user is null)
            throw new NotFoundException(nameof(User), id);

        await ValidateUpdateUserDtoAsync(id, dto, cancellationToken);

        user.Adapt(dto);
        await _context.SaveChangesAsync(cancellationToken);

        _logger.LogInformation(
            "User {UserName} updated successfully with ID {UserID}.", 
            user.UserName, 
            user.UserID);
    }

    private async Task ValidateUpdateUserDtoAsync(
        int id, 
        UpdateUserDto dto,
        CancellationToken cancellation)
    {
        await ValidateDtoAsync(dto, _updateUserValidator);

        var exists = await _context.Users.AnyAsync(
            u => u.UserName == dto.UserName && u.UserID != id,
            cancellation);
        
        if (exists)
            throw new ConflictException("Username is already exists!");
    }

    public async Task ToggleStatusAsync(
        int id,
        CancellationToken cancellationToken = default)
    {
        if (!_currentUserService.HasPermission(Permissions.ManageUsers))
            throw new ForbiddenAccessException(
                "You do not have permission to change user status!");

        var user = await _context.Users.FindAsync(new object[] { id }, cancellationToken);

        if (user is null)
            throw new NotFoundException(nameof(User), id);

        user.IsActive = !user.IsActive;
        await _context.SaveChangesAsync(cancellationToken);

        _logger.LogInformation(
            "User {UserName} status toggled to {IsActive}.", 
            user.UserName, 
            user.IsActive);
    }

    public async Task DeleteAsync(int id, CancellationToken cancellationToken = default)
    {
        if (!_currentUserService.HasPermission(Permissions.ManageUsers))
            throw new ForbiddenAccessException(
                "You do not have permission to delete users!");

        var user = await _context.Users.FindAsync(new object[] { id }, cancellationToken);

        if (user is null)
            throw new NotFoundException(nameof(User), id);

        _context.Users.Remove(user);
        await _context.SaveChangesAsync(cancellationToken);

        _logger.LogInformation("User {UserName} deleted successfully.", user.UserName);
    }
}