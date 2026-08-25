using DVLD_Enterprise_System.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace DVLD_Enterprise_System.Application.DTOs.People
{
    public class UpdatePersonDto
    {
        [Required]
        [MaxLength(20)]
        public string NationalNo { get; set; } = string.Empty;

        [Required]
        [MaxLength(20)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [MaxLength(20)]
        public string SecondName { get; set; } = string.Empty;

        [MaxLength(20)]
        public string? ThirdName { get; set; }

        [Required]
        [MaxLength(20)]
        public string LastName { get; set; } = string.Empty;

        public DateTime DateOfBirth { get; set; }

        public GenderType Gender { get; set; }

        [Required]
        [MaxLength(500)]
        public string Address { get; set; } = string.Empty;

        [Required]
        [MaxLength(20)]
        public string Phone { get; set; } = string.Empty;

        [MaxLength(50)]
        [EmailAddress]
        public string? Email { get; set; }

        public int NationalityCountryID { get; set; }

        [MaxLength(250)]
        public string? ImagePath { get; set; }
    }
}
