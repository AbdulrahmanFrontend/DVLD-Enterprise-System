using DVLD_Enterprise_System.Application.DTOs.Auth;
using DVLD_Enterprise_System.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DVLD_Enterprise_System.API.Controllers;

[Route("api/Auth")]
[ApiController]
public class UsersAuthController : ControllerBase
{
    private readonly IUserAuthService _authService;

    public UsersAuthController(IUserAuthService authService)
    {
        _authService = authService;
    }

    [HttpPost("change-password")]
    public async Task<IActionResult> ChangePassword(
        [FromBody] ChangePasswordDto dto, 
        CancellationToken cancellationToken)
    {
        // استخراج الـ ID الخاص بالمستخدم الحالي من الـ Claims
        var userIdClaim = User
            .FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?
            .Value;
        if (string.IsNullOrEmpty(userIdClaim) || 
            !int.TryParse(userIdClaim, out int currentUserId))
        {
            return Unauthorized(new { message = "Authentication data is invalid!" });
        }

        await _authService.ChangePasswordAsync(currentUserId, dto, cancellationToken);
        return Ok(new { message = "Password changed successfully." });
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(
        [FromBody] LoginRequestDto dto,
        CancellationToken cancellationToken)
    {
        var token = await _authService.LoginAsync(dto, cancellationToken);

        if (token == null)
            return Unauthorized(new { message = "Invalid username or password!" });

        return Ok(new { token });
    }
}
