namespace eshift.View.Staff
{
    partial class CreateStaffForm
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
            txtPhone = new TextBox();
            lblPhone = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtLastName = new TextBox();
            lblLastName = new Label();
            txtFirstName = new TextBox();
            btnCancel = new Button();
            btnCreate = new Button();
            lblFirstName = new Label();
            lblFormTitle = new Label();
            lblLicenseNo = new Label();
            txtLicenseNumber = new TextBox();
            cmbPosition = new ComboBox();
            lblPosition = new Label();
            lblFirstNameErrorMessage = new Label();
            lblLastNameErrorMessage = new Label();
            lblEmailErrorMessage = new Label();
            lblPhoneErrorMessage = new Label();
            lblLicenseNumberErrorMessage = new Label();
            lblPositionErrorMessage = new Label();
            SuspendLayout();
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 11.25F);
            txtPhone.Location = new Point(216, 355);
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
            lblPhone.Location = new Point(72, 352);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(71, 28);
            lblPhone.TabIndex = 62;
            lblPhone.Text = "Phone";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 11.25F);
            txtEmail.Location = new Point(216, 277);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(259, 32);
            txtEmail.TabIndex = 61;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Semibold", 12F);
            lblEmail.Location = new Point(72, 275);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(60, 28);
            lblEmail.TabIndex = 60;
            lblEmail.Text = "Email";
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 11.25F);
            txtLastName.Location = new Point(216, 192);
            txtLastName.Margin = new Padding(3, 4, 3, 4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(259, 32);
            txtLastName.TabIndex = 59;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI Semibold", 12F);
            lblLastName.Location = new Point(72, 195);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(108, 28);
            lblLastName.TabIndex = 58;
            lblLastName.Text = "Last Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 11.25F);
            txtFirstName.Location = new Point(216, 121);
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
            btnCancel.Location = new Point(358, 612);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Padding = new Padding(0, 7, 0, 7);
            btnCancel.Size = new Size(118, 49);
            btnCancel.TabIndex = 56;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = SystemColors.HotTrack;
            btnCreate.Cursor = Cursors.Hand;
            btnCreate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(216, 612);
            btnCreate.Margin = new Padding(3, 4, 3, 4);
            btnCreate.Name = "btnCreate";
            btnCreate.Padding = new Padding(0, 7, 0, 7);
            btnCreate.Size = new Size(118, 49);
            btnCreate.TabIndex = 55;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI Semibold", 12F);
            lblFirstName.Location = new Point(70, 119);
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
            lblFormTitle.Location = new Point(38, 27);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(159, 37);
            lblFormTitle.TabIndex = 53;
            lblFormTitle.Text = "Create Staff";
            // 
            // lblLicenseNo
            // 
            lblLicenseNo.AutoSize = true;
            lblLicenseNo.Font = new Font("Segoe UI Semibold", 12F);
            lblLicenseNo.Location = new Point(72, 436);
            lblLicenseNo.Name = "lblLicenseNo";
            lblLicenseNo.Size = new Size(112, 28);
            lblLicenseNo.TabIndex = 64;
            lblLicenseNo.Text = "License No";
            // 
            // txtLicenseNumber
            // 
            txtLicenseNumber.Font = new Font("Segoe UI", 11.25F);
            txtLicenseNumber.Location = new Point(216, 439);
            txtLicenseNumber.Margin = new Padding(3, 4, 3, 4);
            txtLicenseNumber.Name = "txtLicenseNumber";
            txtLicenseNumber.PlaceholderText = "*Optional unless you are a driver";
            txtLicenseNumber.Size = new Size(259, 32);
            txtLicenseNumber.TabIndex = 65;
            // 
            // cmbPosition
            // 
            cmbPosition.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPosition.Font = new Font("Segoe UI", 11.25F);
            cmbPosition.FormattingEnabled = true;
            cmbPosition.Items.AddRange(new object[] { "ADMIN", "DRIVER", "ASSISTANT" });
            cmbPosition.Location = new Point(216, 525);
            cmbPosition.Margin = new Padding(3, 4, 3, 4);
            cmbPosition.Name = "cmbPosition";
            cmbPosition.Size = new Size(259, 33);
            cmbPosition.TabIndex = 66;
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Font = new Font("Segoe UI Semibold", 12F);
            lblPosition.Location = new Point(72, 528);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(85, 28);
            lblPosition.TabIndex = 67;
            lblPosition.Text = "Position";
            // 
            // lblFirstNameErrorMessage
            // 
            lblFirstNameErrorMessage.AutoSize = true;
            lblFirstNameErrorMessage.ForeColor = Color.Red;
            lblFirstNameErrorMessage.Location = new Point(216, 157);
            lblFirstNameErrorMessage.Name = "lblFirstNameErrorMessage";
            lblFirstNameErrorMessage.Size = new Size(103, 20);
            lblFirstNameErrorMessage.TabIndex = 68;
            lblFirstNameErrorMessage.Text = "error message";
            // 
            // lblLastNameErrorMessage
            // 
            lblLastNameErrorMessage.AutoSize = true;
            lblLastNameErrorMessage.ForeColor = Color.Red;
            lblLastNameErrorMessage.Location = new Point(216, 228);
            lblLastNameErrorMessage.Name = "lblLastNameErrorMessage";
            lblLastNameErrorMessage.Size = new Size(103, 20);
            lblLastNameErrorMessage.TabIndex = 69;
            lblLastNameErrorMessage.Text = "error message";
            // 
            // lblEmailErrorMessage
            // 
            lblEmailErrorMessage.AutoSize = true;
            lblEmailErrorMessage.ForeColor = Color.Red;
            lblEmailErrorMessage.Location = new Point(216, 313);
            lblEmailErrorMessage.Name = "lblEmailErrorMessage";
            lblEmailErrorMessage.Size = new Size(103, 20);
            lblEmailErrorMessage.TabIndex = 70;
            lblEmailErrorMessage.Text = "error message";
            // 
            // lblPhoneErrorMessage
            // 
            lblPhoneErrorMessage.AutoSize = true;
            lblPhoneErrorMessage.ForeColor = Color.Red;
            lblPhoneErrorMessage.Location = new Point(216, 391);
            lblPhoneErrorMessage.Name = "lblPhoneErrorMessage";
            lblPhoneErrorMessage.Size = new Size(103, 20);
            lblPhoneErrorMessage.TabIndex = 71;
            lblPhoneErrorMessage.Text = "error message";
            // 
            // lblLicenseNumberErrorMessage
            // 
            lblLicenseNumberErrorMessage.AutoSize = true;
            lblLicenseNumberErrorMessage.ForeColor = Color.Red;
            lblLicenseNumberErrorMessage.Location = new Point(216, 475);
            lblLicenseNumberErrorMessage.Name = "lblLicenseNumberErrorMessage";
            lblLicenseNumberErrorMessage.Size = new Size(103, 20);
            lblLicenseNumberErrorMessage.TabIndex = 72;
            lblLicenseNumberErrorMessage.Text = "error message";
            // 
            // lblPositionErrorMessage
            // 
            lblPositionErrorMessage.AutoSize = true;
            lblPositionErrorMessage.ForeColor = Color.Red;
            lblPositionErrorMessage.Location = new Point(216, 562);
            lblPositionErrorMessage.Name = "lblPositionErrorMessage";
            lblPositionErrorMessage.Size = new Size(103, 20);
            lblPositionErrorMessage.TabIndex = 73;
            lblPositionErrorMessage.Text = "error message";
            // 
            // CreateStaffForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(578, 696);
            Controls.Add(lblPositionErrorMessage);
            Controls.Add(lblLicenseNumberErrorMessage);
            Controls.Add(lblPhoneErrorMessage);
            Controls.Add(lblEmailErrorMessage);
            Controls.Add(lblLastNameErrorMessage);
            Controls.Add(lblFirstNameErrorMessage);
            Controls.Add(lblPosition);
            Controls.Add(cmbPosition);
            Controls.Add(txtLicenseNumber);
            Controls.Add(lblLicenseNo);
            Controls.Add(txtPhone);
            Controls.Add(lblPhone);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtLastName);
            Controls.Add(lblLastName);
            Controls.Add(txtFirstName);
            Controls.Add(btnCancel);
            Controls.Add(btnCreate);
            Controls.Add(lblFirstName);
            Controls.Add(lblFormTitle);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "CreateStaffForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create Staff Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtPhone;
        private Label lblPhone;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtLastName;
        private Label lblLastName;
        private TextBox txtFirstName;
        private Button btnCancel;
        private Button btnCreate;
        private Label lblFirstName;
        private Label lblFormTitle;
        private Label lblLicenseNo;
        private TextBox txtLicenseNumber;
        private ComboBox cmbPosition;
        private Label lblPosition;
        private Label lblFirstNameErrorMessage;
        private Label lblLastNameErrorMessage;
        private Label lblEmailErrorMessage;
        private Label lblPhoneErrorMessage;
        private Label lblLicenseNumberErrorMessage;
        private Label lblPositionErrorMessage;
    }
}