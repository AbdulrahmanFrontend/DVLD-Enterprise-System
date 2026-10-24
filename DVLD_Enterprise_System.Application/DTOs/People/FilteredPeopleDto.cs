using DVLD_Enterprise_System.Domain.Enums;
using System.Text;

namespace DVLD_Enterprise_System.Application.DTOs.People;

public sealed record FilteredPeopleDto
{
    public int PersonID { get; set; }
    public string NationalNo { get; set; } = null!;
    public string FirstName { get; set; } = null!;
    public string SecondName { get; set; } = null!;
    public string? ThirdName { get; set; }
    public string LastName { get; set; } = null!;
    public string FullName
    {
        get
        {
            StringBuilder fullName = new StringBuilder();

            fullName.Append(FirstName + " " + SecondName + " ");

            if (!string.IsNullOrEmpty(ThirdName))
            {
                fullName.Append(ThirdName + " " + LastName);
                return fullName.ToString();
            }

            fullName.Append(LastName);

            return fullName.ToString();
        }
    }
    public string? Email { get; set; }
    public GenderType Gender { get; set; }
    public string GenderCaption => Gender.ToString();
    public string Phone { get; set; } = null!;
    public int NationalityCountryID { get; set; }
    public string NationalityCountryName { get; set; } = null!;
}
