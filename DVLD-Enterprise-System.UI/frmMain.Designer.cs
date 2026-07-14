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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
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
            this.tsmiPeople = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDrivers = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAccountSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCurrentUserInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.tss5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSignOut = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.ctrlMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlMainMenu
            // 
            this.ctrlMainMenu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ctrlMainMenu.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.ctrlMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiApplications,
            this.tsmiPeople,
            this.tsmiDrivers,
            this.tsmiUsers,
            this.tsmiAccountSettings});
            this.ctrlMainMenu.Location = new System.Drawing.Point(0, 0);
            this.ctrlMainMenu.Name = "ctrlMainMenu";
            this.ctrlMainMenu.Padding = new System.Windows.Forms.Padding(9, 4, 9, 4);
            this.ctrlMainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ctrlMainMenu.Size = new System.Drawing.Size(1204, 35);
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
            this.tsmiApplications.Name = "tsmiApplications";
            this.tsmiApplications.Size = new System.Drawing.Size(135, 27);
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
            this.tsmiDrivingLicensesServices.Name = "tsmiDrivingLicensesServices";
            this.tsmiDrivingLicensesServices.Size = new System.Drawing.Size(294, 28);
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
            this.tss3.Size = new System.Drawing.Size(291, 6);
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
            this.tsmiManageApplications.Name = "tsmiManageApplications";
            this.tsmiManageApplications.Size = new System.Drawing.Size(294, 28);
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
            this.tss4.Size = new System.Drawing.Size(291, 6);
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
            this.tsmiDetained.Name = "tsmiDetained";
            this.tsmiDetained.Size = new System.Drawing.Size(294, 28);
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
            this.tsmiManageAppTypes.Name = "tsmiManageAppTypes";
            this.tsmiManageAppTypes.Size = new System.Drawing.Size(294, 28);
            this.tsmiManageAppTypes.Text = "Manage Application Types";
            // 
            // tsmiManageTestTypes
            // 
            this.tsmiManageTestTypes.BackColor = System.Drawing.SystemColors.Control;
            this.tsmiManageTestTypes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsmiManageTestTypes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsmiManageTestTypes.Image = global::DVLD_Enterprise_System.UI.Properties.Resources.Test_Type_64;
            this.tsmiManageTestTypes.Name = "tsmiManageTestTypes";
            this.tsmiManageTestTypes.Size = new System.Drawing.Size(294, 28);
            this.tsmiManageTestTypes.Text = "Manage Test Types";
            // 
            // tsmiPeople
            // 
            this.tsmiPeople.BackColor = System.Drawing.SystemColors.Control;
            this.tsmiPeople.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsmiPeople.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsmiPeople.Image = ((System.Drawing.Image)(resources.GetObject("tsmiPeople.Image")));
            this.tsmiPeople.Name = "tsmiPeople";
            this.tsmiPeople.Size = new System.Drawing.Size(93, 27);
            this.tsmiPeople.Text = "People";
            // 
            // tsmiDrivers
            // 
            this.tsmiDrivers.BackColor = System.Drawing.SystemColors.Control;
            this.tsmiDrivers.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsmiDrivers.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsmiDrivers.Image = global::DVLD_Enterprise_System.UI.Properties.Resources.Drivers_64;
            this.tsmiDrivers.Name = "tsmiDrivers";
            this.tsmiDrivers.Size = new System.Drawing.Size(94, 27);
            this.tsmiDrivers.Text = "Drivers";
            // 
            // tsmiUsers
            // 
            this.tsmiUsers.BackColor = System.Drawing.SystemColors.Control;
            this.tsmiUsers.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsmiUsers.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsmiUsers.Image = global::DVLD_Enterprise_System.UI.Properties.Resources.Users_2_64;
            this.tsmiUsers.Name = "tsmiUsers";
            this.tsmiUsers.Size = new System.Drawing.Size(83, 27);
            this.tsmiUsers.Text = "Users";
            // 
            // tsmiAccountSettings
            // 
            this.tsmiAccountSettings.BackColor = System.Drawing.SystemColors.Control;
            this.tsmiAccountSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCurrentUserInfo,
            this.tsmiChangePassword,
            this.tss5,
            this.tsmiSignOut});
            this.tsmiAccountSettings.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsmiAccountSettings.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsmiAccountSettings.Image = global::DVLD_Enterprise_System.UI.Properties.Resources.account_settings_64;
            this.tsmiAccountSettings.Name = "tsmiAccountSettings";
            this.tsmiAccountSettings.Size = new System.Drawing.Size(171, 27);
            this.tsmiAccountSettings.Text = "Account Settings";
            // 
            // tsmiCurrentUserInfo
            // 
            this.tsmiCurrentUserInfo.BackColor = System.Drawing.SystemColors.Control;
            this.tsmiCurrentUserInfo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsmiCurrentUserInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsmiCurrentUserInfo.Image = global::DVLD_Enterprise_System.UI.Properties.Resources.PersonDetails_32;
            this.tsmiCurrentUserInfo.Name = "tsmiCurrentUserInfo";
            this.tsmiCurrentUserInfo.Size = new System.Drawing.Size(228, 28);
            this.tsmiCurrentUserInfo.Text = "Current User Info";
            // 
            // tsmiChangePassword
            // 
            this.tsmiChangePassword.BackColor = System.Drawing.SystemColors.Control;
            this.tsmiChangePassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsmiChangePassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsmiChangePassword.Image = global::DVLD_Enterprise_System.UI.Properties.Resources.Password_32;
            this.tsmiChangePassword.Name = "tsmiChangePassword";
            this.tsmiChangePassword.Size = new System.Drawing.Size(228, 28);
            this.tsmiChangePassword.Text = "Change Password";
            // 
            // tss5
            // 
            this.tss5.BackColor = System.Drawing.SystemColors.Control;
            this.tss5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tss5.Name = "tss5";
            this.tss5.Size = new System.Drawing.Size(225, 6);
            // 
            // tsmiSignOut
            // 
            this.tsmiSignOut.BackColor = System.Drawing.SystemColors.Control;
            this.tsmiSignOut.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsmiSignOut.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsmiSignOut.Image = global::DVLD_Enterprise_System.UI.Properties.Resources.sign_out_32__2;
            this.tsmiSignOut.Name = "tsmiSignOut";
            this.tsmiSignOut.Size = new System.Drawing.Size(228, 28);
            this.tsmiSignOut.Text = "Sign Out";
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackgroundImage = global::DVLD_Enterprise_System.UI.Properties.Resources.Logo_Final;
            this.pnlContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 35);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1204, 378);
            this.pnlContainer.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 413);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.ctrlMainMenu);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DVLD";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.ToolStripMenuItem tsmiPeople;
        private System.Windows.Forms.ToolStripMenuItem tsmiDrivers;
        private System.Windows.Forms.ToolStripMenuItem tsmiUsers;
        private System.Windows.Forms.ToolStripMenuItem tsmiAccountSettings;
        private System.Windows.Forms.ToolStripMenuItem tsmiCurrentUserInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmiChangePassword;
        private System.Windows.Forms.ToolStripSeparator tss5;
        private System.Windows.Forms.ToolStripMenuItem tsmiSignOut;
        private System.Windows.Forms.Panel pnlContainer;
    }
}

