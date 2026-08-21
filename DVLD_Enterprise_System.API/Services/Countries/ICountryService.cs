using DVLD_Enterprise_System.API.DTOs.Countries;

namespace DVLD_Enterprise_System.API.Services.Countries
{
    public interface ICountryService
    {
        Task<IEnumerable<CountryDto>> GetAllAsync();

        Task<CountryDto?> GetByIdAsync(int id);

        Task<CountryDto> CreateAsync(CreateCountryDto dto);

        Task<bool> UpdateAsync(int id, UpdateCountryDto dto);

        Task<bool> DeleteAsync(int id);
    }
}
