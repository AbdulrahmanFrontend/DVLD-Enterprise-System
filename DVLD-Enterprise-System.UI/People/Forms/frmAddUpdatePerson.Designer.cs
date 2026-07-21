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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUpdatePerson));
            this.epPerson = new System.Windows.Forms.ErrorProvider(this.components);
            this.flpFooter = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tlpBody = new System.Windows.Forms.TableLayoutPanel();
            this.tlpImage = new System.Windows.Forms.TableLayoutPanel();
            this.llSetImage = new System.Windows.Forms.LinkLabel();
            this.llRemoveImage = new System.Windows.Forms.LinkLabel();
            this.tlpContainer = new System.Windows.Forms.TableLayoutPanel();
            this.tlpAddress = new System.Windows.Forms.TableLayoutPanel();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.tlpFields = new System.Windows.Forms.TableLayoutPanel();
            this.tlpEmail = new System.Windows.Forms.TableLayoutPanel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.tlpCountry = new System.Windows.Forms.TableLayoutPanel();
            this.cbCountries = new System.Windows.Forms.ComboBox();
            this.tlpGender = new System.Windows.Forms.TableLayoutPanel();
            this.cbGenders = new System.Windows.Forms.ComboBox();
            this.tlpDateOfBirth = new System.Windows.Forms.TableLayoutPanel();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.tlpPhone = new System.Windows.Forms.TableLayoutPanel();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.tlpNationalNo = new System.Windows.Forms.TableLayoutPanel();
            this.txtNationalNo = new System.Windows.Forms.TextBox();
            this.tlpPersonID = new System.Windows.Forms.TableLayoutPanel();
            this.tbPersonID = new System.Windows.Forms.TextBox();
            this.tlpLastName = new System.Windows.Forms.TableLayoutPanel();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.tlpThirdName = new System.Windows.Forms.TableLayoutPanel();
            this.txtThirdName = new System.Windows.Forms.TextBox();
            this.tlpSecondName = new System.Windows.Forms.TableLayoutPanel();
            this.txtSecondName = new System.Windows.Forms.TextBox();
            this.tlpFirstName = new System.Windows.Forms.TableLayoutPanel();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.ofdPersonImage = new System.Windows.Forms.OpenFileDialog();
            this.ctrlbtnSave = new DevToolkit.BaseWinForms.Controls.CustomControls.ccButton();
            this.ctrlbtnClose = new DevToolkit.BaseWinForms.Controls.CustomControls.ccButton();
            this.pbPersonImage = new System.Windows.Forms.PictureBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblNationalNo = new System.Windows.Forms.Label();
            this.lblPersonID = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblThirdName = new System.Windows.Forms.Label();
            this.lblSecondName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.epPerson)).BeginInit();
            this.flpFooter.SuspendLayout();
            this.tlpBody.SuspendLayout();
            this.tlpImage.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).BeginInit();
            this.SuspendLayout();
            // 
            // epPerson
            // 
            this.epPerson.ContainerControl = this;
            // 
            // flpFooter
            // 
            this.flpFooter.AutoSize = true;
            this.flpFooter.Controls.Add(this.ctrlbtnClose);
            this.flpFooter.Controls.Add(this.ctrlbtnSave);
            this.flpFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpFooter.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpFooter.Location = new System.Drawing.Point(0, 515);
            this.flpFooter.Name = "flpFooter";
            this.flpFooter.Size = new System.Drawing.Size(1073, 43);
            this.flpFooter.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1073, 39);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Add New Person";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpBody
            // 
            this.tlpBody.ColumnCount = 2;
            this.tlpBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpBody.Controls.Add(this.tlpImage, 1, 0);
            this.tlpBody.Controls.Add(this.tlpContainer, 0, 0);
            this.tlpBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBody.Location = new System.Drawing.Point(0, 39);
            this.tlpBody.Name = "tlpBody";
            this.tlpBody.RowCount = 1;
            this.tlpBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBody.Size = new System.Drawing.Size(1073, 476);
            this.tlpBody.TabIndex = 4;
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
            this.tlpImage.Controls.Add(this.llRemoveImage, 0, 2);
            this.tlpImage.Location = new System.Drawing.Point(754, 3);
            this.tlpImage.Name = "tlpImage";
            this.tlpImage.RowCount = 3;
            this.tlpImage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpImage.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpImage.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpImage.Size = new System.Drawing.Size(316, 470);
            this.tlpImage.TabIndex = 6;
            // 
            // llSetImage
            // 
            this.llSetImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.llSetImage.AutoSize = true;
            this.llSetImage.Location = new System.Drawing.Point(125, 421);
            this.llSetImage.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.llSetImage.Name = "llSetImage";
            this.llSetImage.Size = new System.Drawing.Size(66, 17);
            this.llSetImage.TabIndex = 1;
            this.llSetImage.TabStop = true;
            this.llSetImage.Text = "Set Image";
            // 
            // llRemoveImage
            // 
            this.llRemoveImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.llRemoveImage.AutoSize = true;
            this.llRemoveImage.Location = new System.Drawing.Point(130, 448);
            this.llRemoveImage.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.llRemoveImage.Name = "llRemoveImage";
            this.llRemoveImage.Size = new System.Drawing.Size(55, 17);
            this.llRemoveImage.TabIndex = 2;
            this.llRemoveImage.TabStop = true;
            this.llRemoveImage.Text = "Remove";
            this.llRemoveImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llRemoveImage_LinkClicked);
            // 
            // tlpContainer
            // 
            this.tlpContainer.ColumnCount = 1;
            this.tlpContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpContainer.Controls.Add(this.tlpAddress, 0, 1);
            this.tlpContainer.Controls.Add(this.tlpFields, 0, 0);
            this.tlpContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContainer.Location = new System.Drawing.Point(3, 3);
            this.tlpContainer.Name = "tlpContainer";
            this.tlpContainer.RowCount = 2;
            this.tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tlpContainer.Size = new System.Drawing.Size(745, 470);
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
            this.tlpAddress.Controls.Add(this.txtAddress, 0, 1);
            this.tlpAddress.Location = new System.Drawing.Point(3, 293);
            this.tlpAddress.Name = "tlpAddress";
            this.tlpAddress.RowCount = 2;
            this.tlpAddress.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpAddress.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAddress.Size = new System.Drawing.Size(739, 174);
            this.tlpAddress.TabIndex = 25;
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.Location = new System.Drawing.Point(3, 25);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 3, 18, 3);
            this.txtAddress.MaxLength = 500;
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(718, 146);
            this.txtAddress.TabIndex = 1;
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
            this.tlpFields.Location = new System.Drawing.Point(3, 3);
            this.tlpFields.Name = "tlpFields";
            this.tlpFields.RowCount = 4;
            this.tlpFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpFields.Size = new System.Drawing.Size(739, 284);
            this.tlpFields.TabIndex = 0;
            // 
            // tlpEmail
            // 
            this.tlpEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpEmail.ColumnCount = 1;
            this.tlpEmail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEmail.Controls.Add(this.lblEmail, 0, 0);
            this.tlpEmail.Controls.Add(this.txtEmail, 0, 1);
            this.tlpEmail.Location = new System.Drawing.Point(249, 216);
            this.tlpEmail.Name = "tlpEmail";
            this.tlpEmail.RowCount = 2;
            this.tlpEmail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEmail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpEmail.Size = new System.Drawing.Size(240, 65);
            this.tlpEmail.TabIndex = 23;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Location = new System.Drawing.Point(3, 37);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 3, 18, 3);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(219, 25);
            this.txtEmail.TabIndex = 1;
            // 
            // tlpCountry
            // 
            this.tlpCountry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpCountry.ColumnCount = 1;
            this.tlpCountry.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCountry.Controls.Add(this.lblCountry, 0, 0);
            this.tlpCountry.Controls.Add(this.cbCountries, 0, 1);
            this.tlpCountry.Location = new System.Drawing.Point(3, 216);
            this.tlpCountry.Name = "tlpCountry";
            this.tlpCountry.RowCount = 2;
            this.tlpCountry.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.87719F));
            this.tlpCountry.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.12281F));
            this.tlpCountry.Size = new System.Drawing.Size(240, 65);
            this.tlpCountry.TabIndex = 22;
            // 
            // cbCountries
            // 
            this.cbCountries.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCountries.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCountries.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCountries.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbCountries.DropDownHeight = 100;
            this.cbCountries.FormattingEnabled = true;
            this.cbCountries.IntegralHeight = false;
            this.cbCountries.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cbCountries.Location = new System.Drawing.Point(3, 36);
            this.cbCountries.Margin = new System.Windows.Forms.Padding(3, 3, 18, 3);
            this.cbCountries.Name = "cbCountries";
            this.cbCountries.Size = new System.Drawing.Size(219, 25);
            this.cbCountries.TabIndex = 1;
            // 
            // tlpGender
            // 
            this.tlpGender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpGender.ColumnCount = 1;
            this.tlpGender.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpGender.Controls.Add(this.lblGender, 0, 0);
            this.tlpGender.Controls.Add(this.cbGenders, 0, 1);
            this.tlpGender.Location = new System.Drawing.Point(495, 145);
            this.tlpGender.Name = "tlpGender";
            this.tlpGender.RowCount = 2;
            this.tlpGender.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.87719F));
            this.tlpGender.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.12281F));
            this.tlpGender.Size = new System.Drawing.Size(241, 64);
            this.tlpGender.TabIndex = 21;
            // 
            // cbGenders
            // 
            this.cbGenders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbGenders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbGenders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGenders.FormattingEnabled = true;
            this.cbGenders.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cbGenders.Location = new System.Drawing.Point(3, 35);
            this.cbGenders.Margin = new System.Windows.Forms.Padding(3, 3, 18, 3);
            this.cbGenders.Name = "cbGenders";
            this.cbGenders.Size = new System.Drawing.Size(220, 25);
            this.cbGenders.TabIndex = 1;
            this.cbGenders.SelectedIndexChanged += new System.EventHandler(this.cbGenders_SelectedIndexChanged);
            // 
            // tlpDateOfBirth
            // 
            this.tlpDateOfBirth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpDateOfBirth.ColumnCount = 1;
            this.tlpDateOfBirth.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDateOfBirth.Controls.Add(this.lblDateOfBirth, 0, 0);
            this.tlpDateOfBirth.Controls.Add(this.dtpDateOfBirth, 0, 1);
            this.tlpDateOfBirth.Location = new System.Drawing.Point(249, 145);
            this.tlpDateOfBirth.Name = "tlpDateOfBirth";
            this.tlpDateOfBirth.RowCount = 2;
            this.tlpDateOfBirth.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDateOfBirth.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDateOfBirth.Size = new System.Drawing.Size(240, 64);
            this.tlpDateOfBirth.TabIndex = 20;
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDateOfBirth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpDateOfBirth.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(3, 36);
            this.dtpDateOfBirth.Margin = new System.Windows.Forms.Padding(3, 3, 18, 3);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(219, 25);
            this.dtpDateOfBirth.TabIndex = 1;
            this.dtpDateOfBirth.Value = new System.DateTime(2026, 7, 19, 0, 19, 27, 0);
            // 
            // tlpPhone
            // 
            this.tlpPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpPhone.ColumnCount = 1;
            this.tlpPhone.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPhone.Controls.Add(this.lblPhone, 0, 0);
            this.tlpPhone.Controls.Add(this.txtPhone, 0, 1);
            this.tlpPhone.Location = new System.Drawing.Point(3, 145);
            this.tlpPhone.Name = "tlpPhone";
            this.tlpPhone.RowCount = 2;
            this.tlpPhone.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPhone.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPhone.Size = new System.Drawing.Size(240, 64);
            this.tlpPhone.TabIndex = 19;
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhone.Location = new System.Drawing.Point(3, 36);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 3, 18, 3);
            this.txtPhone.MaxLength = 20;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(219, 25);
            this.txtPhone.TabIndex = 1;
            // 
            // tlpNationalNo
            // 
            this.tlpNationalNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpNationalNo.ColumnCount = 1;
            this.tlpNationalNo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpNationalNo.Controls.Add(this.lblNationalNo, 0, 0);
            this.tlpNationalNo.Controls.Add(this.txtNationalNo, 0, 1);
            this.tlpNationalNo.Location = new System.Drawing.Point(495, 74);
            this.tlpNationalNo.Name = "tlpNationalNo";
            this.tlpNationalNo.RowCount = 2;
            this.tlpNationalNo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpNationalNo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpNationalNo.Size = new System.Drawing.Size(241, 64);
            this.tlpNationalNo.TabIndex = 18;
            // 
            // txtNationalNo
            // 
            this.txtNationalNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNationalNo.Location = new System.Drawing.Point(3, 36);
            this.txtNationalNo.Margin = new System.Windows.Forms.Padding(3, 3, 18, 3);
            this.txtNationalNo.MaxLength = 20;
            this.txtNationalNo.Name = "txtNationalNo";
            this.txtNationalNo.Size = new System.Drawing.Size(220, 25);
            this.txtNationalNo.TabIndex = 1;
            // 
            // tlpPersonID
            // 
            this.tlpPersonID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpPersonID.ColumnCount = 1;
            this.tlpPersonID.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPersonID.Controls.Add(this.lblPersonID, 0, 0);
            this.tlpPersonID.Controls.Add(this.tbPersonID, 0, 1);
            this.tlpPersonID.Location = new System.Drawing.Point(3, 3);
            this.tlpPersonID.Name = "tlpPersonID";
            this.tlpPersonID.RowCount = 2;
            this.tlpPersonID.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPersonID.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPersonID.Size = new System.Drawing.Size(240, 64);
            this.tlpPersonID.TabIndex = 17;
            // 
            // tbPersonID
            // 
            this.tbPersonID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPersonID.Location = new System.Drawing.Point(3, 36);
            this.tbPersonID.Margin = new System.Windows.Forms.Padding(3, 3, 18, 3);
            this.tbPersonID.Name = "tbPersonID";
            this.tbPersonID.ReadOnly = true;
            this.tbPersonID.Size = new System.Drawing.Size(219, 25);
            this.tbPersonID.TabIndex = 1;
            // 
            // tlpLastName
            // 
            this.tlpLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpLastName.ColumnCount = 1;
            this.tlpLastName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLastName.Controls.Add(this.lblLastName, 0, 0);
            this.tlpLastName.Controls.Add(this.txtLastName, 0, 1);
            this.tlpLastName.Location = new System.Drawing.Point(249, 74);
            this.tlpLastName.Name = "tlpLastName";
            this.tlpLastName.RowCount = 2;
            this.tlpLastName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLastName.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpLastName.Size = new System.Drawing.Size(240, 64);
            this.tlpLastName.TabIndex = 16;
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLastName.Location = new System.Drawing.Point(3, 36);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(3, 3, 18, 3);
            this.txtLastName.MaxLength = 20;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(219, 25);
            this.txtLastName.TabIndex = 1;
            // 
            // tlpThirdName
            // 
            this.tlpThirdName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpThirdName.ColumnCount = 1;
            this.tlpThirdName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpThirdName.Controls.Add(this.lblThirdName, 0, 0);
            this.tlpThirdName.Controls.Add(this.txtThirdName, 0, 1);
            this.tlpThirdName.Location = new System.Drawing.Point(3, 74);
            this.tlpThirdName.Name = "tlpThirdName";
            this.tlpThirdName.RowCount = 2;
            this.tlpThirdName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpThirdName.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpThirdName.Size = new System.Drawing.Size(240, 64);
            this.tlpThirdName.TabIndex = 13;
            // 
            // txtThirdName
            // 
            this.txtThirdName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtThirdName.Location = new System.Drawing.Point(3, 36);
            this.txtThirdName.Margin = new System.Windows.Forms.Padding(3, 3, 18, 3);
            this.txtThirdName.MaxLength = 20;
            this.txtThirdName.Name = "txtThirdName";
            this.txtThirdName.Size = new System.Drawing.Size(219, 25);
            this.txtThirdName.TabIndex = 1;
            // 
            // tlpSecondName
            // 
            this.tlpSecondName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpSecondName.ColumnCount = 1;
            this.tlpSecondName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSecondName.Controls.Add(this.lblSecondName, 0, 0);
            this.tlpSecondName.Controls.Add(this.txtSecondName, 0, 1);
            this.tlpSecondName.Location = new System.Drawing.Point(495, 3);
            this.tlpSecondName.Name = "tlpSecondName";
            this.tlpSecondName.RowCount = 2;
            this.tlpSecondName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSecondName.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSecondName.Size = new System.Drawing.Size(241, 64);
            this.tlpSecondName.TabIndex = 12;
            // 
            // txtSecondName
            // 
            this.txtSecondName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSecondName.Location = new System.Drawing.Point(3, 36);
            this.txtSecondName.Margin = new System.Windows.Forms.Padding(3, 3, 18, 3);
            this.txtSecondName.MaxLength = 20;
            this.txtSecondName.Name = "txtSecondName";
            this.txtSecondName.Size = new System.Drawing.Size(220, 25);
            this.txtSecondName.TabIndex = 1;
            // 
            // tlpFirstName
            // 
            this.tlpFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpFirstName.ColumnCount = 1;
            this.tlpFirstName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFirstName.Controls.Add(this.lblFirstName, 0, 0);
            this.tlpFirstName.Controls.Add(this.txtFirstName, 0, 1);
            this.tlpFirstName.Location = new System.Drawing.Point(249, 3);
            this.tlpFirstName.Name = "tlpFirstName";
            this.tlpFirstName.RowCount = 2;
            this.tlpFirstName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFirstName.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpFirstName.Size = new System.Drawing.Size(240, 64);
            this.tlpFirstName.TabIndex = 0;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFirstName.Location = new System.Drawing.Point(3, 36);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(3, 3, 18, 3);
            this.txtFirstName.MaxLength = 20;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(219, 25);
            this.txtFirstName.TabIndex = 1;
            // 
            // ofdPersonImage
            // 
            this.ofdPersonImage.FileName = "openFileDialog1";
            // 
            // ctrlbtnSave
            // 
            this.ctrlbtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.ctrlbtnSave.ButtonStyle = DevToolkit.BaseWinForms.Theming.ButtonStyle.Success;
            this.ctrlbtnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctrlbtnSave.FlatAppearance.BorderSize = 0;
            this.ctrlbtnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(101)))), ((int)(((byte)(47)))));
            this.ctrlbtnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(145)))), ((int)(((byte)(74)))));
            this.ctrlbtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ctrlbtnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.ctrlbtnSave.ForeColor = System.Drawing.Color.White;
            this.ctrlbtnSave.Image = global::DVLD_Enterprise_System.UI.Properties.Resources.Save_32;
            this.ctrlbtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ctrlbtnSave.Location = new System.Drawing.Point(850, 3);
            this.ctrlbtnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ctrlbtnSave.Name = "ctrlbtnSave";
            this.ctrlbtnSave.Padding = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.ctrlbtnSave.Size = new System.Drawing.Size(106, 37);
            this.ctrlbtnSave.TabIndex = 1;
            this.ctrlbtnSave.Text = "Save";
            this.ctrlbtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ctrlbtnSave.UseVisualStyleBackColor = false;
            // 
            // ctrlbtnClose
            // 
            this.ctrlbtnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.ctrlbtnClose.ButtonStyle = DevToolkit.BaseWinForms.Theming.ButtonStyle.Primary;
            this.ctrlbtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctrlbtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ctrlbtnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.ctrlbtnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.ctrlbtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.ctrlbtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ctrlbtnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.ctrlbtnClose.ForeColor = System.Drawing.Color.White;
            this.ctrlbtnClose.Image = global::DVLD_Enterprise_System.UI.Properties.Resources.Close_32;
            this.ctrlbtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ctrlbtnClose.Location = new System.Drawing.Point(963, 3);
            this.ctrlbtnClose.Margin = new System.Windows.Forms.Padding(3, 3, 4, 3);
            this.ctrlbtnClose.Name = "ctrlbtnClose";
            this.ctrlbtnClose.Padding = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.ctrlbtnClose.Size = new System.Drawing.Size(106, 37);
            this.ctrlbtnClose.TabIndex = 2;
            this.ctrlbtnClose.Text = "Close";
            this.ctrlbtnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ctrlbtnClose.UseVisualStyleBackColor = false;
            // 
            // pbPersonImage
            // 
            this.pbPersonImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbPersonImage.Image = global::DVLD_Enterprise_System.UI.Properties.Resources.Male_512;
            this.pbPersonImage.Location = new System.Drawing.Point(3, 3);
            this.pbPersonImage.Name = "pbPersonImage";
            this.pbPersonImage.Size = new System.Drawing.Size(310, 410);
            this.pbPersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPersonImage.TabIndex = 0;
            this.pbPersonImage.TabStop = false;
            // 
            // lblAddress
            // 
            this.lblAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddress.Image = global::DVLD_Enterprise_System.UI.Properties.Resources.Address_32;
            this.lblAddress.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAddress.Location = new System.Drawing.Point(3, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(733, 22);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "Address:";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmail.Image = global::DVLD_Enterprise_System.UI.Properties.Resources.Email_32;
            this.lblEmail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEmail.Location = new System.Drawing.Point(3, 1);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(234, 31);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email:";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCountry
            // 
            this.lblCountry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCountry.Image = global::DVLD_Enterprise_System.UI.Properties.Resources.Country_32;
            this.lblCountry.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCountry.Location = new System.Drawing.Point(3, 3);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(234, 27);
            this.lblCountry.TabIndex = 0;
            this.lblCountry.Text = "Country:";
            this.lblCountry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGender
            // 
            this.lblGender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGender.Image = global::DVLD_Enterprise_System.UI.Properties.Resources.Man_32;
            this.lblGender.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblGender.Location = new System.Drawing.Point(3, 2);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(235, 27);
            this.lblGender.TabIndex = 0;
            this.lblGender.Text = "Gender:";
            this.lblGender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateOfBirth.Image = global::DVLD_Enterprise_System.UI.Properties.Resources.Calendar_32;
            this.lblDateOfBirth.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDateOfBirth.Location = new System.Drawing.Point(3, 1);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(234, 31);
            this.lblDateOfBirth.TabIndex = 0;
            this.lblDateOfBirth.Text = "Date Of Birth:";
            this.lblDateOfBirth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPhone
            // 
            this.lblPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPhone.Image = global::DVLD_Enterprise_System.UI.Properties.Resources.Phone_32;
            this.lblPhone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPhone.Location = new System.Drawing.Point(3, 1);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(234, 31);
            this.lblPhone.TabIndex = 0;
            this.lblPhone.Text = "Phone:";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNationalNo
            // 
            this.lblNationalNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNationalNo.Image = global::DVLD_Enterprise_System.UI.Properties.Resources.Number_32;
            this.lblNationalNo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNationalNo.Location = new System.Drawing.Point(3, 1);
            this.lblNationalNo.Name = "lblNationalNo";
            this.lblNationalNo.Size = new System.Drawing.Size(235, 31);
            this.lblNationalNo.TabIndex = 0;
            this.lblNationalNo.Text = "National No:";
            this.lblNationalNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPersonID
            // 
            this.lblPersonID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPersonID.Image = global::DVLD_Enterprise_System.UI.Properties.Resources.Number_32;
            this.lblPersonID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPersonID.Location = new System.Drawing.Point(3, 1);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(234, 31);
            this.lblPersonID.TabIndex = 0;
            this.lblPersonID.Text = "Person ID:";
            this.lblPersonID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLastName
            // 
            this.lblLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLastName.Image = global::DVLD_Enterprise_System.UI.Properties.Resources.Person_32;
            this.lblLastName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLastName.Location = new System.Drawing.Point(3, 1);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(234, 31);
            this.lblLastName.TabIndex = 0;
            this.lblLastName.Text = "Last Name:";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblThirdName
            // 
            this.lblThirdName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblThirdName.Image = global::DVLD_Enterprise_System.UI.Properties.Resources.Person_32;
            this.lblThirdName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblThirdName.Location = new System.Drawing.Point(3, 1);
            this.lblThirdName.Name = "lblThirdName";
            this.lblThirdName.Size = new System.Drawing.Size(234, 31);
            this.lblThirdName.TabIndex = 0;
            this.lblThirdName.Text = "Third Name:";
            this.lblThirdName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSecondName
            // 
            this.lblSecondName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSecondName.Image = global::DVLD_Enterprise_System.UI.Properties.Resources.Person_32;
            this.lblSecondName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSecondName.Location = new System.Drawing.Point(3, 1);
            this.lblSecondName.Name = "lblSecondName";
            this.lblSecondName.Size = new System.Drawing.Size(235, 31);
            this.lblSecondName.TabIndex = 0;
            this.lblSecondName.Text = "Second Name:";
            this.lblSecondName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFirstName.Image = global::DVLD_Enterprise_System.UI.Properties.Resources.Person_32;
            this.lblFirstName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFirstName.Location = new System.Drawing.Point(3, 1);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(234, 31);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name:";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmAddUpdatePerson
            // 
            this.AcceptButton = this.ctrlbtnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.CancelButton = this.ctrlbtnClose;
            this.ClientSize = new System.Drawing.Size(1073, 558);
            this.Controls.Add(this.tlpBody);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.flpFooter);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddUpdatePerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmAddUpdatePerson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epPerson)).EndInit();
            this.flpFooter.ResumeLayout(false);
            this.tlpBody.ResumeLayout(false);
            this.tlpImage.ResumeLayout(false);
            this.tlpImage.PerformLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider epPerson;
        private System.Windows.Forms.FlowLayoutPanel flpFooter;
        private System.Windows.Forms.Label lblTitle;
        private DevToolkit.BaseWinForms.Controls.CustomControls.ccButton ctrlbtnClose;
        private DevToolkit.BaseWinForms.Controls.CustomControls.ccButton ctrlbtnSave;
        private System.Windows.Forms.TableLayoutPanel tlpBody;
        private System.Windows.Forms.TableLayoutPanel tlpImage;
        private System.Windows.Forms.PictureBox pbPersonImage;
        private System.Windows.Forms.LinkLabel llSetImage;
        private System.Windows.Forms.LinkLabel llRemoveImage;
        private System.Windows.Forms.TableLayoutPanel tlpContainer;
        private System.Windows.Forms.TableLayoutPanel tlpAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TableLayoutPanel tlpFields;
        private System.Windows.Forms.TableLayoutPanel tlpEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TableLayoutPanel tlpCountry;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.ComboBox cbCountries;
        private System.Windows.Forms.TableLayoutPanel tlpGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cbGenders;
        private System.Windows.Forms.TableLayoutPanel tlpDateOfBirth;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.TableLayoutPanel tlpPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TableLayoutPanel tlpNationalNo;
        private System.Windows.Forms.Label lblNationalNo;
        private System.Windows.Forms.TextBox txtNationalNo;
        private System.Windows.Forms.TableLayoutPanel tlpPersonID;
        private System.Windows.Forms.Label lblPersonID;
        private System.Windows.Forms.TextBox tbPersonID;
        private System.Windows.Forms.TableLayoutPanel tlpLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TableLayoutPanel tlpThirdName;
        private System.Windows.Forms.Label lblThirdName;
        private System.Windows.Forms.TextBox txtThirdName;
        private System.Windows.Forms.TableLayoutPanel tlpSecondName;
        private System.Windows.Forms.Label lblSecondName;
        private System.Windows.Forms.TextBox txtSecondName;
        private System.Windows.Forms.TableLayoutPanel tlpFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.OpenFileDialog ofdPersonImage;
    }
}