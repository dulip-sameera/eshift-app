namespace eshift.View
{
    partial class UpdateUserAccountForm
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
            btnUpdate = new Button();
            txtLastName = new TextBox();
            lblLastName = new Label();
            txtFirstName = new TextBox();
            lblFirstName = new Label();
            btnShowPassword = new Button();
            txtVisiblePassword = new TextBox();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtUsername = new TextBox();
            lblUsername = new Label();
            txtReferenceId = new TextBox();
            lblReferenceId = new Label();
            label1 = new Label();
            lblFormTitle = new Label();
            txtRole = new TextBox();
            lblUsernameErrorMessage = new Label();
            lblPasswordErrorMessage = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ButtonHighlight;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = SystemColors.WindowText;
            btnCancel.Location = new Point(302, 420);
            btnCancel.Name = "btnCancel";
            btnCancel.Padding = new Padding(0, 5, 0, 5);
            btnCancel.Size = new Size(103, 37);
            btnCancel.TabIndex = 39;
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
            btnUpdate.Location = new Point(178, 420);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Padding = new Padding(0, 5, 0, 5);
            btnUpdate.Size = new Size(103, 37);
            btnUpdate.TabIndex = 38;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(178, 238);
            txtLastName.Name = "txtLastName";
            txtLastName.ReadOnly = true;
            txtLastName.Size = new Size(227, 27);
            txtLastName.TabIndex = 37;
            txtLastName.Text = "Sameera";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI Semibold", 12F);
            lblLastName.Location = new Point(50, 238);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(86, 21);
            lblLastName.TabIndex = 36;
            lblLastName.Text = "Last Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(178, 191);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.ReadOnly = true;
            txtFirstName.Size = new Size(227, 27);
            txtFirstName.TabIndex = 35;
            txtFirstName.Text = "Dulip";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI Semibold", 12F);
            lblFirstName.Location = new Point(50, 191);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(88, 21);
            lblFirstName.TabIndex = 34;
            lblFirstName.Text = "First Name";
            // 
            // btnShowPassword
            // 
            btnShowPassword.Cursor = Cursors.Hand;
            btnShowPassword.Location = new Point(411, 352);
            btnShowPassword.Name = "btnShowPassword";
            btnShowPassword.Size = new Size(75, 27);
            btnShowPassword.TabIndex = 32;
            btnShowPassword.Text = "Show";
            btnShowPassword.UseVisualStyleBackColor = true;
            btnShowPassword.Click += btnShowPassword_Click;
            // 
            // txtVisiblePassword
            // 
            txtVisiblePassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtVisiblePassword.Location = new Point(178, 351);
            txtVisiblePassword.Name = "txtVisiblePassword";
            txtVisiblePassword.Size = new Size(227, 27);
            txtVisiblePassword.TabIndex = 31;
            txtVisiblePassword.Visible = false;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(178, 338);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(227, 27);
            txtPassword.TabIndex = 30;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI Semibold", 12F);
            lblPassword.Location = new Point(50, 351);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(116, 21);
            lblPassword.TabIndex = 29;
            lblPassword.Text = "New Password";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(178, 289);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(227, 27);
            txtUsername.TabIndex = 28;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI Semibold", 12F);
            lblUsername.Location = new Point(50, 289);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(120, 21);
            lblUsername.TabIndex = 27;
            lblUsername.Text = "New Username";
            // 
            // txtReferenceId
            // 
            txtReferenceId.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtReferenceId.Location = new Point(178, 144);
            txtReferenceId.Name = "txtReferenceId";
            txtReferenceId.ReadOnly = true;
            txtReferenceId.Size = new Size(227, 27);
            txtReferenceId.TabIndex = 26;
            txtReferenceId.Text = "EMP20250001";
            // 
            // lblReferenceId
            // 
            lblReferenceId.AutoSize = true;
            lblReferenceId.Font = new Font("Segoe UI Semibold", 12F);
            lblReferenceId.Location = new Point(50, 146);
            lblReferenceId.Name = "lblReferenceId";
            lblReferenceId.Size = new Size(65, 21);
            lblReferenceId.TabIndex = 25;
            lblReferenceId.Text = "Staff ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F);
            label1.Location = new Point(50, 95);
            label1.Name = "label1";
            label1.Size = new Size(43, 21);
            label1.TabIndex = 22;
            label1.Text = "Role";
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormTitle.ForeColor = SystemColors.WindowText;
            lblFormTitle.Location = new Point(22, 29);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(218, 30);
            lblFormTitle.TabIndex = 21;
            lblFormTitle.Text = "Update User Account";
            // 
            // txtRole
            // 
            txtRole.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRole.Location = new Point(178, 95);
            txtRole.Name = "txtRole";
            txtRole.ReadOnly = true;
            txtRole.Size = new Size(227, 27);
            txtRole.TabIndex = 40;
            txtRole.Text = "ADMIN";
            // 
            // lblUsernameErrorMessage
            // 
            lblUsernameErrorMessage.AutoSize = true;
            lblUsernameErrorMessage.ForeColor = Color.Red;
            lblUsernameErrorMessage.Location = new Point(178, 320);
            lblUsernameErrorMessage.Name = "lblUsernameErrorMessage";
            lblUsernameErrorMessage.Size = new Size(81, 15);
            lblUsernameErrorMessage.TabIndex = 41;
            lblUsernameErrorMessage.Text = "error message";
            // 
            // lblPasswordErrorMessage
            // 
            lblPasswordErrorMessage.AutoSize = true;
            lblPasswordErrorMessage.ForeColor = Color.Red;
            lblPasswordErrorMessage.Location = new Point(178, 381);
            lblPasswordErrorMessage.Name = "lblPasswordErrorMessage";
            lblPasswordErrorMessage.Size = new Size(81, 15);
            lblPasswordErrorMessage.TabIndex = 42;
            lblPasswordErrorMessage.Text = "error message";
            // 
            // UpdateUserAccountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(506, 557);
            Controls.Add(lblPasswordErrorMessage);
            Controls.Add(lblUsernameErrorMessage);
            Controls.Add(txtRole);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(txtLastName);
            Controls.Add(lblLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblFirstName);
            Controls.Add(btnShowPassword);
            Controls.Add(txtVisiblePassword);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(txtReferenceId);
            Controls.Add(lblReferenceId);
            Controls.Add(label1);
            Controls.Add(lblFormTitle);
            Name = "UpdateUserAccountForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Update User Account";
            Load += UpdateUserAccountForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnUpdate;
        private TextBox txtLastName;
        private Label lblLastName;
        private TextBox txtFirstName;
        private Label lblFirstName;
        private Button btnShowPassword;
        private TextBox txtVisiblePassword;
        private TextBox txtPassword;
        private Label lblPassword;
        private TextBox txtUsername;
        private Label lblUsername;
        private TextBox txtReferenceId;
        private Label lblReferenceId;
        private Label label1;
        private Label lblFormTitle;
        private TextBox txtRole;
        private Label lblUsernameErrorMessage;
        private Label lblPasswordErrorMessage;
    }
}