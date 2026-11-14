namespace DVLD_Enterprise_System.Application.DTOs.Users;

public class FilteredUsersDto
{
    public int UserID { get; set; }
    public string UserName { get; set; } = null!;
    public string FullName { get; set; } = null!;
    public bool IsActive { get; set; }
}
