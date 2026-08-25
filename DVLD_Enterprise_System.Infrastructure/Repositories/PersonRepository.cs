using DVLD_Enterprise_System.Application.Interfaces;
using DVLD_Enterprise_System.Domain.Entities;
using DVLD_Enterprise_System.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Security;
using System.Text;

namespace DVLD_Enterprise_System.Infrastructure.Repositories
{
    /// <summary>
    /// Provides the actual data-access implementation for Person entities.
    ///
    /// This class belongs to Infrastructure because it uses EF Core
    /// and DVLDDbContext directly.
    ///
    /// Application does not know about this class.
    /// Application only knows about IPersonRepository.
    /// </summary>
    public class PersonRepository : IPersonRepository
    {
        private readonly DVLDDbContext _context;

        /// <summary>
        /// DVLDDbContext is injected by ASP.NET Core Dependency Injection.
        ///
        /// The repository does not create the DbContext itself.
        /// Instead, the DI container provides the DbContext instance.
        /// </summary>
        public PersonRepository(DVLDDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Retrieves all people from the database.
        ///
        /// AsNoTracking is used because this operation is read-only.
        /// EF Core therefore does not need to track the returned entities
        /// for later updates.
        /// </summary>
        public async Task<IEnumerable<Person>> GetAllAsync()
        {
            return await _context.People
                .AsNoTracking()
                .Include(p => p.NationalityCountry)
                .ToListAsync();
        }

        /// <summary>
        /// Retrieves a person by primary key.
        ///
        /// Returns null when the person does not exist.
        /// </summary>
        public async Task<Person?> GetByIdAsync(int id)
        {
            return await _context.People
                .Include(p => p.NationalityCountry)
                .FirstOrDefaultAsync(p => p.PersonID == id);
        }

        /// <summary>
        /// Checks whether a National Number already exists.
        ///
        /// excludedPersonId is useful during updates.
        ///
        /// Example:
        /// Person 10 currently has NationalNo = "N10".
        ///
        /// When updating Person 10, "N10" should NOT be considered
        /// a duplicate of itself.
        /// </summary>
        public async Task<bool> ExistsByNationalNoAsync(
            string nationalNo,
            int? excludedPersonId = null)
        {
            return await _context.People
                .AnyAsync(p =>
                    p.NationalNo == nationalNo &&
                    (!excludedPersonId.HasValue ||
                     p.PersonID != excludedPersonId.Value));
        }

        /// <summary>
        /// Checks whether a phone number already exists.
        ///
        /// During an update, the current person's own phone number
        /// is excluded from the duplicate check.
        /// </summary>
        public async Task<bool> ExistsByPhoneAsync(
            string phone,
            int? excludedPersonId = null)
        {
            return await _context.People
                .AnyAsync(p =>
                    p.Phone == phone &&
                    (!excludedPersonId.HasValue ||
                     p.PersonID != excludedPersonId.Value));
        }

        /// <summary>
        /// Adds a new Person entity to the EF Core change tracker.
        ///
        /// The actual INSERT statement is not executed here.
        /// It is executed when SaveChangesAsync is called.
        /// </summary>
        public async Task AddAsync(Person person)
        {
            await _context.People.AddAsync(person);
        }

        /// <summary>
        /// Marks the person for deletion.
        ///
        /// The actual DELETE statement is executed by
        /// SaveChangesAsync.
        /// </summary>
        public Task DeleteAsync(Person person)
        {
            _context.People.Remove(person);

            return Task.CompletedTask;
        }
    }
}
