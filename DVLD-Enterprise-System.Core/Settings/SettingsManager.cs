using DevToolkit.Core.Guards;
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
        public static Result SaveRememberMe(bool value)
        {
            var result = RegistryManager.SaveValue("Remember me", value);

            if (result != null && result.IsSuccess)
                return result;

            return Result.Failure("Failed to save remember me setting.");
        }

        public static Result<bool> GetRememberMe()
        {
            var result = RegistryManager.GetValue<bool>("Remember me");

            if (result != null && result.IsSuccess)
                return result;

            return Result<bool>.Failure("Failed to get remember me setting.");
        }

        public static Result SaveCurrentUserName(string value)
        {
            var result = RegistryManager.SaveValue(
                "Current UserName", 
                value);

            if (result != null && result.IsSuccess)
                return result;

            return Result.Failure("Failed to save current UserName setting.");
        }

        public static Result<string> GetCurrentUserName()
        {
            var result = RegistryManager.GetValue<string>("Current UserName");

            if (result != null && result.IsSuccess)
            {
                if (Guard.HasValue(result.Data))
                    return result;

                return Result<string>.Failure(
                    "Current UserName not saved during run.");
            }

            return Result<string>.Failure("Failed to get remember me setting.");
        }
    }
}
