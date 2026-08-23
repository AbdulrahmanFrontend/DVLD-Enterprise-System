using DVLD_Enterprise_System.API.DTOs.People;
using DVLD_Enterprise_System.API.Exceptions;
using DVLD_Enterprise_System.Domain.Entities;
using DVLD_Enterprise_System.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace DVLD_Enterprise_System.API.Services.People
{
    public class PersonService : IPersonService
    {
        private readonly DVLDDbContext _context;

        public PersonService(DVLDDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<PersonDto>> GetAllAsync()
        {
            return await _context.People
                .AsNoTracking()
                .Select(p => new PersonDto
                {
                    PersonID = p.PersonID,
                    NationalNo = p.NationalNo,
                    FirstName = p.FirstName,
                    SecondName = p.SecondName,
                    ThirdName = p.ThirdName,
                    LastName = p.LastName,
                    FullName = p.FullName,
                    DateOfBirth = p.DateOfBirth,
                    Gender = p.Gender,
                    Address = p.Address,
                    Phone = p.Phone,
                    Email = p.Email,
                    NationalityCountryID = p.NationalityCountryID,
                    ImagePath = p.ImagePath,
                    NationalityCountryName =
                        p.NationalityCountry != null
                            ? p.NationalityCountry.CountryName
                            : null
                })
                .ToListAsync();
        }

        public async Task<PersonDto?> GetByIdAsync(int id)
        {
            return await _context.People
                .AsNoTracking()
                .Where(p => p.PersonID == id)
                .Select(p => new PersonDto
                {
                    PersonID = p.PersonID,
                    NationalNo = p.NationalNo,
                    FirstName = p.FirstName,
                    SecondName = p.SecondName,
                    ThirdName = p.ThirdName,
                    LastName = p.LastName,
                    FullName = p.FullName,
                    DateOfBirth = p.DateOfBirth,
                    Gender = p.Gender,
                    Address = p.Address,
                    Phone = p.Phone,
                    Email = p.Email,
                    NationalityCountryID = p.NationalityCountryID,
                    ImagePath = p.ImagePath,
                    NationalityCountryName =
                        p.NationalityCountry != null
                            ? p.NationalityCountry.CountryName
                            : null
                })
                .FirstOrDefaultAsync();
        }

        public async Task<PersonDto> CreateAsync(CreatePersonDto dto)
        {
            var countryExists = await _context.Countries
                .AnyAsync(c => c.CountryID == dto.NationalityCountryID);

            if (!countryExists)
            {
                throw new NotFoundException(
                    "Nationality country was not found.");
            }

            var nationalNoExists = await _context.People
                .AnyAsync(p => p.NationalNo == dto.NationalNo);

            if (nationalNoExists)
            {
                throw new ConflictException(
                    "National number already exists.");
            }

            var phoneExists = await _context.People
                .AnyAsync(p => p.Phone == dto.Phone);

            if (phoneExists)
            {
                throw new ConflictException(
                    "Phone number already exists.");
            }

            var person = new Person
            {
                NationalNo = dto.NationalNo,
                FirstName = dto.FirstName,
                SecondName = dto.SecondName,
                ThirdName = dto.ThirdName,
                LastName = dto.LastName,
                DateOfBirth = dto.DateOfBirth,
                Gender = dto.Gender,
                Address = dto.Address,
                Phone = dto.Phone,
                Email = dto.Email,
                NationalityCountryID = dto.NationalityCountryID,
                ImagePath = dto.ImagePath
            };

            _context.People.Add(person);

            await _context.SaveChangesAsync();

            return new PersonDto
            {
                PersonID = person.PersonID,
                NationalNo = person.NationalNo,
                FirstName = person.FirstName,
                SecondName = person.SecondName,
                ThirdName = person.ThirdName,
                LastName = person.LastName,
                FullName = person.FullName,
                DateOfBirth = person.DateOfBirth,
                Gender = person.Gender,
                Address = person.Address,
                Phone = person.Phone,
                Email = person.Email,
                NationalityCountryID = person.NationalityCountryID,
                ImagePath = person.ImagePath
            };
        }

        public async Task<PersonDto?> UpdateAsync(int id, UpdatePersonDto dto)
        {
            var person = await _context.People
                .FirstOrDefaultAsync(p => p.PersonID == id);

            if (person == null)
                return null;

            var countryExists = await _context.Countries
                .AnyAsync(c => c.CountryID == dto.NationalityCountryID);

            if (!countryExists)
            {
                throw new NotFoundException(
                    "Nationality country was not found.");
            }

            var nationalNoExists = await _context.People
                .AnyAsync(p =>
                    p.NationalNo == dto.NationalNo &&
                    p.PersonID != id);

            if (nationalNoExists)
            {
                throw new ConflictException(
                    "National number already exists.");
            }

            var phoneExists = await _context.People
                .AnyAsync(p =>
                    p.Phone == dto.Phone &&
                    p.PersonID != id);

            if (phoneExists)
            {
                throw new ConflictException(
                    "Phone number already exists.");
            }

            person.NationalNo = dto.NationalNo;
            person.FirstName = dto.FirstName;
            person.SecondName = dto.SecondName;
            person.ThirdName = dto.ThirdName;
            person.LastName = dto.LastName;
            person.DateOfBirth = dto.DateOfBirth;
            person.Gender = dto.Gender;
            person.Address = dto.Address;
            person.Phone = dto.Phone;
            person.Email = dto.Email;
            person.NationalityCountryID = dto.NationalityCountryID;
            person.ImagePath = dto.ImagePath;

            await _context.SaveChangesAsync();

            return new PersonDto
            {
                PersonID = person.PersonID,
                NationalNo = person.NationalNo,
                FirstName = person.FirstName,
                SecondName = person.SecondName,
                ThirdName = person.ThirdName,
                LastName = person.LastName,
                FullName = person.FullName,
                DateOfBirth = person.DateOfBirth,
                Gender = person.Gender,
                Address = person.Address,
                Phone = person.Phone,
                Email = person.Email,
                NationalityCountryID = person.NationalityCountryID,
                ImagePath = person.ImagePath
            };
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var person = await _context.People
                .FirstOrDefaultAsync(c => c.PersonID == id);

            if (person == null)
                return false;

            _context.People.Remove(person);

            await _context.SaveChangesAsync();

            return true;
        }
    }
}
