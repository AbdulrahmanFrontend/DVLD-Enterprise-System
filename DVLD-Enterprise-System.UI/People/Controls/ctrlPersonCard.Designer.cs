namespace DVLD_Enterprise_System.UI.People.Controls
{
    partial class ctrlPersonCard
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
            this.tlpBody = new System.Windows.Forms.TableLayoutPanel();
            this.tlpImage = new System.Windows.Forms.TableLayoutPanel();
            this.llEditPersonInfo = new System.Windows.Forms.LinkLabel();
            this.pbPersonImage = new System.Windows.Forms.PictureBox();
            this.tlpContainer = new System.Windows.Forms.TableLayoutPanel();
            this.tlpAddress = new System.Windows.Forms.TableLayoutPanel();
            this.lblAddress = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tlpFields = new System.Windows.Forms.TableLayoutPanel();
            this.tlpPersonID = new System.Windows.Forms.TableLayoutPanel();
            this.lblPersonID = new System.Windows.Forms.Label();
            this.tbPersonID = new System.Windows.Forms.TextBox();
            this.tlpNationalNo = new System.Windows.Forms.TableLayoutPanel();
            this.lblNationalNo = new System.Windows.Forms.Label();
            this.tbNationalNo = new System.Windows.Forms.TextBox();
            this.tlpDateOfBirth = new System.Windows.Forms.TableLayoutPanel();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.tlpGender = new System.Windows.Forms.TableLayoutPanel();
            this.lblGender = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.tlpFullName = new System.Windows.Forms.TableLayoutPanel();
            this.tbFullName = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.tlpPhone = new System.Windows.Forms.TableLayoutPanel();
            this.lblPhone = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tlpEmail = new System.Windows.Forms.TableLayoutPanel();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tlpCountry = new System.Windows.Forms.TableLayoutPanel();
            this.tbCountries = new System.Windows.Forms.TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.tlpBody.SuspendLayout();
            this.tlpImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).BeginInit();
            this.tlpContainer.SuspendLayout();
            this.tlpAddress.SuspendLayout();
            this.tlpFields.SuspendLayout();
            this.tlpPersonID.SuspendLayout();
            this.tlpNationalNo.SuspendLayout();
            this.tlpDateOfBirth.SuspendLayout();
            this.tlpGender.SuspendLayout();
            this.tlpFullName.SuspendLayout();
            this.tlpPhone.SuspendLayout();
            this.tlpEmail.SuspendLayout();
            this.tlpCountry.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpBody
            // 
            this.tlpBody.ColumnCount = 2;
            this.tlpBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpBody.Controls.Add(this.tlpImage, 1, 0);
            this.tlpBody.Controls.Add(this.tlpContainer, 0, 0);
            this.tlpBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBody.Location = new System.Drawing.Point(0, 0);
            this.tlpBody.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tlpBody.Name = "tlpBody";
            this.tlpBody.RowCount = 1;
            this.tlpBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBody.Size = new System.Drawing.Size(1021, 382);
            this.tlpBody.TabIndex = 5;
            // 
            // tlpImage
            // 
            this.tlpImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpImage.ColumnCount = 1;
            this.tlpImage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpImage.Controls.Add(this.llEditPersonInfo, 0, 0);
            this.tlpImage.Controls.Add(this.pbPersonImage, 0, 1);
            this.tlpImage.Location = new System.Drawing.Point(718, 3);
            this.tlpImage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tlpImage.Name = "tlpImage";
            this.tlpImage.RowCount = 2;
            this.tlpImage.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpImage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpImage.Size = new System.Drawing.Size(299, 376);
            this.tlpImage.TabIndex = 6;
            // 
            // llEditPersonInfo
            // 
            this.llEditPersonInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.llEditPersonInfo.AutoSize = true;
            this.llEditPersonInfo.Location = new System.Drawing.Point(99, 5);
            this.llEditPersonInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.llEditPersonInfo.Name = "llEditPersonInfo";
            this.llEditPersonInfo.Size = new System.Drawing.Size(100, 17);
            this.llEditPersonInfo.TabIndex = 2;
            this.llEditPersonInfo.TabStop = true;
            this.llEditPersonInfo.Text = "Edit Person Info";
            this.llEditPersonInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llEditPersonInfo_LinkClicked);
            // 
            // pbPersonImage
            // 
            this.pbPersonImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbPersonImage.Image = global::DVLD_Enterprise_System.UI.Properties.Resources.Male_512;
            this.pbPersonImage.Location = new System.Drawing.Point(4, 30);
            this.pbPersonImage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbPersonImage.Name = "pbPersonImage";
            this.pbPersonImage.Size = new System.Drawing.Size(291, 343);
            this.pbPersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPersonImage.TabIndex = 0;
            this.pbPersonImage.TabStop = false;
            // 
            // tlpContainer
            // 
            this.tlpContainer.ColumnCount = 1;
            this.tlpContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpContainer.Controls.Add(this.tlpAddress, 0, 1);
            this.tlpContainer.Controls.Add(this.tlpFields, 0, 0);
            this.tlpContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContainer.Location = new System.Drawing.Point(4, 3);
            this.tlpContainer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tlpContainer.Name = "tlpContainer";
            this.tlpContainer.RowCount = 2;
            this.tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 169F));
            this.tlpContainer.Size = new System.Drawing.Size(706, 376);
            this.tlpContainer.TabIndex = 5;
            // 
            // tlpAddress
            // 
            this.tlpAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpAddress.ColumnCount = 1;
            this.tlpAddress.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAddress.Controls.Add(this.lblAddress, 0, 0);
            this.tlpAddress.Controls.Add(this.tbAddress, 0, 1);
            this.tlpAddress.Location = new System.Drawing.Point(4, 210);
            this.tlpAddress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tlpAddress.Name = "tlpAddress";
            this.tlpAddress.RowCount = 2;
            this.tlpAddress.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpAddress.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAddress.Size = new System.Drawing.Size(698, 163);
            this.tlpAddress.TabIndex = 25;
            // 
            // lblAddress
            // 
            this.lblAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddress.Image = global::DVLD_Enterprise_System.UI.Properties.Resources.Address_32;
            this.lblAddress.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAddress.Location = new System.Drawing.Point(4, 3);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(690, 28);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "Address:";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbAddress
            // 
            this.tbAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAddress.Location = new System.Drawing.Point(4, 38);
            this.tbAddress.Margin = new System.Windows.Forms.Padding(4, 3, 20, 3);
            this.tbAddress.MaxLength = 500;
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.ReadOnly = true;
            this.tbAddress.Size = new System.Drawing.Size(674, 122);
            this.tbAddress.TabIndex = 1;
            // 
            // tlpFields
            // 
            this.tlpFields.ColumnCount = 3;
            this.tlpFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpFields.Controls.Add(this.tlpPersonID, 0, 0);
            this.tlpFields.Controls.Add(this.tlpNationalNo, 2, 0);
            this.tlpFields.Controls.Add(this.tlpDateOfBirth, 0, 1);
            this.tlpFields.Controls.Add(this.tlpGender, 1, 1);
            this.tlpFields.Controls.Add(this.tlpFullName, 1, 0);
            this.tlpFields.Controls.Add(this.tlpPhone, 2, 1);
            this.tlpFields.Controls.Add(this.tlpEmail, 1, 2);
            this.tlpFields.Controls.Add(this.tlpCountry, 0, 2);
            this.tlpFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFields.Location = new System.Drawing.Point(4, 3);
            this.tlpFields.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tlpFields.Name = "tlpFields";
            this.tlpFields.RowCount = 3;
            this.tlpFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpFields.Size = new System.Drawing.Size(698, 201);
            this.tlpFields.TabIndex = 0;
            // 
            // tlpPersonID
            // 
            this.tlpPersonID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpPersonID.ColumnCount = 1;
            this.tlpPersonID.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPersonID.Controls.Add(this.lblPersonID, 0, 0);
            this.tlpPersonID.Controls.Add(this.tbPersonID, 0, 1);
            this.tlpPersonID.Location = new System.Drawing.Point(4, 4);
            this.tlpPersonID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tlpPersonID.Name = "tlpPersonID";
            this.tlpPersonID.RowCount = 2;
            this.tlpPersonID.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPersonID.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPersonID.Size = new System.Drawing.Size(224, 58);
            this.tlpPersonID.TabIndex = 17;
            // 
            // lblPersonID
            // 
            this.lblPersonID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPersonID.Image = global::DVLD_Enterprise_System.UI.Properties.Resources.Number_32;
            this.lblPersonID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPersonID.Location = new System.Drawing.Point(4, 0);
            this.lblPersonID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(216, 27);
            this.lblPersonID.TabIndex = 0;
            this.lblPersonID.Text = "Person ID:";
            this.lblPersonID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbPersonID
            // 
            this.tbPersonID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPersonID.Location = new System.Drawing.Point(4, 30);
            this.tbPersonID.Margin = new System.Windows.Forms.Padding(4, 3, 20, 3);
            this.tbPersonID.Name = "tbPersonID";
            this.tbPersonID.ReadOnly = true;
            this.tbPersonID.Size = new System.Drawing.Size(200, 25);
            this.tbPersonID.TabIndex = 1;
            // 
            // tlpNationalNo
            // 
            this.tlpNationalNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpNationalNo.ColumnCount = 1;
            this.tlpNationalNo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpNationalNo.Controls.Add(this.lblNationalNo, 0, 0);
            this.tlpNationalNo.Controls.Add(this.tbNationalNo, 0, 1);
            this.tlpNationalNo.Location = new System.Drawing.Point(468, 4);
            this.tlpNationalNo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tlpNationalNo.Name = "tlpNationalNo";
            this.tlpNationalNo.RowCount = 2;
            this.tlpNationalNo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpNationalNo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpNationalNo.Size = new System.Drawing.Size(226, 58);
            this.tlpNationalNo.TabIndex = 18;
            // 
            // lblNationalNo
            // 
            this.lblNationalNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNationalNo.Image = global::DVLD_Enterprise_System.UI.Properties.Resources.Number_32;
            this.lblNationalNo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNationalNo.Location = new System.Drawing.Point(4, 0);
            this.lblNationalNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNationalNo.Name = "lblNationalNo";
            this.lblNationalNo.Size = new System.Drawing.Size(218, 27);
            this.lblNationalNo.TabIndex = 0;
            this.lblNationalNo.Text = "National No:";
            this.lblNationalNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbNationalNo
            // 
            this.tbNationalNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNationalNo.Location = new System.Drawing.Point(4, 30);
            this.tbNationalNo.Margin = new System.Windows.Forms.Padding(4, 3, 20, 3);
            this.tbNationalNo.MaxLength = 20;
            this.tbNationalNo.Name = "tbNationalNo";
            this.tbNationalNo.ReadOnly = true;
            this.tbNationalNo.Size = new System.Drawing.Size(202, 25);
            this.tbNationalNo.TabIndex = 1;
            // 
            // tlpDateOfBirth
            // 
            this.tlpDateOfBirth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpDateOfBirth.ColumnCount = 1;
            this.tlpDateOfBirth.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDateOfBirth.Controls.Add(this.lblDateOfBirth, 0, 0);
            this.tlpDateOfBirth.Controls.Add(this.dtpDateOfBirth, 0, 1);
            this.tlpDateOfBirth.Location = new System.Drawing.Point(4, 71);
            this.tlpDateOfBirth.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tlpDateOfBirth.Name = "tlpDateOfBirth";
            this.tlpDateOfBirth.RowCount = 2;
            this.tlpDateOfBirth.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDateOfBirth.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDateOfBirth.Size = new System.Drawing.Size(224, 58);
            this.tlpDateOfBirth.TabIndex = 20;
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateOfBirth.Image = global::DVLD_Enterprise_System.UI.Properties.Resources.Calendar_32;
            this.lblDateOfBirth.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDateOfBirth.Location = new System.Drawing.Point(4, 1);
            this.lblDateOfBirth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(216, 25);
            this.lblDateOfBirth.TabIndex = 0;
            this.lblDateOfBirth.Text = "Date Of Birth:";
            this.lblDateOfBirth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDateOfBirth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpDateOfBirth.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.dtpDateOfBirth.Enabled = false;
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(4, 30);
            this.dtpDateOfBirth.Margin = new System.Windows.Forms.Padding(4, 3, 20, 3);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(200, 25);
            this.dtpDateOfBirth.TabIndex = 1;
            this.dtpDateOfBirth.Value = new System.DateTime(2026, 7, 19, 0, 19, 27, 0);
            // 
            // tlpGender
            // 
            this.tlpGender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpGender.ColumnCount = 1;
            this.tlpGender.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpGender.Controls.Add(this.lblGender, 0, 0);
            this.tlpGender.Controls.Add(this.cbGender, 0, 1);
            this.tlpGender.Location = new System.Drawing.Point(236, 71);
            this.tlpGender.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tlpGender.Name = "tlpGender";
            this.tlpGender.RowCount = 2;
            this.tlpGender.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.87719F));
            this.tlpGender.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.12281F));
            this.tlpGender.Size = new System.Drawing.Size(224, 58);
            this.tlpGender.TabIndex = 21;
            // 
            // lblGender
            // 
            this.lblGender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGender.Image = global::DVLD_Enterprise_System.UI.Properties.Resources.Man_32;
            this.lblGender.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblGender.Location = new System.Drawing.Point(4, 2);
            this.lblGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(216, 25);
            this.lblGender.TabIndex = 0;
            this.lblGender.Text = "Gender:";
            this.lblGender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbGender
            // 
            this.cbGender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbGender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.Enabled = false;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cbGender.Location = new System.Drawing.Point(4, 32);
            this.cbGender.Margin = new System.Windows.Forms.Padding(4, 3, 20, 3);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(200, 25);
            this.cbGender.TabIndex = 1;
            // 
            // tlpFullName
            // 
            this.tlpFullName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpFullName.ColumnCount = 1;
            this.tlpFullName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFullName.Controls.Add(this.tbFullName, 0, 1);
            this.tlpFullName.Controls.Add(this.lblFullName, 0, 0);
            this.tlpFullName.Location = new System.Drawing.Point(236, 4);
            this.tlpFullName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tlpFullName.Name = "tlpFullName";
            this.tlpFullName.RowCount = 2;
            this.tlpFullName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFullName.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpFullName.Size = new System.Drawing.Size(224, 58);
            this.tlpFullName.TabIndex = 0;
            // 
            // tbFullName
            // 
            this.tbFullName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFullName.Location = new System.Drawing.Point(4, 30);
            this.tbFullName.Margin = new System.Windows.Forms.Padding(4, 3, 20, 3);
            this.tbFullName.MaxLength = 20;
            this.tbFullName.Name = "tbFullName";
            this.tbFullName.ReadOnly = true;
            this.tbFullName.Size = new System.Drawing.Size(200, 25);
            this.tbFullName.TabIndex = 1;
            // 
            // lblFullName
            // 
            this.lblFullName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFullName.Image = global::DVLD_Enterprise_System.UI.Properties.Resources.Person_32;
            this.lblFullName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFullName.Location = new System.Drawing.Point(4, 0);
            this.lblFullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(216, 27);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "Name:";
            this.lblFullName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpPhone
            // 
            this.tlpPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpPhone.ColumnCount = 1;
            this.tlpPhone.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPhone.Controls.Add(this.lblPhone, 0, 0);
            this.tlpPhone.Controls.Add(this.tbPhone, 0, 1);
            this.tlpPhone.Location = new System.Drawing.Point(468, 71);
            this.tlpPhone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tlpPhone.Name = "tlpPhone";
            this.tlpPhone.RowCount = 2;
            this.tlpPhone.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPhone.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPhone.Size = new System.Drawing.Size(226, 58);
            this.tlpPhone.TabIndex = 19;
            // 
            // lblPhone
            // 
            this.lblPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPhone.Image = global::DVLD_Enterprise_System.UI.Properties.Resources.Phone_32;
            this.lblPhone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPhone.Location = new System.Drawing.Point(4, 0);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(218, 27);
            this.lblPhone.TabIndex = 0;
            this.lblPhone.Text = "Phone:";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbPhone
            // 
            this.tbPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPhone.Location = new System.Drawing.Point(4, 30);
            this.tbPhone.Margin = new System.Windows.Forms.Padding(4, 3, 20, 3);
            this.tbPhone.MaxLength = 20;
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.ReadOnly = true;
            this.tbPhone.Size = new System.Drawing.Size(202, 25);
            this.tbPhone.TabIndex = 1;
            // 
            // tlpEmail
            // 
            this.tlpEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpEmail.ColumnCount = 1;
            this.tlpEmail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEmail.Controls.Add(this.lblEmail, 0, 0);
            this.tlpEmail.Controls.Add(this.tbEmail, 0, 1);
            this.tlpEmail.Location = new System.Drawing.Point(236, 138);
            this.tlpEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tlpEmail.Name = "tlpEmail";
            this.tlpEmail.RowCount = 2;
            this.tlpEmail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEmail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpEmail.Size = new System.Drawing.Size(224, 59);
            this.tlpEmail.TabIndex = 23;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmail.Image = global::DVLD_Enterprise_System.UI.Properties.Resources.Email_32;
            this.lblEmail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEmail.Location = new System.Drawing.Point(4, 0);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(216, 28);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email:";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbEmail
            // 
            this.tbEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEmail.Location = new System.Drawing.Point(4, 31);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4, 3, 20, 3);
            this.tbEmail.MaxLength = 50;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.ReadOnly = true;
            this.tbEmail.Size = new System.Drawing.Size(200, 25);
            this.tbEmail.TabIndex = 1;
            // 
            // tlpCountry
            // 
            this.tlpCountry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpCountry.ColumnCount = 1;
            this.tlpCountry.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCountry.Controls.Add(this.tbCountries, 0, 1);
            this.tlpCountry.Controls.Add(this.lblCountry, 0, 0);
            this.tlpCountry.Location = new System.Drawing.Point(4, 138);
            this.tlpCountry.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tlpCountry.Name = "tlpCountry";
            this.tlpCountry.RowCount = 2;
            this.tlpCountry.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.87719F));
            this.tlpCountry.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.12281F));
            this.tlpCountry.Size = new System.Drawing.Size(224, 59);
            this.tlpCountry.TabIndex = 22;
            // 
            // tbCountries
            // 
            this.tbCountries.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCountries.Location = new System.Drawing.Point(4, 33);
            this.tbCountries.Margin = new System.Windows.Forms.Padding(4, 3, 20, 3);
            this.tbCountries.MaxLength = 50;
            this.tbCountries.Name = "tbCountries";
            this.tbCountries.ReadOnly = true;
            this.tbCountries.Size = new System.Drawing.Size(200, 25);
            this.tbCountries.TabIndex = 2;
            // 
            // lblCountry
            // 
            this.lblCountry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCountry.Image = global::DVLD_Enterprise_System.UI.Properties.Resources.Country_32;
            this.lblCountry.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCountry.Location = new System.Drawing.Point(4, 2);
            this.lblCountry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(216, 25);
            this.lblCountry.TabIndex = 0;
            this.lblCountry.Text = "Country:";
            this.lblCountry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ctrlPersonCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpBody);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ctrlPersonCard";
            this.Size = new System.Drawing.Size(1021, 382);
            this.tlpBody.ResumeLayout(false);
            this.tlpImage.ResumeLayout(false);
            this.tlpImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).EndInit();
            this.tlpContainer.ResumeLayout(false);
            this.tlpAddress.ResumeLayout(false);
            this.tlpAddress.PerformLayout();
            this.tlpFields.ResumeLayout(false);
            this.tlpPersonID.ResumeLayout(false);
            this.tlpPersonID.PerformLayout();
            this.tlpNationalNo.ResumeLayout(false);
            this.tlpNationalNo.PerformLayout();
            this.tlpDateOfBirth.ResumeLayout(false);
            this.tlpGender.ResumeLayout(false);
            this.tlpFullName.ResumeLayout(false);
            this.tlpFullName.PerformLayout();
            this.tlpPhone.ResumeLayout(false);
            this.tlpPhone.PerformLayout();
            this.tlpEmail.ResumeLayout(false);
            this.tlpEmail.PerformLayout();
            this.tlpCountry.ResumeLayout(false);
            this.tlpCountry.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpBody;
        private System.Windows.Forms.TableLayoutPanel tlpImage;
        private System.Windows.Forms.PictureBox pbPersonImage;
        private System.Windows.Forms.TableLayoutPanel tlpContainer;
        private System.Windows.Forms.TableLayoutPanel tlpAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TableLayoutPanel tlpFields;
        private System.Windows.Forms.TableLayoutPanel tlpEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TableLayoutPanel tlpCountry;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.TableLayoutPanel tlpGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.TableLayoutPanel tlpDateOfBirth;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.TableLayoutPanel tlpPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TableLayoutPanel tlpNationalNo;
        private System.Windows.Forms.Label lblNationalNo;
        private System.Windows.Forms.TextBox tbNationalNo;
        private System.Windows.Forms.TableLayoutPanel tlpPersonID;
        private System.Windows.Forms.Label lblPersonID;
        private System.Windows.Forms.TextBox tbPersonID;
        private System.Windows.Forms.TableLayoutPanel tlpFullName;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox tbFullName;
        private System.Windows.Forms.LinkLabel llEditPersonInfo;
        private System.Windows.Forms.TextBox tbCountries;
    }
}
