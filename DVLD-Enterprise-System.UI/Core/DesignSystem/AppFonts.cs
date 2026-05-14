using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Enterprise_System.UI.Core.DesignSystem
{
    public class AppFonts
    {
        public static Font Title =>
        new Font("Segoe UI", 20, FontStyle.Bold);

        public static Font Subtitle =>
            new Font("Segoe UI", 12, FontStyle.Regular);

        public static Font Body =>
            new Font("Segoe UI", 10, FontStyle.Regular);

        public static Font Button =>
            new Font("Segoe UI", 10, FontStyle.Bold);
    }
}
