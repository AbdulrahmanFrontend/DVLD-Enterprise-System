using DVLD_Enterprise_System.Application.Interfaces;
using DVLD_Enterprise_System.Infrastructure.Persistence;

namespace DVLD_Enterprise_System.Infrastructure.Repositories
{
    /// <summary>
    /// Infrastructure implementation of IUnitOfWork.
    ///
    /// This class is responsible for committing all tracked
    /// changes through Entity Framework Core.
    /// </summary>
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DVLDDbContext _context;

        public UnitOfWork(DVLDDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Persists all pending changes to the database.
        /// </summary>
        public Task<int> SaveChangesAsync(
            CancellationToken cancellationToken = default)
        {
            return _context.SaveChangesAsync(cancellationToken);
        }
    }
}