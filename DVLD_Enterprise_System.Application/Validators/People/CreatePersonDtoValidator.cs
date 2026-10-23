using DVLD_Enterprise_System.Application.DTOs.People;
using DVLD_Enterprise_System.Application.Interfaces;
using DVLD_Enterprise_System.Domain.Constants.PropertiesMaxLength;
using DVLD_Enterprise_System.Domain.Messages;
using FluentValidation;

namespace DVLD_Enterprise_System.Application.Validators.People;

internal class CreatePersonDtoValidator : AbstractValidator<CreatePersonDto>
{
    private IAppDbContext _context;

    public CreatePersonDtoValidator(IAppDbContext context)
    {
        _context = context;

        RuleLevelCascadeMode = CascadeMode.Stop;

        RuleFor(c => c.NationalNo)
            .NotEmpty()
            .WithMessage(PeopleMessages.RequiredNationalNo)
            .MaximumLength(PeopleFieldsMaxLength.NationalNoMaxLength)
            .WithMessage(PeopleMessages.NationalNoMaxLength);
    }
}
