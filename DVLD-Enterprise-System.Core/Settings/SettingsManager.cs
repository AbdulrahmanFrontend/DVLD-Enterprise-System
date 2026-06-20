using DevToolkit.Core.Results;
using DevToolkit.Infrastructure.Registry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Enterprise_System.Core.Settings
{
    public static class SettingsManager
    {
        public static Result SaveRememberMe(bool rememberMe)
        {
            var result = RegistryManager.SaveValue("Remember me", rememberMe);

            if (result != null && result.IsSuccess)
                return result;

            return Result.Failure("Failed to save remember me setting.");
        }

        public static Result SaveCurrentUserName(string userName)
        {
            var result = RegistryManager.SaveValue(
                "Current UserName", 
                userName);

            if (result != null && result.IsSuccess)
                return result;

            return Result.Failure("Failed to save current UserName setting.");
        }
    }
}
