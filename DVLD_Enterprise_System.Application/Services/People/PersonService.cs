using DVLD_Enterprise_System.Application.DTOs.People;
using DVLD_Enterprise_System.Application.Exceptions;
using DVLD_Enterprise_System.Application.Interfaces;
using DVLD_Enterprise_System.Domain.Entities;

namespace DVLD_Enterprise_System.Application.Services.People
{
    /// <summary>
    /// Coordinates application operations related to Person entities.
    ///
    /// This layer contains application rules such as:
    ///
    /// - Checking whether referenced countries exist.
    /// - Checking duplicate National Numbers.
    /// - Checking duplicate phone numbers.
    /// - Creating and updating Domain entities.
    /// - Coordinating persistence through repositories and Unit of Work.
    /// - Mapping Domain entities to Application DTOs.
    ///
    /// It does not know how data is stored because it depends only
    /// on repository abstractions.
    /// </summary>
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepository;
        private readonly ICountryRepository _countryRepository;
        private readonly IUnitOfWork _unitOfWork;

        public PersonService(
            IPersonRepository personRepository,
            ICountryRepository countryRepository,
            IUnitOfWork unitOfWork)
        {
            _personRepository = personRepository;
            _countryRepository = countryRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<PersonDto>> GetAllAsync()
        {
            var People = await _personRepository.GetAllAsync();

            var PeopleDto = new List<PersonDto>();

            foreach (var Person in People)
            {
                PeopleDto.Add(new PersonDto
                {
                    PersonID = Person.PersonID,
                    NationalNo = Person.NationalNo,
                    FirstName = Person.FirstName,
                    SecondName = Person.SecondName,
                    ThirdName = Person.ThirdName,
                    LastName = Person.LastName,
                    DateOfBirth = Person.DateOfBirth,
                    Gender = Person.Gender,
                    Phone = Person.Phone,
                    Address = Person.Address,
                    NationalityCountryID = Person.NationalityCountryID,
                    Email = Person.Email,
                    ImagePath = Person.ImagePath,
                    NationalityCountryName =
                        Person.NationalityCountry != null
                            ? Person.NationalityCountry.CountryName
                            : null
                });
            }

            return PeopleDto;
        }

        public async Task<PersonDto?> GetByIdAsync(int id)
        {
            var Person = await _personRepository.GetByIdAsync(id);

            if (Person == null)
                return null;

            return new PersonDto
            {
                PersonID = Person.PersonID,
                NationalNo = Person.NationalNo,
                FirstName = Person.FirstName,
                SecondName = Person.SecondName,
                ThirdName = Person.ThirdName,
                LastName = Person.LastName,
                DateOfBirth = Person.DateOfBirth,
                Gender = Person.Gender,
                Phone = Person.Phone,
                Address = Person.Address,
                NationalityCountryID = Person.NationalityCountryID,
                Email = Person.Email,
                ImagePath = Person.ImagePath,
                NationalityCountryName =
                        Person.NationalityCountry != null
                            ? Person.NationalityCountry.CountryName
                            : null
            };
        }

        public async Task<PersonDto?> GetByNationalNoAsync(string nationalNo)
        {
            var Person = await _personRepository.GetByNationalNoAsync(nationalNo);

            if (Person == null)
                return null;

            return new PersonDto
            {
                PersonID = Person.PersonID,
                NationalNo = Person.NationalNo,
                FirstName = Person.FirstName,
                SecondName = Person.SecondName,
                ThirdName = Person.ThirdName,
                LastName = Person.LastName,
                DateOfBirth = Person.DateOfBirth,
                Gender = Person.Gender,
                Phone = Person.Phone,
                Address = Person.Address,
                NationalityCountryID = Person.NationalityCountryID,
                Email = Person.Email,
                ImagePath = Person.ImagePath,
                NationalityCountryName =
                        Person.NationalityCountry != null
                            ? Person.NationalityCountry.CountryName
                            : null
            };
        }

        public async Task<PersonDto> CreateAsync(CreatePersonDto dto)
        {
            // Validate the foreign-key reference before creating/updating the entity.
            //
            // This provides a clear application-level error to the client instead
            // of relying only on the database foreign-key constraint.
            var countryExists = await _countryRepository
                .ExistsAsync(dto.NationalityCountryID);

            //if (!countryExists)
            //{
            //    throw new NotFoundException(
            //        "Nationality country was not found.");
            //}

            // Perform an early duplicate check to provide a meaningful application
            // response.
            //
            // The database UNIQUE constraint remains necessary because this check
            // cannot completely prevent race conditions between concurrent requests.
            var nationalNoExists = await _personRepository
                .ExistsByNationalNoAsync(dto.NationalNo);

            if (nationalNoExists)
            {
                throw new ConflictException(
                    "National number already exists.");
            }

            var phoneExists = await _personRepository.ExistsByPhoneAsync(dto.Phone);

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

            await _personRepository.AddAsync(person);

            await _unitOfWork.SaveChangesAsync();

            return new PersonDto
            {
                PersonID = person.PersonID,
                NationalNo = person.NationalNo,
                FirstName = person.FirstName,
                SecondName = person.SecondName,
                ThirdName = person.ThirdName,
                LastName = person.LastName,
                //FullName = person.FullName,
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
            var person = await _personRepository.GetByIdAsync(id);

            if (person == null)
                return null;

            var countryExists = await _countryRepository
                .ExistsAsync(dto.NationalityCountryID);

            //if (!countryExists)
            //{
            //    throw new NotFoundException(
            //        "Nationality country was not found.");
            //}

            var nationalNoExists = await _personRepository
                .ExistsByNationalNoAsync(dto.NationalNo, person.PersonID);

            if (nationalNoExists)
            {
                throw new ConflictException(
                    "National number already exists.");
            }

            var phoneExists = await _personRepository
                .ExistsByPhoneAsync(dto.Phone, person.PersonID);

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

            await _unitOfWork.SaveChangesAsync();

            return new PersonDto
            {
                PersonID = person.PersonID,
                NationalNo = person.NationalNo,
                FirstName = person.FirstName,
                SecondName = person.SecondName,
                ThirdName = person.ThirdName,
                LastName = person.LastName,
                //FullName = person.FullName,
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
            var person = await _personRepository.GetByIdAsync(id);

            if (person == null)
                return false;

            await _personRepository.DeleteAsync(person);

            await _unitOfWork.SaveChangesAsync();

            return true;
        }
    }
}
