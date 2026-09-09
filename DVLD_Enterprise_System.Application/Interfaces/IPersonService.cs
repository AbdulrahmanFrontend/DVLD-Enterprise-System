using DVLD_Enterprise_System.Application.DTOs;

namespace DVLD_Enterprise_System.Application.Interfaces;

public interface IPersonService
{
    Task<IReadOnlyList<PersonDto>> GetAllAsync();
    Task<PersonDto> GetByIdAsync(int id);
    Task<PersonDto> CreateAsync(PersonCreateDto dto);
    Task<PersonDto> UpdateAsync(int id, PersonUpdateDto dto);
}
