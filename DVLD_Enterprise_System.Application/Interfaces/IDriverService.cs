using DVLD_Enterprise_System.Application.DTOs;

namespace DVLD_Enterprise_System.Application.Interfaces;

public interface IDriverService
{
    Task<IReadOnlyList<DriverDto>> GetAllAsync();
    Task<DriverDto> GetByIdAsync(int id);
    Task<DriverDto> CreateAsync(DriverCreateDto dto);
}
