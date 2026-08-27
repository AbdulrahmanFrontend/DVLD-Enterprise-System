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

        /// <summary>
        /// Retrieves a user account by username.
        ///
        /// Returns null when no matching account exists.
        ///
        /// The Person navigation property is included because
        /// authentication may need information about the associated person.
        /// </summary>
        public async Task<User?> GetByUserIdAsync(int id)
            => await _context.Users.FindAsync(id);

        public async Task<User?> GetByPersonIdAsync(int personId)
            => await _context.Users.FirstOrDefaultAsync(u => u.PersonID == personId);
    }
}
