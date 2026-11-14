using DVLD_Enterprise_System.Application.DTOs.Auth;
using DVLD_Enterprise_System.Application.Exceptions;
using DVLD_Enterprise_System.Application.Interfaces;
using DVLD_Enterprise_System.Domain.Entities;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace DVLD_Enterprise_System.Application.Services;

public class UserAuthService : IUserAuthService
{
    private readonly IAppDbContext _context;
    private readonly IPasswordHasher _passwordHasher;
    private readonly IJwtTokenService _jwtTokenService;
    private readonly IValidator<LoginRequestDto> _loginRequestValidator;
    private readonly IValidator<ChangePasswordDto> _changePasswordValidator;
    private readonly ILogger<UserAuthService> _logger;

    public UserAuthService(
        IAppDbContext context,
        IPasswordHasher passwordHasher,
        IJwtTokenService jwtTokenService,
        IValidator<LoginRequestDto> loginRequestValidator,
        IValidator<ChangePasswordDto> changePasswordValidator,
        ILogger<UserAuthService> logger)
    {
        _context = context;
        _passwordHasher = passwordHasher;
        _jwtTokenService = jwtTokenService;
        _loginRequestValidator = loginRequestValidator;
        _changePasswordValidator = changePasswordValidator;
        _logger = logger;
    }

    public async Task<AuthResponseDto> LoginAsync(
        LoginRequestDto dto,
        CancellationToken cancellation = default)
    {
        await ValidateDtoAsync(dto, _loginRequestValidator);

        var user = await _context.Users
            .FirstOrDefaultAsync(u => u.UserName == dto.UserName, cancellation);

        if (user == null)
            throw new UnauthorizedAccessException("Username is incorrect!");

        if (!user.IsActive)
            throw new BusinessRuleException("This account is not active!");

        var isPasswordValid = _passwordHasher.VerifyPassword(
            user,
            user.PasswordHash,
            dto.Password);

        if (!isPasswordValid)
            throw new UnauthorizedAccessException("Password is incorrect!");

        var token = _jwtTokenService.GenerateToken(user);

        _logger.LogInformation("User {UserName} logged in successfully.", user.UserName);

        return new AuthResponseDto
        {
            Token = token,
            UserName = user.UserName,
            ExpiresAt = DateTime.UtcNow.AddHours(2)
        };
    }

    private async Task ValidateDtoAsync<T>(T dto, IValidator<T> validator)
    {
        if (dto is null)
            throw new ArgumentNullException(nameof(dto));

        var validationResult = await validator.ValidateAsync(dto);

        if (!validationResult.IsValid)
            throw new ValidationException(validationResult.Errors);
    }

    public async Task ChangePasswordAsync(
        int id,
        ChangePasswordDto dto,
        CancellationToken cancellationToken = default)
    {
        var user = await _context.Users.FindAsync(new object[] { id }, cancellationToken);

        if (user is null)
            throw new NotFoundException(nameof(User), id);

        await ValidateDtoAsync(dto, _changePasswordValidator);

        var isCurrentPasswordValid = _passwordHasher.VerifyPassword(
            user,
            user.PasswordHash,
            dto.CurrentPassword);

        if (!isCurrentPasswordValid)
            throw new UnauthorizedAccessException("Current password is incorrect!");

        user.PasswordHash = _passwordHasher.HashPassword(user, dto.NewPassword);
        await _context.SaveChangesAsync(cancellationToken);

        _logger.LogInformation(
            "User {UserName} changed password successfully.",
            user.UserName);
    }
}
