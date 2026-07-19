namespace DVLD_Enterprise_System.UI.People.Forms
{
    partial class frmAddUpdatePerson
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
            this.components = new System.ComponentModel.Container();
            this.epPerson = new System.Windows.Forms.ErrorProvider(this.components);
            this.flpFooter = new System.Windows.Forms.FlowLayoutPanel();
            this.ctrlbtnCancel = new DevToolkit.BaseWinForms.Controls.CustomControls.ccButton();
            this.ctrlbtnSave = new DevToolkit.BaseWinForms.Controls.CustomControls.ccButton();
            this.ctrlbtnDelete = new DevToolkit.BaseWinForms.Controls.CustomControls.ccButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.ctrlPersonCard1 = new DVLD_Enterprise_System.UI.People.Controls.ctrlPersonCard();
            ((System.ComponentModel.ISupportInitialize)(this.epPerson)).BeginInit();
            this.flpFooter.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // epPerson
            // 
            this.epPerson.ContainerControl = this;
            // 
            // flpFooter
            // 
            this.flpFooter.AutoSize = true;
            this.flpFooter.Controls.Add(this.ctrlbtnCancel);
            this.flpFooter.Controls.Add(this.ctrlbtnSave);
            this.flpFooter.Controls.Add(this.ctrlbtnDelete);
            this.flpFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpFooter.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpFooter.Location = new System.Drawing.Point(0, 319);
            this.flpFooter.Name = "flpFooter";
            this.flpFooter.Size = new System.Drawing.Size(1079, 41);
            this.flpFooter.TabIndex = 1;
            // 
            // ctrlbtnCancel
            // 
            this.ctrlbtnCancel.AutoSize = true;
            this.ctrlbtnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ctrlbtnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.ctrlbtnCancel.ButtonStyle = DevToolkit.BaseWinForms.Theming.ButtonStyle.Primary;
            this.ctrlbtnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctrlbtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ctrlbtnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.ctrlbtnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.ctrlbtnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.ctrlbtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ctrlbtnCancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.ctrlbtnCancel.ForeColor = System.Drawing.Color.White;
            this.ctrlbtnCancel.Location = new System.Drawing.Point(980, 3);
            this.ctrlbtnCancel.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.ctrlbtnCancel.Name = "ctrlbtnCancel";
            this.ctrlbtnCancel.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ctrlbtnCancel.Size = new System.Drawing.Size(94, 35);
            this.ctrlbtnCancel.TabIndex = 2;
            this.ctrlbtnCancel.Text = "Cancel";
            this.ctrlbtnCancel.UseVisualStyleBackColor = false;
            // 
            // ctrlbtnSave
            // 
            this.ctrlbtnSave.AutoSize = true;
            this.ctrlbtnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ctrlbtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.ctrlbtnSave.ButtonStyle = DevToolkit.BaseWinForms.Theming.ButtonStyle.Success;
            this.ctrlbtnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctrlbtnSave.FlatAppearance.BorderSize = 0;
            this.ctrlbtnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(101)))), ((int)(((byte)(47)))));
            this.ctrlbtnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(145)))), ((int)(((byte)(74)))));
            this.ctrlbtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ctrlbtnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.ctrlbtnSave.ForeColor = System.Drawing.Color.White;
            this.ctrlbtnSave.Location = new System.Drawing.Point(895, 3);
            this.ctrlbtnSave.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.ctrlbtnSave.Name = "ctrlbtnSave";
            this.ctrlbtnSave.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ctrlbtnSave.Size = new System.Drawing.Size(77, 33);
            this.ctrlbtnSave.TabIndex = 1;
            this.ctrlbtnSave.Text = "Save";
            this.ctrlbtnSave.UseVisualStyleBackColor = false;
            // 
            // ctrlbtnDelete
            // 
            this.ctrlbtnDelete.AutoSize = true;
            this.ctrlbtnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ctrlbtnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ctrlbtnDelete.ButtonStyle = DevToolkit.BaseWinForms.Theming.ButtonStyle.Danger;
            this.ctrlbtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctrlbtnDelete.FlatAppearance.BorderSize = 0;
            this.ctrlbtnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ctrlbtnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ctrlbtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ctrlbtnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.ctrlbtnDelete.ForeColor = System.Drawing.Color.White;
            this.ctrlbtnDelete.Location = new System.Drawing.Point(793, 3);
            this.ctrlbtnDelete.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.ctrlbtnDelete.Name = "ctrlbtnDelete";
            this.ctrlbtnDelete.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ctrlbtnDelete.Size = new System.Drawing.Size(92, 33);
            this.ctrlbtnDelete.TabIndex = 0;
            this.ctrlbtnDelete.Text = "Delete";
            this.ctrlbtnDelete.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1079, 37);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.ctrlPersonCard1);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 37);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1079, 282);
            this.pnlContainer.TabIndex = 4;
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlPersonCard1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlPersonCard1.Location = new System.Drawing.Point(0, 0);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.SelectedCountryID = 0;
            this.ctrlPersonCard1.SelectedGenderIndex = -1;
            this.ctrlPersonCard1.Size = new System.Drawing.Size(1079, 282);
            this.ctrlPersonCard1.TabIndex = 0;
            // 
            // frmAddUpdatePerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 360);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.flpFooter);
            this.Name = "frmAddUpdatePerson";
            this.Load += new System.EventHandler(this.frmAddUpdatePerson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epPerson)).EndInit();
            this.flpFooter.ResumeLayout(false);
            this.flpFooter.PerformLayout();
            this.pnlContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider epPerson;
        private System.Windows.Forms.FlowLayoutPanel flpFooter;
        private DevToolkit.BaseWinForms.Controls.CustomControls.ccButton ctrlbtnCancel;
        private DevToolkit.BaseWinForms.Controls.CustomControls.ccButton ctrlbtnSave;
        private DevToolkit.BaseWinForms.Controls.CustomControls.ccButton ctrlbtnDelete;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlContainer;
        private Controls.ctrlPersonCard ctrlPersonCard1;
    }
}