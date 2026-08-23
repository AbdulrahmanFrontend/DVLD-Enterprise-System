using DVLD_Enterprise_System.API.DTOs.People;

namespace DVLD_Enterprise_System.API.Services.People
{
    public interface IPersonService
    {
        Task<IEnumerable<PersonDto>> GetAllAsync();

        Task<PersonDto?> GetByIdAsync(int id);

        Task<PersonDto> CreateAsync(CreatePersonDto dto);

        Task<PersonDto?> UpdateAsync(int id, UpdatePersonDto dto);

        Task<bool> DeleteAsync(int id);
    }
}
