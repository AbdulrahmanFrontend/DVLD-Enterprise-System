using DevToolkit.Core.Results;
using DVLD_Enterprise_System.BLL;
using DVLD_Enterprise_System.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Enterprise_System.BLL.Startup
{
    public class StartupService
    {
        public Result<User> GetAdminUser() => UserService.GetAdminUser();
    }
}
