using DVLD_Enterprise_System.Domain.Entities;

namespace DVLD_Enterprise_System.Application.Interfaces
{
    /// <summary>
    /// Defines the data-access operations required by the Application layer
    /// for working with Person entities.
    ///
    /// This interface belongs to the Application layer and represents a
    /// contract for data access.
    ///
    /// It defines WHAT the application needs, but not HOW the data is stored.
    ///
    /// The actual implementation is provided by Infrastructure.
    /// </summary>
    public interface IPersonRepository
    {
        /// <summary>
        /// Retrieves all people.
        /// </summary>
        Task<IEnumerable<Person>> GetAllAsync();

        /// <summary>
        /// Retrieves a person by primary key.
        ///
        /// Returns null when the person does not exist.
        /// </summary>
        Task<Person?> GetByIdAsync(int id);

        /// <summary>
        /// Retrieves a person by National Number.
        ///
        /// Returns null when no matching person exists.
        /// </summary>
        Task<Person?> GetByNationalNoAsync(string nationalNo);

        /// <summary>
        /// Determines whether a National Number already exists.
        ///
        /// excludedPersonId is mainly used during updates so that
        /// the current person's own National Number is not treated
        /// as a duplicate.
        /// </summary>
        Task<bool> ExistsByNationalNoAsync(
            string nationalNo,
            int? excludedPersonId = null);

        /// <summary>
        /// Determines whether a phone number already exists.
        ///
        /// excludedPersonId is mainly used during updates so that
        /// the current person's own phone number is not treated
        /// as a duplicate.
        /// </summary>
        Task<bool> ExistsByPhoneAsync(
            string phone,
            int? excludedPersonId = null);

        /// <summary>
        /// Adds a Person entity to the current persistence context.
        ///
        /// This does not necessarily execute an INSERT immediately.
        /// The database operation is committed when SaveChangesAsync
        /// is called through the Unit of Work.
        /// </summary>
        Task AddAsync(Person person);

        /// <summary>
        /// Marks a Person entity for deletion.
        ///
        /// The actual DELETE operation is executed when the Unit of Work
        /// commits the pending changes.
        /// </summary>
        Task DeleteAsync(Person person);
    }
}