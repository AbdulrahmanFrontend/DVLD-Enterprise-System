using DevToolkit.BaseWinForms.Managers;
using DevToolkit.Core.Common;
using DevToolkit.Core.Results;
using DVLD_Enterprise_System.BLL;
using DVLD_Enterprise_System.Core.Enums;
using DVLD_Enterprise_System.Core.Models;
using DVLD_Enterprise_System.UI.Global_Classes;
using DVLD_Enterprise_System.UI.People.Controls;
using DVLD_Enterprise_System.UI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        PersonService _Person;

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
                _Person = new PersonService();
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
                MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
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
                MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                this.Close();
                return;
            }

            _Person = result.Data;

            //the following code will not be executed if the person was not found
            txtFirstName.Text = _Person.Model.FirstName;
            txtSecondName.Text = _Person.Model.SecondName;
            txtThirdName.Text = _Person.Model.ThirdName;
            txtLastName.Text = _Person.Model.LastName;
            txtNationalNo.Text = _Person.Model.NationalNo;
            dtpDateOfBirth.Value = _Person.Model.DateOfBirth;

            cbGenders.SelectedIndex = (int)_Person.Model.Gender;

            txtAddress.Text = _Person.Model.Address;
            txtPhone.Text = _Person.Model.Phone;
            txtEmail.Text = _Person.Model.Email;
            cbCountries.SelectedIndex = 
                cbCountries.FindString(_Person.Country.CountryName);


            //load person image incase it was set.
            if (_Person.Model.ImagePath != "")
                pbPersonImage.ImageLocation = _Person.Model.ImagePath;

            //hide/show the remove linke incase there is no image for the person.
            llRemoveImage.Visible = (_Person.Model.ImagePath != "");
        }

        private void Validate(object sender, CancelEventArgs e, Result result)
        {
            // First: set AutoValidate property of your Form to EnableAllowFocusChange in designer 
            Control Temp = ((Control)sender);
            if (result.IsSuccess)
            {
                e.Cancel = true;
                epPerson.SetError(Temp, result.Message);
            }
            else
            {
                //e.Cancel = false;
                epPerson.SetError(Temp, string.Empty);
            }
        }

        private void llSetImage_LinkClicked(
            object sender,
            LinkLabelLinkClickedEventArgs e)
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

        private void llRemoveImage_LinkClicked(
            object sender, 
            LinkLabelLinkClickedEventArgs e)
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

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
            => Validate(sender, e, _Person.ValidateFirstName());

        private void txtSecondName_Validating(object sender, CancelEventArgs e)
            => Validate(sender, e, _Person.ValidateSecondName());

        private void txtLastName_Validating(object sender, CancelEventArgs e)
            => Validate(sender, e, _Person.ValidateLastName());

        private void txtNationalNo_Validating(object sender, CancelEventArgs e)
            => Validate(sender, e, _Person.ValidateNationalNo());

        private void txtPhone_Validating(object sender, CancelEventArgs e)
            => Validate(sender, e, _Person.ValidatePhone());

        private void dtpDateOfBirth_Validating(object sender, CancelEventArgs e)
            => Validate(sender, e, _Person.ValidateDateOfBirth());

        private void txtEmail_Validating(object sender, CancelEventArgs e)
            => Validate(sender, e, _Person.ValidateEmail());

        private void txtAddress_Validating(object sender, CancelEventArgs e)
            => Validate(sender, e, _Person.ValidateAddress());

        private void ctrlbtnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!," +
                    " put the mouse over the red icon(s) to see the erro",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            Result result = _HandlePersonImage();

            if (!result.IsSuccess)
            {
                MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            _Person.Model.FirstName = txtFirstName.Text.Trim();
            _Person.Model.SecondName = txtSecondName.Text.Trim();
            _Person.Model.ThirdName = txtThirdName.Text.Trim();
            _Person.Model.LastName = txtLastName.Text.Trim();
            _Person.Model.NationalNo = txtNationalNo.Text.Trim();
            _Person.Model.Email = txtEmail.Text.Trim();
            _Person.Model.Phone = txtPhone.Text.Trim();
            _Person.Model.Address = txtAddress.Text.Trim();
            _Person.Model.DateOfBirth = dtpDateOfBirth.Value;

            _Person.Model.Gender = (Gender)cbGenders.SelectedIndex;

            _Person.Model.NationalityCountryID = 
                int.TryParse(cbCountries.SelectedValue?.ToString(), out int value) 
                ? value : 0;

            if (pbPersonImage.ImageLocation != null)
                _Person.Model.ImagePath = pbPersonImage.ImageLocation;
            else
                _Person.Model.ImagePath = "";

            result = _Person.Save();

            if (result.IsSuccess)
            {
                lblPersonID.Text = _Person.Model.PersonID.ToString();
                //change form mode to update.
                _Mode = Mode.Update;
                lblTitle.Text = "Update Person";

                MessageBox.Show(result.Message, "Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);


                // Trigger the event to send data back to the caller form.
                DataBack?.Invoke(this, _Person.Model.PersonID);
            }
            else
                MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }

        private Result _HandlePersonImage()
        {

            //this procedure will handle the person image,
            //it will take care of deleting the old image from the folder
            //in case the image changed. and it will rename the new image with guid and 
            // place it in the images folder.


            //_Person.ImagePath contains the old Image, we check if it changed then we copy the new image
            if (_Person.Model.ImagePath != pbPersonImage.ImageLocation)
            {
                if (_Person.Model.ImagePath != "")
                {
                    //first we delete the old image from the folder in case there is any.

                    try
                    {
                        File.Delete(_Person.Model.ImagePath);
                    }
                    catch (IOException)
                    {
                        // We could not delete the file.
                        
                        //log it later   
                    }
                }

                if (pbPersonImage.ImageLocation != null)
                {
                    //then we copy the new image to the image folder after we rename it
                    string SourceImageFile = pbPersonImage.ImageLocation.ToString();

                    if (Utils.CopyImageToProjectImagesFolder(ref SourceImageFile))
                    {
                        pbPersonImage.ImageLocation = SourceImageFile;
                        return Result.Success();
                    }
                    else
                    {
                        MessageBox.Show("Error Copying Image File", "Error", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return Result.Failure("Error Copying Image File");
                    }
                }

            }
            return Result.Success();
        }
    }
}
