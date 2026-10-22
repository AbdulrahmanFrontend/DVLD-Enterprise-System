using DVLD_Enterprise_System.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DVLD_Enterprise_System.Application.Interfaces;

public interface IAppDbContext
{
    DbSet<Country> Countries { get; }
    DbSet<Person> People { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    int SaveChanges();
}
