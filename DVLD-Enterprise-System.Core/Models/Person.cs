using DevToolkit.Core.Common;
using DevToolkit.Core.Validation.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Enterprise_System.Core.Models
{
    public abstract class Person : BaseEntity
    {
        [Required]
        [NationalNo]
        [Length(14)]
        public string NationalNo { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(20)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(20)]
        public string SecondName { get; set; }

        [MinLength(1)]
        [MaxLength(20)]
        public string ThirdName { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(20)]
        public string LastName { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Range(0, 2)]
        public int Gender { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(500)]
        public string Address { get; set; }

        [Required]
        [Length(11)]
        [PhoneNo]
        public string Phone { get; set; }

        [MaxLength(50)]
        [EmailAddr]
        public string Email { get; set; }

        [Required]
        public int NationalityCountryID { get; set; }

        [MaxLength(250)]
        public string ImagePath { get; set; }
    }
}
