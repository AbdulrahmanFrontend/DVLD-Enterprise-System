using DevToolkit.Core.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Enterprise_System.UI.Services
{
    public class AuthenticationService
    {
        public Result Login(string userName)
            => userName == "admin" ? Result.Success() : Result.Failure("Failed to login");
    }
}
