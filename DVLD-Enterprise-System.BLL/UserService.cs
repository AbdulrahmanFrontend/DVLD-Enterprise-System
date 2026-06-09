using DevToolkit.Core;
using DevToolkit.Core.Results;
using DevToolkit.Core.Common;
using DVLD_Enterprise_System.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using DVLD_Enterprise_System.DAL;

namespace DVLD_Enterprise_System.BLL
{
    public class UserService : BaseBusiness
    {
        public User userModel { get; private set; }

        public UserService()
        {
            this.userModel = new User();
            this.Mode = Mode.AddNew;
        }

        private UserService(User user)
        {
            this.userModel = user;
            this.Mode = Mode.Update;
        }

        protected override Result _AddNew() => Result.Success();

        protected override Result _Update() => Result.Success();

        public static Result<User> HasUsers() => UserData.HasUsers();
    }
}
