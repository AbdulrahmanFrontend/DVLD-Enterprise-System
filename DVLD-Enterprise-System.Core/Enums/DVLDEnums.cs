using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Enterprise_System.Core.Enums
{
    public enum StartupResult
    {
        RegisterAdmin,
        Login
    }

    public enum Gender
    {
        Unknown = 0,
        Male = 1,
        Female = 2,
    }

    public enum PeopleFilterMethods
    {
        None = 0,
        PersonID = 1,
        NationalNo = 2,
        FirstName = 3,
        SecondName = 4,
        ThirdName = 5,
        LastName = 6,
        DateOfBirth = 7,
        Nationality = 8,
        Gender = 9,
        Phone = 10,
        Address = 11,
        Email = 12,
    }
}
