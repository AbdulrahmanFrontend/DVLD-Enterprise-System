using DevToolkit.BaseWinForms.Managers;
using DevToolkit.Core.Common;
using DVLD_Enterprise_System.BLL;
using DVLD_Enterprise_System.Core.Enums;
using DVLD_Enterprise_System.Core.Models;
using DVLD_Enterprise_System.UI.People.Controls;
using DVLD_Enterprise_System.UI.Properties;
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
    public partial class frmAddUpdatePerson : Form
    {
        // Declare a delegate
        public delegate void DataBackEventHandler(object sender, int PersonID);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;

        public enum Mode { AddNew = 0, Update = 1 };
        public Gender Gender { get; set; }

        private Mode _Mode;
        private int _PersonID = -1;
        PersonModel _Person;

        public frmAddUpdatePerson()
        {
            InitializeComponent();
            _Mode = Mode.AddNew;
        }

        public frmAddUpdatePerson(int id)
        {
            InitializeComponent();
            _Mode = Mode.Update;
            _PersonID = id;
        }

        private void frmAddUpdatePerson_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();

            if (_Mode == Mode.Update)
                _LoadData();
        }

        private void _ResetDefualtValues()
        {
            //this will initialize the reset the defaule values
            _FillCountriesInComoboBox();

            if (_Mode == Mode.AddNew)
            {
                lblTitle.Text = "Add New Person";
                _Person = new PersonModel();
            }
            else
            {
                lblTitle.Text = "Update Person";
            }

            //hide/show the remove linke incase there is no image for the person.
            llRemoveImage.Visible = (pbPersonImage.ImageLocation != null);

            //we set the max date to 18 years from today, and set the default value the same.
            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
            dtpDateOfBirth.Value = dtpDateOfBirth.MaxDate;

            //should not allow adding age more than 100 years
            dtpDateOfBirth.MinDate = DateTime.Now.AddYears(-100);

            //this will set default country to jordan.
            cbCountries.SelectedIndex = cbCountries.FindString("Egypt");
            
            cbGenders.SelectedIndex = 0;
        }

        private void _FillCountriesInComoboBox()
        {
            var result = CountryService.GetAll();

            if (!result.IsSuccess)
            {
                MessageBoxManager.ShowError(result.Message, Language.en);
                this.DialogResult = DialogResult.Cancel;
                return;
            }

            cbCountries.DisplayMember = "CountryName";
            cbCountries.ValueMember = "CountryID";
            cbCountries.DataSource = result.Data;
        }

        private void _LoadData()
        {
            var result = PersonService.Find(_PersonID);

            if (!result.IsSuccess)
            {
                MessageBoxManager.ShowError(result.Message, Language.en);
                this.Close();
                return;
            }

            _Person = result.Data.Model;

            //the following code will not be executed if the person was not found
            txtFirstName.Text = _Person.FirstName;
            txtSecondName.Text = _Person.SecondName;
            txtThirdName.Text = _Person.ThirdName;
            txtLastName.Text = _Person.LastName;
            txtNationalNo.Text = _Person.NationalNo;
            dtpDateOfBirth.Value = _Person.DateOfBirth;

            cbGenders.SelectedIndex = (int)_Person.Gender;

            txtAddress.Text = _Person.Address;
            txtPhone.Text = _Person.Phone;
            txtEmail.Text = _Person.Email;
            cbCountries.SelectedIndex = 
                cbCountries.FindString(result.Data.Country.CountryName);


            //load person image incase it was set.
            if (_Person.ImagePath != "")
            {
                pbPersonImage.ImageLocation = _Person.ImagePath;

            }

            //hide/show the remove linke incase there is no image for the person.
            llRemoveImage.Visible = (_Person.ImagePath != "");
        }

        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ofdPersonImage.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            ofdPersonImage.FilterIndex = 1;
            ofdPersonImage.RestoreDirectory = true;

            if (ofdPersonImage.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = ofdPersonImage.FileName;
                pbPersonImage.Load(selectedFilePath);
                llRemoveImage.Visible = true;
                // ...
            }
        }

        private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbPersonImage.ImageLocation = null;
            
            if (cbGenders.SelectedIndex == 0)
                pbPersonImage.Image = Resources.Male_512;
            else if (cbGenders.SelectedIndex == 1)
                pbPersonImage.Image = Resources.Female_512;

            llRemoveImage.Visible = false;
        }

        private void cbGenders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pbPersonImage.ImageLocation != null)
                return;

            if (cbGenders.SelectedIndex == 0)
                pbPersonImage.Image = Resources.Male_512;
            else if (cbGenders.SelectedIndex == 1)
                pbPersonImage.Image = Resources.Female_512;
            else
                pbPersonImage.ImageLocation = null;
        }
    }
}
