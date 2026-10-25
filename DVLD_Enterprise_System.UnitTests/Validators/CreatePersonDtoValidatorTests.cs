using DVLD_Enterprise_System.Application.DTOs.People;
using DVLD_Enterprise_System.Domain.Entities;
using DVLD_Enterprise_System.Infrastructure.Persistence;
using FluentValidation.TestHelper;
using Microsoft.EntityFrameworkCore;

namespace DVLD_Enterprise_System.UnitTests.Validators
{
    public class CreatePersonDtoValidatorTests : IDisposable
    {
        private readonly DVLDDbContext _context;
        private readonly CreatePersonDtoValidator _validator;

        public CreatePersonDtoValidatorTests()
        {
            var options = new DbContextOptionsBuilder<DVLDDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            _context = new DVLDDbContext(options);
            _validator = new CreatePersonDtoValidator(_context);
        }

        [Fact]
        public async Task ShouldHaveError_WhenNationalNoIsEmpty()
        {
            // Arrange
            var model = new CreatePersonDto { NationalNo = string.Empty };

            // Act
            var result = await _validator.TestValidateAsync(model);

            // Assert
            result.ShouldHaveValidationErrorFor(p => p.NationalNo);
        }

        [Fact]
        public async Task ShouldHaveError_WhenNationalNoAlreadyExists()
        {
            // Arrange: إضافة شخص مسبقاً بنفس الرقم القومي
            _context.Countries.Add(new Country { CountryID = 1, CountryName = "Jordan" });
            _context.People.Add(new Person
            {
                NationalNo = "NAT-DUPLICATE",
                FirstName = "Test",
                SecondName = "Test",
                LastName = "Test",
                Address = "Amman",
                Phone = "0790000000",
                NationalityCountryID = 1
            });
            await _context.SaveChangesAsync();

            var model = new CreatePersonDto { NationalNo = "NAT-DUPLICATE" };

            // Act
            var result = await _validator.TestValidateAsync(model);

            // Assert
            result.ShouldHaveValidationErrorFor(p => p.NationalNo);
        }

        public void Dispose()
        {
            _context.Database.EnsureDeleted();
            _context.Dispose();
        }
    }
}