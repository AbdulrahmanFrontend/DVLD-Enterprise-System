using DVLD_Enterprise_System.Domain.Enums;

namespace DVLD_Enterprise_System.Application.Interfaces;

public interface ICurrentUserService
{
    int? UserId { get; }
    string? UserName { get; }
    int Permissions { get; }
    bool HasPermission(Permissions requiredPermission);
}
