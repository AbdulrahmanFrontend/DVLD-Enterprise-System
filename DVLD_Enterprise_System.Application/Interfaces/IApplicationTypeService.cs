using DVLD_Enterprise_System.Application.DTOs;

namespace DVLD_Enterprise_System.Application.Interfaces;

public interface IApplicationTypeService
{
    Task<IReadOnlyList<ApplicationTypeDto>> GetAllAsync();
    Task<ApplicationTypeDto> GetByIdAsync(int id);
    Task<ApplicationTypeDto> CreateAsync(ApplicationTypeCreateDto dto);
}
