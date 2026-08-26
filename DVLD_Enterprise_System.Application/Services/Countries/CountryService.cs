using DVLD_Enterprise_System.Application.DTOs.Countries;
using DVLD_Enterprise_System.Application.Interfaces;

namespace DVLD_Enterprise_System.Application.Services.Countries
{
    /// <summary>
    /// Contains application-level operations related to countries.
    ///
    /// Countries are read-only reference data in the system.
    ///
    /// This service coordinates the operation between the API layer
    /// and the country repository without exposing Infrastructure
    /// implementation details to the API.
    /// </summary>
    public class CountryService : ICountryService
    {
        private readonly ICountryRepository _countryRepository;

        public CountryService(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }

        /// <summary>
        /// Retrieves all countries and maps Domain entities to DTOs.
        /// </summary>
        public async Task<IEnumerable<CountryDto>> GetAllAsync()
        {
            var countries = await _countryRepository.GetAllAsync();

            var countryDtos = new List<CountryDto>();

            foreach (var country in countries)
            {
                countryDtos.Add(new CountryDto
                {
                    CountryID = country.CountryID,
                    CountryName = country.CountryName
                });
            }

            return countryDtos;
        }

        /// <summary>
        /// Retrieves a country by ID and maps it to a DTO.
        ///
        /// Returns null when the country does not exist.
        /// </summary>
        public async Task<CountryDto?> GetByIdAsync(int id)
        {
            var country = await _countryRepository.GetByIdAsync(id);

            if (country == null)
                return null;

            return new CountryDto
            {
                CountryID = country.CountryID,
                CountryName = country.CountryName
            };
        }

        /// <summary>
        /// Checks whether a country exists.
        ///
        /// This operation is mainly used by other application operations,
        /// such as creating or updating a Person.
        /// </summary>
        public async Task<bool> ExistsAsync(int id)
        {
            return await _countryRepository.ExistsAsync(id);
        }
    }
}