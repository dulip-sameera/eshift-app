namespace eshift.View.Customer
{
    partial class UpdateCustomerForm
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
            txtZipCode = new TextBox();
            lblZipCode = new Label();
            txtCity = new TextBox();
            lblCity = new Label();
            tchTxtAddress = new RichTextBox();
            label1 = new Label();
            txtPhone = new TextBox();
            lblPhone = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtLastName = new TextBox();
            lblLastName = new Label();
            txtFirstName = new TextBox();
            btnCancel = new Button();
            btnUpdate = new Button();
            lblFirstName = new Label();
            lblFormTitle = new Label();
            lblFirstNameErrorMessage = new Label();
            lblLastNameErrorMessage = new Label();
            lblEmailErrorMessage = new Label();
            lblPhoneErrorMessage = new Label();
            lblCityErrorMessage = new Label();
            lblZipCodeErrorMessage = new Label();
            cmbStatus = new ComboBox();
            lblStatus = new Label();
            SuspendLayout();
            // 
            // txtZipCode
            // 
            txtZipCode.Font = new Font("Segoe UI", 11.25F);
            txtZipCode.Location = new Point(674, 373);
            txtZipCode.Margin = new Padding(3, 4, 3, 4);
            txtZipCode.Name = "txtZipCode";
            txtZipCode.Size = new Size(259, 32);
            txtZipCode.TabIndex = 69;
            // 
            // lblZipCode
            // 
            lblZipCode.AutoSize = true;
            lblZipCode.Font = new Font("Segoe UI Semibold", 12F);
            lblZipCode.Location = new Point(530, 370);
            lblZipCode.Name = "lblZipCode";
            lblZipCode.Size = new Size(94, 28);
            lblZipCode.TabIndex = 68;
            lblZipCode.Text = "Zip Code";
            // 
            // txtCity
            // 
            txtCity.Font = new Font("Segoe UI", 11.25F);
            txtCity.Location = new Point(674, 280);
            txtCity.Margin = new Padding(3, 4, 3, 4);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(259, 32);
            txtCity.TabIndex = 67;
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Font = new Font("Segoe UI Semibold", 12F);
            lblCity.Location = new Point(530, 282);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(46, 28);
            lblCity.TabIndex = 66;
            lblCity.Text = "City";
            // 
            // tchTxtAddress
            // 
            tchTxtAddress.Font = new Font("Segoe UI", 11.25F);
            tchTxtAddress.Location = new Point(674, 124);
            tchTxtAddress.Margin = new Padding(3, 4, 3, 4);
            tchTxtAddress.Name = "tchTxtAddress";
            tchTxtAddress.Size = new Size(259, 95);
            tchTxtAddress.TabIndex = 65;
            tchTxtAddress.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F);
            label1.Location = new Point(530, 124);
            label1.Name = "label1";
            label1.Size = new Size(85, 28);
            label1.TabIndex = 64;
            label1.Text = "Address";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 11.25F);
            txtPhone.Location = new Point(209, 360);
            txtPhone.Margin = new Padding(3, 4, 3, 4);
            txtPhone.MaxLength = 10;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(259, 32);
            txtPhone.TabIndex = 63;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI Semibold", 12F);
            lblPhone.Location = new Point(65, 357);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(71, 28);
            lblPhone.TabIndex = 62;
            lblPhone.Text = "Phone";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 11.25F);
            txtEmail.Location = new Point(209, 283);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(259, 32);
            txtEmail.TabIndex = 61;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Semibold", 12F);
            lblEmail.Location = new Point(65, 280);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(60, 28);
            lblEmail.TabIndex = 60;
            lblEmail.Text = "Email";
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 11.25F);
            txtLastName.Location = new Point(209, 197);
            txtLastName.Margin = new Padding(3, 4, 3, 4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(259, 32);
            txtLastName.TabIndex = 59;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI Semibold", 12F);
            lblLastName.Location = new Point(65, 200);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(108, 28);
            lblLastName.TabIndex = 58;
            lblLastName.Text = "Last Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 11.25F);
            txtFirstName.Location = new Point(209, 127);
            txtFirstName.Margin = new Padding(3, 4, 3, 4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(259, 32);
            txtFirstName.TabIndex = 57;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ButtonHighlight;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = SystemColors.WindowText;
            btnCancel.Location = new Point(816, 473);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Padding = new Padding(0, 7, 0, 7);
            btnCancel.Size = new Size(118, 49);
            btnCancel.TabIndex = 56;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.HotTrack;
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(674, 473);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Padding = new Padding(0, 7, 0, 7);
            btnUpdate.Size = new Size(118, 49);
            btnUpdate.TabIndex = 55;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI Semibold", 12F);
            lblFirstName.Location = new Point(63, 124);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(110, 28);
            lblFirstName.TabIndex = 54;
            lblFirstName.Text = "First Name";
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormTitle.ForeColor = SystemColors.WindowText;
            lblFormTitle.Location = new Point(31, 32);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(437, 37);
            lblFormTitle.TabIndex = 53;
            lblFormTitle.Text = "Update Customer #CUS202500021";
            // 
            // lblFirstNameErrorMessage
            // 
            lblFirstNameErrorMessage.AutoSize = true;
            lblFirstNameErrorMessage.ForeColor = Color.Red;
            lblFirstNameErrorMessage.Location = new Point(209, 163);
            lblFirstNameErrorMessage.Name = "lblFirstNameErrorMessage";
            lblFirstNameErrorMessage.Size = new Size(103, 20);
            lblFirstNameErrorMessage.TabIndex = 70;
            lblFirstNameErrorMessage.Text = "error message";
            // 
            // lblLastNameErrorMessage
            // 
            lblLastNameErrorMessage.AutoSize = true;
            lblLastNameErrorMessage.ForeColor = Color.Red;
            lblLastNameErrorMessage.Location = new Point(209, 233);
            lblLastNameErrorMessage.Name = "lblLastNameErrorMessage";
            lblLastNameErrorMessage.Size = new Size(103, 20);
            lblLastNameErrorMessage.TabIndex = 71;
            lblLastNameErrorMessage.Text = "error message";
            // 
            // lblEmailErrorMessage
            // 
            lblEmailErrorMessage.AutoSize = true;
            lblEmailErrorMessage.ForeColor = Color.Red;
            lblEmailErrorMessage.Location = new Point(209, 319);
            lblEmailErrorMessage.Name = "lblEmailErrorMessage";
            lblEmailErrorMessage.Size = new Size(103, 20);
            lblEmailErrorMessage.TabIndex = 72;
            lblEmailErrorMessage.Text = "error message";
            // 
            // lblPhoneErrorMessage
            // 
            lblPhoneErrorMessage.AutoSize = true;
            lblPhoneErrorMessage.ForeColor = Color.Red;
            lblPhoneErrorMessage.Location = new Point(209, 396);
            lblPhoneErrorMessage.Name = "lblPhoneErrorMessage";
            lblPhoneErrorMessage.Size = new Size(103, 20);
            lblPhoneErrorMessage.TabIndex = 73;
            lblPhoneErrorMessage.Text = "error message";
            // 
            // lblCityErrorMessage
            // 
            lblCityErrorMessage.AutoSize = true;
            lblCityErrorMessage.ForeColor = Color.Red;
            lblCityErrorMessage.Location = new Point(674, 316);
            lblCityErrorMessage.Name = "lblCityErrorMessage";
            lblCityErrorMessage.Size = new Size(103, 20);
            lblCityErrorMessage.TabIndex = 74;
            lblCityErrorMessage.Text = "error message";
            // 
            // lblZipCodeErrorMessage
            // 
            lblZipCodeErrorMessage.AutoSize = true;
            lblZipCodeErrorMessage.ForeColor = Color.Red;
            lblZipCodeErrorMessage.Location = new Point(674, 409);
            lblZipCodeErrorMessage.Name = "lblZipCodeErrorMessage";
            lblZipCodeErrorMessage.Size = new Size(103, 20);
            lblZipCodeErrorMessage.TabIndex = 75;
            lblZipCodeErrorMessage.Text = "error message";
            // 
            // cmbStatus
            // 
            cmbStatus.BackColor = SystemColors.Window;
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "ACTIVE", "DELETED" });
            cmbStatus.Location = new Point(209, 456);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(259, 28);
            cmbStatus.TabIndex = 76;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI Semibold", 12F);
            lblStatus.Location = new Point(65, 456);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(67, 28);
            lblStatus.TabIndex = 77;
            lblStatus.Text = "Status";
            // 
            // UpdateCustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1087, 568);
            Controls.Add(lblStatus);
            Controls.Add(cmbStatus);
            Controls.Add(lblZipCodeErrorMessage);
            Controls.Add(lblCityErrorMessage);
            Controls.Add(lblPhoneErrorMessage);
            Controls.Add(lblEmailErrorMessage);
            Controls.Add(lblLastNameErrorMessage);
            Controls.Add(lblFirstNameErrorMessage);
            Controls.Add(txtZipCode);
            Controls.Add(lblZipCode);
            Controls.Add(txtCity);
            Controls.Add(lblCity);
            Controls.Add(tchTxtAddress);
            Controls.Add(label1);
            Controls.Add(txtPhone);
            Controls.Add(lblPhone);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtLastName);
            Controls.Add(lblLastName);
            Controls.Add(txtFirstName);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(lblFirstName);
            Controls.Add(lblFormTitle);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "UpdateCustomerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Update Customer Form";
            Load += UpdateCustomerForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtZipCode;
        private Label lblZipCode;
        private TextBox txtCity;
        private Label lblCity;
        private RichTextBox tchTxtAddress;
        private Label label1;
        private TextBox txtPhone;
        private Label lblPhone;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtLastName;
        private Label lblLastName;
        private TextBox txtFirstName;
        private Button btnCancel;
        private Button btnUpdate;
        private Label lblFirstName;
        private Label lblFormTitle;
        private Label lblFirstNameErrorMessage;
        private Label lblLastNameErrorMessage;
        private Label lblEmailErrorMessage;
        private Label lblPhoneErrorMessage;
        private Label lblCityErrorMessage;
        private Label lblZipCodeErrorMessage;
        private ComboBox cmbStatus;
        private Label lblStatus;
    }
}