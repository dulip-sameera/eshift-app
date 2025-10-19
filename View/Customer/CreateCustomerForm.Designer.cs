namespace eshift.View.Customer
{
    partial class CreateCustomerForm
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
            btnCancel = new Button();
            btnCreate = new Button();
            lblFirstName = new Label();
            lblFormTitle = new Label();
            txtFirstName = new TextBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblPhone = new Label();
            txtPhone = new TextBox();
            label1 = new Label();
            rchTxtAddress = new RichTextBox();
            lblCity = new Label();
            txtCity = new TextBox();
            lblZipCode = new Label();
            txtZipCode = new TextBox();
            lblFirstNameErrorMessage = new Label();
            lblLastNameErrorMessage = new Label();
            lblEmailErrorMessage = new Label();
            lblPhoneErrorMessage = new Label();
            lblZipCodeErrorMessage = new Label();
            lblCityErrorMessage = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ButtonHighlight;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = SystemColors.WindowText;
            btnCancel.Location = new Point(345, 800);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Padding = new Padding(0, 7, 0, 7);
            btnCancel.Size = new Size(118, 49);
            btnCancel.TabIndex = 39;
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
            btnCreate.Location = new Point(203, 800);
            btnCreate.Margin = new Padding(3, 4, 3, 4);
            btnCreate.Name = "btnCreate";
            btnCreate.Padding = new Padding(0, 7, 0, 7);
            btnCreate.Size = new Size(118, 49);
            btnCreate.TabIndex = 38;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI Semibold", 12F);
            lblFirstName.Location = new Point(57, 124);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(110, 28);
            lblFirstName.TabIndex = 34;
            lblFirstName.Text = "First Name";
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormTitle.ForeColor = SystemColors.WindowText;
            lblFormTitle.Location = new Point(25, 32);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(222, 37);
            lblFormTitle.TabIndex = 21;
            lblFormTitle.Text = "Create Customer";
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 11.25F);
            txtFirstName.Location = new Point(203, 127);
            txtFirstName.Margin = new Padding(3, 4, 3, 4);
            txtFirstName.MaxLength = 50;
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(259, 32);
            txtFirstName.TabIndex = 40;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI Semibold", 12F);
            lblLastName.Location = new Point(59, 200);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(108, 28);
            lblLastName.TabIndex = 41;
            lblLastName.Text = "Last Name";
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 11.25F);
            txtLastName.Location = new Point(203, 197);
            txtLastName.Margin = new Padding(3, 4, 3, 4);
            txtLastName.MaxLength = 50;
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(259, 32);
            txtLastName.TabIndex = 42;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Semibold", 12F);
            lblEmail.Location = new Point(59, 280);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(60, 28);
            lblEmail.TabIndex = 43;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 11.25F);
            txtEmail.Location = new Point(203, 283);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.MaxLength = 100;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(259, 32);
            txtEmail.TabIndex = 44;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI Semibold", 12F);
            lblPhone.Location = new Point(59, 357);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(71, 28);
            lblPhone.TabIndex = 45;
            lblPhone.Text = "Phone";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 11.25F);
            txtPhone.Location = new Point(203, 360);
            txtPhone.Margin = new Padding(3, 4, 3, 4);
            txtPhone.MaxLength = 10;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(259, 32);
            txtPhone.TabIndex = 46;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F);
            label1.Location = new Point(59, 443);
            label1.Name = "label1";
            label1.Size = new Size(85, 28);
            label1.TabIndex = 47;
            label1.Text = "Address";
            // 
            // rchTxtAddress
            // 
            rchTxtAddress.Font = new Font("Segoe UI", 11.25F);
            rchTxtAddress.Location = new Point(203, 443);
            rchTxtAddress.Margin = new Padding(3, 4, 3, 4);
            rchTxtAddress.Name = "rchTxtAddress";
            rchTxtAddress.Size = new Size(259, 95);
            rchTxtAddress.TabIndex = 48;
            rchTxtAddress.Text = "";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Font = new Font("Segoe UI Semibold", 12F);
            lblCity.Location = new Point(59, 601);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(46, 28);
            lblCity.TabIndex = 49;
            lblCity.Text = "City";
            // 
            // txtCity
            // 
            txtCity.Font = new Font("Segoe UI", 11.25F);
            txtCity.Location = new Point(203, 599);
            txtCity.Margin = new Padding(3, 4, 3, 4);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(259, 32);
            txtCity.TabIndex = 50;
            // 
            // lblZipCode
            // 
            lblZipCode.AutoSize = true;
            lblZipCode.Font = new Font("Segoe UI Semibold", 12F);
            lblZipCode.Location = new Point(59, 689);
            lblZipCode.Name = "lblZipCode";
            lblZipCode.Size = new Size(94, 28);
            lblZipCode.TabIndex = 51;
            lblZipCode.Text = "Zip Code";
            // 
            // txtZipCode
            // 
            txtZipCode.Font = new Font("Segoe UI", 11.25F);
            txtZipCode.Location = new Point(203, 692);
            txtZipCode.Margin = new Padding(3, 4, 3, 4);
            txtZipCode.Name = "txtZipCode";
            txtZipCode.Size = new Size(259, 32);
            txtZipCode.TabIndex = 52;
            // 
            // lblFirstNameErrorMessage
            // 
            lblFirstNameErrorMessage.AutoSize = true;
            lblFirstNameErrorMessage.ForeColor = Color.Red;
            lblFirstNameErrorMessage.Location = new Point(203, 163);
            lblFirstNameErrorMessage.Name = "lblFirstNameErrorMessage";
            lblFirstNameErrorMessage.Size = new Size(103, 20);
            lblFirstNameErrorMessage.TabIndex = 53;
            lblFirstNameErrorMessage.Text = "Error Message";
            lblFirstNameErrorMessage.Visible = false;
            // 
            // lblLastNameErrorMessage
            // 
            lblLastNameErrorMessage.AutoSize = true;
            lblLastNameErrorMessage.ForeColor = Color.Red;
            lblLastNameErrorMessage.Location = new Point(203, 233);
            lblLastNameErrorMessage.Name = "lblLastNameErrorMessage";
            lblLastNameErrorMessage.Size = new Size(103, 20);
            lblLastNameErrorMessage.TabIndex = 54;
            lblLastNameErrorMessage.Text = "Error Message";
            lblLastNameErrorMessage.Visible = false;
            // 
            // lblEmailErrorMessage
            // 
            lblEmailErrorMessage.AutoSize = true;
            lblEmailErrorMessage.ForeColor = Color.Red;
            lblEmailErrorMessage.Location = new Point(203, 319);
            lblEmailErrorMessage.Name = "lblEmailErrorMessage";
            lblEmailErrorMessage.Size = new Size(103, 20);
            lblEmailErrorMessage.TabIndex = 55;
            lblEmailErrorMessage.Text = "Error Message";
            lblEmailErrorMessage.Visible = false;
            // 
            // lblPhoneErrorMessage
            // 
            lblPhoneErrorMessage.AutoSize = true;
            lblPhoneErrorMessage.ForeColor = Color.Red;
            lblPhoneErrorMessage.Location = new Point(203, 396);
            lblPhoneErrorMessage.Name = "lblPhoneErrorMessage";
            lblPhoneErrorMessage.Size = new Size(103, 20);
            lblPhoneErrorMessage.TabIndex = 56;
            lblPhoneErrorMessage.Text = "Error Message";
            lblPhoneErrorMessage.Visible = false;
            // 
            // lblZipCodeErrorMessage
            // 
            lblZipCodeErrorMessage.AutoSize = true;
            lblZipCodeErrorMessage.ForeColor = Color.Red;
            lblZipCodeErrorMessage.Location = new Point(203, 728);
            lblZipCodeErrorMessage.Name = "lblZipCodeErrorMessage";
            lblZipCodeErrorMessage.Size = new Size(103, 20);
            lblZipCodeErrorMessage.TabIndex = 57;
            lblZipCodeErrorMessage.Text = "Error Message";
            lblZipCodeErrorMessage.Visible = false;
            // 
            // lblCityErrorMessage
            // 
            lblCityErrorMessage.AutoSize = true;
            lblCityErrorMessage.ForeColor = Color.Red;
            lblCityErrorMessage.Location = new Point(203, 635);
            lblCityErrorMessage.Name = "lblCityErrorMessage";
            lblCityErrorMessage.Size = new Size(103, 20);
            lblCityErrorMessage.TabIndex = 58;
            lblCityErrorMessage.Text = "Error Message";
            lblCityErrorMessage.Visible = false;
            // 
            // CreateCustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(578, 865);
            Controls.Add(lblCityErrorMessage);
            Controls.Add(lblZipCodeErrorMessage);
            Controls.Add(lblPhoneErrorMessage);
            Controls.Add(lblEmailErrorMessage);
            Controls.Add(lblLastNameErrorMessage);
            Controls.Add(lblFirstNameErrorMessage);
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
            Controls.Add(btnCreate);
            Controls.Add(lblFirstName);
            Controls.Add(lblFormTitle);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "CreateCustomerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create Customer Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnCreate;
        private TextBox txtFirstName;
        private Label lblLastName;
        private TextBox txtLastName;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblPhone;
        private TextBox txtPhone;
        private Label label1;
        private RichTextBox rchTxtAddress;
        private Label lblCity;
        private TextBox txtCity;
        private Label lblZipCode;
        private TextBox txtZipCode;
        private Label lblFirstName;
        private Button btnShowPassword;
        private TextBox txtVisiblePassword;
        private TextBox txtPassword;
        private Label lblPassword;
        private TextBox txtUsername;
        private Label lblUsername;
        private Label lblFormTitle;
        private Label lblFirstNameErrorMessage;
        private Label lblLastNameErrorMessage;
        private Label lblEmailErrorMessage;
        private Label lblPhoneErrorMessage;
        private Label lblZipCodeErrorMessage;
        private Label lblCityErrorMessage;
    }
}