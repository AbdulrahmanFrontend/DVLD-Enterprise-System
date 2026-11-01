using DVLD_Enterprise_System.Application.DTOs.Auth;

namespace DVLD_Enterprise_System.Application.Interfaces;

public interface IUserAuthService
{
    Task<AuthResponseDto> LoginAsync(
        LoginRequestDto dto,
        CancellationToken cancellationToken = default);

    Task ChangePasswordAsync(
        int userId,
        ChangePasswordDto dto,
        CancellationToken cancellationToken = default);
}
