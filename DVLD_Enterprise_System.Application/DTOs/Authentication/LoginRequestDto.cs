using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD_Enterprise_System.Application.DTOs.Authentication
{
    public class LoginRequestDto
    {
        public string UserName { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;
    }
}
