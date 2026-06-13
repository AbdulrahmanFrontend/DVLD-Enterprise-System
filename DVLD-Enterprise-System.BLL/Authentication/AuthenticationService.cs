using DevToolkit.Core.Results;
using DevToolkit.Security.PasswordHashing;
using DVLD_Enterprise_System.Core.Models;
using DVLD_Enterprise_System.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Enterprise_System.BLL.Authentication
{
    public class AuthenticationService : IAuthenticationService
    {
        public Result<User> Login(string userName, string password)
        {
            string PasswordHash = PasswordHasher.HashPassword(password);
            return AuthenticationData.Login(userName, PasswordHash);
        }
    }
}
