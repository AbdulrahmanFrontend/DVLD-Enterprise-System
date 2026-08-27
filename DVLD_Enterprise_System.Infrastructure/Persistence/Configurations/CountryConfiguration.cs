using DVLD_Enterprise_System.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD_Enterprise_System.Infrastructure.Persistence.Configurations
{
    internal class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.ToTable("Countries");

            builder.HasKey(c => c.CountryID);

            builder.Property(c => c.CountryID)
                   .ValueGeneratedOnAdd();

            builder.Property(c => c.CountryName)
                   .HasMaxLength(50)
                   .IsRequired();

            builder.HasIndex(c => c.CountryName)
                .HasDatabaseName("UQ_CountryName")
                .IsUnique();
        }
    }
}
