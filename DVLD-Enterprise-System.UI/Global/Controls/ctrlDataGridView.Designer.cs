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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpContainer = new System.Windows.Forms.TableLayoutPanel();
            this.ctrlDgvMain = new DevToolkit.BaseWinForms.Controls.CustomControls.ccDataGridView();
            this.tlpFooter = new System.Windows.Forms.TableLayoutPanel();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.tlpTop = new System.Windows.Forms.TableLayoutPanel();
            this.tlpSearchbar = new System.Windows.Forms.TableLayoutPanel();
            this.cbFilterValue = new System.Windows.Forms.ComboBox();
            this.lblSearchBy = new System.Windows.Forms.Label();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.cbFilterMethod = new System.Windows.Forms.ComboBox();
            this.flpButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.tlpContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlDgvMain)).BeginInit();
            this.tlpFooter.SuspendLayout();
            this.tlpTop.SuspendLayout();
            this.tlpSearchbar.SuspendLayout();
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
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.ctrlDgvMain.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.ctrlDgvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ctrlDgvMain.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ctrlDgvMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ctrlDgvMain.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ctrlDgvMain.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ctrlDgvMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.ctrlDgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ctrlDgvMain.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ctrlDgvMain.DefaultCellStyle = dataGridViewCellStyle21;
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
            this.ctrlDgvMain.Size = new System.Drawing.Size(932, 454);
            this.ctrlDgvMain.TabIndex = 17;
            this.ctrlDgvMain.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ctrlDgvMain_CellDoubleClick);
            // 
            // tlpFooter
            // 
            this.tlpFooter.AutoSize = true;
            this.tlpFooter.ColumnCount = 1;
            this.tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpFooter.Controls.Add(this.lblRecordsCount, 0, 0);
            this.tlpFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFooter.Location = new System.Drawing.Point(8, 516);
            this.tlpFooter.Name = "tlpFooter";
            this.tlpFooter.RowCount = 1;
            this.tlpFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFooter.Size = new System.Drawing.Size(932, 20);
            this.tlpFooter.TabIndex = 4;
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsCount.Location = new System.Drawing.Point(3, 0);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(120, 20);
            this.lblRecordsCount.TabIndex = 0;
            this.lblRecordsCount.Text = "Records Count: 0";
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
            this.tlpTop.Controls.Add(this.tlpSearchbar, 0, 0);
            this.tlpTop.Controls.Add(this.flpButtons, 1, 0);
            this.tlpTop.Location = new System.Drawing.Point(8, 8);
            this.tlpTop.Name = "tlpTop";
            this.tlpTop.RowCount = 1;
            this.tlpTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTop.Size = new System.Drawing.Size(932, 42);
            this.tlpTop.TabIndex = 18;
            // 
            // tlpSearchbar
            // 
            this.tlpSearchbar.ColumnCount = 4;
            this.tlpSearchbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpSearchbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 185F));
            this.tlpSearchbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tlpSearchbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSearchbar.Controls.Add(this.cbFilterValue, 2, 0);
            this.tlpSearchbar.Controls.Add(this.lblSearchBy, 0, 0);
            this.tlpSearchbar.Controls.Add(this.tbInput, 3, 0);
            this.tlpSearchbar.Controls.Add(this.cbFilterMethod, 1, 0);
            this.tlpSearchbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSearchbar.Location = new System.Drawing.Point(0, 0);
            this.tlpSearchbar.Margin = new System.Windows.Forms.Padding(0);
            this.tlpSearchbar.Name = "tlpSearchbar";
            this.tlpSearchbar.RowCount = 1;
            this.tlpSearchbar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSearchbar.Size = new System.Drawing.Size(554, 42);
            this.tlpSearchbar.TabIndex = 16;
            // 
            // cbFilterValue
            // 
            this.cbFilterValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFilterValue.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbFilterValue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbFilterValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterValue.FormattingEnabled = true;
            this.cbFilterValue.Location = new System.Drawing.Point(254, 9);
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
            // tbInput
            // 
            this.tbInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInput.Location = new System.Drawing.Point(352, 7);
            this.tbInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(199, 27);
            this.tbInput.TabIndex = 2;
            this.tbInput.Visible = false;
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
            this.cbFilterMethod.Location = new System.Drawing.Point(69, 9);
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
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
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
            this.tlpTop.ResumeLayout(false);
            this.tlpTop.PerformLayout();
            this.tlpSearchbar.ResumeLayout(false);
            this.tlpSearchbar.PerformLayout();
            this.flpButtons.ResumeLayout(false);
            this.flpButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpContainer;
        private DevToolkit.BaseWinForms.Controls.CustomControls.ccDataGridView ctrlDgvMain;
        private System.Windows.Forms.TableLayoutPanel tlpFooter;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.TableLayoutPanel tlpTop;
        private System.Windows.Forms.TableLayoutPanel tlpSearchbar;
        private System.Windows.Forms.ComboBox cbFilterValue;
        private System.Windows.Forms.Label lblSearchBy;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.ComboBox cbFilterMethod;
        private System.Windows.Forms.FlowLayoutPanel flpButtons;
        private System.Windows.Forms.Button btnAddNew;
    }
}
