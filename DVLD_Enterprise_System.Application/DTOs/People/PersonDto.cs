using DVLD_Enterprise_System.Domain.Enums;

namespace DVLD_Enterprise_System.Application.DTOs.People;

public class PersonDto
{
    public int PersonID { get; set; }
    public string NationalNo { get; set; } = null!;
    public string FirstName { get; set; } = null!;
    public string SecondName { get; set; } = null!;
    public string? ThirdName { get; set; }
    public string LastName { get; set; } = null!;
    public DateTime DateOfBirth { get; set; }
    public GenderType Gender { get; set; }
    public string GenderCaption => Gender.ToString();
    public string Address { get; set; } = null!;
    public string Phone { get; set; } = null!;
    public string? Email { get; set; }
    public int NationalityCountryID { get; set; }
    public string? ImagePath { get; set; }
}
