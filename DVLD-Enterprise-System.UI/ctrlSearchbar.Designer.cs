namespace DVLD_Enterprise_System.UI
{
    partial class ctrlSearchbar
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
            this.tlpContainer = new System.Windows.Forms.TableLayoutPanel();
            this.cbFilterMethod = new System.Windows.Forms.ComboBox();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.lblFilterBy = new System.Windows.Forms.Label();
            this.tlpContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpContainer
            // 
            this.tlpContainer.ColumnCount = 3;
            this.tlpContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 173F));
            this.tlpContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContainer.Controls.Add(this.cbFilterMethod, 1, 0);
            this.tlpContainer.Controls.Add(this.tbInput, 2, 0);
            this.tlpContainer.Controls.Add(this.lblFilterBy, 0, 0);
            this.tlpContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContainer.Location = new System.Drawing.Point(0, 0);
            this.tlpContainer.Margin = new System.Windows.Forms.Padding(0);
            this.tlpContainer.Name = "tlpContainer";
            this.tlpContainer.RowCount = 1;
            this.tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContainer.Size = new System.Drawing.Size(917, 44);
            this.tlpContainer.TabIndex = 1;
            // 
            // cbFilterMethod
            // 
            this.cbFilterMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFilterMethod.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbFilterMethod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbFilterMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterMethod.FormattingEnabled = true;
            this.cbFilterMethod.Location = new System.Drawing.Point(74, 8);
            this.cbFilterMethod.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cbFilterMethod.MaxDropDownItems = 5;
            this.cbFilterMethod.Name = "cbFilterMethod";
            this.cbFilterMethod.Size = new System.Drawing.Size(167, 28);
            this.cbFilterMethod.TabIndex = 4;
            // 
            // tbInput
            // 
            this.tbInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInput.Enabled = false;
            this.tbInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInput.Location = new System.Drawing.Point(247, 8);
            this.tbInput.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(667, 27);
            this.tbInput.TabIndex = 2;
            // 
            // lblFilterBy
            // 
            this.lblFilterBy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFilterBy.AutoSize = true;
            this.lblFilterBy.Location = new System.Drawing.Point(3, 12);
            this.lblFilterBy.Name = "lblFilterBy";
            this.lblFilterBy.Size = new System.Drawing.Size(65, 20);
            this.lblFilterBy.TabIndex = 0;
            this.lblFilterBy.Text = "Filter By:";
            // 
            // ctrlSearchbar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpContainer);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ctrlSearchbar";
            this.Size = new System.Drawing.Size(917, 44);
            this.tlpContainer.ResumeLayout(false);
            this.tlpContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpContainer;
        private System.Windows.Forms.ComboBox cbFilterMethod;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Label lblFilterBy;
    }
}
