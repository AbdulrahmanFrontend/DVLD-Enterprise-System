using DVLD_Enterprise_System.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD_Enterprise_System.Application.Interfaces
{
    /// <summary>
    /// Defines the data-access operations required for Person entities.
    ///
    /// This interface belongs to the Application layer.
    ///
    /// It describes WHAT the application needs from the data layer,
    /// but it does not describe HOW the data is stored or retrieved.
    ///
    /// The implementation is provided by Infrastructure.
    /// </summary>
    public interface IPersonRepository
    {
        Task<IEnumerable<Person>> GetAllAsync();

        Task<Person?> GetByIdAsync(int id);

        Task<bool> ExistsByNationalNoAsync(
            string nationalNo,
            int? excludedPersonId = null);

        Task<bool> ExistsByPhoneAsync(
            string phone,
            int? excludedPersonId = null);

        Task AddAsync(Person person);

        Task DeleteAsync(Person person);
    }
}
