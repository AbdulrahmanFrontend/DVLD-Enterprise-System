using DVLD_Enterprise_System.Application.DTOs;
using DVLD_Enterprise_System.Application.Exceptions;
using DVLD_Enterprise_System.Application.Interfaces;
using DVLD_Enterprise_System.Application.Mapping;
using DVLD_Enterprise_System.Domain.Entities;

namespace DVLD_Enterprise_System.Application.Services;

/// <summary>
/// The simplest possible service: a thin pass-through over IUnitOfWork for a
/// pure lookup table that has no business rules of its own. Use this file as
/// the template for LicenseClassService and TestTypeService (see the practice
/// exercise notes on ILicenseClassService / ITestTypeService).
/// </summary>
public class CountryService : ICountryService
{
    private readonly DVLD_Enterprise_System.Domain.Interfaces.IUnitOfWork _unitOfWork;

    // CONSTRUCTOR INJECTION: ASP.NET Core's Dependency Injection container will
    // automatically create and pass in the IUnitOfWork implementation when this
    // service is requested (we'll register that in the API layer's Program.cs).
    public CountryService(DVLD_Enterprise_System.Domain.Interfaces.IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IReadOnlyList<CountryDto>> GetAllAsync()
    {
        var countries = await _unitOfWork.Countries.GetAllAsync();

        // .Select(...).ToList() projects each Country entity into a CountryDto
        // using the ToDto() extension method we wrote in MappingExtensions.
        return countries.Select(c => c.ToDto()).ToList();
    }

    public async Task<CountryDto> GetByIdAsync(int id)
    {
        var country = await _unitOfWork.Countries.GetByIdAsync(id)
            ?? throw new NotFoundException(nameof(Country), id);

        return country.ToDto();
    }

    public async Task<CountryDto> CreateAsync(CountryCreateDto dto)
    {
        var country = new Country { CountryName = dto.CountryName };

        await _unitOfWork.Countries.AddAsync(country);   // Step 1: stage the insert
        await _unitOfWork.SaveChangesAsync();             // Step 2: commit it (see IUnitOfWork docs)

        // After SaveChangesAsync(), EF Core has populated country.CountryID
        // with the real, database-generated identity value - that's why we
        // build the return DTO AFTER saving, not before.
        return country.ToDto();
    }
}
