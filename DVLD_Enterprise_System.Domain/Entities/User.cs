using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Enterprise_System.Domain.Entities
{
    public class User
    {
        public int UserID { get; set; }

        public int PersonID { get; set; }

        public string UserName { get; set; } = string.Empty;

        public string PasswordHash { get; set; } = string.Empty;

        public bool IsActive { get; set; } = true;

        public Person? Person { get; set; }
    }
}
