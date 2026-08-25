using DVLD_Enterprise_System.Application.DTOs.Countries;
using DVLD_Enterprise_System.Application.Interfaces;
using DVLD_Enterprise_System.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DVLD_Enterprise_System.Application.Services.Countries
{
    public class CountryService : ICountryService
    {
        private readonly ICountryRepository _countryRepository;

        public CountryService(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }

        public async Task<IEnumerable<CountryDto>> GetAllAsync()
        {
            var counties = await _countryRepository.GetAllAsync();

            var countryDto = new List<CountryDto>();

            foreach(var country in counties)
            {
                countryDto.Add(new CountryDto
                {
                    CountryID = country.CountryID,
                    CountryName = country.CountryName,
                });
            }

            return countryDto;
        }

        public async Task<CountryDto?> GetByIdAsync(int id)
        {
            var country = await _countryRepository.GetByIdAsync(id);

            if (country == null)
                return null;

            return new CountryDto
            {
                CountryID = country.CountryID,
                CountryName = country.CountryName,
            };
        }

        public async Task<bool> ExistsAsync(int id)
        {
            return await _countryRepository.ExistsAsync(id);
        }
    }
}
