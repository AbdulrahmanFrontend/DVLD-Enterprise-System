using DVLD_Enterprise_System.Domain.Enums;

namespace DVLD_Enterprise_System.API.DTOs.People
{
    public class PersonDto
    {
        public int PersonID { get; set; }

        public string NationalNo { get; set; } = string.Empty;

        public string FirstName { get; set; } = string.Empty;

        public string SecondName { get; set; } = string.Empty;

        public string ThirdName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string FullName { get; set; } = string.Empty;

        public DateTime DateOfBirth { get; set; }

        public GenderType Gender { get; set; }

        public string Address { get; set; } = string.Empty;

        public string Phone { get; set; } = string.Empty;

        public string? Email { get; set; }

        public int NationalityCountryID { get; set; }

        public string? ImagePath { get; set; }

        public string? NationalityCountryName { get; set; }
    }
}
