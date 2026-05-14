using DVLD_Enterprise_System.UI.Core.DesignSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Enterprise_System.UI.Core.Components
{
    public partial class DVLDButton : Button
    {
        public DVLDButton()
        {
            InitializeComponent();

            this.FlatStyle = FlatStyle.Flat;

            BackColor = AppColors.Secondary;

            ForeColor = Color.White;

            Font = AppFonts.Button;

            this.FlatAppearance.BorderSize = 0;

            Height = 45;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
