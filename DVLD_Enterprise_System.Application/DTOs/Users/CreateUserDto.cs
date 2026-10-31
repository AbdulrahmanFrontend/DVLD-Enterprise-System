using DVLD_Enterprise_System.Domain.Enums;

namespace DVLD_Enterprise_System.Application.DTOs.Users;

public class CreateUserDto
{
    public string UserName { get; set; } = null!;
    public string PasswordHash { get; set; } = null!;
    public Permissions Permissions { get; set; } = Permissions.None;
    public int PersonID { get; set; }
}
