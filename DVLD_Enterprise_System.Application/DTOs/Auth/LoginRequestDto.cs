namespace DVLD_Enterprise_System.Application.DTOs.Auth;

// DTO لتسجيل الدخول
public class LoginRequestDto 
{
    public string UserName { get; set; } = null!; 
    public string Password { get; set; } = null!;
}
