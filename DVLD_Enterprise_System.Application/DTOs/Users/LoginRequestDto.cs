namespace DVLD_Enterprise_System.Application.DTOs.Users;

// DTO لتسجيل الدخول
public class LoginRequestDto 
{
    public string UserName { get; set; } = null!; 
    public string Password { get; set; } = null!;
}
