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

            var result = AuthenticationData.Login(userName, PasswordHash);

            if (result != null && result.IsSuccess)
            {
                if (result.Data != null)
                    return result;

                return Result<User>.Failure(
                    "UserName or Password not valid or User not found;");
            }

            return Result<User>.Failure(result.Message);
        }
    }
}
