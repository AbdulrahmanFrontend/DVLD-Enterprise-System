using DVLD_Enterprise_System.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD_Enterprise_System.Application.Interfaces
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAllAsync();

        Task<User?> GetByUserIdAsync(int id);

        Task<User?> GetByPersonIdAsync(int personId);

        Task<User?> GetByUserNameAsync(string userName);

        Task<bool> ExistsByPersonIdAsync(int personId, int? excludedUserId = null);

        Task<bool> ExistsByUserNameAsync(string userName, int? excludedUserId = null);

        Task AddAsync(User user);

        Task DeleteAsync(User user);
    }
}
