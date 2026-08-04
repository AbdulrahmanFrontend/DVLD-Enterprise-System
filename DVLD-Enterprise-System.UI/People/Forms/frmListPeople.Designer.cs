namespace DVLD_Enterprise_System.UI.People.Forms
{
    partial class frmListPeople
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListPeople));
            this.flpFooter = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClose = new DevToolkit.BaseWinForms.Controls.CustomControls.ccButton();
            this.ctrlHeaderbar = new DevToolkit.BaseWinForms.Controls.UserControls.ucHeaderbarWithButton();
            this.ctrlDgvPeople = new DevToolkit.BaseWinForms.Controls.UserControls.ucDataGridView();
            this.flpFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpFooter
            // 
            this.flpFooter.AutoSize = true;
            this.flpFooter.Controls.Add(this.btnClose);
            this.flpFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpFooter.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpFooter.Location = new System.Drawing.Point(0, 550);
            this.flpFooter.Name = "flpFooter";
            this.flpFooter.Padding = new System.Windows.Forms.Padding(3);
            this.flpFooter.Size = new System.Drawing.Size(1241, 52);
            this.flpFooter.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnClose.ButtonStyle = DevToolkit.BaseWinForms.Theming.ButtonStyle.Primary;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = global::DVLD_Enterprise_System.UI.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1111, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnClose.Size = new System.Drawing.Size(121, 40);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // ctrlHeaderbar
            // 
            this.ctrlHeaderbar.ButtonBackgroundImage = global::DVLD_Enterprise_System.UI.Properties.Resources.add;
            this.ctrlHeaderbar.ButtonText = "";
            this.ctrlHeaderbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctrlHeaderbar.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlHeaderbar.ForeColor = System.Drawing.Color.Red;
            this.ctrlHeaderbar.Location = new System.Drawing.Point(0, 0);
            this.ctrlHeaderbar.Margin = new System.Windows.Forms.Padding(0);
            this.ctrlHeaderbar.Name = "ctrlHeaderbar";
            this.ctrlHeaderbar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ctrlHeaderbar.Size = new System.Drawing.Size(1241, 62);
            this.ctrlHeaderbar.TabIndex = 4;
            this.ctrlHeaderbar.Title = "Manage People";
            // 
            // ctrlDgvPeople
            // 
            this.ctrlDgvPeople.cmsData = null;
            this.ctrlDgvPeople.DataSource = null;
            this.ctrlDgvPeople.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlDgvPeople.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlDgvPeople.Location = new System.Drawing.Point(0, 62);
            this.ctrlDgvPeople.Name = "ctrlDgvPeople";
            this.ctrlDgvPeople.Size = new System.Drawing.Size(1241, 488);
            this.ctrlDgvPeople.TabIndex = 7;
            // 
            // frmListPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1241, 602);
            this.Controls.Add(this.ctrlDgvPeople);
            this.Controls.Add(this.ctrlHeaderbar);
            this.Controls.Add(this.flpFooter);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListPeople";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List People";
            this.flpFooter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpFooter;
        private DevToolkit.BaseWinForms.Controls.CustomControls.ccButton btnClose;
        private DevToolkit.BaseWinForms.Controls.UserControls.ucHeaderbarWithButton ctrlHeaderbar;
        private DevToolkit.BaseWinForms.Controls.UserControls.ucDataGridView ctrlDgvPeople;
    }
}