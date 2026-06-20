using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Enterprise_System.Core.Settings
{
    public class SettingsModel
    {
        public bool RememberMe { get; set; } = false;
        public string UserName { get; set; } = string.Empty;
    }
}
