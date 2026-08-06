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
                cbFilterMethod.Items.AddRange(filterMethods.ToArray());
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

        private void tbInput_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tbInput.Text = string.Empty;
            cbFilterMethod.SelectedIndex = -1;
        }

        [Category("Custom Properties")]
        public bool ShowCancelButton
        {
            get => btnCancel.Visible;
            set => btnCancel.Visible = value;
        }

        private void cbFilterMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tbInput_KeyPress(object sender, KeyPressEventArgs e)
            => InputEntered?.Invoke(this, EventArgs.Empty);

        [Category("Custom Events")]
        public event EventHandler InputEntered;

        private void cbFilterValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

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
                    _SetRecordsCount(list.Count);
                else if (value is IListSource listSource)
                    _SetRecordsCount(listSource.GetList().Count);
                else if (value is IBindingList bindingList)
                    _SetRecordsCount(bindingList.Count);
                else if (value is IBindingListView listView)
                    _SetRecordsCount(listView.Count);
                else
                    _SetRecordsCount(0);
            }
        }

        [Category("Custom Properties")]
        public bool ImportButtonVisible
        {
            get => btnImport.Visible;
            set => btnImport.Visible = value;
        }

        [Category("Custom Properties")]
        public string AddNewButtonText
        {
            get => btnAddNew.Text;
            set => btnAddNew.Text = value;
        }

        [Category("Custom Properties")]
        public string ImportButtonText
        {
            get => btnImport.Text;
            set => btnImport.Text = value;
        }

        [Category("Custom Properties")]
        public Image AddNewButtonImage
        {
            get => btnAddNew.BackgroundImage;
            set => btnAddNew.BackgroundImage = value;
        }

        [Category("Custom Properties")]
        public Image ImportButtonImage
        {
            get => btnImport.BackgroundImage;
            set => btnImport.BackgroundImage = value;
        }

        [Category("Custom Properties")]
        public Color AddNewButtonColor
        {
            get => btnAddNew.BackColor;
            set => btnAddNew.BackColor = value;
        }

        [Category("Custom Properties")]
        public Color ImportButtonColor
        {
            get => btnImport.BackColor;
            set => btnImport.BackColor = value;
        }

        private void _SetRecordsCount(int count)
        {
            if (RightToLeft == RightToLeft.Yes)
                lblRecordsCount.Text = $"عدد الصفوف: {count}";
            else
                lblRecordsCount.Text = $"Records Count: {count}";
        }

        public object GetSelectedRow(string columnName)
            => ctrlDgvMain.GetSelectedRow(columnName);

        public object GetSelectedRow(int columnIndex)
            => ctrlDgvMain.GetSelectedRow(columnIndex);

        public void SetPagesCount(int count)
        {
            cbPagesNumbers.Items.Clear();

            int i = 1;
            do
            {
                cbPagesNumbers.Items.Add(i.ToString());
                i++;
            } while (i <= count);

            cbPagesNumbers.SelectedIndex = 0;
        }

        public void SetPageSizes(IEnumerable<int> pageSizes)
        {
            cbPageSizes.Items.Clear();

            if (pageSizes != null && pageSizes.Any())
            {
                foreach (var size in pageSizes)
                    cbPageSizes.Items.Add(size.ToString());

                cbPageSizes.SelectedIndex = 0;
            }
        }

        private void cbPagesNumbers_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            if (int.TryParse(cbPagesNumbers.Text?.ToString(), out int pageNumber) &&
                int.TryParse(cbPageSizes.Text?.ToString(), out int pageSize))
                Filter?.Invoke(this,
                    new FilterEventArgs(
                        pageNumber,
                        pageSize,
                        cbFilterMethod.SelectedIndex,
                        cbFilterValue.SelectedIndex,
                        tbInput.Text));
        }

        [Category("Custom Events")]
        public event EventHandler<FilterEventArgs> Filter;

        public class FilterEventArgs : EventArgs
        {
            public int PageNumber { get; }

            public int PageSize { get; }

            public int FilteringMethodIndex { get; }

            public string Input { get; }

            public int FilteringValueIndex { get; }

            public FilterEventArgs(
                int pageNumber,
                int pageSize,
                int filteringMethodIndex,
                int filteringValueIndex,
                string input)
            {
                PageNumber = pageNumber;
                PageSize = pageSize;
                FilteringMethodIndex = filteringMethodIndex;
                Input = input;
                FilteringValueIndex = filteringValueIndex;
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (cbPagesNumbers.Items.Count == 0) return;

            cbPagesNumbers.SelectedIndex = 0;

            if (int.TryParse(cbPagesNumbers.Text?.ToString(), out int pageNumber) &&
                int.TryParse(cbPageSizes.Text?.ToString(), out int pageSize))
                Filter?.Invoke(this,
                    new FilterEventArgs(
                        pageNumber,
                        pageSize,
                        cbFilterMethod.SelectedIndex,
                        cbFilterValue.SelectedIndex,
                        tbInput.Text));
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            int Index = cbPagesNumbers.SelectedIndex;

            if (Index > 0)
            {
                cbPagesNumbers.SelectedIndex--;

                if (int.TryParse(cbPagesNumbers.Text?.ToString(), out int pageNumber) &&
                    int.TryParse(cbPageSizes.Text?.ToString(), out int pageSize))
                    Filter?.Invoke(this,
                        new FilterEventArgs(
                            pageNumber,
                            pageSize,
                            cbFilterMethod.SelectedIndex,
                            cbFilterValue.SelectedIndex,
                            tbInput.Text));
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int Index = cbPagesNumbers.SelectedIndex;

            if (Index < cbPagesNumbers.Items.Count - 1)
            {
                cbPagesNumbers.SelectedIndex++;

                if (int.TryParse(cbPagesNumbers.Text?.ToString(), out int pageNumber) &&
                    int.TryParse(cbPageSizes.Text?.ToString(), out int pageSize))
                    Filter?.Invoke(this,
                        new FilterEventArgs(
                            pageNumber,
                            pageSize,
                            cbFilterMethod.SelectedIndex,
                            cbFilterValue.SelectedIndex,
                            tbInput.Text));
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if (cbPagesNumbers.Items.Count == 0) return;

            cbPagesNumbers.SelectedIndex = cbPagesNumbers.Items.Count - 1;

            if (int.TryParse(cbPagesNumbers.Text?.ToString(), out int pageNumber) &&
                int.TryParse(cbPageSizes.Text?.ToString(), out int pageSize))
                Filter?.Invoke(this,
                    new FilterEventArgs(
                        pageNumber,
                        pageSize,
                        cbFilterMethod.SelectedIndex,
                        cbFilterValue.SelectedIndex,
                        tbInput.Text));
        }

        private void ctrlDgvMain_CellDoubleClick(
            object sender,
            DataGridViewCellEventArgs e)
            => RowDoubleClicked?.Invoke(this, e);

        [Category("Custom Events")]
        public event EventHandler RowDoubleClicked;

        private void ctrlDgvMain_CellFormatting(
            object sender,
            DataGridViewCellFormattingEventArgs e)
            => CellFormatting?.Invoke(this, e);

        [Category("Custom Events")]
        public event EventHandler<DataGridViewCellFormattingEventArgs> CellFormatting;

        private void cbPageSizes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.TryParse(cbPagesNumbers.Text?.ToString(), out int pageNumber) &&
                int.TryParse(cbPageSizes.Text?.ToString(), out int pageSize))
                Filter?.Invoke(this,
                    new FilterEventArgs(
                        pageNumber,
                        pageSize,
                        cbFilterMethod.SelectedIndex,
                        cbFilterValue.SelectedIndex,
                        tbInput.Text));
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            AddNewClicked?.Invoke(this, EventArgs.Empty);
        }

        [Category("Custom Events")]
        public event EventHandler AddNewClicked;

        private void btnImport_Click(object sender, EventArgs e)
        {
            ImportClicked?.Invoke(this, EventArgs.Empty);
        }

        [Category("Custom Events")]
        public event EventHandler ImportClicked;
    }
}
