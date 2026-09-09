using DVLD_Enterprise_System.Application.DTOs;

namespace DVLD_Enterprise_System.Application.Interfaces;

/// <summary>
/// PRACTICE EXERCISE FOR YOU (same as ILicenseClassService): implement
/// TestTypeService.cs yourself, mirroring CountryService / ApplicationTypeService.
/// </summary>
public interface ITestTypeService
{
    Task<IReadOnlyList<TestTypeDto>> GetAllAsync();
    Task<TestTypeDto> GetByIdAsync(int id);
    Task<TestTypeDto> CreateAsync(TestTypeCreateDto dto);
}
