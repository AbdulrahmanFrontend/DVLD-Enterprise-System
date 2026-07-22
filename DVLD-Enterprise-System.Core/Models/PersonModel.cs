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

        [Required("National No is required")]
        [NationalNo("Invalid")]
        [MaxLength(20, "National No must be less than or equal 20 characters")]
        public string NationalNo { get; set; } = string.Empty;

        [Required("First Name is required")]
        [MaxLength(20, "First Name must be less than or equal 20 characters")]
        public string FirstName { get; set; } = string.Empty;

        [Required("Second Name is required")]
        [MaxLength(20, "Second Name must be less than or equal 20 characters")]
        public string SecondName { get; set; } = string.Empty;

        [MaxLength(20, "Third Name must be less than or equal 20 characters")]
        public string ThirdName { get; set; } = string.Empty;

        [Required("Third Name is required")]
        [MaxLength(20, "Last Name must be less than or equal 20 characters")]
        public string LastName { get; set; } = string.Empty;

        public string FullName => 
            FirstName + " " + SecondName + " " + ThirdName + " " + LastName;

        public DateTime DateOfBirth { get; set; } = DateTime.Now;

        public Gender Gender { get; set; }

        [Required("Address is required")]
        [MaxLength(500, "Address must be less than or equal 500 characters")]
        public string Address { get; set; } = string.Empty;

        [Required("Phone is required")]
        [MaxLength(20, "Phone must be less than or equal 20 characters")]
        [MinLength(7, "Phone must be larger than or equal 7 characters")]
        [PhoneNo("Invalid")]
        public string Phone { get; set; } = string.Empty;

        [MaxLength(50, "Email must be less than or equal 50 characters")]
        [EmailAddr("Invalid")]
        public string Email { get; set; } = string.Empty;

        public int NationalityCountryID { get; set; } = 0;

        [MaxLength(250, "Image Path must be less than or equal 250 characters")]
        public string ImagePath { get; set; } = string.Empty;
    }
}
