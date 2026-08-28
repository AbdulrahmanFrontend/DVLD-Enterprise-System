using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DVLD_Enterprise_System.Application.DTOs.Users
{
    public class CreateUserDto
    {
        public int UserID { get; set; }

        [Required]
        [MaxLength(20)]
        public string UserName { get; set; } = string.Empty;

        [Required]
        [MaxLength(20)]
        public string Password { get; set; } = string.Empty;

        public bool IsActive { get; set; } = true;

        public int PersonID { get; set; }
    }
}
