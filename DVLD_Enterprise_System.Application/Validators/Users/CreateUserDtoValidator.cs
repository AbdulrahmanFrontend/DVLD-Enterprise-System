using DVLD_Enterprise_System.Application.DTOs.Users;
using FluentValidation;

namespace DVLD_Enterprise_System.Application.Validators.Users;

public class CreateUserDtoValidator : AbstractValidator<CreateUserDto>
{
    public CreateUserDtoValidator()
    {
        RuleFor(x => x.UserName)
            .NotEmpty().WithMessage("UserName is required!")
            .MaximumLength(50).WithMessage("UserName cannot exceed 50 characters!");

        RuleFor(x => x.Password)
            .NotEmpty().WithMessage("Password is required!")
            .MinimumLength(6).WithMessage("Password must be at least 6 characters long!")
            .MaximumLength(50).WithMessage("Password must not exceed 50 characters long!");

        RuleFor(x => x.Permissions)
            .IsInEnum().WithMessage("Invalid permission value!");

        RuleFor(x => x.PersonID)
            .GreaterThan(0).WithMessage("PersonID must be a positive integer!");
    }
}
