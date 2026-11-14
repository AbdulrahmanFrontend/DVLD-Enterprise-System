using DVLD_Enterprise_System.Application.DTOs.People;
using DVLD_Enterprise_System.Domain.Entities;
using DVLD_Enterprise_System.Infrastructure.Persistence;
using FluentValidation.TestHelper;
using Microsoft.EntityFrameworkCore;

namespace DVLD_Enterprise_System.UnitTests.Validators
{
    public class CreatePersonDtoValidatorTests
    {
        private readonly CreatePersonDtoValidator _validator;

        public CreatePersonDtoValidatorTests()
        {
            _validator = new CreatePersonDtoValidator();
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
    }
}