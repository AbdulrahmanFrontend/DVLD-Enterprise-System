using DevToolkit.Core.Results;
using DVLD_Enterprise_System.BLL;
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
    public partial class frmListPeople : Form
    {
        private Result<DataTable> _PeopleDataResult = PersonService.GetAll();

        public frmListPeople()
        {
            InitializeComponent();
        }

        private void frmListPeople_Load(object sender, EventArgs e)
        {
            if (!_PeopleDataResult.IsSuccess)
            {
                MessageBox.Show(
                    _PeopleDataResult.Message,
                    "Error", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);

                return;
            }

            ctrlDgvData.DataSource = _PeopleDataResult.Data.DefaultView;
        }

        private void ctrlDgvData_InputEntered(object sender, EventArgs e)
        {
            //if (e. == "PersonID")
            //    //in this case we deal with integer not string.

            //    _dtPeople.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
            //else
            //    _dtPeople.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());
        }

        private void ctrlDgvData_AddNewClicked(object sender, EventArgs e)
        {

        }

        private void ctrlDgvData_RowDoubleClicked(object sender, EventArgs e)
        {

        }
    }
}
