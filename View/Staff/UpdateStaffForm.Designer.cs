namespace eshift.View.Staff
{
    partial class UpdateStaffForm
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
            lblPosition = new Label();
            cmbPosition = new ComboBox();
            txtLicenseNumber = new TextBox();
            lblLicenseNumber = new Label();
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
            lblLicenseNumberErrorMessage = new Label();
            lblPositionErrorMessage = new Label();
            label1 = new Label();
            lblStatus = new Label();
            cmbStatus = new ComboBox();
            SuspendLayout();
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Font = new Font("Segoe UI Semibold", 12F);
            lblPosition.Location = new Point(69, 494);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(85, 28);
            lblPosition.TabIndex = 82;
            lblPosition.Text = "Position";
            // 
            // cmbPosition
            // 
            cmbPosition.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPosition.Font = new Font("Segoe UI", 11.25F);
            cmbPosition.FormattingEnabled = true;
            cmbPosition.Items.AddRange(new object[] { "ADMIN", "DRIVER", "ASSISTANT" });
            cmbPosition.Location = new Point(213, 492);
            cmbPosition.Margin = new Padding(3, 4, 3, 4);
            cmbPosition.Name = "cmbPosition";
            cmbPosition.Size = new Size(259, 33);
            cmbPosition.TabIndex = 81;
            // 
            // txtLicenseNumber
            // 
            txtLicenseNumber.Font = new Font("Segoe UI", 11.25F);
            txtLicenseNumber.Location = new Point(213, 405);
            txtLicenseNumber.Margin = new Padding(3, 4, 3, 4);
            txtLicenseNumber.Name = "txtLicenseNumber";
            txtLicenseNumber.PlaceholderText = "*Optional unless you are a driver";
            txtLicenseNumber.Size = new Size(259, 32);
            txtLicenseNumber.TabIndex = 80;
            // 
            // lblLicenseNumber
            // 
            lblLicenseNumber.AutoSize = true;
            lblLicenseNumber.Font = new Font("Segoe UI Semibold", 12F);
            lblLicenseNumber.Location = new Point(69, 402);
            lblLicenseNumber.Name = "lblLicenseNumber";
            lblLicenseNumber.Size = new Size(112, 28);
            lblLicenseNumber.TabIndex = 79;
            lblLicenseNumber.Text = "License No";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 11.25F);
            txtPhone.Location = new Point(213, 321);
            txtPhone.Margin = new Padding(3, 4, 3, 4);
            txtPhone.MaxLength = 10;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(259, 32);
            txtPhone.TabIndex = 78;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI Semibold", 12F);
            lblPhone.Location = new Point(69, 318);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(71, 28);
            lblPhone.TabIndex = 77;
            lblPhone.Text = "Phone";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 11.25F);
            txtEmail.Location = new Point(213, 244);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(259, 32);
            txtEmail.TabIndex = 76;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Semibold", 12F);
            lblEmail.Location = new Point(69, 241);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(60, 28);
            lblEmail.TabIndex = 75;
            lblEmail.Text = "Email";
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 11.25F);
            txtLastName.Location = new Point(213, 158);
            txtLastName.Margin = new Padding(3, 4, 3, 4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(259, 32);
            txtLastName.TabIndex = 74;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI Semibold", 12F);
            lblLastName.Location = new Point(69, 161);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(108, 28);
            lblLastName.TabIndex = 73;
            lblLastName.Text = "Last Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 11.25F);
            txtFirstName.Location = new Point(213, 88);
            txtFirstName.Margin = new Padding(3, 4, 3, 4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(259, 32);
            txtFirstName.TabIndex = 72;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ButtonHighlight;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = SystemColors.WindowText;
            btnCancel.Location = new Point(354, 639);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Padding = new Padding(0, 7, 0, 7);
            btnCancel.Size = new Size(118, 49);
            btnCancel.TabIndex = 71;
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
            btnUpdate.Location = new Point(213, 639);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Padding = new Padding(0, 7, 0, 7);
            btnUpdate.Size = new Size(118, 49);
            btnUpdate.TabIndex = 70;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI Semibold", 12F);
            lblFirstName.Location = new Point(66, 85);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(110, 28);
            lblFirstName.TabIndex = 69;
            lblFirstName.Text = "First Name";
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormTitle.ForeColor = SystemColors.WindowText;
            lblFormTitle.Location = new Point(34, 27);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(375, 37);
            lblFormTitle.TabIndex = 68;
            lblFormTitle.Text = "Update Staff#EMP202500023";
            // 
            // lblFirstNameErrorMessage
            // 
            lblFirstNameErrorMessage.AutoSize = true;
            lblFirstNameErrorMessage.ForeColor = Color.Red;
            lblFirstNameErrorMessage.Location = new Point(213, 124);
            lblFirstNameErrorMessage.Name = "lblFirstNameErrorMessage";
            lblFirstNameErrorMessage.Size = new Size(103, 20);
            lblFirstNameErrorMessage.TabIndex = 83;
            lblFirstNameErrorMessage.Text = "error message";
            lblFirstNameErrorMessage.Visible = false;
            // 
            // lblLastNameErrorMessage
            // 
            lblLastNameErrorMessage.AutoSize = true;
            lblLastNameErrorMessage.ForeColor = Color.Red;
            lblLastNameErrorMessage.Location = new Point(213, 194);
            lblLastNameErrorMessage.Name = "lblLastNameErrorMessage";
            lblLastNameErrorMessage.Size = new Size(103, 20);
            lblLastNameErrorMessage.TabIndex = 84;
            lblLastNameErrorMessage.Text = "error message";
            lblLastNameErrorMessage.Visible = false;
            // 
            // lblEmailErrorMessage
            // 
            lblEmailErrorMessage.AutoSize = true;
            lblEmailErrorMessage.ForeColor = Color.Red;
            lblEmailErrorMessage.Location = new Point(213, 280);
            lblEmailErrorMessage.Name = "lblEmailErrorMessage";
            lblEmailErrorMessage.Size = new Size(103, 20);
            lblEmailErrorMessage.TabIndex = 85;
            lblEmailErrorMessage.Text = "error message";
            lblEmailErrorMessage.Visible = false;
            // 
            // lblPhoneErrorMessage
            // 
            lblPhoneErrorMessage.AutoSize = true;
            lblPhoneErrorMessage.ForeColor = Color.Red;
            lblPhoneErrorMessage.Location = new Point(213, 357);
            lblPhoneErrorMessage.Name = "lblPhoneErrorMessage";
            lblPhoneErrorMessage.Size = new Size(103, 20);
            lblPhoneErrorMessage.TabIndex = 86;
            lblPhoneErrorMessage.Text = "error message";
            lblPhoneErrorMessage.Visible = false;
            // 
            // lblLicenseNumberErrorMessage
            // 
            lblLicenseNumberErrorMessage.AutoSize = true;
            lblLicenseNumberErrorMessage.ForeColor = Color.Red;
            lblLicenseNumberErrorMessage.Location = new Point(213, 441);
            lblLicenseNumberErrorMessage.Name = "lblLicenseNumberErrorMessage";
            lblLicenseNumberErrorMessage.Size = new Size(103, 20);
            lblLicenseNumberErrorMessage.TabIndex = 87;
            lblLicenseNumberErrorMessage.Text = "error message";
            lblLicenseNumberErrorMessage.Visible = false;
            // 
            // lblPositionErrorMessage
            // 
            lblPositionErrorMessage.AutoSize = true;
            lblPositionErrorMessage.ForeColor = Color.Red;
            lblPositionErrorMessage.Location = new Point(213, 529);
            lblPositionErrorMessage.Name = "lblPositionErrorMessage";
            lblPositionErrorMessage.Size = new Size(103, 20);
            lblPositionErrorMessage.TabIndex = 88;
            lblPositionErrorMessage.Text = "error message";
            lblPositionErrorMessage.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(213, 604);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 91;
            label1.Text = "error message";
            label1.Visible = false;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI Semibold", 12F);
            lblStatus.Location = new Point(69, 569);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(67, 28);
            lblStatus.TabIndex = 90;
            lblStatus.Text = "Status";
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Font = new Font("Segoe UI", 11.25F);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "ACTIVE", "DELETED" });
            cmbStatus.Location = new Point(213, 567);
            cmbStatus.Margin = new Padding(3, 4, 3, 4);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(259, 33);
            cmbStatus.TabIndex = 89;
            // 
            // UpdateStaffForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(578, 708);
            Controls.Add(label1);
            Controls.Add(lblStatus);
            Controls.Add(cmbStatus);
            Controls.Add(lblPositionErrorMessage);
            Controls.Add(lblLicenseNumberErrorMessage);
            Controls.Add(lblPhoneErrorMessage);
            Controls.Add(lblEmailErrorMessage);
            Controls.Add(lblLastNameErrorMessage);
            Controls.Add(lblFirstNameErrorMessage);
            Controls.Add(lblPosition);
            Controls.Add(cmbPosition);
            Controls.Add(txtLicenseNumber);
            Controls.Add(lblLicenseNumber);
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
            MinimizeBox = false;
            Name = "UpdateStaffForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Update Staff Form";
            Load += UpdateStaffForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPosition;
        private ComboBox cmbPosition;
        private TextBox txtLicenseNumber;
        private Label lblLicenseNumber;
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
        private Label lblLicenseNumberErrorMessage;
        private Label lblPositionErrorMessage;
        private Label label1;
        private Label lblStatus;
        private ComboBox cmbStatus;
    }
}