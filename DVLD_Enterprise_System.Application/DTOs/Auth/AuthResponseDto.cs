namespace DVLD_Enterprise_System.Application.DTOs.Auth;

public class AuthResponseDto
{
    public string Token { get; set; } = null!;
    public string UserName { get; set; } = null!;
    public DateTime ExpiresAt { get; set; } = DateTime.Now;
}
