namespace DVLD_Enterprise_System.UI.People.Controls
{
    partial class ctrlPersonCardWithFilter
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
            this.components = new System.ComponentModel.Container();
            this.tlpFilters = new System.Windows.Forms.TableLayoutPanel();
            this.lblFilterBy = new System.Windows.Forms.Label();
            this.cbFilterMethods = new System.Windows.Forms.ComboBox();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnAddNewPerson = new System.Windows.Forms.Button();
            this.PersonCard = new DVLD_Enterprise_System.UI.People.Controls.ctrlPersonCard();
            this.epFilterValue = new System.Windows.Forms.ErrorProvider(this.components);
            this.tlpFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epFilterValue)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpFilters
            // 
            this.tlpFilters.AutoSize = true;
            this.tlpFilters.ColumnCount = 5;
            this.tlpFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.11152F));
            this.tlpFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.88847F));
            this.tlpFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpFilters.Controls.Add(this.lblFilterBy, 0, 0);
            this.tlpFilters.Controls.Add(this.cbFilterMethods, 1, 0);
            this.tlpFilters.Controls.Add(this.txtFilterValue, 2, 0);
            this.tlpFilters.Controls.Add(this.btnFind, 3, 0);
            this.tlpFilters.Controls.Add(this.btnAddNewPerson, 4, 0);
            this.tlpFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpFilters.Location = new System.Drawing.Point(0, 0);
            this.tlpFilters.Name = "tlpFilters";
            this.tlpFilters.Padding = new System.Windows.Forms.Padding(5);
            this.tlpFilters.RowCount = 1;
            this.tlpFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFilters.Size = new System.Drawing.Size(993, 51);
            this.tlpFilters.TabIndex = 0;
            // 
            // lblFilterBy
            // 
            this.lblFilterBy.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFilterBy.AutoSize = true;
            this.lblFilterBy.Location = new System.Drawing.Point(8, 17);
            this.lblFilterBy.Name = "lblFilterBy";
            this.lblFilterBy.Size = new System.Drawing.Size(56, 17);
            this.lblFilterBy.TabIndex = 0;
            this.lblFilterBy.Text = "Filter By:";
            // 
            // cbFilterMethods
            // 
            this.cbFilterMethods.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFilterMethods.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbFilterMethods.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterMethods.FormattingEnabled = true;
            this.cbFilterMethods.Items.AddRange(new object[] {
            "Person ID",
            "National No."});
            this.cbFilterMethods.Location = new System.Drawing.Point(70, 13);
            this.cbFilterMethods.Name = "cbFilterMethods";
            this.cbFilterMethods.Size = new System.Drawing.Size(226, 25);
            this.cbFilterMethods.TabIndex = 1;
            this.cbFilterMethods.SelectedIndexChanged += new System.EventHandler(this.cbFilterMethods_SelectedIndexChanged);
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilterValue.Location = new System.Drawing.Point(302, 13);
            this.txtFilterValue.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(516, 25);
            this.txtFilterValue.TabIndex = 2;
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
            this.txtFilterValue.Validating += new System.ComponentModel.CancelEventHandler(this.txtFilterValue_Validating);
            // 
            // btnFind
            // 
            this.btnFind.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFind.BackgroundImage = global::DVLD_Enterprise_System.UI.Properties.Resources.SearchPerson;
            this.btnFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFind.FlatAppearance.BorderSize = 0;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Location = new System.Drawing.Point(841, 8);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(66, 35);
            this.btnFind.TabIndex = 3;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnAddNewPerson
            // 
            this.btnAddNewPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewPerson.BackgroundImage = global::DVLD_Enterprise_System.UI.Properties.Resources.AddPerson_32;
            this.btnAddNewPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddNewPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewPerson.FlatAppearance.BorderSize = 0;
            this.btnAddNewPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewPerson.Location = new System.Drawing.Point(913, 8);
            this.btnAddNewPerson.Name = "btnAddNewPerson";
            this.btnAddNewPerson.Size = new System.Drawing.Size(72, 35);
            this.btnAddNewPerson.TabIndex = 4;
            this.btnAddNewPerson.UseVisualStyleBackColor = true;
            this.btnAddNewPerson.Click += new System.EventHandler(this.btnAddNewPerson_Click);
            // 
            // PersonCard
            // 
            this.PersonCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PersonCard.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonCard.Location = new System.Drawing.Point(0, 51);
            this.PersonCard.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PersonCard.Name = "PersonCard";
            this.PersonCard.Size = new System.Drawing.Size(993, 376);
            this.PersonCard.TabIndex = 3;
            // 
            // epFilterValue
            // 
            this.epFilterValue.ContainerControl = this;
            // 
            // ctrlPersonCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PersonCard);
            this.Controls.Add(this.tlpFilters);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ctrlPersonCardWithFilter";
            this.Size = new System.Drawing.Size(993, 427);
            this.Load += new System.EventHandler(this.ctrlPersonCardWithFilter_Load);
            this.tlpFilters.ResumeLayout(false);
            this.tlpFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epFilterValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpFilters;
        private System.Windows.Forms.Label lblFilterBy;
        private ctrlPersonCard PersonCard;
        private System.Windows.Forms.ComboBox cbFilterMethods;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnAddNewPerson;
        private System.Windows.Forms.ErrorProvider epFilterValue;
    }
}
