using DVLD_Enterprise_System.Application.DTOs.Auth;
using FluentValidation;

namespace DVLD_Enterprise_System.Application.Validators.Auth;

public class ChangePasswordDtoValidator : AbstractValidator<ChangePasswordDto>
{
    public ChangePasswordDtoValidator()
    {
        RuleFor(x => x.CurrentPassword)
            .NotEmpty().WithMessage("Current password is required!")
            .MinimumLength(6)
            .WithMessage("Current password must be at least 6 characters long!")
            .MaximumLength(50)
            .WithMessage("Current password must not exceed 50 characters long!");

        RuleFor(x => x.NewPassword)
            .NotEmpty().WithMessage("New password is required!")
            .MinimumLength(6).WithMessage("New password must be at least 6 characters long!")
            .MaximumLength(50).WithMessage("New password must not exceed 50 characters long!");

        RuleFor(x => x.NewPassword)
            .NotEqual(x => x.CurrentPassword)
            .WithMessage("New password must be different from the current password!");
    }
}
