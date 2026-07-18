using DVLD_Enterprise_System.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Enterprise_System.UI.People.Controls
{
    public partial class ctrlPersonCard : UserControl
    {
        public ctrlPersonCard()
        {
            InitializeComponent();
        }

        public ctrlPersonCard(PersonModel model)
        {
            InitializeComponent();


        }

        [Category("Custom Properties")]
        public int? SelectedCountryID
        {
            get
            {
                return cbCountry.SelectedValue == null &&
                    int.TryParse(cbCountry.Text?.ToString(), out int id) ? id : 0;
            }
            set
            {
                if (value == null)
                    cbCountry.SelectedIndex = -1;
                else
                    cbCountry.SelectedValue = value;
            }
        }

        [Category("Custom Properties")]
        public int SelectedGenderIndex
        {
            get => cbGender.SelectedIndex;
            set => cbGender.SelectedIndex = value;
        }

        public void FillContries(DataTable data)
        {
            cbCountry.DisplayMember = "CountryName";
            cbCountry.ValueMember = "CountryID";
            cbCountry.DataSource = data;

            if (data == null || data.Rows.Count == 0)
                return;

            cbCountry.SelectedValue = 51;
        }
    }
}
