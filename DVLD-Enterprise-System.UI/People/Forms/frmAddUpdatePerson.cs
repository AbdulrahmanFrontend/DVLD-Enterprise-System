using DevToolkit.BaseWinForms.Managers;
using DevToolkit.Core.Common;
using DVLD_Enterprise_System.BLL;
using DVLD_Enterprise_System.Core.Enums;
using DVLD_Enterprise_System.Core.Models;
using DVLD_Enterprise_System.UI.Core.BaseForms;
using DVLD_Enterprise_System.UI.People.Controls;
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
    public partial class frmAddUpdatePerson : frmAddUpdate
    {
        // Declare a delegate
        public delegate void DataBackEventHandler(object sender, int PersonID);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;

        public frmAddUpdatePerson()
        {
            InitializeComponent();

            this.ButtonDeleteVisible = false;
            this.Title = "Add New Person";
            ctrlPersonCard Card = new ctrlPersonCard();
            ScreenManager.ShowScreen(this.Container, Card);
        }

        public frmAddUpdatePerson(int id)
        {
            InitializeComponent();

            this.Title = "Update Person Info";
            var result = PersonService.Find(id);
            if (result.IsSuccess)
            {
                MessageBoxManager.ShowError(result.Message, Language.en);
                this.DialogResult = DialogResult.Cancel;
                return;
            }
        }

        private void frmAddUpdatePerson_Load(object sender, EventArgs e)
        {
            
        }
    }
}
