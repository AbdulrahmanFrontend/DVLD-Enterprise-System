using DVLD_Enterprise_System.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD_Enterprise_System.Infrastructure.Persistence.Configurations
{
    internal class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable("People");

            builder.HasKey(p => p.PersonID);

            builder.Property(p => p.PersonID)
                   .ValueGeneratedOnAdd();

            builder.Property(p => p.NationalNo)
                   .HasMaxLength(20)
                   .IsRequired();

            builder.Property(p => p.FirstName)
                   .HasMaxLength(20)
                   .IsRequired();

            builder.Property(p => p.SecondName)
                   .HasMaxLength(20)
                   .IsRequired();

            builder.Property(p => p.ThirdName)
                   .HasMaxLength(20)
                   .IsRequired(false);

            builder.Property(p => p.LastName)
                   .HasMaxLength(20)
                   .IsRequired();

            builder.Property(p => p.DateOfBirth)
                   .IsRequired();

            builder.Property(p => p.Gender)
                   .HasConversion<byte>()
                   .IsRequired();

            builder.Property(p => p.Address)
                   .HasMaxLength(500)
                   .IsRequired();

            builder.Property(p => p.Phone)
                   .HasMaxLength(20)
                   .IsRequired();

            builder.Property(p => p.Email)
                   .HasMaxLength(50)
                   .IsRequired(false);

            builder.Property(p => p.ImagePath)
                   .HasMaxLength(250)
                   .IsRequired(false);

            builder.HasIndex(p => p.NationalNo)
                   .IsUnique()
                   .HasDatabaseName("UQ_NationalNo");

            builder.HasIndex(p => p.Phone)
                   .IsUnique()
                   .HasDatabaseName("UQ_Phone");

            builder.HasOne(p => p.NationalityCountry)
                   .WithMany(c => c.People)
                   .HasForeignKey(p => p.NationalityCountryID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.Ignore(p => p.FullName);
        }
    }
}
