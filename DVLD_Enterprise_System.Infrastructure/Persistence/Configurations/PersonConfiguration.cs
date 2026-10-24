using DVLD_Enterprise_System.Domain.Constants.PropertiesMaxLength;
using DVLD_Enterprise_System.Domain.Entities;
using DVLD_Enterprise_System.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

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
                   .HasMaxLength(PeopleFieldsMaxLength.NationalNoMaxLength)
                   .IsRequired();

            builder.Property(p => p.FirstName)
                   .HasMaxLength(PeopleFieldsMaxLength.FirstNameMaxLength)
                   .IsRequired();

            builder.Property(p => p.SecondName)
                   .HasMaxLength(PeopleFieldsMaxLength.SecondNameMaxLength)
                   .IsRequired();

            builder.Property(p => p.ThirdName)
                   .HasMaxLength(PeopleFieldsMaxLength.ThirdNameMaxLength);

            builder.Property(p => p.LastName)
                   .HasMaxLength(PeopleFieldsMaxLength.LastNameMaxLength)
                   .IsRequired();

            builder.Property(p => p.DateOfBirth)
                   .IsRequired();

            builder.Property(p => p.Gender)
                   .HasConversion<byte>()
                   .HasDefaultValue((GenderType)0)
                   .IsRequired();

            builder.Property(p => p.Address)
                   .HasMaxLength(PeopleFieldsMaxLength.AddressMaxLength)
                   .IsRequired();

            builder.Property(p => p.Phone)
                   .HasMaxLength(PeopleFieldsMaxLength.PhoneNumberMaxLength)
                   .IsRequired();

            builder.Property(p => p.Email)
                   .HasMaxLength(PeopleFieldsMaxLength.EmailMaxLength)
                   .IsRequired(false);

            builder.Property(p => p.ImagePath)
                   .HasMaxLength(PeopleFieldsMaxLength.ImagePathMaxLength)
                   .IsRequired(false);

            builder.HasIndex(p => p.NationalNo)
                   .IsUnique()
                   .HasDatabaseName("UQ_NationalNo");

            builder.HasIndex(p => p.Phone)
                   .IsUnique()
                   .HasDatabaseName("UQ_Phone");

            builder.HasIndex(p => p.Email)
                .IsUnique()
                .HasDatabaseName("UQ_Email");

            builder.HasOne(p => p.NationalityCountry)
                   .WithMany(c => c.People)
                   .HasForeignKey(p => p.NationalityCountryID)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.Ignore(p => p.FullName);
        }
    }
}
