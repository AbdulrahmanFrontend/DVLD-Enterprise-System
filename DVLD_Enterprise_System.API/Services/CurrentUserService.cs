using System.Security.Claims;
using DVLD_Enterprise_System.Application.Interfaces;
using DVLD_Enterprise_System.Domain.Enums;

namespace DVLD_Enterprise_System.API.Services;

public class CurrentUserService : ICurrentUserService
{
    private readonly IHttpContextAccessor _httpContextAccessor;

    public CurrentUserService(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

    public int? UserId
    {
        get
        {
            var value = _httpContextAccessor.HttpContext?.User?.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            return int.TryParse(value, out var id) ? id : null;
        }
    }

    public string? UserName =>
        _httpContextAccessor.HttpContext?.User?.FindFirst(ClaimTypes.Name)?.Value;

    public int Permissions
    {
        get
        {
            var value = _httpContextAccessor.HttpContext?.User?.FindFirst("Permissions")?.Value;
            return int.TryParse(value, out var p) ? p : 0;
        }
    }

    public bool HasPermission(Permissions requiredPermission)
    {
        var userPermissions = Permissions;

        // إذا كان الصلاحية -1 فهذا يعني Admin شامل يمتلك كل الصلاحيات
        if (userPermissions == -1) return true;

        // التحقق عبر Bitwise AND
        return ((Permissions)userPermissions & requiredPermission) == requiredPermission;
    }
}
