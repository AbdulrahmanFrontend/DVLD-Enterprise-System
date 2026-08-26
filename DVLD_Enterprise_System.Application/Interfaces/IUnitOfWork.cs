namespace DVLD_Enterprise_System.Application.Interfaces
{
    /// <summary>
    /// Represents the application's unit of work.
    ///
    /// The Unit of Work provides a single point for committing
    /// all pending changes made during an application operation.
    ///
    /// The Application layer depends only on this abstraction.
    /// Infrastructure provides the actual implementation using EF Core.
    /// </summary>
    public interface IUnitOfWork
    {
        /// <summary>
        /// Persists all pending changes to the database.
        ///
        /// The returned integer represents the number of state entries
        /// written to the database.
        /// </summary>
        Task<int> SaveChangesAsync(
            CancellationToken cancellationToken = default);
    }
}