using DVLD_Enterprise_System.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Enterprise_System.Infrastructure.Persistence
{
    internal class DVLDDbContext : DbContext
    {
        public DVLDDbContext(DbContextOptions<DVLDDbContext> options)
        : base(options)
        {
        }

        public DbSet<Person> People => Set<Person>();

        public DbSet<Country> Countries => Set<Country>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(
                typeof(DVLDDbContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
