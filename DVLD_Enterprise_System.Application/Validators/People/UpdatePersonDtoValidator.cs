using DVLD_Enterprise_System.Application.DTOs.People;
using DVLD_Enterprise_System.Domain.Constants.PropertiesMaxLength;
using DVLD_Enterprise_System.Domain.Messages;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

namespace DVLD_Enterprise_System.Application.Validators.People;

public class UpdatePersonDtoValidator : AbstractValidator<UpdatePersonDto>
{
    public UpdatePersonDtoValidator()
    {
        RuleLevelCascadeMode = CascadeMode.Stop;

        RuleFor(p => p.NationalNo)
            .NotEmpty()
            .WithMessage(PeopleMessages.RequiredNationalNo)
            .MaximumLength(PeopleFieldsMaxLength.NationalNoMaxLength)
            .WithMessage(PeopleMessages.NationalNoMaxLength);

        RuleFor(p => p.FirstName)
            .NotEmpty()
            .WithMessage(PeopleMessages.RequiredFirstName)
            .MaximumLength(PeopleFieldsMaxLength.FirstNameMaxLength)
            .WithMessage(PeopleMessages.FirstNameMaxLength);

        RuleFor(p => p.SecondName)
            .NotEmpty()
            .WithMessage(PeopleMessages.RequiredSecondName)
            .MaximumLength(PeopleFieldsMaxLength.SecondNameMaxLength)
            .WithMessage(PeopleMessages.SecondNameMaxLength);

        RuleFor(p => p.ThirdName)
            .MaximumLength(PeopleFieldsMaxLength.ThirdNameMaxLength)
            .WithMessage(PeopleMessages.ThirdNameMaxLength);

        RuleFor(p => p.LastName)
            .NotEmpty()
            .WithMessage(PeopleMessages.RequiredLastName)
            .MaximumLength(PeopleFieldsMaxLength.LastNameMaxLength)
            .WithMessage(PeopleMessages.LastNameMaxLength);

        RuleFor(p => p.Email)
            .MaximumLength(PeopleFieldsMaxLength.EmailMaxLength)
            .WithMessage(PeopleMessages.EmailMaxLength)
            .EmailAddress().When(p => !string.IsNullOrEmpty(p.Email))
            .WithMessage(PeopleMessages.InvalidEmail);

        RuleFor(p => p.Phone)
            .NotEmpty()
            .WithMessage(PeopleMessages.RequirdPhone)
            .MaximumLength(PeopleFieldsMaxLength.PhoneNumberMaxLength)
            .WithMessage(PeopleMessages.PhoneMaxLength);

        RuleFor(p => p.Address)
            .NotEmpty()
            .WithMessage(PeopleMessages.RequiredAddress)
            .MaximumLength(PeopleFieldsMaxLength.AddressMaxLength)
            .WithMessage(PeopleMessages.AddressMaxLength);

        RuleFor(p => p.Gender)
            .Must(gender => (int)gender == 1 || (int)gender == 2 || gender == 0)
            .WithMessage(PeopleMessages.InvalidGender);

        RuleFor(x => x.ImageFileName)
            .Must(imageFileName => string.IsNullOrEmpty(imageFileName)
            || imageFileName.EndsWith(".jpg")
            || imageFileName.EndsWith(".png")
            || imageFileName.EndsWith(".jpeg"))
            .WithMessage(PeopleMessages.InvalidImagePath);

        RuleFor(p => p.ImageStream)
            .Must(imageStream => imageStream == null || imageStream.Length <= 3 * 1024 * 1024)
            .WithMessage(PeopleMessages.ImageSize);
    }
}
