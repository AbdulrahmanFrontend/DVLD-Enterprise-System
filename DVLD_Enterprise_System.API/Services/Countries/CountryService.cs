using DVLD_Enterprise_System.API.DTOs.Countries;
using DVLD_Enterprise_System.Domain.Entities;
using DVLD_Enterprise_System.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace DVLD_Enterprise_System.API.Services.Countries
{
    public class CountryService : ICountryService
    {
        private readonly DVLDDbContext _context;

        public CountryService(DVLDDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<CountryDto>> GetAllAsync()
        {
            return await _context.Countries
                .AsNoTracking()
                .Select(c => new CountryDto
                {
                    CountryID = c.CountryID,
                    CountryName = c.CountryName
                })
                .ToListAsync();
        }

        public async Task<CountryDto?> GetByIdAsync(int id)
        {
            return await _context.Countries
                .AsNoTracking()
                .Where(c => c.CountryID == id)
                .Select(c => new CountryDto
                {
                    CountryID = c.CountryID,
                    CountryName = c.CountryName
                })
                .FirstOrDefaultAsync();
        }

        public async Task<CountryDto> CreateAsync(CreateCountryDto dto)
        {
            var country = new Country
            {
                CountryName = dto.CountryName
            };

            _context.Countries.Add(country);

            await _context.SaveChangesAsync();

            return new CountryDto
            {
                CountryID = country.CountryID,
                CountryName = country.CountryName
            };
        }

        public async Task<bool> UpdateAsync(int id, UpdateCountryDto dto)
        {
            var country = await _context.Countries
                .FirstOrDefaultAsync(c => c.CountryID == id);

            if (country == null)
                return false;

            country.CountryName = dto.CountryName;

            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var country = await _context.Countries
                .FirstOrDefaultAsync(c => c.CountryID == id);

            if (country == null)
                return false;

            _context.Countries.Remove(country);

            await _context.SaveChangesAsync();

            return true;
        }
    }
}
