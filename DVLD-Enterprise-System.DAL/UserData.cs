using DevToolkit.Core.Results;
using DevToolkit.Data;
using DVLD_Enterprise_System.Core.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Enterprise_System.DAL
{
    public class UserData
    {
        public static Result<bool> IsAdminFound()
        {
            var result = DataQueryService.Scalar<bool>(
                CommandType.StoredProcedure,
                "sp_IsAdminFound");

            if (result != null && result.IsSuccess)
                return result;

            return Result<bool>.Failure("Failed to check admin is found;");
        }
    }
}
