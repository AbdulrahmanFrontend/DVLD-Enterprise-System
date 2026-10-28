using DVLD_Enterprise_System.Application.DTOs.People;
using DVLD_Enterprise_System.Application.Exceptions;
using DVLD_Enterprise_System.Application.Interfaces;
using DVLD_Enterprise_System.Application.Mappings;
using DVLD_Enterprise_System.Application.Services;
using DVLD_Enterprise_System.Domain.Entities;
using DVLD_Enterprise_System.Domain.Enums;
using DVLD_Enterprise_System.Domain.Messages;
using DVLD_Enterprise_System.Infrastructure.Persistence;
using FluentAssertions;
using FluentValidation;
using FluentValidation.Results;
using Mapster;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Moq;

namespace DVLD_Enterprise_System.UnitTests;

public class PersonServiceTests : IDisposable
{
    private readonly DVLDDbContext _context;
    private readonly Mock<IValidator<CreatePersonDto>> _createValidatorMock;
    private readonly Mock<IValidator<UpdatePersonDto>> _updateValidatorMock;
    private readonly Mock<ILogger<PersonService>> _loggerMock;
    private readonly Mock<IFileStorageService> _fileStorageService;
    private readonly PersonService _personService;

    public PersonServiceTests()
    {
        TypeAdapterConfig.GlobalSettings.Scan(typeof(PersonMappingConfig).Assembly);

        var options = new DbContextOptionsBuilder<DVLDDbContext>()
            .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
            .Options;

        _context = new DVLDDbContext(options);
        _createValidatorMock = new Mock<IValidator<CreatePersonDto>>();
        _updateValidatorMock = new Mock<IValidator<UpdatePersonDto>>();
        _loggerMock = new Mock<ILogger<PersonService>>();
        _fileStorageService = new Mock<IFileStorageService>();

        _personService = new PersonService(
            _context,
            _createValidatorMock.Object,
            _updateValidatorMock.Object,
            _loggerMock.Object,
            _fileStorageService.Object
        );

        SeedDatabase();
    }

    private void SeedDatabase()
    {
        var jordan = new Country { CountryID = 1, CountryName = "Jordan" };
        _context.Countries.Add(jordan);
        _context.People.AddRange(
            new Person
            {
                PersonID = 1,
                NationalNo = "NAT-100",
                FirstName = "Ahmed",
                SecondName = "Ali",
                LastName = "Mohammed",
                DateOfBirth = new DateTime(1995, 1, 1),
                Gender = GenderType.Male,
                Address = "Amman",
                Phone = "0791111111",
                Email = "ahmed@test.com",
                NationalityCountryID = 1,
                NationalityCountry = jordan
            },
            new Person
            {
                PersonID = 2,
                NationalNo = "NAT-200",
                FirstName = "Sara",
                SecondName = "Mahmoud",
                LastName = "Ali",
                DateOfBirth = new DateTime(2000, 5, 5),
                Gender = GenderType.Female,
                Address = "Irbid",
                Phone = "0782222222",
                Email = "sara@test.com",
                NationalityCountryID = 1,
                NationalityCountry = jordan
            }
        );
        _context.SaveChanges();
    }

    [Fact]
    public async Task GetByIdAsync_ShouldReturnPerson_WhenExists()
    {
        // Act
        var result = await _personService.GetByIdAsync(1);

        // Assert
        result.Should().NotBeNull();
        result!.NationalNo.Should().Be("NAT-100");
    }

    [Fact]
    public async Task GetByIdAsync_ShouldReturnNull_WhenNotExists()
    {
        // Act
        var result = await _personService.GetByIdAsync(999);

        // Assert
        result.Should().BeNull();
    }

    [Fact]
    public async Task GetFilteredPeopleAsync_ShouldReturnFilteredResults()
    {
        // Arrange
        var queryDto = new GetPeopleQueryDto(
            nationalNo: "NAT-1",
            firstName: null,
            lastName: null,
            phoneNumber: null,
            email: null,
            gender: null,
            nationalityCountryId: null,
            pageNumber: 1,
            pageSize: 10
        );

        // Act
        var result = await _personService.GetFilteredPeopleAsync(queryDto);

        // Assert
        result.Should().NotBeNull();
        result.TotalCount.Should().Be(1);
        result.Items[0].NationalNo.Should().Be("NAT-100");
        result.Items[0].NationalityCountryName.Should().Be("Jordan");
    }

