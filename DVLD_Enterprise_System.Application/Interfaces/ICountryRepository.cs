using DVLD_Enterprise_System.Domain.Entities;

namespace DVLD_Enterprise_System.Application.Interfaces
{
    /// <summary>
    /// Defines read-only data-access operations for Country entities.
    ///
    /// Countries are reference/master data in the DVLD system.
    ///
    /// According to the system requirements, countries can be retrieved
    /// by the application but cannot be created, updated, or deleted
    /// through the API.
    /// </summary>
    public interface ICountryRepository
    {
        /// <summary>
        /// Retrieves all available countries.
        /// </summary>
        Task<IEnumerable<Country>> GetAllAsync();

        /// <summary>
        /// Retrieves a country by its primary key.
        ///
        /// Returns null when the country does not exist.
        /// </summary>
        Task<Country?> GetByIdAsync(int id);

        /// <summary>
        /// Determines whether a country exists.
        ///
        /// This is used when creating or updating a Person because
        /// Person.NationalityCountryID references Countries.CountryID.
        /// </summary>
        Task<bool> ExistsAsync(int id);
    }
}