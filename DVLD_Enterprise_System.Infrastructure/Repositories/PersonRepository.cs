using DVLD_Enterprise_System.Application.Interfaces;
using DVLD_Enterprise_System.Domain.Entities;
using DVLD_Enterprise_System.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace DVLD_Enterprise_System.Infrastructure.Repositories
{
    /// <summary>
    /// Provides the Infrastructure implementation of IPersonRepository.
    ///
    /// This class contains the actual persistence/data-access code
    /// for Person entities.
    ///
    /// Infrastructure is allowed to depend on EF Core and DbContext.
    /// The Application layer is not aware of these implementation details.
    /// </summary>
    public class PersonRepository : IPersonRepository
    {
        private readonly DVLDDbContext _context;

        /// <summary>
        /// Receives the application's DbContext through Dependency Injection.
        ///
        /// The repository does not create or dispose the DbContext itself.
        /// ASP.NET Core manages its lifetime.
        /// </summary>
        public PersonRepository(DVLDDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Retrieves all people including their related nationality country.
        ///
        /// AsNoTracking is used because this operation is read-only.
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
        /// The nationality country is included because the application
        /// may need its name when building the response DTO.
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
        /// Retrieves a person by National Number.
        ///
        /// The related nationality country is included for response mapping.
        /// Returns null when no matching person exists.
        /// </summary>
        public async Task<Person?> GetByNationalNoAsync(string nationalNo)
        {
            return await _context.People
                .Include(p => p.NationalityCountry)
                .FirstOrDefaultAsync(p => p.NationalNo == nationalNo);
        }

        /// <summary>
        /// Checks whether a National Number already exists.
        ///
        /// During an update, the current person's ID can be supplied
        /// through excludedPersonId so that the person's existing value
        /// is not considered a duplicate of itself.
        ///
        /// This is an application-level pre-check.
        /// The database UNIQUE constraint remains the final protection
        /// against duplicate values.
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
        /// During an update, the current person's ID can be excluded
        /// from the duplicate check.
        ///
        /// The database UNIQUE constraint remains the final protection.
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
        /// Adds a Person entity to the EF Core change tracker.
        ///
        /// This method prepares the entity for insertion.
        /// The actual SQL INSERT is executed only when SaveChangesAsync
        /// is called by the Unit of Work.
        /// </summary>
        public async Task AddAsync(Person person)
        {
            await _context.People.AddAsync(person);
        }

        /// <summary>
        /// Marks a Person entity as deleted in the EF Core change tracker.
        ///
        /// The actual SQL DELETE is executed when SaveChangesAsync
        /// is called by the Unit of Work.
        /// </summary>
        public Task DeleteAsync(Person person)
        {
            _context.People.Remove(person);

            return Task.CompletedTask;
        }
    }
}