    [Fact]
    public async Task CreateAsync_ShouldSucceed_WhenDataIsValid()
    {
        // Arrange
        var stream = new MemoryStream(new byte[] { 1, 2, 3 });
        var dto = new CreatePersonDto
        {
            NationalNo = "NAT-300",
            FirstName = "Omar",
            SecondName = "Khaled",
            LastName = "Yousef",
            DateOfBirth = new DateTime(1998, 3, 3),
            Gender = GenderType.Male,
            Address = "Zarqa",
            Phone = "0773333333",
            Email = "omar@test.com",
            NationalityCountryID = 1,
            ImageStream = stream,
            ImageFileName = "test.jpg"
        }; 
        
        _fileStorageService
            .Setup(
                x => x.SaveFileAsync(It.IsAny<Stream>(),
                It.IsAny<string>(),
                It.IsAny<string>()))
            .ReturnsAsync("uploads/people/test.jpg");

        _createValidatorMock
            .Setup(v => v.ValidateAsync(dto, It.IsAny<CancellationToken>()))
            .ReturnsAsync(new ValidationResult());

        // Act
        var result = await _personService.CreateAsync(dto);

        // Assert
        result.Should().Be(3);
        _context.People.Count().Should().Be(3);
    }

    [Fact]
    public async Task CreateAsync_ShouldFail_WhenValidationFails()
    {
        // Arrange
        var dto = new CreatePersonDto();
        var validationResult = new ValidationResult(new[]
        {
            new ValidationFailure("NationalNo", PeopleMessages.RequiredNationalNo)
        });

        _createValidatorMock
            .Setup(v => v.ValidateAsync(dto, It.IsAny<CancellationToken>()))
            .ReturnsAsync(validationResult);

        // Act
        var action = async () => await _personService.CreateAsync(dto);

        // Assert
        await action.Should().ThrowAsync<ValidationException>();
        _context.People.Count().Should().Be(2);
    }

    [Fact]
    public async Task UpdateAsync_ShouldFail_WhenPersonNotFound()
    {
        // Arrange
        var updateDto = new UpdatePersonDto
        {
            NationalNo = "NAT-100",
            FirstName = "Test",
            SecondName = "Test",
            LastName = "Test",
            Address = "Amman",
            Phone = "0791111111",
            NationalityCountryID = 1
        };

        // Act
        var action = async () => await _personService.UpdateAsync(999, updateDto);
        await action.Should().ThrowAsync<NotFoundException>();
    }

    [Fact]
    public async Task UpdateAsync_ShouldFail_WhenNationalNoExists()
    {
        // Arrange (محاولة تعديل الشخص 1 ليحمل الرقم القومي الخاص بالشخص 2)
        var updateDto = new UpdatePersonDto
        {
            NationalNo = "NAT-200", // مسجل باسم الشخص 2
            FirstName = "Ahmed-Updated",
            SecondName = "Ali",
            LastName = "Mohammed",
            DateOfBirth = new DateTime(1995, 1, 1),
            Gender = GenderType.Male,
            Address = "Amman",
            Phone = "0791111111",
            Email = "ahmed@test.com",
            NationalityCountryID = 1
        };

        _updateValidatorMock
            .Setup(v => v.ValidateAsync(updateDto, It.IsAny<CancellationToken>()))
            .ReturnsAsync(new ValidationResult());

        // Act
        var action = async () => await _personService.UpdateAsync(1, updateDto);

        // Assert
        await action.Should().ThrowAsync<ConflictException>();

        var person = await _context.People.FindAsync(1);
        person?.NationalNo.Should().Be("NAT-100");
    }

    [Fact]
    public async Task DeleteAsync_ShouldSucceed_WhenPersonExists()
    {
        // Act
        var action = async () => await _personService.DeleteAsync(3);

        // Assert
        await action.Should().ThrowAsync<NotFoundException>();
        _context.People.Find(3).Should().BeNull();
    }

    public void Dispose()
    {
        _context.Database.EnsureDeleted();
        _context.Dispose();
    }
}
