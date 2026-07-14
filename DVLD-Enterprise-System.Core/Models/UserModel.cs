using DevToolkit.Core.Common;
using DevToolkit.Core.Validation.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Enterprise_System.Core.Models
{
    public class UserModel : PersonModel
    {
        public int UserID { get; set; } = 0;

        [Required]
        [MaxLength(20)]
        public string UserName { get; set; } = string.Empty;

        [Required]
        [MaxLength(255)]
        public string PasswordHash { get; set; } = string.Empty;

        public bool IsActive { get; set; } = true;
    }
}
