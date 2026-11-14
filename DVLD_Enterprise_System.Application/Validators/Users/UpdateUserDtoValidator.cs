using DVLD_Enterprise_System.Application.DTOs.Users;
using FluentValidation;

namespace DVLD_Enterprise_System.Application.Validators.Users;

public class UpdateUserDtoValidator : AbstractValidator<UpdateUserDto>
{
    public UpdateUserDtoValidator()
    {
        RuleFor(x => x.UserName)
            .NotEmpty().WithMessage("UserName is required!")
            .MaximumLength(50).WithMessage("UserName cannot exceed 50 characters!");

        RuleFor(x => x.Permissions)
            .IsInEnum().WithMessage("Invalid permission value!");
    }
}
