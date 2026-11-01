using DVLD_Enterprise_System.Application.DTOs.Auth;
using FluentValidation;

namespace DVLD_Enterprise_System.Application.Validators.Auth;

public class LoginDtoValidator : AbstractValidator<LoginRequestDto>
{
    public LoginDtoValidator()
    {
        RuleFor(x => x.UserName)
            .NotEmpty().WithMessage("UserName is required!")
            .MaximumLength(50).WithMessage("UserName cannot exceed 50 characters!");

        RuleFor(x => x.Password)
            .NotEmpty().WithMessage("Password is required!")
            .MinimumLength(6).WithMessage("Password must be at least 6 characters long!")
            .MaximumLength(50).WithMessage("Password must not exceed 50 characters long!");
    }
}
