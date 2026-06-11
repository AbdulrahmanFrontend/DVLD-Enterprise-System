using DevToolkit.Core.Common;
using DevToolkit.Core.Validation.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Enterprise_System.Core.Models
{
    public class User : Person
    {
        [Required]
        public int UserID { get; set; }

        [Required]
        public int PersonID { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(20)]
        public string UserName { get; set; }

        [Required]
        [MaxLength(255)]
        [MinLength(1)]
        public string PasswordHash { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
