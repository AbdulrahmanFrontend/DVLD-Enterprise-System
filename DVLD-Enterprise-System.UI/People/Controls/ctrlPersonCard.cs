using DevToolkit.Core.Results;
using DVLD_Enterprise_System.BLL;
using DVLD_Enterprise_System.Core.Models;
using DVLD_Enterprise_System.UI.People.Forms;
using DVLD_Enterprise_System.UI.Properties;
using System.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevToolkit.Core.Guards;

namespace DVLD_Enterprise_System.UI.People.Controls
{
    public partial class ctrlPersonCard : UserControl
    {
        public ctrlPersonCard()
        {
            InitializeComponent();
        }

        private PersonModel _Person;

        private int _PersonID = -1;

        public int PersonID
        {
            get { return _PersonID; }
        }

        public PersonModel SelectedPersonInfo
        {
            get { return _Person; }
        }

        public void LoadPersonInfo(int PersonID)
        {
            Result<PersonService> result = PersonService.Find(PersonID);

            if (result.IsSuccess)
            {
                ResetPersonInfo();

                MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            _Person = result.Data.Model;

            _FillPersonInfo();
        }

        public void LoadPersonInfo(string NationalNo)
        {
            Result<PersonService> result = PersonService.Find(NationalNo);

            if (result.IsSuccess)
            {
                ResetPersonInfo();

                MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            _Person = result.Data.Model;

            _FillPersonInfo();
        }

        private void _LoadPersonImage()
        {
            if ((int)_Person.Gender == 0)
                pbPersonImage.Image = Resources.Male_512;
            else if ((int)_Person.Gender == 1)
                pbPersonImage.Image = Resources.Female_512;
            else
                pbPersonImage.Image = null;

            string ImagePath = _Person.ImagePath;

            if (Guard.HasValue(ImagePath))
                if (File.Exists(ImagePath))
                    pbPersonImage.ImageLocation = ImagePath;
                else
                    MessageBox.Show("Could not find this image: = " + ImagePath,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void _FillPersonInfo()
        {
            llEditPersonInfo.Enabled = true;
            _PersonID = _Person.PersonID;
            tbPersonID.Text = _Person.PersonID.ToString();
            tbNationalNo.Text = _Person.NationalNo;
            tbFullName.Text = _Person.FullName;
            cbGender.SelectedIndex = (int)_Person.Gender;
            tbEmail.Text = _Person.Email;
            tbPhone.Text = _Person.Phone;
            dtpDateOfBirth.Value = _Person.DateOfBirth;

            Result<CountryService> result = 
                CountryService.Find(_Person.NationalityCountryID);

            if (!result.IsSuccess)
            {
                MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                this.ParentForm?.Close();
            }

            tbCountries.Text = result.Data.Model.CountryName;
            tbAddress.Text = _Person.Address;
            _LoadPersonImage();
        }

        public void ResetPersonInfo()
        {
            _PersonID = 0;
            tbPersonID.Text = string.Empty;
            tbNationalNo.Text = string.Empty;
            tbFullName.Text = string.Empty;
            pbPersonImage.Image = null;
            cbGender.SelectedIndex = -1;
            tbEmail.Text = string.Empty;
            tbPhone.Text = string.Empty;
            dtpDateOfBirth.Value = DateTime.Now;
            tbCountries.Text = string.Empty;
            tbAddress.Text = string.Empty;
        }

        private void llEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson(_PersonID);
            frm.ShowDialog();

            //refresh
            LoadPersonInfo(_PersonID);
        }
    }
}
