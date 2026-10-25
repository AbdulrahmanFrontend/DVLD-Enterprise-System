using DVLD_Enterprise_System.Application.Common;
using DVLD_Enterprise_System.Application.DTOs.People;
using DVLD_Enterprise_System.Domain.Entities;
using DVLD_Enterprise_System.Domain.Enums;
using DVLD_Enterprise_System.Infrastructure.Persistence;
using DVLD_Enterprise_System.IntegrationTests.Factories;
using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;
using System.Net;
using System.Net.Http.Json;

namespace DVLD_Enterprise_System.IntegrationTests.Controllers
{
    public class PeopleControllerIntegrationTests : IClassFixture<CustomWebApplicationFactory<Program>>
    {
        private readonly CustomWebApplicationFactory<Program> _factory;
        private readonly HttpClient _client;

        public PeopleControllerIntegrationTests(CustomWebApplicationFactory<Program> factory)
        {
            _factory = factory;
            _client = factory.CreateClient();
        }

        // دالة مساعدة موحدة لضمان حقن البيانات في قاعدة البيانات الثابتة قبل كل اختبار
        private void EnsureDatabaseSeeded(Action<DVLDDbContext> seedAction)
        {
            using var scope = _factory.Services.CreateScope();
            var db = scope.ServiceProvider.GetRequiredService<DVLDDbContext>();
            db.Database.EnsureCreated();
            seedAction(db);
            db.SaveChanges();
        }

        [Fact]
        public async Task GetById_ReturnsOk_WhenPersonExists()
        {
            // Arrange
            EnsureDatabaseSeeded(db =>
            {
                if (!db.Countries.Any(c => c.CountryID == 1))
                    db.Countries.Add(new Country { CountryID = 1, CountryName = "Jordan" });

                if (!db.People.Any(p => p.PersonID == 1))
                {
                    db.People.Add(new Person
                    {
                        PersonID = 1,
                        NationalNo = "INT-100",
                        FirstName = "Hassan",
                        SecondName = "Ali",
                        LastName = "Omar",
                        DateOfBirth = new DateTime(1990, 1, 1),
                        Gender = GenderType.Male,
                        Address = "Amman",
                        Phone = "0799999999",
                        Email = "hassan@test.com",
                        NationalityCountryID = 1
                    });
                }
            });

            // Act
            var response = await _client.GetAsync("/api/People/1");

            // Assert
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            var person = await response.Content.ReadFromJsonAsync<PersonDto>();
            person.Should().NotBeNull();
            person!.NationalNo.Should().Be("INT-100");
        }

        [Fact]
        public async Task GetById_ReturnsNotFound_WhenPersonDoesNotExist()
        {
            // Act
            var response = await _client.GetAsync("/api/People/9999");

            // Assert
            response.StatusCode.Should().Be(HttpStatusCode.NotFound);
        }

        [Fact]
        public async Task GetFilteredPeople_ReturnsPagedResult()
        {
            // Arrange
            EnsureDatabaseSeeded(db =>
            {
                if (!db.Countries.Any(c => c.CountryID == 1))
                    db.Countries.Add(new Country { CountryID = 1, CountryName = "Jordan" });

                if (!db.People.Any(p => p.PersonID == 10))
                {
                    db.People.Add(new Person
                    {
                        PersonID = 10,
                        NationalNo = "INT-400",
                        FirstName = "HassanFilter",
                        SecondName = "Ali",
                        LastName = "Omar",
                        DateOfBirth = new DateTime(1990, 1, 1),
                        Gender = GenderType.Male,
                        Address = "Amman",
                        Phone = "0798888888",
                        Email = "filter@test.com",
                        NationalityCountryID = 1
                    });
                }
            });

            // Act 
            var response = await _client.GetAsync("/api/People/filtered?firstName=HassanFilter&pageNumber=1&pageSize=10");

            // Assert
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            var result = await response.Content.ReadFromJsonAsync<PagedResult<FilteredPeopleDto>>();
            result.Should().NotBeNull();
            result!.TotalCount.Should().BeGreaterThanOrEqualTo(1);
            result.Items.First(p => p.NationalNo == "INT-400").FirstName.Should().Be("HassanFilter");
        }

