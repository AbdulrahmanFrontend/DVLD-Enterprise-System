using DVLD_Enterprise_System.Application.Common;
using DVLD_Enterprise_System.Application.DTOs.Users;

namespace DVLD_Enterprise_System.Application.Interfaces;

public interface IUserManagementService
{
    Task<PagedResult<FilteredUsersDto>> GetFilteredUsersAsync(
        GetUsersQueryDto queryDto,
        CancellationToken cancellationToken = default);

    Task<UserDto> GetByUserIdAsync(
        int id,
        CancellationToken cancellationToken = default);

    Task<int> CreateAsync(
        CreateUserDto dto,
        CancellationToken cancellationToken = default);

    Task UpdateAsync(
        int id,
        UpdateUserDto dto,
        CancellationToken cancellationToken = default);

    Task ToggleStatusAsync(
        int id,
        CancellationToken cancellationToken = default);

    Task DeleteAsync(
        int id,
        CancellationToken cancellationToken = default);
}
