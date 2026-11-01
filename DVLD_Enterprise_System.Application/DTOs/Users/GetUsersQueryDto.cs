namespace DVLD_Enterprise_System.Application.DTOs.Users;

public class GetUsersQueryDto
{
    public string? UserName { get; set; }
    public string? FullName { get; set; }
    public bool? IsActive { get; set; }
    public int PageNumber { get; set; } = 1;
    public int PageSize { get; set; } = 50;
}