        [Fact]
        public async Task CreatePerson_ReturnsCreated_WhenDataIsValid()
        {
            // Arrange
            EnsureDatabaseSeeded(db =>
            {
                if (!db.Countries.Any(c => c.CountryID == 1))
                    db.Countries.Add(new Country { CountryID = 1, CountryName = "Jordan" });
            });

            var newDto = new CreatePersonDto
            {
                NationalNo = "INT-300",
                FirstName = "Layla",
                SecondName = "Mohammad",
                LastName = "Salem",
                DateOfBirth = new DateTime(2000, 1, 1),
                Gender = GenderType.Female,
                Address = "Zarqa",
                Phone = "0777777777",
                Email = "layla@test.com",
                NationalityCountryID = 1
            };

            // Act
            var response = await _client.PostAsJsonAsync("/api/People", newDto);

            // Assert
            response.IsSuccessStatusCode.Should().BeTrue();
            var createdPerson = await response.Content.ReadFromJsonAsync<PersonDto>();
            createdPerson.Should().NotBeNull();
            createdPerson!.NationalNo.Should().Be("INT-300");
        }

        [Fact]
        public async Task UpdatePerson_ReturnsOk_WhenDataIsValid()
        {
            // Arrange
            EnsureDatabaseSeeded(db =>
            {
                if (!db.Countries.Any(c => c.CountryID == 1))
                    db.Countries.Add(new Country { CountryID = 1, CountryName = "Jordan" });

                if (!db.People.Any(p => p.PersonID == 5))
                {
                    db.People.Add(new Person
                    {
                        PersonID = 5,
                        NationalNo = "INT-500",
                        FirstName = "HassanToUpdate",
                        SecondName = "Ali",
                        LastName = "Omar",
                        DateOfBirth = new DateTime(1990, 1, 1),
                        Gender = GenderType.Male,
                        Address = "Amman",
                        Phone = "0795555555",
                        Email = "update@test.com",
                        NationalityCountryID = 1
                    });
                }
            });

            var updateDto = new UpdatePersonDto
            {
                NationalNo = "INT-500",
                FirstName = "Hassan-Updated",
                SecondName = "Ali",
                LastName = "Omar",
                DateOfBirth = new DateTime(1990, 1, 1),
                Gender = GenderType.Male,
                Address = "Amman-Updated",
                Phone = "0795555555",
                Email = "hassan.updated@test.com",
                NationalityCountryID = 1
            };

            // Act
            var response = await _client.PutAsJsonAsync("/api/People/5", updateDto);

            // Assert
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            var updatedPerson = await response.Content.ReadFromJsonAsync<PersonDto>();
            updatedPerson.Should().NotBeNull();
            updatedPerson!.FirstName.Should().Be("Hassan-Updated");
        }

        [Fact]
        public async Task DeletePerson_ReturnsNoContent_WhenPersonExists()
        {
            // Arrange
            EnsureDatabaseSeeded(db =>
            {
                if (!db.Countries.Any(c => c.CountryID == 1))
                    db.Countries.Add(new Country { CountryID = 1, CountryName = "Jordan" });

                if (!db.People.Any(p => p.PersonID == 8))
                {
                    db.People.Add(new Person
                    {
                        PersonID = 8,
                        NationalNo = "INT-800",
                        FirstName = "PersonToDelete",
                        SecondName = "Ali",
                        LastName = "Omar",
                        DateOfBirth = new DateTime(1990, 1, 1),
                        Gender = GenderType.Male,
                        Address = "Amman",
                        Phone = "0798888888",
                        Email = "delete@test.com",
                        NationalityCountryID = 1
                    });
                }
            });

            // Act 
            var response = await _client.DeleteAsync("/api/People/8");

            // Assert
            response.StatusCode.Should().Be(HttpStatusCode.NoContent);

            var getResponse = await _client.GetAsync("/api/People/8");
            getResponse.StatusCode.Should().Be(HttpStatusCode.NotFound);
        }
    }
}
