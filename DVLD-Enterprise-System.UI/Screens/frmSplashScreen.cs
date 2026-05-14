using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Enterprise_System.UI.Core.BaseForms;

namespace DVLD_Enterprise_System.UI.Screens
{
    public partial class frmSplashScreen : frmBaseScreen
    {
        public frmSplashScreen()
        {
            InitializeComponent();
        }

        private void tSplash_Tick(object sender, EventArgs e)
        {
            if (pbLoading.Value < pbLoading.Maximum)
            {
                pbLoading.Value++;
            }
            else
            {
                tSplash.Stop();
                this.Close();
            }
        }

        private void frmSplashScreen_Load(object sender, EventArgs e)
        {
            tSplash.Start();
        }
    }
}
