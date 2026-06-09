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
        public static Result<User> HasUsers()
            => DataQueryService.FirstOrDefault<User>(CommandType.StoredProcedure, "sp_HasUsers");
    }
}
