using DVLD_Enterprise_System.Application.Interfaces;
using DVLD_Enterprise_System.Infrastructure.Persistence;

namespace DVLD_Enterprise_System.Infrastructure.Repositories
{
    /// <summary>
    /// Provides the Infrastructure implementation of IUnitOfWork.
    ///
    /// The Unit of Work uses the shared DbContext to commit
    /// all tracked changes as one persistence operation.
    /// </summary>
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DVLDDbContext _context;

        public UnitOfWork(DVLDDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Persists all pending changes tracked by the DbContext.
        ///
        /// This is the point where EF Core sends the required
        /// INSERT, UPDATE, or DELETE commands to SQL Server.
        /// </summary>
        public Task<int> SaveChangesAsync(
            CancellationToken cancellationToken = default)
            => _context.SaveChangesAsync(cancellationToken);
    }
}