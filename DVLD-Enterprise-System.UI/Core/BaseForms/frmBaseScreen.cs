using DVLD_Enterprise_System.UI.Core.DesignSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Enterprise_System.UI.Core.BaseForms
{
    public partial class frmBaseScreen : Form
    {
        public frmBaseScreen()
        {
            _ApplyTheme();
        }

        private void _ApplyTheme()
        {
            switch (AppTheme.CurrentTheme)
            {
                case AppTheme.ThemeType.Light:
                    _ApplyLightTheme();
                    break;
                case AppTheme.ThemeType.Dark:
                    break;
                default:
                    BackColor = AppColors.Background;
                    Font = AppFonts.Body;
                    break;
            }
        }

        private void _ApplyLightTheme()
        {
            BackColor = AppColors.Background;
            Font = AppFonts.Body;
        }
    }
}
