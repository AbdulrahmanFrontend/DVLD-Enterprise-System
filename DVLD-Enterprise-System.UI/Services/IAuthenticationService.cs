using DevToolkit.Core.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Enterprise_System.UI.Services
{
    public interface IAuthenticationService
    {
        Result Login(string userName);
    }
}
