using DVLD_Enterprise_System.Application.DTOs;

namespace DVLD_Enterprise_System.Application.Interfaces;

/// <summary>
/// PRACTICE EXERCISE FOR YOU:
/// This interface is provided, but the implementation (LicenseClassService) is
/// intentionally NOT included. It follows the exact same pattern as
/// CountryService / ApplicationTypeService (both provided). Try building
/// LicenseClassService.cs yourself using those two as a template — it's the
/// best way to make the Repository/Service pattern truly click.
/// </summary>
public interface ILicenseClassService
{
    Task<IReadOnlyList<LicenseClassDto>> GetAllAsync();
    Task<LicenseClassDto> GetByIdAsync(int id);
    Task<LicenseClassDto> CreateAsync(LicenseClassCreateDto dto);
}
