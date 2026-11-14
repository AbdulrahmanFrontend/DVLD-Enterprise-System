using DVLD_Enterprise_System.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD_Enterprise_System.Infrastructure.Persistence.Configurations;

/// <summary>
/// FLUENT API CONFIGURATION - an alternative to putting [Attribute]s directly
/// on your Entity classes (called "Data Annotations"). We use Fluent API
/// exclusively in this project because it keeps ALL persistence/database
/// concerns here in Infrastructure, and keeps the Domain entities 100% clean
/// C# with no EF Core attributes cluttering them (again: persistence ignorance).
///
/// Implementing IEntityTypeConfiguration&lt;Country&gt; is what lets
/// ApplyConfigurationsFromAssembly() (in DVLDDbContext) find and apply this
/// class automatically.
/// </summary>
public class CountryConfiguration : IEntityTypeConfiguration<Country>
{
    public void Configure(EntityTypeBuilder<Country> builder)
    {
        // Not strictly required (EF Core would infer "Countries" from the
        // DbSet<Country> property name anyway) but being explicit makes the
        // mapping to your existing table obvious to anyone reading this file.
        builder.ToTable("Countries");

        builder.HasKey(c => c.CountryID);

        builder.Property(c => c.CountryName)
            .IsRequired()          // maps to NOT NULL
            .HasMaxLength(50);     // maps to nvarchar(50), matching your original script

        // Reproduces "CONSTRAINT [UQ_CountryName] UNIQUE" from Countries.sql.
        builder.HasIndex(c => c.CountryName)
            .IsUnique();
    }
}
