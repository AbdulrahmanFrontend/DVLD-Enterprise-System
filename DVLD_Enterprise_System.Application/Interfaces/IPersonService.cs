using DVLD_Enterprise_System.Application.DTOs.People;

namespace DVLD_Enterprise_System.Application.Interfaces
{
    public interface IPersonService
    {
        Task<IEnumerable<PersonDto>> GetAllAsync();

        Task<PersonDto?> GetByIdAsync(int id);

        Task<PersonDto?> GetByNationalNoAsync(string nationalNo);

        Task<PersonDto> CreateAsync(CreatePersonDto dto);

        Task<PersonDto?> UpdateAsync(int id, UpdatePersonDto dto);

        Task<bool> DeleteAsync(int id);
    }
}
