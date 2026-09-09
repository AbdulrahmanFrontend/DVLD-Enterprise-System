namespace DVLD_Enterprise_System.Domain.Interfaces;

/// <summary>
/// GENERIC REPOSITORY PATTERN.
///
/// WHY DOES THIS EXIST?
/// Without it, your Application/API layer code would talk directly to EF Core's
/// DbContext/DbSet everywhere. That works, but it tightly couples every part of
/// your app to EF Core. The Repository Pattern puts a simple, framework-agnostic
/// "contract" (this interface) in the Domain layer, and lets the Infrastructure
/// layer provide the real EF Core implementation. Your Application layer only
/// ever talks to THIS interface, never to EF Core directly.
///
/// "T : class" is a generic constraint meaning T must be a reference type
/// (all our Entities are classes, so this works for any of them):
/// e.g. IGenericRepository&lt;Person&gt;, IGenericRepository&lt;License&gt;, etc.
/// </summary>
public interface IGenericRepository<T> where T : class
{
    /// <summary>Fetch a single entity by its primary key, or null if not found.</summary>
    Task<T?> GetByIdAsync(int id);

    /// <summary>Fetch every row of this entity. Use with care on large tables (add paging later if needed).</summary>
    Task<IReadOnlyList<T>> GetAllAsync();

    /// <summary>
    /// Marks a new entity to be inserted. Note this does NOT save to the database yet —
    /// see IUnitOfWork.SaveChangesAsync() below for why we separate these two steps.
    /// </summary>
    Task AddAsync(T entity);

    /// <summary>Marks an existing entity as modified. Also does not save immediately.</summary>
    void Update(T entity);

    /// <summary>Marks an entity for deletion. Also does not save immediately.</summary>
    void Remove(T entity);
}
