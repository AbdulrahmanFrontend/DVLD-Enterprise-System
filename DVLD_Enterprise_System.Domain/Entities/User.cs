using System.ComponentModel.DataAnnotations;

namespace DVLD_Enterprise_System.Domain.Entities;

public class User
{
    public int UserID { get; set; }
    public int PersonID { get; set; }

    [Required(ErrorMessage = "Username is required!")]
    [MaxLength(20, ErrorMessage = "Username cannot exceed 20 characters!")]
    public string UserName { get; set; } = null!;

    [Required(ErrorMessage = "Password hash is required!")]
    [MaxLength(255, ErrorMessage = "Password hash cannot exceed 255 characters!")]
    public string PasswordHash { get; set; } = null!;

    public bool IsActive { get; set; } = true;
    public Person Person { get; set; } = null!;
}
