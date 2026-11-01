using DVLD_Enterprise_System.Application.Common;
using DVLD_Enterprise_System.Application.DTOs.Users;
using DVLD_Enterprise_System.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DVLD_Enterprise_System.API.Controllers;

[Route("api/Users")]
[ApiController]
[Authorize] // 🔒 يتطلب توكن صالح افتراضياً للوصول لأي دالة
public class UsersManagementController : ControllerBase
{
    private readonly IUserManagementService _userService;

    public UsersManagementController(IUserManagementService userService)
    {
        _userService = userService;
    }

    [HttpGet]
    public async Task<ActionResult<PagedResult<FilteredUsersDto>>> GetFilteredUsers(
        [FromQuery] GetUsersQueryDto queryDto,
        CancellationToken cancellationToken)
    {
        var result = await _userService.GetFilteredUsersAsync(queryDto, cancellationToken);
        return Ok(result);
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<UserDto>> GetById(
        int id,
        CancellationToken cancellationToken)
    {
        var user = await _userService.GetByUserIdAsync(id, cancellationToken);
        return Ok(user);
    }

    [HttpPost]
    public async Task<ActionResult<int>> Create(
        [FromBody] CreateUserDto dto,
        CancellationToken cancellationToken)
    {
        var userId = await _userService.CreateAsync(dto, cancellationToken);
        return CreatedAtAction(nameof(GetById), new { id = userId });
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> Update(
        int id, 
        [FromBody] UpdateUserDto dto, 
        CancellationToken cancellationToken)
    {
        await _userService.UpdateAsync(id, dto, cancellationToken);
        return NoContent();
    }

    [HttpPatch("{id:int}/toggle-status")]
    public async Task<IActionResult> ToggleStatus(
        int id,
        CancellationToken cancellationToken)
    {
        await _userService.ToggleStatusAsync(id, cancellationToken);
        return NoContent();
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id, CancellationToken cancellationToken)
    {
        await _userService.DeleteAsync(id, cancellationToken);
        return NoContent();
    }
}
