using DVLD_Enterprise_System.Application.DTOs.Countries;

namespace DVLD_Enterprise_System.Application.Services.Countries
{
    public interface ICountryService
    {
        Task<IEnumerable<CountryDto>> GetAllAsync();

        Task<CountryDto?> GetByIdAsync(int id);

        Task<bool> ExistsAsync(int id);
    }
}
