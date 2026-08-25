using DVLD_Enterprise_System.Application.Interfaces;
using DVLD_Enterprise_System.Domain.Entities;
using DVLD_Enterprise_System.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD_Enterprise_System.Infrastructure.Repositories
{
    public class CountryRepository : ICountryRepository
    {
        /// <summary>
        /// Provides read-only data access for Country entities.
        ///
        /// Countries are reference/master data in the DVLD system.
        /// According to the system requirements, they can be retrieved
        /// through the API but cannot be created, updated, or deleted.
        /// </summary>
        private readonly DVLDDbContext _context;

        public CountryRepository(DVLDDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Retrieves all countries.
        ///
        /// Countries are read-only, therefore only query operations
        /// are exposed by this repository.
        /// </summary>
        public async Task<IEnumerable<Country>> GetAllAsync()
        {
            return await _context.Countries
                .AsNoTracking()
                .ToListAsync();
        }

        /// <summary>
        /// Retrieves a country by its primary key.
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
        /// Checks whether a country exists.
        ///
        /// This is useful when creating or updating a Person,
        /// because Person.NationalityCountryID is a foreign key
        /// referencing Countries.CountryID.
        /// </summary>
        public async Task<bool> ExistsAsync(int id)
        {
            return await _context.Countries
                .AnyAsync(c => c.CountryID == id);
        }
    }
}
