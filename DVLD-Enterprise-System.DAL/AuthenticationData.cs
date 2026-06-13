using DevToolkit.Core.Results;
using DevToolkit.Data.Core;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DevToolkit.Data;
using DVLD_Enterprise_System.Core.Models;
using DevToolkit.Core.Guards;

namespace DVLD_Enterprise_System.DAL
{
    public static class AuthenticationData
    {
        public static Result<User> Login(string userName, string passwordHash)
        {
            DbParameterInfo[] parameters = new DbParameterInfo[]
            {
                new DbParameterInfo
                { 
                    Name = "UserName",
                    Value = userName,
                    DbType = DbType.String, 
                    Size = 20,
                },
                new DbParameterInfo
                {
                    Name = "PasswordHash",
                    Value = passwordHash,
                    DbType = DbType.String,
                    Size = 255,
                },
            };

            var result = DataQueryService.FirstOrDefault<User>(CommandType.StoredProcedure, 
                "sp_Login", parameters);

            if (result != null && result.IsSuccess)
                return Result<User>.Success(result.Data);

            return Result<User>.Failure("UserName or Password not valid or User not found;");
        }
    }
}
