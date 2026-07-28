using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Enterprise_System.UI.People.Forms
{
    public partial class frmShowPersonInfo : Form
    {
        public frmShowPersonInfo(int personId)
        {
            InitializeComponent();
            PersonCard.LoadPersonInfo(personId);
        }

        public frmShowPersonInfo(string nationalNo)
        {
            InitializeComponent();
            PersonCard.LoadPersonInfo(nationalNo);
        }
    }
}
