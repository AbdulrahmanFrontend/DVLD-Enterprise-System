using DVLD_Enterprise_System.Application.DTOs.Users;

namespace DVLD_Enterprise_System.Application.Interfaces;

public interface IUserService
{
    Task<AuthResponseDto> LoginAsync(
        LoginRequestDto dto,
        CancellationToken cancellation = default);

    Task<int> CreateUserAsync(
        CreateUserDto dto,
        CancellationToken cancellation = default);
}
