using DVLD_Enterprise_System.Application.DTOs.Users;
using DVLD_Enterprise_System.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DVLD_Enterprise_System.API.Controllers;

[Route("api/[controller]")]
[ApiController]
//سيناريو الاستجابة:
public class AuthController : ControllerBase
{
    private readonly IUserService _userService;

    public AuthController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost("login")]
    public async Task<ActionResult<AuthResponseDto>> Login([FromBody] LoginRequestDto dto, CancellationToken cancellationToken)
    {
        var result = await _userService.LoginAsync(dto, cancellationToken);
        return Ok(result);
    }

    // تجربة Endpoint محمية تتطلب تسجيل دخول وصلاحية
    [HttpGet("protected-test")]
    [Authorize]
    public IActionResult ProtectedTest()
    {
        var username = User.Identity?.Name;
        return Ok(new { message = $"أهلاً بك يا {username}, أنت متصل بنجاح وصلاحياتك مؤكدة عبر الـ JWT!" });
    }
}