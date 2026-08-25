using DVLD_Enterprise_System.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD_Enterprise_System.Application.Interfaces
{
    /// <summary>
    /// Provides read-only data access for Country entities.
    ///
    /// Countries are reference/master data in the DVLD system.
    /// According to the system requirements, they can be retrieved
    /// through the API but cannot be created, updated, or deleted.
    /// </summary>
    public interface ICountryRepository
    {
        Task<IEnumerable<Country>> GetAllAsync();

        Task<Country?> GetByIdAsync(int id);

        Task<bool> ExistsAsync(int id);
    }
}
