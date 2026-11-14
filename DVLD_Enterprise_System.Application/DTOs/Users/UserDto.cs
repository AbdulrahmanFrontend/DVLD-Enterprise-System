using DVLD_Enterprise_System.Application.DTOs.People;
using DVLD_Enterprise_System.Domain.Enums;

namespace DVLD_Enterprise_System.Application.DTOs.Users;

public class UserDto
{
    public int UserID { get; set; }
    public string UserName { get; set; } = null!;
    public string FullName { get; set; } = null!;
    public bool IsActive { get; set; }
    public Permissions Permissions { get; set; }
    public int PersonID { get; set; }
    public PersonDto Person { get; set; } = null!;
}
