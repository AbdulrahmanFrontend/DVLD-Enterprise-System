using DVLD_Enterprise_System.Application.Interfaces;
using DVLD_Enterprise_System.Domain.Entities;
using DVLD_Enterprise_System.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace DVLD_Enterprise_System.Infrastructure.Repositories
{
    /// <summary>
    /// Provides the Infrastructure implementation of ICountryRepository.
    ///
    /// This class belongs to Infrastructure because it uses EF Core
    /// and DVLDDbContext directly.
    ///
    /// The Application layer does not depend on this implementation.
    /// It depends only on ICountryRepository.
    /// </summary>
    public class CountryRepository : ICountryRepository
    {
        private readonly DVLDDbContext _context;

        public CountryRepository(DVLDDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Retrieves all countries.
        ///
        /// AsNoTracking is used because countries are read-only
        /// in this application and the returned entities are not
        /// intended to be updated through this repository.
        /// </summary>
        public async Task<IEnumerable<Country>> GetAllAsync()
        {
            return await _context.Countries
                .AsNoTracking()
                .ToListAsync();
        }

        /// <summary>
        /// Retrieves a country by primary key.
        ///
        /// Returns null when the country does not exist.
        /// </summary>
        public async Task<Country?> GetByIdAsync(int id)
        {
            return await _context.Countries
                .AsNoTracking()
                .FirstOrDefaultAsync(c => c.CountryID == id);
        }

        /// <summary>
        /// Determines whether a country exists.
        ///
        /// AnyAsync is used because only existence is required;
        /// loading the complete entity would be unnecessary.
        /// </summary>
        public async Task<bool> ExistsAsync(int id)
        {
            return await _context.Countries
                .AnyAsync(c => c.CountryID == id);
        }
    }
}