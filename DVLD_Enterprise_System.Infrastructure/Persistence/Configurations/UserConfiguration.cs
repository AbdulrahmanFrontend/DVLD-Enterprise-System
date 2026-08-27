using DVLD_Enterprise_System.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD_Enterprise_System.Infrastructure.Persistence.Configurations
{
    internal class UserConfiguration : IEntityTypeConfiguration<User>
    {
        /// <summary>
        /// Configures the User entity and its database relationship.
        ///
        /// This configuration belongs to Infrastructure because it describes
        /// how the Domain entity is mapped to the relational database.
        /// </summary>
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");

            // Primary key.
            builder.HasKey(u => u.UserID);

            builder.Property(u => u.UserID)
                .ValueGeneratedOnAdd();

            // UserName is required and limited to 20 characters.
            builder.Property(u => u.UserName)
                .IsRequired()
                .HasMaxLength(20);

            // PasswordHash is required and limited to 255 characters.
            builder.Property(u => u.PasswordHash)
                .IsRequired()
                .HasMaxLength(255);

            // IsActive is required and defaults to true at the database level.
            builder.Property(u => u.IsActive)
                .IsRequired()
                .HasDefaultValue(true);

            // Configure the one-to-one relationship:
            //
            // Person → User
            //
            // User.PersonID is the foreign key.
            //
            // The unique constraint on Users.PersonID ensures that
            // one Person cannot have more than one User account.
            builder.HasOne(u => u.Person)
                .WithOne()
                .HasForeignKey<User>(u => u.PersonID);

            // UserName is unique.
            builder.HasIndex(u => u.UserName)
                .IsUnique();

            // PersonID is unique.
            //
            // This enforces the one-user-per-person rule.
            builder.HasIndex(u => u.PersonID)
                .IsUnique();
        }
    }
}
