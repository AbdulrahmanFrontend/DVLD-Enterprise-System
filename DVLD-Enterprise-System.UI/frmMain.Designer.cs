namespace DVLD_Enterprise_System.UI
{
    partial class frmMain
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
            this.ctrlMainMenu = new DevToolkit.BaseWinForms.Controls.CustomControls.ccMenuStrip();
            this.tsmiApplications = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDrivingLicensesServices = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLocalLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInternationalLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRenew = new System.Windows.Forms.ToolStripMenuItem();
            this.tss1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiReplacement = new System.Windows.Forms.ToolStripMenuItem();
            this.tss2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiRelease = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRetake = new System.Windows.Forms.ToolStripMenuItem();
            this.tss3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiManageApplications = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLocalApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInternationalApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.tss4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiDetained = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiManageDetained = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDetainLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReleaseDetained = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiManageApplicationTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiManageAppTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiManageTestTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrlMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlMainMenu
            // 
            this.ctrlMainMenu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ctrlMainMenu.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.ctrlMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiApplications});
            this.ctrlMainMenu.Location = new System.Drawing.Point(0, 0);
            this.ctrlMainMenu.Name = "ctrlMainMenu";
            this.ctrlMainMenu.Padding = new System.Windows.Forms.Padding(10, 4, 10, 4);
            this.ctrlMainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ctrlMainMenu.Size = new System.Drawing.Size(800, 76);
            this.ctrlMainMenu.TabIndex = 0;
            this.ctrlMainMenu.Text = "ccMenuStrip1";
            // 
            // tsmiApplications
            // 
            this.tsmiApplications.BackColor = System.Drawing.SystemColors.Control;
            this.tsmiApplications.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDrivingLicensesServices,
            this.tss3,
            this.tsmiManageApplications,
            this.tss4,
            this.tsmiDetained,
            this.tsmiManageAppTypes,
            this.tsmiManageTestTypes});
            this.tsmiApplications.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsmiApplications.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsmiApplications.Image = global::DVLD_Enterprise_System.UI.Properties.Resources.Applications_64;
            this.tsmiApplications.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiApplications.Name = "tsmiApplications";
            this.tsmiApplications.Size = new System.Drawing.Size(181, 68);
            this.tsmiApplications.Text = "Applications";
            // 
            // tsmiDrivingLicensesServices
            // 
            this.tsmiDrivingLicensesServices.BackColor = System.Drawing.SystemColors.Control;
            this.tsmiDrivingLicensesServices.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNew,
            this.tsmiRenew,
            this.tss1,
            this.tsmiReplacement,
            this.tss2,
            this.tsmiRelease,
            this.tsmiRetake});
            this.tsmiDrivingLicensesServices.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsmiDrivingLicensesServices.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsmiDrivingLicensesServices.Image = global::DVLD_Enterprise_System.UI.Properties.Resources.Driver_License_48;
            this.tsmiDrivingLicensesServices.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiDrivingLicensesServices.Name = "tsmiDrivingLicensesServices";
            this.tsmiDrivingLicensesServices.Size = new System.Drawing.Size(339, 70);
            this.tsmiDrivingLicensesServices.Text = "Driving Licenses Services";
            // 
            // tsmiNew
            // 
            this.tsmiNew.BackColor = System.Drawing.SystemColors.Control;
            this.tsmiNew.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLocalLicense,
            this.tsmiInternationalLicense});
            this.tsmiNew.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsmiNew.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsmiNew.Image = global::DVLD_Enterprise_System.UI.Properties.Resources.New_Driving_License_32;
            this.tsmiNew.Name = "tsmiNew";
            this.tsmiNew.Size = new System.Drawing.Size(415, 28);
            this.tsmiNew.Text = "New Driving License";
            // 
            // tsmiLocalLicense
            // 
            this.tsmiLocalLicense.BackColor = System.Drawing.SystemColors.Control;
            this.tsmiLocalLicense.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsmiLocalLicense.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsmiLocalLicense.Image = global::DVLD_Enterprise_System.UI.Properties.Resources.Local_32;
            this.tsmiLocalLicense.Name = "tsmiLocalLicense";
            this.tsmiLocalLicense.Size = new System.Drawing.Size(252, 28);
            this.tsmiLocalLicense.Text = "Local License";
            // 
            // tsmiInternationalLicense
            // 
            this.tsmiInternationalLicense.BackColor = System.Drawing.SystemColors.Control;
            this.tsmiInternationalLicense.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsmiInternationalLicense.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsmiInternationalLicense.Image = global::DVLD_Enterprise_System.UI.Properties.Resources.International_32;
            this.tsmiInternationalLicense.Name = "tsmiInternationalLicense";
            this.tsmiInternationalLicense.Size = new System.Drawing.Size(252, 28);
            this.tsmiInternationalLicense.Text = "International License";
            // 
            // tsmiRenew
            // 
            this.tsmiRenew.BackColor = System.Drawing.SystemColors.Control;
            this.tsmiRenew.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsmiRenew.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsmiRenew.Image = global::DVLD_Enterprise_System.UI.Properties.Resources.Renew_Driving_License_32;
            this.tsmiRenew.Name = "tsmiRenew";
            this.tsmiRenew.Size = new System.Drawing.Size(415, 28);
            this.tsmiRenew.Text = "Renew Driving License";
            // 
            // tss1
            // 
            this.tss1.BackColor = System.Drawing.SystemColors.Control;
            this.tss1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tss1.Name = "tss1";
            this.tss1.Size = new System.Drawing.Size(412, 6);
            // 
            // tsmiReplacement
            // 
            this.tsmiReplacement.BackColor = System.Drawing.SystemColors.Control;
            this.tsmiReplacement.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsmiReplacement.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsmiReplacement.Image = global::DVLD_Enterprise_System.UI.Properties.Resources.Damaged_Driving_License_32;
            this.tsmiReplacement.Name = "tsmiReplacement";
            this.tsmiReplacement.Size = new System.Drawing.Size(415, 28);
            this.tsmiReplacement.Text = "Replacement for Lost or Damaged License";
            // 
            // tss2
            // 
            this.tss2.BackColor = System.Drawing.SystemColors.Control;
            this.tss2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tss2.Name = "tss2";
            this.tss2.Size = new System.Drawing.Size(412, 6);
            // 
            // tsmiRelease
            // 
            this.tsmiRelease.BackColor = System.Drawing.SystemColors.Control;
            this.tsmiRelease.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsmiRelease.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsmiRelease.Image = global::DVLD_Enterprise_System.UI.Properties.Resources.Detained_Driving_License_32;
            this.tsmiRelease.Name = "tsmiRelease";
            this.tsmiRelease.Size = new System.Drawing.Size(415, 28);
            this.tsmiRelease.Text = "Release Detained Driving License";
            // 
            // tsmiRetake
            // 
            this.tsmiRetake.BackColor = System.Drawing.SystemColors.Control;
            this.tsmiRetake.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsmiRetake.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsmiRetake.Image = global::DVLD_Enterprise_System.UI.Properties.Resources.Retake_Test_32;
            this.tsmiRetake.Name = "tsmiRetake";
            this.tsmiRetake.Size = new System.Drawing.Size(415, 28);
            this.tsmiRetake.Text = "Retake Test";
            // 
            // tss3
            // 
            this.tss3.BackColor = System.Drawing.SystemColors.Control;
            this.tss3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tss3.Name = "tss3";
            this.tss3.Size = new System.Drawing.Size(336, 6);
            // 
            // tsmiManageApplications
            // 
            this.tsmiManageApplications.BackColor = System.Drawing.SystemColors.Control;
            this.tsmiManageApplications.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLocalApplication,
            this.tsmiInternationalApplication});
            this.tsmiManageApplications.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsmiManageApplications.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsmiManageApplications.Image = global::DVLD_Enterprise_System.UI.Properties.Resources.Manage_Applications_64;
            this.tsmiManageApplications.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiManageApplications.Name = "tsmiManageApplications";
            this.tsmiManageApplications.Size = new System.Drawing.Size(339, 70);
            this.tsmiManageApplications.Text = "Manage Applications";
            // 
            // tsmiLocalApplication
            // 
            this.tsmiLocalApplication.BackColor = System.Drawing.SystemColors.Control;
            this.tsmiLocalApplication.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsmiLocalApplication.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsmiLocalApplication.Image = global::DVLD_Enterprise_System.UI.Properties.Resources.LocalDriving_License;
            this.tsmiLocalApplication.Name = "tsmiLocalApplication";
            this.tsmiLocalApplication.Size = new System.Drawing.Size(409, 28);
            this.tsmiLocalApplication.Text = "Local Driving License Applications";
            // 
            // tsmiInternationalApplication
            // 
            this.tsmiInternationalApplication.BackColor = System.Drawing.SystemColors.Control;
            this.tsmiInternationalApplication.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsmiInternationalApplication.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsmiInternationalApplication.Image = global::DVLD_Enterprise_System.UI.Properties.Resources.International_32;
            this.tsmiInternationalApplication.Name = "tsmiInternationalApplication";
            this.tsmiInternationalApplication.Size = new System.Drawing.Size(409, 28);
            this.tsmiInternationalApplication.Text = "International Driving License Applications";
            // 
            // tss4
            // 
            this.tss4.BackColor = System.Drawing.SystemColors.Control;
            this.tss4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tss4.Name = "tss4";
            this.tss4.Size = new System.Drawing.Size(336, 6);
            // 
            // tsmiDetained
            // 
            this.tsmiDetained.BackColor = System.Drawing.SystemColors.Control;
            this.tsmiDetained.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiManageDetained,
            this.tsmiDetainLicense,
            this.tsmiReleaseDetained,
            this.tsmiManageApplicationTypes});
            this.tsmiDetained.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsmiDetained.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsmiDetained.Image = global::DVLD_Enterprise_System.UI.Properties.Resources.Detain_64;
            this.tsmiDetained.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiDetained.Name = "tsmiDetained";
            this.tsmiDetained.Size = new System.Drawing.Size(339, 70);
            this.tsmiDetained.Text = "Detained License";
            // 
            // tsmiManageDetained
            // 
            this.tsmiManageDetained.BackColor = System.Drawing.SystemColors.Control;
            this.tsmiManageDetained.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsmiManageDetained.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsmiManageDetained.Image = global::DVLD_Enterprise_System.UI.Properties.Resources.Detain_32;
            this.tsmiManageDetained.Name = "tsmiManageDetained";
            this.tsmiManageDetained.Size = new System.Drawing.Size(297, 28);
            this.tsmiManageDetained.Text = "Manage Detained Licenses";
            // 
            // tsmiDetainLicense
            // 
            this.tsmiDetainLicense.BackColor = System.Drawing.SystemColors.Control;
            this.tsmiDetainLicense.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsmiDetainLicense.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsmiDetainLicense.Image = global::DVLD_Enterprise_System.UI.Properties.Resources.Detain_32;
            this.tsmiDetainLicense.Name = "tsmiDetainLicense";
            this.tsmiDetainLicense.Size = new System.Drawing.Size(297, 28);
            this.tsmiDetainLicense.Text = "Detain License";
            // 
            // tsmiReleaseDetained
            // 
            this.tsmiReleaseDetained.BackColor = System.Drawing.SystemColors.Control;
            this.tsmiReleaseDetained.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsmiReleaseDetained.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsmiReleaseDetained.Image = global::DVLD_Enterprise_System.UI.Properties.Resources.Release_Detained_License_32;
            this.tsmiReleaseDetained.Name = "tsmiReleaseDetained";
            this.tsmiReleaseDetained.Size = new System.Drawing.Size(297, 28);
            this.tsmiReleaseDetained.Text = "Release Detained License";
            // 
            // tsmiManageApplicationTypes
            // 
            this.tsmiManageApplicationTypes.BackColor = System.Drawing.SystemColors.Control;
            this.tsmiManageApplicationTypes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsmiManageApplicationTypes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsmiManageApplicationTypes.Image = global::DVLD_Enterprise_System.UI.Properties.Resources.Application_Types_64;
            this.tsmiManageApplicationTypes.Name = "tsmiManageApplicationTypes";
            this.tsmiManageApplicationTypes.Size = new System.Drawing.Size(297, 28);
            this.tsmiManageApplicationTypes.Text = "Manage Application Types";
            // 
            // tsmiManageAppTypes
            // 
            this.tsmiManageAppTypes.BackColor = System.Drawing.SystemColors.Control;
            this.tsmiManageAppTypes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsmiManageAppTypes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsmiManageAppTypes.Image = global::DVLD_Enterprise_System.UI.Properties.Resources.Application_Types_64;
            this.tsmiManageAppTypes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiManageAppTypes.Name = "tsmiManageAppTypes";
            this.tsmiManageAppTypes.Size = new System.Drawing.Size(339, 70);
            this.tsmiManageAppTypes.Text = "Manage Application Types";
            // 
            // tsmiManageTestTypes
            // 
            this.tsmiManageTestTypes.BackColor = System.Drawing.SystemColors.Control;
            this.tsmiManageTestTypes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsmiManageTestTypes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsmiManageTestTypes.Image = global::DVLD_Enterprise_System.UI.Properties.Resources.Test_Type_64;
            this.tsmiManageTestTypes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiManageTestTypes.Name = "tsmiManageTestTypes";
            this.tsmiManageTestTypes.Size = new System.Drawing.Size(339, 70);
            this.tsmiManageTestTypes.Text = "Manage Test Types";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ctrlMainMenu);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.ctrlMainMenu.ResumeLayout(false);
            this.ctrlMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevToolkit.BaseWinForms.Controls.CustomControls.ccMenuStrip ctrlMainMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiApplications;
        private System.Windows.Forms.ToolStripMenuItem tsmiDrivingLicensesServices;
        private System.Windows.Forms.ToolStripMenuItem tsmiNew;
        private System.Windows.Forms.ToolStripMenuItem tsmiLocalLicense;
        private System.Windows.Forms.ToolStripMenuItem tsmiInternationalLicense;
        private System.Windows.Forms.ToolStripMenuItem tsmiRenew;
        private System.Windows.Forms.ToolStripSeparator tss1;
        private System.Windows.Forms.ToolStripMenuItem tsmiReplacement;
        private System.Windows.Forms.ToolStripSeparator tss2;
        private System.Windows.Forms.ToolStripMenuItem tsmiRelease;
        private System.Windows.Forms.ToolStripMenuItem tsmiRetake;
        private System.Windows.Forms.ToolStripSeparator tss3;
        private System.Windows.Forms.ToolStripMenuItem tsmiLocalApplication;
        private System.Windows.Forms.ToolStripMenuItem tsmiInternationalApplication;
        private System.Windows.Forms.ToolStripSeparator tss4;
        private System.Windows.Forms.ToolStripMenuItem tsmiDetained;
        private System.Windows.Forms.ToolStripMenuItem tsmiManageDetained;
        private System.Windows.Forms.ToolStripMenuItem tsmiDetainLicense;
        private System.Windows.Forms.ToolStripMenuItem tsmiReleaseDetained;
        private System.Windows.Forms.ToolStripMenuItem tsmiManageApplicationTypes;
        private System.Windows.Forms.ToolStripMenuItem tsmiManageAppTypes;
        private System.Windows.Forms.ToolStripMenuItem tsmiManageTestTypes;
        private System.Windows.Forms.ToolStripMenuItem tsmiManageApplications;
    }
}

