using DevToolkit.Core.Results;
using DVLD_Enterprise_System.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Enterprise_System.BLL.Authentication
{
    public interface IAuthenticationService
    {
        Result<User> Login(string userName, string PasswordHash);
    }
}
