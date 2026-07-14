using DevToolkit.Core.Common;
using DevToolkit.Core.Validation.Attributes;
using DVLD_Enterprise_System.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Enterprise_System.Core.Models
{
    public class PersonModel
    {
        public int PersonID { get; set; } = 0;

        [Required]
        [NationalNo]
        [MaxLength(20)]
        public string NationalNo { get; set; } = string.Empty;

        [Required]
        [MaxLength(20)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [MaxLength(20)]
        public string SecondName { get; set; } = string.Empty;

        [MaxLength(20)]
        public string ThirdName { get; set; } = string.Empty;

        [Required]
        [MaxLength(20)]
        public string LastName { get; set; } = string.Empty;

        public string FullName => 
            FirstName + " " + SecondName + " " + ThirdName + " " + LastName;

        public DateTime DateOfBirth { get; set; } = DateTime.Now;

        public Gender Gender { get; set; }

        [Required]
        [MaxLength(500)]
        public string Address { get; set; } = string.Empty;

        [Required]
        [MaxLength(20)]
        [MinLength(7)]
        [PhoneNo]
        public string Phone { get; set; } = string.Empty;

        [MaxLength(50)]
        [EmailAddr]
        public string Email { get; set; } = string.Empty;

        public int NationalityCountryID { get; set; } = 0;

        [MaxLength(250)]
        public string ImagePath { get; set; } = string.Empty;
    }
}
