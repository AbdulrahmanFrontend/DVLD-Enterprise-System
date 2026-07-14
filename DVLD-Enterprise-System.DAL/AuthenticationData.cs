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
        public static Result<UserModel> Login(string userName, string passwordHash)
        {
            DbParameterInfo[] parameters = new DbParameterInfo[]
            {
                new DbParameterInfo
                { 
                    Name = "@UserName",
                    Value = userName,
                    DbType = DbType.String, 
                    Size = 20,
                },
                new DbParameterInfo
                {
                    Name = "@PasswordHash",
                    Value = passwordHash,
                    DbType = DbType.String,
                    Size = 255,
                },
            };

            var result = DataQueryService.FirstOrDefault<UserModel>(
                CommandType.StoredProcedure, 
                "sp_Login", 
                parameters);

            if (result.IsSuccess)
                return result;

            return Result<UserModel>.Failure("Authentication Failed;");
        }
    }
}
