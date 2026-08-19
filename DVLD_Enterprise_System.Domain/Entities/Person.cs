using DVLD_Enterprise_System.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Enterprise_System.Domain.Entities
{
    public class Person
    {
        public int PersonID { get; set; }

        public string NationalNo { get; set; } = string.Empty;

        public string FirstName { get; set; } = string.Empty;

        public string SecondName { get; set; } = string.Empty;

        public string ThirdName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string FullName =>
            $"{FirstName} {SecondName} {ThirdName} {LastName}";

        public DateTime DateOfBirth { get; set; }

        public GenderType Gender { get; set; }

        public string Address { get; set; } = string.Empty;

        public string Phone { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public int NationalityCountryID { get; set; } = 0;

        public string ImagePath { get; set; } = string.Empty;

        public Country? NationalityCountry { get; set; }
    }
}
