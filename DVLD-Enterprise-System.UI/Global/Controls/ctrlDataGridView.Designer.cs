namespace DVLD_Enterprise_System.UI.Global.Controls
{
    partial class ctrlDataGridView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpContainer = new System.Windows.Forms.TableLayoutPanel();
            this.ctrlDgvMain = new DevToolkit.BaseWinForms.Controls.CustomControls.ccDataGridView();
            this.tlpFooter = new System.Windows.Forms.TableLayoutPanel();
            this.tlpPagination = new System.Windows.Forms.TableLayoutPanel();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.cbPagesNumbers = new System.Windows.Forms.ComboBox();
            this.lblPage = new System.Windows.Forms.Label();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.tlpPageSize = new System.Windows.Forms.TableLayoutPanel();
            this.lblPageSize = new System.Windows.Forms.Label();
            this.cbPageSizes = new System.Windows.Forms.ComboBox();
            this.tlpTop = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cbFilterValue = new System.Windows.Forms.ComboBox();
            this.lblSearchBy = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.cbFilterMethod = new System.Windows.Forms.ComboBox();
            this.flpButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.tlpContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlDgvMain)).BeginInit();
            this.tlpFooter.SuspendLayout();
            this.tlpPagination.SuspendLayout();
            this.tlpPageSize.SuspendLayout();
            this.tlpTop.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flpButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpContainer
            // 
            this.tlpContainer.ColumnCount = 1;
            this.tlpContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContainer.Controls.Add(this.ctrlDgvMain, 0, 1);
            this.tlpContainer.Controls.Add(this.tlpFooter, 0, 2);
            this.tlpContainer.Controls.Add(this.tlpTop, 0, 0);
            this.tlpContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContainer.Location = new System.Drawing.Point(0, 0);
            this.tlpContainer.Name = "tlpContainer";
            this.tlpContainer.Padding = new System.Windows.Forms.Padding(5);
            this.tlpContainer.RowCount = 3;
            this.tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpContainer.Size = new System.Drawing.Size(948, 544);
            this.tlpContainer.TabIndex = 16;
            // 
            // ctrlDgvMain
            // 
            this.ctrlDgvMain.AllowUserToAddRows = false;
            this.ctrlDgvMain.AllowUserToDeleteRows = false;
            this.ctrlDgvMain.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.ctrlDgvMain.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ctrlDgvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ctrlDgvMain.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ctrlDgvMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ctrlDgvMain.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ctrlDgvMain.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ctrlDgvMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ctrlDgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ctrlDgvMain.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ctrlDgvMain.DefaultCellStyle = dataGridViewCellStyle3;
            this.ctrlDgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlDgvMain.EnableHeadersVisualStyles = false;
            this.ctrlDgvMain.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(224)))), ((int)(((byte)(230)))));
            this.ctrlDgvMain.Location = new System.Drawing.Point(8, 56);
            this.ctrlDgvMain.MultiSelect = false;
            this.ctrlDgvMain.Name = "ctrlDgvMain";
            this.ctrlDgvMain.ReadOnly = true;
            this.ctrlDgvMain.RowHeadersVisible = false;
            this.ctrlDgvMain.RowHeadersWidth = 51;
            this.ctrlDgvMain.RowTemplate.Height = 35;
            this.ctrlDgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ctrlDgvMain.Size = new System.Drawing.Size(932, 434);
            this.ctrlDgvMain.TabIndex = 17;
            this.ctrlDgvMain.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ctrlDgvMain_CellDoubleClick);
            this.ctrlDgvMain.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.ctrlDgvMain_CellFormatting);
            // 
            // tlpFooter
            // 
            this.tlpFooter.AutoSize = true;
            this.tlpFooter.ColumnCount = 3;
            this.tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpFooter.Controls.Add(this.tlpPagination, 1, 0);
            this.tlpFooter.Controls.Add(this.lblRecordsCount, 0, 0);
            this.tlpFooter.Controls.Add(this.tlpPageSize, 2, 0);
            this.tlpFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFooter.Location = new System.Drawing.Point(8, 496);
            this.tlpFooter.Name = "tlpFooter";
            this.tlpFooter.RowCount = 1;
            this.tlpFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFooter.Size = new System.Drawing.Size(932, 40);
            this.tlpFooter.TabIndex = 4;
            // 
            // tlpPagination
            // 
            this.tlpPagination.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tlpPagination.ColumnCount = 6;
            this.tlpPagination.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpPagination.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpPagination.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpPagination.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpPagination.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpPagination.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpPagination.Controls.Add(this.btnLast, 5, 0);
            this.tlpPagination.Controls.Add(this.btnNext, 4, 0);
            this.tlpPagination.Controls.Add(this.cbPagesNumbers, 3, 0);
            this.tlpPagination.Controls.Add(this.lblPage, 2, 0);
            this.tlpPagination.Controls.Add(this.btnFirst, 0, 0);
            this.tlpPagination.Controls.Add(this.btnBack, 1, 0);
            this.tlpPagination.Location = new System.Drawing.Point(255, 3);
            this.tlpPagination.Name = "tlpPagination";
            this.tlpPagination.RowCount = 1;
            this.tlpPagination.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPagination.Size = new System.Drawing.Size(379, 34);
            this.tlpPagination.TabIndex = 12;
            // 
            // btnLast
            // 
            this.btnLast.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLast.FlatAppearance.BorderSize = 0;
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast.Location = new System.Drawing.Point(346, 3);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(24, 28);
            this.btnLast.TabIndex = 5;
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Location = new System.Drawing.Point(309, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(19, 28);
            this.btnNext.TabIndex = 4;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // cbPagesNumbers
            // 
            this.cbPagesNumbers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPagesNumbers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbPagesNumbers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPagesNumbers.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPagesNumbers.FormattingEnabled = true;
            this.cbPagesNumbers.ItemHeight = 20;
            this.cbPagesNumbers.Location = new System.Drawing.Point(190, 3);
            this.cbPagesNumbers.MaxDropDownItems = 3;
            this.cbPagesNumbers.Name = "cbPagesNumbers";
            this.cbPagesNumbers.Size = new System.Drawing.Size(107, 28);
            this.cbPagesNumbers.Sorted = true;
            this.cbPagesNumbers.TabIndex = 1;
            this.cbPagesNumbers.SelectedIndexChanged += new System.EventHandler(this.cbPagesNumbers_SelectedIndexChanged);
            // 
            // lblPage
            // 
            this.lblPage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPage.AutoSize = true;
            this.lblPage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPage.Location = new System.Drawing.Point(77, 7);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(106, 20);
            this.lblPage.TabIndex = 0;
            this.lblPage.Text = "Page Number: ";
            // 
            // btnFirst
            // 
            this.btnFirst.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFirst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFirst.FlatAppearance.BorderSize = 0;
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst.Location = new System.Drawing.Point(9, 3);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(19, 28);
            this.btnFirst.TabIndex = 2;
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(46, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(19, 28);
            this.btnBack.TabIndex = 3;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsCount.Location = new System.Drawing.Point(3, 10);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(120, 20);
            this.lblRecordsCount.TabIndex = 0;
            this.lblRecordsCount.Text = "Records Count: 0";
            // 
            // tlpPageSize
            // 
            this.tlpPageSize.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpPageSize.AutoSize = true;
            this.tlpPageSize.ColumnCount = 2;
            this.tlpPageSize.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPageSize.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpPageSize.Controls.Add(this.lblPageSize, 0, 0);
            this.tlpPageSize.Controls.Add(this.cbPageSizes, 1, 0);
            this.tlpPageSize.Location = new System.Drawing.Point(766, 3);
            this.tlpPageSize.Name = "tlpPageSize";
            this.tlpPageSize.RowCount = 1;
            this.tlpPageSize.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPageSize.Size = new System.Drawing.Size(163, 34);
            this.tlpPageSize.TabIndex = 13;
            // 
            // lblPageSize
            // 
            this.lblPageSize.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPageSize.AutoSize = true;
            this.lblPageSize.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageSize.Location = new System.Drawing.Point(3, 7);
            this.lblPageSize.Name = "lblPageSize";
            this.lblPageSize.Size = new System.Drawing.Size(79, 20);
            this.lblPageSize.TabIndex = 0;
            this.lblPageSize.Text = "Page Size: ";
            // 
            // cbPageSizes
            // 
            this.cbPageSizes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPageSizes.FormattingEnabled = true;
            this.cbPageSizes.Location = new System.Drawing.Point(88, 3);
            this.cbPageSizes.Name = "cbPageSizes";
            this.cbPageSizes.Size = new System.Drawing.Size(72, 25);
            this.cbPageSizes.TabIndex = 1;
            this.cbPageSizes.SelectedIndexChanged += new System.EventHandler(this.cbPageSizes_SelectedIndexChanged);
            // 
            // tlpTop
            // 
            this.tlpTop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpTop.AutoSize = true;
            this.tlpTop.ColumnCount = 2;
            this.tlpTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.21401F));
            this.tlpTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 378F));
            this.tlpTop.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tlpTop.Controls.Add(this.flpButtons, 1, 0);
            this.tlpTop.Location = new System.Drawing.Point(8, 8);
            this.tlpTop.Name = "tlpTop";
            this.tlpTop.RowCount = 1;
            this.tlpTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTop.Size = new System.Drawing.Size(932, 42);
            this.tlpTop.TabIndex = 18;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 185F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.Controls.Add(this.cbFilterValue, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblSearchBy, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbInput, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbFilterMethod, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(554, 42);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // cbFilterValue
            // 
            this.cbFilterValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFilterValue.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbFilterValue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbFilterValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterValue.FormattingEnabled = true;
            this.cbFilterValue.Location = new System.Drawing.Point(254, 8);
            this.cbFilterValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbFilterValue.MaxDropDownItems = 5;
            this.cbFilterValue.Name = "cbFilterValue";
            this.cbFilterValue.Size = new System.Drawing.Size(92, 25);
            this.cbFilterValue.TabIndex = 5;
            this.cbFilterValue.SelectedIndexChanged += new System.EventHandler(this.cbFilterValue_SelectedIndexChanged);
            // 
            // lblSearchBy
            // 
            this.lblSearchBy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSearchBy.AutoSize = true;
            this.lblSearchBy.Location = new System.Drawing.Point(3, 12);
            this.lblSearchBy.Name = "lblSearchBy";
            this.lblSearchBy.Size = new System.Drawing.Size(60, 17);
            this.lblSearchBy.TabIndex = 0;
            this.lblSearchBy.Text = "Filter By: ";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(516, 6);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(38, 29);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbInput
            // 
            this.tbInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInput.Enabled = false;
            this.tbInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInput.Location = new System.Drawing.Point(352, 7);
            this.tbInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(161, 27);
            this.tbInput.TabIndex = 2;
            this.tbInput.TextChanged += new System.EventHandler(this.tbInput_TextChanged);
            this.tbInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbInput_KeyPress);
            // 
            // cbFilterMethod
            // 
            this.cbFilterMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFilterMethod.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbFilterMethod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbFilterMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterMethod.FormattingEnabled = true;
            this.cbFilterMethod.Location = new System.Drawing.Point(69, 8);
            this.cbFilterMethod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbFilterMethod.MaxDropDownItems = 5;
            this.cbFilterMethod.Name = "cbFilterMethod";
            this.cbFilterMethod.Size = new System.Drawing.Size(179, 25);
            this.cbFilterMethod.TabIndex = 4;
            this.cbFilterMethod.SelectedIndexChanged += new System.EventHandler(this.cbFilterMethod_SelectedIndexChanged);
            // 
            // flpButtons
            // 
            this.flpButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpButtons.AutoSize = true;
            this.flpButtons.Controls.Add(this.btnAddNew);
            this.flpButtons.Controls.Add(this.btnImport);
            this.flpButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpButtons.Location = new System.Drawing.Point(557, 3);
            this.flpButtons.Name = "flpButtons";
            this.flpButtons.Size = new System.Drawing.Size(372, 36);
            this.flpButtons.TabIndex = 15;
            // 
            // btnAddNew
            // 
            this.btnAddNew.AutoSize = true;
            this.btnAddNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNew.FlatAppearance.BorderSize = 0;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Location = new System.Drawing.Point(297, 3);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(72, 27);
            this.btnAddNew.TabIndex = 0;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnImport
            // 
            this.btnImport.AutoSize = true;
            this.btnImport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImport.FlatAppearance.BorderSize = 0;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Location = new System.Drawing.Point(234, 3);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(57, 27);
            this.btnImport.TabIndex = 1;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // ctrlDataGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpContainer);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ctrlDataGridView";
            this.Size = new System.Drawing.Size(948, 544);
            this.tlpContainer.ResumeLayout(false);
            this.tlpContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlDgvMain)).EndInit();
            this.tlpFooter.ResumeLayout(false);
            this.tlpFooter.PerformLayout();
            this.tlpPagination.ResumeLayout(false);
            this.tlpPagination.PerformLayout();
            this.tlpPageSize.ResumeLayout(false);
            this.tlpPageSize.PerformLayout();
            this.tlpTop.ResumeLayout(false);
            this.tlpTop.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flpButtons.ResumeLayout(false);
            this.flpButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpContainer;
        private DevToolkit.BaseWinForms.Controls.CustomControls.ccDataGridView ctrlDgvMain;
        private System.Windows.Forms.TableLayoutPanel tlpFooter;
        private System.Windows.Forms.TableLayoutPanel tlpPagination;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ComboBox cbPagesNumbers;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.TableLayoutPanel tlpPageSize;
        private System.Windows.Forms.Label lblPageSize;
        private System.Windows.Forms.ComboBox cbPageSizes;
        private System.Windows.Forms.TableLayoutPanel tlpTop;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cbFilterValue;
        private System.Windows.Forms.Label lblSearchBy;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.ComboBox cbFilterMethod;
        private System.Windows.Forms.FlowLayoutPanel flpButtons;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnImport;
    }
}
