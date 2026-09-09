using DVLD_Enterprise_System.Application.DTOs;
using DVLD_Enterprise_System.Application.Exceptions;
using DVLD_Enterprise_System.Application.Interfaces;
using DVLD_Enterprise_System.Application.Mapping;
using DVLD_Enterprise_System.Domain.Entities;

namespace DVLD_Enterprise_System.Application.Services;

/// <summary>
/// A step up from CountryService: this one has an Update operation that only
/// touches SOME fields (see the comment on PersonUpdateDto for why).
/// </summary>
public class PersonService : IPersonService
{
    private readonly DVLD_Enterprise_System.Domain.Interfaces.IUnitOfWork _unitOfWork;

    public PersonService(DVLD_Enterprise_System.Domain.Interfaces.IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IReadOnlyList<PersonDto>> GetAllAsync()
    {
        var people = await _unitOfWork.People.GetAllAsync();
        return people.Select(p => p.ToDto()).ToList();
    }

    public async Task<PersonDto> GetByIdAsync(int id)
    {
        var person = await _unitOfWork.People.GetByIdAsync(id)
            ?? throw new NotFoundException(nameof(Person), id);

        return person.ToDto();
    }

    public async Task<PersonDto> CreateAsync(PersonCreateDto dto)
    {
        // A real system would add business-rule checks here before saving, e.g.:
        //   - Is the person at least X years old for the license class they'll request later?
        //   - Does NationalNo already belong to someone else? (the DB's UQ_NationalNo
        //     constraint will catch this too, but a friendly check here gives a
        //     nicer error message than a raw SQL exception).
        // We're keeping this minimal for now and relying on the database
        // constraints you already defined (UNIQUE on NationalNo and Phone).
        var person = dto.ToEntity();

        await _unitOfWork.People.AddAsync(person);
        await _unitOfWork.SaveChangesAsync();

        return person.ToDto();
    }

    public async Task<PersonDto> UpdateAsync(int id, PersonUpdateDto dto)
    {
        var person = await _unitOfWork.People.GetByIdAsync(id)
            ?? throw new NotFoundException(nameof(Person), id);

        // We update the entity's properties one by one (instead of replacing
        // the whole object) so that EF Core's change tracker knows EXACTLY
        // which columns changed and only includes those in the UPDATE statement
        // it eventually generates.
        person.FirstName = dto.FirstName;
        person.SecondName = dto.SecondName;
        person.ThirdName = dto.ThirdName;
        person.LastName = dto.LastName;
        person.Address = dto.Address;
        person.Phone = dto.Phone;
        person.Email = dto.Email;
        person.ImagePath = dto.ImagePath;

        _unitOfWork.People.Update(person);
        await _unitOfWork.SaveChangesAsync();

        return person.ToDto();
    }
}
