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
            this.pbPersonImage = new System.Windows.Forms.PictureBox();
            this.llSetImage = new System.Windows.Forms.LinkLabel();
            this.llRemove = new System.Windows.Forms.LinkLabel();
            this.tlpContainer = new System.Windows.Forms.TableLayoutPanel();
            this.tlpAddress = new System.Windows.Forms.TableLayoutPanel();
            this.lblAddress = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tlpFields = new System.Windows.Forms.TableLayoutPanel();
            this.tlpEmail = new System.Windows.Forms.TableLayoutPanel();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tlpCountry = new System.Windows.Forms.TableLayoutPanel();
            this.lblCountry = new System.Windows.Forms.Label();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.tlpGender = new System.Windows.Forms.TableLayoutPanel();
            this.lblGender = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.tlpDateOfBirth = new System.Windows.Forms.TableLayoutPanel();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.tlpPhone = new System.Windows.Forms.TableLayoutPanel();
            this.lblPhone = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tlpNationalNo = new System.Windows.Forms.TableLayoutPanel();
            this.lblNationalNo = new System.Windows.Forms.Label();
            this.tbNationalNo = new System.Windows.Forms.TextBox();
            this.tlpPersonID = new System.Windows.Forms.TableLayoutPanel();
            this.lblPersonID = new System.Windows.Forms.Label();
            this.tbPersonID = new System.Windows.Forms.TextBox();
            this.tlpLastName = new System.Windows.Forms.TableLayoutPanel();
            this.lblLastName = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tlpThirdName = new System.Windows.Forms.TableLayoutPanel();
            this.lblThirdName = new System.Windows.Forms.Label();
            this.tbThirdName = new System.Windows.Forms.TextBox();
            this.tlpSecondName = new System.Windows.Forms.TableLayoutPanel();
            this.lblSecondName = new System.Windows.Forms.Label();
            this.tbSecondName = new System.Windows.Forms.TextBox();
            this.tlpFirstName = new System.Windows.Forms.TableLayoutPanel();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tlpBody.SuspendLayout();
            this.tlpImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).BeginInit();
            this.tlpContainer.SuspendLayout();
            this.tlpAddress.SuspendLayout();
            this.tlpFields.SuspendLayout();
            this.tlpEmail.SuspendLayout();
            this.tlpCountry.SuspendLayout();
            this.tlpGender.SuspendLayout();
            this.tlpDateOfBirth.SuspendLayout();
            this.tlpPhone.SuspendLayout();
            this.tlpNationalNo.SuspendLayout();
            this.tlpPersonID.SuspendLayout();
            this.tlpLastName.SuspendLayout();
            this.tlpThirdName.SuspendLayout();
            this.tlpSecondName.SuspendLayout();
            this.tlpFirstName.SuspendLayout();
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
            this.tlpBody.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tlpBody.Name = "tlpBody";
            this.tlpBody.RowCount = 1;
            this.tlpBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBody.Size = new System.Drawing.Size(1681, 728);
            this.tlpBody.TabIndex = 5;
            // 
            // tlpImage
            // 
            this.tlpImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpImage.ColumnCount = 1;
            this.tlpImage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpImage.Controls.Add(this.pbPersonImage, 0, 0);
            this.tlpImage.Controls.Add(this.llSetImage, 0, 1);
            this.tlpImage.Controls.Add(this.llRemove, 0, 2);
            this.tlpImage.Location = new System.Drawing.Point(1181, 5);
            this.tlpImage.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tlpImage.Name = "tlpImage";
            this.tlpImage.RowCount = 3;
            this.tlpImage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpImage.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpImage.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpImage.Size = new System.Drawing.Size(495, 718);
            this.tlpImage.TabIndex = 6;
            // 
            // pbPersonImage
            // 
            this.pbPersonImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbPersonImage.Image = global::DVLD_Enterprise_System.UI.Properties.Resources.Male_512;
            this.pbPersonImage.Location = new System.Drawing.Point(5, 5);
            this.pbPersonImage.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pbPersonImage.Name = "pbPersonImage";
            this.pbPersonImage.Size = new System.Drawing.Size(485, 620);
            this.pbPersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPersonImage.TabIndex = 0;
            this.pbPersonImage.TabStop = false;
            // 
            // llSetImage
            // 
            this.llSetImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.llSetImage.AutoSize = true;
            this.llSetImage.Location = new System.Drawing.Point(198, 638);
            this.llSetImage.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.llSetImage.Name = "llSetImage";
            this.llSetImage.Size = new System.Drawing.Size(99, 28);
            this.llSetImage.TabIndex = 1;
            this.llSetImage.TabStop = true;
            this.llSetImage.Text = "Set Image";
            // 
            // llRemove
            // 
            this.llRemove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.llRemove.AutoSize = true;
            this.llRemove.Location = new System.Drawing.Point(206, 682);
            this.llRemove.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.llRemove.Name = "llRemove";
            this.llRemove.Size = new System.Drawing.Size(82, 28);
            this.llRemove.TabIndex = 2;
            this.llRemove.TabStop = true;
            this.llRemove.Text = "Remove";
            // 
            // tlpContainer
            // 
            this.tlpContainer.ColumnCount = 1;
            this.tlpContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpContainer.Controls.Add(this.tlpAddress, 0, 1);
            this.tlpContainer.Controls.Add(this.tlpFields, 0, 0);
            this.tlpContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContainer.Location = new System.Drawing.Point(5, 5);
            this.tlpContainer.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tlpContainer.Name = "tlpContainer";
            this.tlpContainer.RowCount = 2;
            this.tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 278F));
            this.tlpContainer.Size = new System.Drawing.Size(1166, 718);
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
            this.tlpAddress.Location = new System.Drawing.Point(5, 445);
            this.tlpAddress.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tlpAddress.Name = "tlpAddress";
            this.tlpAddress.RowCount = 2;
            this.tlpAddress.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tlpAddress.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAddress.Size = new System.Drawing.Size(1156, 268);
            this.tlpAddress.TabIndex = 25;
            // 
            // lblAddress
            // 
            this.lblAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddress.Image = global::DVLD_Enterprise_System.UI.Properties.Resources.Address_32;
            this.lblAddress.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAddress.Location = new System.Drawing.Point(5, 6);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(1146, 46);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "Address:";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbAddress
            // 
            this.tbAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAddress.Location = new System.Drawing.Point(5, 63);
            this.tbAddress.Margin = new System.Windows.Forms.Padding(5, 5, 31, 5);
            this.tbAddress.MaxLength = 500;
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.ReadOnly = true;
            this.tbAddress.Size = new System.Drawing.Size(1120, 200);
            this.tbAddress.TabIndex = 1;
            // 
            // tlpFields
            // 
            this.tlpFields.ColumnCount = 3;
            this.tlpFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpFields.Controls.Add(this.tlpEmail, 1, 3);
            this.tlpFields.Controls.Add(this.tlpCountry, 0, 3);
            this.tlpFields.Controls.Add(this.tlpGender, 2, 2);
            this.tlpFields.Controls.Add(this.tlpDateOfBirth, 1, 2);
            this.tlpFields.Controls.Add(this.tlpPhone, 0, 2);
            this.tlpFields.Controls.Add(this.tlpNationalNo, 2, 1);
            this.tlpFields.Controls.Add(this.tlpPersonID, 0, 0);
            this.tlpFields.Controls.Add(this.tlpLastName, 1, 1);
            this.tlpFields.Controls.Add(this.tlpThirdName, 0, 1);
            this.tlpFields.Controls.Add(this.tlpSecondName, 2, 0);
            this.tlpFields.Controls.Add(this.tlpFirstName, 1, 0);
            this.tlpFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFields.Location = new System.Drawing.Point(5, 5);
            this.tlpFields.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tlpFields.Name = "tlpFields";
            this.tlpFields.RowCount = 4;
            this.tlpFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpFields.Size = new System.Drawing.Size(1156, 430);
            this.tlpFields.TabIndex = 0;
            // 
            // tlpEmail
            // 
            this.tlpEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpEmail.ColumnCount = 1;
            this.tlpEmail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEmail.Controls.Add(this.lblEmail, 0, 0);
            this.tlpEmail.Controls.Add(this.tbEmail, 0, 1);
            this.tlpEmail.Location = new System.Drawing.Point(390, 326);
            this.tlpEmail.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tlpEmail.Name = "tlpEmail";
            this.tlpEmail.RowCount = 2;
            this.tlpEmail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEmail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpEmail.Size = new System.Drawing.Size(375, 99);
            this.tlpEmail.TabIndex = 23;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmail.Image = global::DVLD_Enterprise_System.UI.Properties.Resources.Email_32;
            this.lblEmail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEmail.Location = new System.Drawing.Point(5, 3);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(365, 48);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email:";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbEmail
            // 
            this.tbEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEmail.Location = new System.Drawing.Point(5, 60);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(5, 5, 31, 5);
            this.tbEmail.MaxLength = 50;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.ReadOnly = true;
            this.tbEmail.Size = new System.Drawing.Size(339, 34);
            this.tbEmail.TabIndex = 1;
            // 
            // tlpCountry
            // 
            this.tlpCountry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpCountry.ColumnCount = 1;
            this.tlpCountry.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCountry.Controls.Add(this.lblCountry, 0, 0);
            this.tlpCountry.Controls.Add(this.cbCountry, 0, 1);
            this.tlpCountry.Location = new System.Drawing.Point(5, 326);
            this.tlpCountry.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tlpCountry.Name = "tlpCountry";
            this.tlpCountry.RowCount = 2;
            this.tlpCountry.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.87719F));
            this.tlpCountry.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.12281F));
            this.tlpCountry.Size = new System.Drawing.Size(375, 99);
            this.tlpCountry.TabIndex = 22;
            // 
            // lblCountry
            // 
            this.lblCountry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCountry.Image = global::DVLD_Enterprise_System.UI.Properties.Resources.Country_32;
            this.lblCountry.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCountry.Location = new System.Drawing.Point(5, 4);
            this.lblCountry.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(365, 41);
            this.lblCountry.TabIndex = 0;
            this.lblCountry.Text = "Country:";
            this.lblCountry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbCountry
            // 
            this.cbCountry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCountry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCountry.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCountry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbCountry.DropDownHeight = 100;
            this.cbCountry.Enabled = false;
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.IntegralHeight = false;
            this.cbCountry.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cbCountry.Location = new System.Drawing.Point(5, 56);
            this.cbCountry.Margin = new System.Windows.Forms.Padding(5, 5, 31, 5);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(339, 36);
            this.cbCountry.TabIndex = 1;
            // 
            // tlpGender
            // 
            this.tlpGender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpGender.ColumnCount = 1;
            this.tlpGender.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpGender.Controls.Add(this.lblGender, 0, 0);
            this.tlpGender.Controls.Add(this.cbGender, 0, 1);
            this.tlpGender.Location = new System.Drawing.Point(775, 219);
            this.tlpGender.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tlpGender.Name = "tlpGender";
            this.tlpGender.RowCount = 2;
            this.tlpGender.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.87719F));
            this.tlpGender.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.12281F));
            this.tlpGender.Size = new System.Drawing.Size(376, 97);
            this.tlpGender.TabIndex = 21;
            // 
            // lblGender
            // 
            this.lblGender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGender.Image = global::DVLD_Enterprise_System.UI.Properties.Resources.Man_32;
            this.lblGender.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblGender.Location = new System.Drawing.Point(5, 4);
            this.lblGender.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(366, 41);
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
            this.cbGender.Location = new System.Drawing.Point(5, 55);
            this.cbGender.Margin = new System.Windows.Forms.Padding(5, 5, 31, 5);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(340, 36);
            this.cbGender.TabIndex = 1;
            // 
            // tlpDateOfBirth
            // 
            this.tlpDateOfBirth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpDateOfBirth.ColumnCount = 1;
            this.tlpDateOfBirth.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDateOfBirth.Controls.Add(this.lblDateOfBirth, 0, 0);
            this.tlpDateOfBirth.Controls.Add(this.dtpDateOfBirth, 0, 1);
            this.tlpDateOfBirth.Location = new System.Drawing.Point(390, 219);
            this.tlpDateOfBirth.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tlpDateOfBirth.Name = "tlpDateOfBirth";
            this.tlpDateOfBirth.RowCount = 2;
            this.tlpDateOfBirth.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDateOfBirth.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDateOfBirth.Size = new System.Drawing.Size(375, 97);
            this.tlpDateOfBirth.TabIndex = 20;
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateOfBirth.Image = global::DVLD_Enterprise_System.UI.Properties.Resources.Calendar_32;
            this.lblDateOfBirth.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDateOfBirth.Location = new System.Drawing.Point(5, 6);
            this.lblDateOfBirth.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(365, 41);
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
            this.dtpDateOfBirth.Location = new System.Drawing.Point(5, 58);
            this.dtpDateOfBirth.Margin = new System.Windows.Forms.Padding(5, 5, 31, 5);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(339, 34);
            this.dtpDateOfBirth.TabIndex = 1;
            this.dtpDateOfBirth.Value = new System.DateTime(2026, 7, 19, 0, 19, 27, 0);
            // 
            // tlpPhone
            // 
            this.tlpPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpPhone.ColumnCount = 1;
            this.tlpPhone.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPhone.Controls.Add(this.lblPhone, 0, 0);
            this.tlpPhone.Controls.Add(this.tbPhone, 0, 1);
            this.tlpPhone.Location = new System.Drawing.Point(5, 219);
            this.tlpPhone.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tlpPhone.Name = "tlpPhone";
            this.tlpPhone.RowCount = 2;
            this.tlpPhone.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPhone.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPhone.Size = new System.Drawing.Size(375, 97);
            this.tlpPhone.TabIndex = 19;
            // 
            // lblPhone
            // 
            this.lblPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPhone.Image = global::DVLD_Enterprise_System.UI.Properties.Resources.Phone_32;
            this.lblPhone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPhone.Location = new System.Drawing.Point(5, 3);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(365, 46);
            this.lblPhone.TabIndex = 0;
            this.lblPhone.Text = "Phone:";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbPhone
            // 
            this.tbPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPhone.Location = new System.Drawing.Point(5, 58);
            this.tbPhone.Margin = new System.Windows.Forms.Padding(5, 5, 31, 5);
            this.tbPhone.MaxLength = 20;
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.ReadOnly = true;
            this.tbPhone.Size = new System.Drawing.Size(339, 34);
            this.tbPhone.TabIndex = 1;
            // 
            // tlpNationalNo
            // 
            this.tlpNationalNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpNationalNo.ColumnCount = 1;
            this.tlpNationalNo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpNationalNo.Controls.Add(this.lblNationalNo, 0, 0);
            this.tlpNationalNo.Controls.Add(this.tbNationalNo, 0, 1);
            this.tlpNationalNo.Location = new System.Drawing.Point(775, 112);
            this.tlpNationalNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tlpNationalNo.Name = "tlpNationalNo";
            this.tlpNationalNo.RowCount = 2;
            this.tlpNationalNo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpNationalNo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpNationalNo.Size = new System.Drawing.Size(376, 97);
            this.tlpNationalNo.TabIndex = 18;
            // 
            // lblNationalNo
            // 
            this.lblNationalNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNationalNo.Image = global::DVLD_Enterprise_System.UI.Properties.Resources.Number_32;
            this.lblNationalNo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNationalNo.Location = new System.Drawing.Point(5, 3);
            this.lblNationalNo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNationalNo.Name = "lblNationalNo";
            this.lblNationalNo.Size = new System.Drawing.Size(366, 46);
            this.lblNationalNo.TabIndex = 0;
            this.lblNationalNo.Text = "National No:";
            this.lblNationalNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbNationalNo
            // 
            this.tbNationalNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNationalNo.Location = new System.Drawing.Point(5, 58);
            this.tbNationalNo.Margin = new System.Windows.Forms.Padding(5, 5, 31, 5);
            this.tbNationalNo.MaxLength = 20;
            this.tbNationalNo.Name = "tbNationalNo";
            this.tbNationalNo.ReadOnly = true;
            this.tbNationalNo.Size = new System.Drawing.Size(340, 34);
            this.tbNationalNo.TabIndex = 1;
            // 
            // tlpPersonID
            // 
            this.tlpPersonID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpPersonID.ColumnCount = 1;
            this.tlpPersonID.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPersonID.Controls.Add(this.lblPersonID, 0, 0);
            this.tlpPersonID.Controls.Add(this.tbPersonID, 0, 1);
            this.tlpPersonID.Location = new System.Drawing.Point(5, 5);
            this.tlpPersonID.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tlpPersonID.Name = "tlpPersonID";
            this.tlpPersonID.RowCount = 2;
            this.tlpPersonID.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPersonID.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPersonID.Size = new System.Drawing.Size(375, 97);
            this.tlpPersonID.TabIndex = 17;
            // 
            // lblPersonID
            // 
            this.lblPersonID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPersonID.Image = global::DVLD_Enterprise_System.UI.Properties.Resources.Number_32;
            this.lblPersonID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPersonID.Location = new System.Drawing.Point(5, 3);
            this.lblPersonID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(365, 46);
            this.lblPersonID.TabIndex = 0;
            this.lblPersonID.Text = "Person ID:";
            this.lblPersonID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbPersonID
            // 
            this.tbPersonID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPersonID.Location = new System.Drawing.Point(5, 58);
            this.tbPersonID.Margin = new System.Windows.Forms.Padding(5, 5, 31, 5);
            this.tbPersonID.Name = "tbPersonID";
            this.tbPersonID.ReadOnly = true;
            this.tbPersonID.Size = new System.Drawing.Size(339, 34);
            this.tbPersonID.TabIndex = 1;
            // 
            // tlpLastName
            // 
            this.tlpLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpLastName.ColumnCount = 1;
            this.tlpLastName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLastName.Controls.Add(this.lblLastName, 0, 0);
            this.tlpLastName.Controls.Add(this.tbLastName, 0, 1);
            this.tlpLastName.Location = new System.Drawing.Point(390, 112);
            this.tlpLastName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tlpLastName.Name = "tlpLastName";
            this.tlpLastName.RowCount = 2;
            this.tlpLastName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLastName.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpLastName.Size = new System.Drawing.Size(375, 97);
            this.tlpLastName.TabIndex = 16;
            // 
            // lblLastName
            // 
            this.lblLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLastName.Image = global::DVLD_Enterprise_System.UI.Properties.Resources.Person_32;
            this.lblLastName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLastName.Location = new System.Drawing.Point(5, 3);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(365, 46);
            this.lblLastName.TabIndex = 0;
            this.lblLastName.Text = "Last Name:";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbLastName
            // 
            this.tbLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLastName.Location = new System.Drawing.Point(5, 58);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(5, 5, 31, 5);
            this.tbLastName.MaxLength = 20;
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.ReadOnly = true;
            this.tbLastName.Size = new System.Drawing.Size(339, 34);
            this.tbLastName.TabIndex = 1;
            // 
            // tlpThirdName
            // 
            this.tlpThirdName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpThirdName.ColumnCount = 1;
            this.tlpThirdName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpThirdName.Controls.Add(this.lblThirdName, 0, 0);
            this.tlpThirdName.Controls.Add(this.tbThirdName, 0, 1);
            this.tlpThirdName.Location = new System.Drawing.Point(5, 112);
            this.tlpThirdName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tlpThirdName.Name = "tlpThirdName";
            this.tlpThirdName.RowCount = 2;
            this.tlpThirdName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpThirdName.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpThirdName.Size = new System.Drawing.Size(375, 97);
            this.tlpThirdName.TabIndex = 13;
            // 
            // lblThirdName
            // 
            this.lblThirdName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblThirdName.Image = global::DVLD_Enterprise_System.UI.Properties.Resources.Person_32;
            this.lblThirdName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblThirdName.Location = new System.Drawing.Point(5, 3);
            this.lblThirdName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblThirdName.Name = "lblThirdName";
            this.lblThirdName.Size = new System.Drawing.Size(365, 46);
            this.lblThirdName.TabIndex = 0;
            this.lblThirdName.Text = "Third Name:";
            this.lblThirdName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbThirdName
            // 
            this.tbThirdName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbThirdName.Location = new System.Drawing.Point(5, 58);
            this.tbThirdName.Margin = new System.Windows.Forms.Padding(5, 5, 31, 5);
            this.tbThirdName.MaxLength = 20;
            this.tbThirdName.Name = "tbThirdName";
            this.tbThirdName.ReadOnly = true;
            this.tbThirdName.Size = new System.Drawing.Size(339, 34);
            this.tbThirdName.TabIndex = 1;
            // 
            // tlpSecondName
            // 
            this.tlpSecondName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpSecondName.ColumnCount = 1;
            this.tlpSecondName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSecondName.Controls.Add(this.lblSecondName, 0, 0);
            this.tlpSecondName.Controls.Add(this.tbSecondName, 0, 1);
            this.tlpSecondName.Location = new System.Drawing.Point(775, 5);
            this.tlpSecondName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tlpSecondName.Name = "tlpSecondName";
            this.tlpSecondName.RowCount = 2;
            this.tlpSecondName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSecondName.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSecondName.Size = new System.Drawing.Size(376, 97);
            this.tlpSecondName.TabIndex = 12;
            // 
            // lblSecondName
            // 
            this.lblSecondName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSecondName.Image = global::DVLD_Enterprise_System.UI.Properties.Resources.Person_32;
            this.lblSecondName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSecondName.Location = new System.Drawing.Point(5, 3);
            this.lblSecondName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSecondName.Name = "lblSecondName";
            this.lblSecondName.Size = new System.Drawing.Size(366, 46);
            this.lblSecondName.TabIndex = 0;
            this.lblSecondName.Text = "Second Name:";
            this.lblSecondName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbSecondName
            // 
            this.tbSecondName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSecondName.Location = new System.Drawing.Point(5, 58);
            this.tbSecondName.Margin = new System.Windows.Forms.Padding(5, 5, 31, 5);
            this.tbSecondName.MaxLength = 20;
            this.tbSecondName.Name = "tbSecondName";
            this.tbSecondName.ReadOnly = true;
            this.tbSecondName.Size = new System.Drawing.Size(340, 34);
            this.tbSecondName.TabIndex = 1;
            // 
            // tlpFirstName
            // 
            this.tlpFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpFirstName.ColumnCount = 1;
            this.tlpFirstName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFirstName.Controls.Add(this.lblFirstName, 0, 0);
            this.tlpFirstName.Controls.Add(this.tbFirstName, 0, 1);
            this.tlpFirstName.Location = new System.Drawing.Point(390, 5);
            this.tlpFirstName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tlpFirstName.Name = "tlpFirstName";
            this.tlpFirstName.RowCount = 2;
            this.tlpFirstName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFirstName.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpFirstName.Size = new System.Drawing.Size(375, 97);
            this.tlpFirstName.TabIndex = 0;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFirstName.Image = global::DVLD_Enterprise_System.UI.Properties.Resources.Person_32;
            this.lblFirstName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFirstName.Location = new System.Drawing.Point(5, 3);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(365, 46);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name:";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFirstName.Location = new System.Drawing.Point(5, 58);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(5, 5, 31, 5);
            this.tbFirstName.MaxLength = 20;
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.ReadOnly = true;
            this.tbFirstName.Size = new System.Drawing.Size(339, 34);
            this.tbFirstName.TabIndex = 1;
            // 
            // ctrlPersonCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpBody);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "ctrlPersonCard";
            this.Size = new System.Drawing.Size(1681, 728);
            this.tlpBody.ResumeLayout(false);
            this.tlpImage.ResumeLayout(false);
            this.tlpImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).EndInit();
            this.tlpContainer.ResumeLayout(false);
            this.tlpAddress.ResumeLayout(false);
            this.tlpAddress.PerformLayout();
            this.tlpFields.ResumeLayout(false);
            this.tlpEmail.ResumeLayout(false);
            this.tlpEmail.PerformLayout();
            this.tlpCountry.ResumeLayout(false);
            this.tlpGender.ResumeLayout(false);
            this.tlpDateOfBirth.ResumeLayout(false);
            this.tlpPhone.ResumeLayout(false);
            this.tlpPhone.PerformLayout();
            this.tlpNationalNo.ResumeLayout(false);
            this.tlpNationalNo.PerformLayout();
            this.tlpPersonID.ResumeLayout(false);
            this.tlpPersonID.PerformLayout();
            this.tlpLastName.ResumeLayout(false);
            this.tlpLastName.PerformLayout();
            this.tlpThirdName.ResumeLayout(false);
            this.tlpThirdName.PerformLayout();
            this.tlpSecondName.ResumeLayout(false);
            this.tlpSecondName.PerformLayout();
            this.tlpFirstName.ResumeLayout(false);
            this.tlpFirstName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpBody;
        private System.Windows.Forms.TableLayoutPanel tlpImage;
        private System.Windows.Forms.PictureBox pbPersonImage;
        private System.Windows.Forms.LinkLabel llSetImage;
        private System.Windows.Forms.LinkLabel llRemove;
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
        private System.Windows.Forms.ComboBox cbCountry;
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
        private System.Windows.Forms.TableLayoutPanel tlpLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TableLayoutPanel tlpThirdName;
        private System.Windows.Forms.Label lblThirdName;
        private System.Windows.Forms.TextBox tbThirdName;
        private System.Windows.Forms.TableLayoutPanel tlpSecondName;
        private System.Windows.Forms.Label lblSecondName;
        private System.Windows.Forms.TextBox tbSecondName;
        private System.Windows.Forms.TableLayoutPanel tlpFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox tbFirstName;
    }
}
