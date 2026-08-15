using DevToolkit.BaseWinForms.Controls.UserControls;
using DevToolkit.Core.Guards;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DVLD_Enterprise_System.UI.Global.Controls
{
    public partial class ctrlDataGridView : UserControl
    {
        public ctrlDataGridView()
        {
            InitializeComponent();
        }

        [Category("Custom Properties")]
        public bool ShowFilterValue
        {
            get => cbFilterValue.Visible;
            set => cbFilterValue.Visible = value;
        }

        public void SetFilteringMethod(IEnumerable<string> filterMethods)
        {
            cbFilterMethod.Items.Clear();
            if (Guard.HasItems(filterMethods))
            {
                cbFilterMethod.Items.AddRange(filterMethods.ToArray());

                cbFilterMethod.SelectedIndex = 0;
            }
        }

        public void SetFilteringValues(IEnumerable<string> filterValues)
        {
            cbFilterValue.Items.Clear();
            if (Guard.HasItems(filterValues))
            {
                cbFilterValue.Items.AddRange(filterValues.ToArray());

                cbFilterValue.SelectedIndex = 0;
            }
        }

        private void tbInput_KeyPress(object sender, KeyPressEventArgs e)
            => InputEntered?.Invoke(this, EventArgs.Empty);

        [Category("Custom Events")]
        public event EventHandler InputEntered;

        [Category("Custom Properties")]
        public DataGridViewColumnCollection Columns => ctrlDgvMain.Columns;

        [Category("Custom Properties")]
        public ContextMenuStrip cmsData
        {
            get => ctrlDgvMain.ContextMenuStrip;
            set => ctrlDgvMain.ContextMenuStrip = value;
        }

        [Category("Custom Properties")]
        public object DataSource
        {
            get => ctrlDgvMain.DataSource;
            set
            {
                ctrlDgvMain.DataSource = value;

                if (value is IList list)
                    lblRecordsCount.Text = $"Records: {list.Count}";
                else if (value is IListSource listSource)
                    lblRecordsCount.Text = $"Records: {listSource.GetList().Count}";
                else if (value is IBindingList bindingList)
                    lblRecordsCount.Text = $"Records: {bindingList.Count}";
                else if (value is IBindingListView listView)
                    lblRecordsCount.Text = $"Records: {listView.Count}";
                else
                    lblRecordsCount.Text = $"Records: {0}";
            }
        }

        [Category("Custom Properties")]
        public Image AddNewButtonImage
        {
            get => btnAddNew.BackgroundImage;
            set => btnAddNew.BackgroundImage = value;
        }

        public object GetSelectedRow(string columnName)
            => ctrlDgvMain.GetSelectedRow(columnName);

        public object GetSelectedRow(int columnIndex)
            => ctrlDgvMain.GetSelectedRow(columnIndex);

        private void ctrlDgvMain_CellDoubleClick(
            object sender,
            DataGridViewCellEventArgs e)
            => RowDoubleClicked?.Invoke(this, e);

        [Category("Custom Events")]
        public event EventHandler RowDoubleClicked;

        private void btnAddNew_Click(object sender, EventArgs e)
            => AddNewClicked?.Invoke(this, EventArgs.Empty);

        [Category("Custom Events")]
        public event EventHandler AddNewClicked;

        private void tbInput_TextChanged(object sender, EventArgs e)
        {
            FilterClicked?.Invoke(
                this,
                new FilterEventArgs(
                    cbFilterMethod.SelectedIndex,
                    cbFilterValue.SelectedIndex,
                    tbInput.Text));
        }

        private void cbFilterValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterClicked?.Invoke(
                this,
                new FilterEventArgs(
                    cbFilterMethod.SelectedIndex,
                    cbFilterValue.SelectedIndex,
                    tbInput.Text));
        }

        private void cbFilterMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbFilterMethod.SelectedIndex == 0)
                tbInput.Visible = false;
            else
            {
                tbInput.Visible = true;
                tbInput.Focus();
            }

            FilterClicked?.Invoke(
                this,
                new FilterEventArgs(
                    cbFilterMethod.SelectedIndex,
                    cbFilterValue.SelectedIndex,
                    tbInput.Text));
        }

        public class FilterEventArgs : EventArgs
        {
            public int FilterMethodIndex { get; }
            public int FilterValueIndex { get; }
            public string Input { get; }

            public FilterEventArgs(
                int filterMethodIndex,
                int filterValueIndex, 
                string input)
            {
                FilterMethodIndex = filterMethodIndex;
                FilterValueIndex = filterValueIndex;
                Input = input;
            }
        }

        [Category("Custom Events")]
        public EventHandler<FilterEventArgs> FilterClicked;
    }
}
