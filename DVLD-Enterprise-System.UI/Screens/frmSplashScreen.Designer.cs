namespace DVLD_Enterprise_System.UI.Screens
{
    partial class frmSplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplashScreen));
            this.picbLogo = new System.Windows.Forms.PictureBox();
            this.tlpContainer = new System.Windows.Forms.TableLayoutPanel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblFeatures = new System.Windows.Forms.Label();
            this.lblLoading = new System.Windows.Forms.Label();
            this.lblSplashSubTitle = new System.Windows.Forms.Label();
            this.lblSplashTitle = new System.Windows.Forms.Label();
            this.pbLoading = new System.Windows.Forms.ProgressBar();
            this.tSplash = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picbLogo)).BeginInit();
            this.tlpContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // picbLogo
            // 
            this.picbLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picbLogo.Image = global::DVLD_Enterprise_System.UI.Properties.Resources.driver_license;
            this.picbLogo.Location = new System.Drawing.Point(280, 5);
            this.picbLogo.Name = "picbLogo";
            this.picbLogo.Size = new System.Drawing.Size(220, 188);
            this.picbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbLogo.TabIndex = 0;
            this.picbLogo.TabStop = false;
            // 
            // tlpContainer
            // 
            this.tlpContainer.ColumnCount = 1;
            this.tlpContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpContainer.Controls.Add(this.lblVersion, 0, 6);
            this.tlpContainer.Controls.Add(this.lblFeatures, 0, 5);
            this.tlpContainer.Controls.Add(this.lblLoading, 0, 3);
            this.tlpContainer.Controls.Add(this.lblSplashSubTitle, 0, 2);
            this.tlpContainer.Controls.Add(this.picbLogo, 0, 0);
            this.tlpContainer.Controls.Add(this.lblSplashTitle, 0, 1);
            this.tlpContainer.Controls.Add(this.pbLoading, 0, 4);
            this.tlpContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContainer.Location = new System.Drawing.Point(10, 10);
            this.tlpContainer.Name = "tlpContainer";
            this.tlpContainer.RowCount = 7;
            this.tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.44788F));
            this.tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.55212F));
            this.tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tlpContainer.Size = new System.Drawing.Size(780, 506);
            this.tlpContainer.TabIndex = 1;
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(343, 472);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(93, 23);
            this.lblVersion.TabIndex = 6;
            this.lblVersion.Text = "Version 1.0";
            // 
            // lblFeatures
            // 
            this.lblFeatures.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFeatures.AutoSize = true;
            this.lblFeatures.Location = new System.Drawing.Point(257, 427);
            this.lblFeatures.Name = "lblFeatures";
            this.lblFeatures.Size = new System.Drawing.Size(266, 23);
            this.lblFeatures.TabIndex = 5;
            this.lblFeatures.Text = "Security • Reliability • Compliance";
            // 
            // lblLoading
            // 
            this.lblLoading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLoading.AutoSize = true;
            this.lblLoading.Location = new System.Drawing.Point(313, 331);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(153, 23);
            this.lblLoading.TabIndex = 3;
            this.lblLoading.Text = "Loading Modules...";
            // 
            // lblSplashSubTitle
            // 
            this.lblSplashSubTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSplashSubTitle.AutoSize = true;
            this.lblSplashSubTitle.Location = new System.Drawing.Point(265, 276);
            this.lblSplashSubTitle.Name = "lblSplashSubTitle";
            this.lblSplashSubTitle.Size = new System.Drawing.Size(250, 23);
            this.lblSplashSubTitle.TabIndex = 2;
            this.lblSplashSubTitle.Text = "Government Licensing Platform";
            // 
            // lblSplashTitle
            // 
            this.lblSplashTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSplashTitle.AutoSize = true;
            this.lblSplashTitle.Location = new System.Drawing.Point(141, 217);
            this.lblSplashTitle.Name = "lblSplashTitle";
            this.lblSplashTitle.Size = new System.Drawing.Size(497, 23);
            this.lblSplashTitle.TabIndex = 1;
            this.lblSplashTitle.Text = "DVLD Enterprise System (Driving && Vehicle License Department)";
            // 
            // pbLoading
            // 
            this.pbLoading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbLoading.Location = new System.Drawing.Point(73, 377);
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(634, 32);
            this.pbLoading.Step = 1;
            this.pbLoading.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbLoading.TabIndex = 8;
            // 
            // tSplash
            // 
            this.tSplash.Enabled = true;
            this.tSplash.Interval = 40;
            this.tSplash.Tick += new System.EventHandler(this.tSplash_Tick);
            // 
            // frmSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 526);
            this.Controls.Add(this.tlpContainer);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSplashScreen";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSplashScreen";
            this.Load += new System.EventHandler(this.frmSplashScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbLogo)).EndInit();
            this.tlpContainer.ResumeLayout(false);
            this.tlpContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picbLogo;
        private System.Windows.Forms.TableLayoutPanel tlpContainer;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblFeatures;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.Label lblSplashSubTitle;
        private System.Windows.Forms.Label lblSplashTitle;
        private System.Windows.Forms.ProgressBar pbLoading;
        private System.Windows.Forms.Timer tSplash;
    }
}