using DevToolkit.Core.Guards;
using DVLD_Enterprise_System.Core.Models;
using DVLD_Enterprise_System.UI.People.Forms;
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
    public partial class ctrlPersonCardWithFilter : UserControl
    {
        // Define a custom event handler delegate with parameters
        public event EventHandler<PersonSelectedEventArgs> OnPersonSelected;
        // Create a protected method to raise the event with a parameter

        public class PersonSelectedEventArgs : EventArgs
        {
            public int PersonID { get; }

            public PersonSelectedEventArgs(int personId)
            {
                this.PersonID = personId;
            }
        }
        
        public bool ShowAddPerson
        {
            get => btnAddNewPerson.Visible;
            set => btnAddNewPerson.Visible = value;
        }

        public bool FilterEnabled
        {
            get => tlpFilters.Enabled;
            set => tlpFilters.Enabled = value;
        }

        public ctrlPersonCardWithFilter()
        {
            InitializeComponent();
        }

        public int PersonID => PersonCard.PersonID;

        public PersonModel SelectedPersonInfo => PersonCard.SelectedPersonInfo;

        public void LoadPersonInfo(int PersonID)
        {
            cbFilterMethods.SelectedIndex = 1;
            txtFilterValue.Text = PersonID.ToString();
            FindNow();
        }

        private void FindNow()
        {
            switch (cbFilterMethods.Text)
            {
                case "Person ID":
                    PersonCard.LoadPersonInfo(int.Parse(txtFilterValue.Text));
                    break;

                case "National No.":
                    PersonCard.LoadPersonInfo(txtFilterValue.Text);
                    break;

                default:
                    break;
            }

            OnPersonSelected?.Invoke(
                this, 
                new PersonSelectedEventArgs(PersonCard.PersonID));
        }

        private void cbFilterMethods_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Text = string.Empty;
            txtFilterValue.Focus();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, " +
                    "put the mouse over the red icon(s) to see the erro",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            FindNow();
        }

        private void ctrlPersonCardWithFilter_Load(object sender, EventArgs e)
        {
            cbFilterMethods.SelectedIndex = 0;
            txtFilterValue.Focus();
        }

        private void txtFilterValue_Validating(object sender, CancelEventArgs e)
        {
            epFilterValue.Clear();
            if (!Guard.HasValue(txtFilterValue.Text.Trim()))
            {
                e.Cancel = true;
                epFilterValue.SetError(txtFilterValue, "required!");
            }
            else
            {
                //e.Cancel = false;
                epFilterValue.SetError(txtFilterValue, null);
            }
        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson();
            frm.DataBack += DataBackEvent; // Subscribe to the event
            frm.ShowDialog();
        }

        private void DataBackEvent(object sender, int personId)
        {
            // Handle the data received
            cbFilterMethods.SelectedIndex = 1;
            txtFilterValue.Text = personId.ToString();
            PersonCard.LoadPersonInfo(personId);
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is Enter (character code 13)
            if (e.KeyChar == (char)13)
                btnFind.PerformClick();

            //this will allow only digits if person id is selected
            if (cbFilterMethods.Text == "Person ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
