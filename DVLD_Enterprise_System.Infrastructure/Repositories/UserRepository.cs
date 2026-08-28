using DVLD_Enterprise_System.Application.Interfaces;
using DVLD_Enterprise_System.Domain.Entities;
using DVLD_Enterprise_System.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD_Enterprise_System.Infrastructure.Repositories
{
    /// <summary>
    /// Provides database access for User entities.
    ///
    /// This class belongs to Infrastructure because it directly uses
    /// Entity Framework Core and DVLDDbContext.
    ///
    /// Application depends only on IUserRepository.
    /// </summary>
    public class UserRepository : IUserRepository
    {
        private readonly DVLDDbContext _context;

        public UserRepository(DVLDDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<User>> GetAllAsync()
            => await _context.Users.AsNoTracking().ToListAsync();

        /// <summary>
        /// Retrieves a user account by its primary key.
        ///
        /// Returns null when no matching user account exists.
        /// </summary>
        public async Task<User?> GetByUserIdAsync(int id)
            => await _context.Users.FindAsync(id);

        /// <summary>
        /// Retrieves the user account associated with a specific person.
        ///
        /// Returns null when no user account is associated with the person.
        /// </summary>
        public async Task<User?> GetByPersonIdAsync(int personId)
            => await _context.Users.FirstOrDefaultAsync(u => u.PersonID == personId);

        /// <summary>
        /// Retrieves a user account by username.
        ///
        /// Username is unique in the database, therefore at most
        /// one user account can match the supplied username.
        ///
        /// Returns null when no matching account exists.
        /// </summary>
        public async Task<User?> GetByUserNameAsync(string userName)
        {
            return await _context.Users
                .FirstOrDefaultAsync(u => u.UserName == userName);
        }

        public async Task<bool> ExistsByPersonIdAsync(
            int personId,
            int? excludedUserId = null)
        {
            return await _context.Users
                .AnyAsync(u => u.PersonID == personId && 
                (!excludedUserId.HasValue || u.PersonID != excludedUserId.Value));
        }

        public async Task<bool> ExistsByUserNameAsync(
            string userName,
            int? excludedUserId = null)
        {
            return await _context.Users
                .AnyAsync(u => u.UserName == userName &&
                (!excludedUserId.HasValue || u.PersonID != excludedUserId.Value));
        }

        public async Task AddAsync(User user)
        {
            await _context.Users.AddAsync(user);
        }

        public Task DeleteAsync(User user)
        {
            _context.Users.Remove(user);

            return Task.CompletedTask;
        }
    }
}
