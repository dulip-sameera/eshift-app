namespace eshift.View
{
    partial class CreateUserAccountForm
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
            lblFormTitle = new Label();
            lblRole = new Label();
            rdBtnCustomer = new RadioButton();
            rdBtnAdmin = new RadioButton();
            lblReferenceId = new Label();
            txtReferenceId = new TextBox();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            txtVisiblePassword = new TextBox();
            btnShowPassword = new Button();
            btnAddUser = new Button();
            txtFirstName = new TextBox();
            lblFirstName = new Label();
            txtLastName = new TextBox();
            lblLastName = new Label();
            btnCreate = new Button();
            btnCancel = new Button();
            lblUsernameErrorMessage = new Label();
            lblPasswordErrorMessage = new Label();
            SuspendLayout();
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormTitle.ForeColor = SystemColors.WindowText;
            lblFormTitle.Location = new Point(22, 30);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(209, 30);
            lblFormTitle.TabIndex = 2;
            lblFormTitle.Text = "Create User Account";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI Semibold", 12F);
            lblRole.Location = new Point(50, 96);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(43, 21);
            lblRole.TabIndex = 3;
            lblRole.Text = "Role";
            // 
            // rdBtnCustomer
            // 
            rdBtnCustomer.AutoSize = true;
            rdBtnCustomer.Checked = true;
            rdBtnCustomer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdBtnCustomer.Location = new Point(113, 94);
            rdBtnCustomer.Name = "rdBtnCustomer";
            rdBtnCustomer.Size = new Size(96, 25);
            rdBtnCustomer.TabIndex = 4;
            rdBtnCustomer.TabStop = true;
            rdBtnCustomer.Text = "Customer";
            rdBtnCustomer.UseVisualStyleBackColor = true;
            rdBtnCustomer.CheckedChanged += rdBtnCustomer_CheckedChanged;
            // 
            // rdBtnAdmin
            // 
            rdBtnAdmin.AutoSize = true;
            rdBtnAdmin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdBtnAdmin.Location = new Point(235, 94);
            rdBtnAdmin.Name = "rdBtnAdmin";
            rdBtnAdmin.Size = new Size(74, 25);
            rdBtnAdmin.TabIndex = 5;
            rdBtnAdmin.TabStop = true;
            rdBtnAdmin.Text = "Admin";
            rdBtnAdmin.UseVisualStyleBackColor = true;
            rdBtnAdmin.CheckedChanged += rdBtnAdmin_CheckedChanged;
            // 
            // lblReferenceId
            // 
            lblReferenceId.AutoSize = true;
            lblReferenceId.Font = new Font("Segoe UI Semibold", 12F);
            lblReferenceId.Location = new Point(50, 147);
            lblReferenceId.Name = "lblReferenceId";
            lblReferenceId.Size = new Size(101, 21);
            lblReferenceId.TabIndex = 6;
            lblReferenceId.Text = "Customer ID";
            // 
            // txtReferenceId
            // 
            txtReferenceId.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtReferenceId.Location = new Point(178, 145);
            txtReferenceId.Name = "txtReferenceId";
            txtReferenceId.Size = new Size(227, 27);
            txtReferenceId.TabIndex = 7;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI Semibold", 12F);
            lblUsername.Location = new Point(50, 303);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(83, 21);
            lblUsername.TabIndex = 8;
            lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(178, 303);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(227, 27);
            txtUsername.TabIndex = 9;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI Semibold", 12F);
            lblPassword.Location = new Point(50, 372);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(79, 21);
            lblPassword.TabIndex = 10;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(178, 373);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(227, 27);
            txtPassword.TabIndex = 11;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtVisiblePassword
            // 
            txtVisiblePassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtVisiblePassword.Location = new Point(178, 372);
            txtVisiblePassword.Name = "txtVisiblePassword";
            txtVisiblePassword.Size = new Size(227, 27);
            txtVisiblePassword.TabIndex = 12;
            txtVisiblePassword.Visible = false;
            // 
            // btnShowPassword
            // 
            btnShowPassword.Cursor = Cursors.Hand;
            btnShowPassword.Location = new Point(411, 373);
            btnShowPassword.Name = "btnShowPassword";
            btnShowPassword.Size = new Size(75, 27);
            btnShowPassword.TabIndex = 13;
            btnShowPassword.Text = "Show";
            btnShowPassword.UseVisualStyleBackColor = true;
            btnShowPassword.Click += btnShowPassword_Click;
            // 
            // btnAddUser
            // 
            btnAddUser.Cursor = Cursors.Hand;
            btnAddUser.Location = new Point(411, 147);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(75, 27);
            btnAddUser.TabIndex = 14;
            btnAddUser.Text = "Add";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(178, 192);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.ReadOnly = true;
            txtFirstName.Size = new Size(227, 27);
            txtFirstName.TabIndex = 16;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI Semibold", 12F);
            lblFirstName.Location = new Point(50, 192);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(88, 21);
            lblFirstName.TabIndex = 15;
            lblFirstName.Text = "First Name";
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(178, 239);
            txtLastName.Name = "txtLastName";
            txtLastName.ReadOnly = true;
            txtLastName.Size = new Size(227, 27);
            txtLastName.TabIndex = 18;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI Semibold", 12F);
            lblLastName.Location = new Point(50, 239);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(86, 21);
            lblLastName.TabIndex = 17;
            lblLastName.Text = "Last Name";
            // 
            // btnCreate
            // 
            btnCreate.BackColor = SystemColors.HotTrack;
            btnCreate.Cursor = Cursors.Hand;
            btnCreate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(178, 441);
            btnCreate.Name = "btnCreate";
            btnCreate.Padding = new Padding(0, 5, 0, 5);
            btnCreate.Size = new Size(103, 37);
            btnCreate.TabIndex = 19;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ButtonHighlight;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = SystemColors.WindowText;
            btnCancel.Location = new Point(302, 441);
            btnCancel.Name = "btnCancel";
            btnCancel.Padding = new Padding(0, 5, 0, 5);
            btnCancel.Size = new Size(103, 37);
            btnCancel.TabIndex = 20;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblUsernameErrorMessage
            // 
            lblUsernameErrorMessage.AutoSize = true;
            lblUsernameErrorMessage.ForeColor = Color.Red;
            lblUsernameErrorMessage.Location = new Point(179, 342);
            lblUsernameErrorMessage.Name = "lblUsernameErrorMessage";
            lblUsernameErrorMessage.Size = new Size(81, 15);
            lblUsernameErrorMessage.TabIndex = 21;
            lblUsernameErrorMessage.Text = "error message";
            // 
            // lblPasswordErrorMessage
            // 
            lblPasswordErrorMessage.AutoSize = true;
            lblPasswordErrorMessage.ForeColor = Color.Red;
            lblPasswordErrorMessage.Location = new Point(179, 412);
            lblPasswordErrorMessage.Name = "lblPasswordErrorMessage";
            lblPasswordErrorMessage.Size = new Size(81, 15);
            lblPasswordErrorMessage.TabIndex = 22;
            lblPasswordErrorMessage.Text = "error message";
            // 
            // CreateUserAccountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(506, 496);
            Controls.Add(lblPasswordErrorMessage);
            Controls.Add(lblUsernameErrorMessage);
            Controls.Add(btnCancel);
            Controls.Add(btnCreate);
            Controls.Add(txtLastName);
            Controls.Add(lblLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblFirstName);
            Controls.Add(btnAddUser);
            Controls.Add(btnShowPassword);
            Controls.Add(txtVisiblePassword);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(txtReferenceId);
            Controls.Add(lblReferenceId);
            Controls.Add(rdBtnAdmin);
            Controls.Add(rdBtnCustomer);
            Controls.Add(lblRole);
            Controls.Add(lblFormTitle);
            MaximizeBox = false;
            Name = "CreateUserAccountForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create User Account";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFormTitle;
        private Label lblRole;
        private RadioButton rdBtnCustomer;
        private RadioButton rdBtnAdmin;
        private Label lblReferenceId;
        private TextBox txtReferenceId;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private TextBox txtVisiblePassword;
        private Button btnShowPassword;
        private Button btnAddUser;
        private TextBox txtFirstName;
        private Label lblFirstName;
        private TextBox txtLastName;
        private Label lblLastName;
        private Button btnCreate;
        private Button btnCancel;
        private Label lblUsernameErrorMessage;
        private Label lblPasswordErrorMessage;
    }
}