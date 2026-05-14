using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Enterprise_System.UI.Core.DesignSystem
{
    public class AppTheme
    {
        public enum ThemeType
        {
            Light,
            Dark
        }

        public static ThemeType CurrentTheme { get; set; } = ThemeType.Light;
    }
}
