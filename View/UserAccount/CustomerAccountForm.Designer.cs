namespace eshift.View.UserAccount
{
    partial class CustomerAccountForm
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
            rchTxtAddress = new RichTextBox();
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
            SuspendLayout();
            // 
            // txtZipCode
            // 
            txtZipCode.Font = new Font("Segoe UI", 11.25F);
            txtZipCode.Location = new Point(217, 502);
            txtZipCode.Name = "txtZipCode";
            txtZipCode.Size = new Size(227, 27);
            txtZipCode.TabIndex = 69;
            // 
            // lblZipCode
            // 
            lblZipCode.AutoSize = true;
            lblZipCode.Font = new Font("Segoe UI Semibold", 12F);
            lblZipCode.Location = new Point(91, 500);
            lblZipCode.Name = "lblZipCode";
            lblZipCode.Size = new Size(76, 21);
            lblZipCode.TabIndex = 68;
            lblZipCode.Text = "Zip Code";
            // 
            // txtCity
            // 
            txtCity.Font = new Font("Segoe UI", 11.25F);
            txtCity.Location = new Point(217, 432);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(227, 27);
            txtCity.TabIndex = 67;
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Font = new Font("Segoe UI Semibold", 12F);
            lblCity.Location = new Point(91, 434);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(38, 21);
            lblCity.TabIndex = 66;
            lblCity.Text = "City";
            // 
            // rchTxtAddress
            // 
            rchTxtAddress.Font = new Font("Segoe UI", 11.25F);
            rchTxtAddress.Location = new Point(217, 315);
            rchTxtAddress.Name = "rchTxtAddress";
            rchTxtAddress.Size = new Size(227, 72);
            rchTxtAddress.TabIndex = 65;
            rchTxtAddress.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F);
            label1.Location = new Point(91, 315);
            label1.Name = "label1";
            label1.Size = new Size(70, 21);
            label1.TabIndex = 64;
            label1.Text = "Address";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 11.25F);
            txtPhone.Location = new Point(217, 253);
            txtPhone.MaxLength = 10;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(227, 27);
            txtPhone.TabIndex = 63;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI Semibold", 12F);
            lblPhone.Location = new Point(91, 251);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(56, 21);
            lblPhone.TabIndex = 62;
            lblPhone.Text = "Phone";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 11.25F);
            txtEmail.Location = new Point(217, 195);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(227, 27);
            txtEmail.TabIndex = 61;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Semibold", 12F);
            lblEmail.Location = new Point(91, 193);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(48, 21);
            lblEmail.TabIndex = 60;
            lblEmail.Text = "Email";
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 11.25F);
            txtLastName.Location = new Point(217, 131);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(227, 27);
            txtLastName.TabIndex = 59;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI Semibold", 12F);
            lblLastName.Location = new Point(91, 133);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(86, 21);
            lblLastName.TabIndex = 58;
            lblLastName.Text = "Last Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 11.25F);
            txtFirstName.Location = new Point(217, 78);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(227, 27);
            txtFirstName.TabIndex = 57;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ButtonHighlight;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = SystemColors.WindowText;
            btnCancel.Location = new Point(341, 564);
            btnCancel.Name = "btnCancel";
            btnCancel.Padding = new Padding(0, 5, 0, 5);
            btnCancel.Size = new Size(103, 37);
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
            btnUpdate.Location = new Point(217, 564);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Padding = new Padding(0, 5, 0, 5);
            btnUpdate.Size = new Size(103, 37);
            btnUpdate.TabIndex = 55;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI Semibold", 12F);
            lblFirstName.Location = new Point(89, 76);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(88, 21);
            lblFirstName.TabIndex = 54;
            lblFirstName.Text = "First Name";
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormTitle.ForeColor = SystemColors.WindowText;
            lblFormTitle.Location = new Point(62, 18);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(162, 30);
            lblFormTitle.TabIndex = 53;
            lblFormTitle.Text = "Account Details";
            // 
            // CustomerAccountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(548, 630);
            Controls.Add(txtZipCode);
            Controls.Add(lblZipCode);
            Controls.Add(txtCity);
            Controls.Add(lblCity);
            Controls.Add(rchTxtAddress);
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
            MaximizeBox = false;
            Name = "CustomerAccountForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Account Details";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtZipCode;
        private Label lblZipCode;
        private TextBox txtCity;
        private Label lblCity;
        private RichTextBox rchTxtAddress;
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
    }
}