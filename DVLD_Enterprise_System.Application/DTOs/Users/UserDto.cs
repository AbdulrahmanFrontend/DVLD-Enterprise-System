using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD_Enterprise_System.Application.DTOs.Users
{
    public class UserDto
    {
        public int UserID { get; set; }

        public string UserName { get; set; } = string.Empty;

        public bool IsActive { get; set; } = true;

        public int PersonID { get; set; }
    }
}
