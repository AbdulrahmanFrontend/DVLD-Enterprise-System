using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD_Enterprise_System.Application.DTOs.Authentication
{
    /// <summary>
    /// Represents the result returned after a successful authentication.
    ///
    /// JWT information will be added later when JWT authentication
    /// is introduced into the API.
    /// </summary>
    public class LoginResponseDto
    {
        public int UserID { get; set; }

        public string UserName { get; set; } = string.Empty;

        public bool IsActive { get; set; }

        public int PersonID { get; set; }
    }
}
