namespace eshift.View
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblEShift = new Label();
            lblUserName = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnExit = new Button();
            lblUsernameErrorMessage = new Label();
            lblPasswordErrorMessage = new Label();
            SuspendLayout();
            // 
            // lblEShift
            // 
            lblEShift.AutoSize = true;
            lblEShift.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEShift.ForeColor = SystemColors.HotTrack;
            lblEShift.Location = new Point(132, 59);
            lblEShift.Name = "lblEShift";
            lblEShift.Size = new Size(181, 39);
            lblEShift.TabIndex = 0;
            lblEShift.Text = "e-Shift Login";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserName.Location = new Point(72, 119);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(81, 21);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(154, 119);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(213, 27);
            txtUsername.TabIndex = 2;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(72, 175);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(76, 21);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(155, 175);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(212, 27);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.HotTrack;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnLogin.ForeColor = SystemColors.ButtonFace;
            btnLogin.Location = new Point(154, 233);
            btnLogin.Name = "btnLogin";
            btnLogin.Padding = new Padding(10, 5, 10, 5);
            btnLogin.Size = new Size(100, 40);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Log In";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogIn_click;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.ButtonHighlight;
            btnExit.Cursor = Cursors.Hand;
            btnExit.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnExit.ForeColor = SystemColors.ActiveCaptionText;
            btnExit.Location = new Point(267, 233);
            btnExit.Name = "btnExit";
            btnExit.Padding = new Padding(10, 5, 10, 5);
            btnExit.Size = new Size(100, 40);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // lblUsernameErrorMessage
            // 
            lblUsernameErrorMessage.AutoSize = true;
            lblUsernameErrorMessage.ForeColor = Color.Red;
            lblUsernameErrorMessage.Location = new Point(155, 149);
            lblUsernameErrorMessage.Name = "lblUsernameErrorMessage";
            lblUsernameErrorMessage.Size = new Size(81, 15);
            lblUsernameErrorMessage.TabIndex = 7;
            lblUsernameErrorMessage.Text = "error message";
            // 
            // lblPasswordErrorMessage
            // 
            lblPasswordErrorMessage.AutoSize = true;
            lblPasswordErrorMessage.ForeColor = Color.Red;
            lblPasswordErrorMessage.Location = new Point(154, 205);
            lblPasswordErrorMessage.Name = "lblPasswordErrorMessage";
            lblPasswordErrorMessage.Size = new Size(81, 15);
            lblPasswordErrorMessage.TabIndex = 8;
            lblPasswordErrorMessage.Text = "error message";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(461, 333);
            Controls.Add(lblPasswordErrorMessage);
            Controls.Add(lblUsernameErrorMessage);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUserName);
            Controls.Add(lblEShift);
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "eShift: The Moving Company";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEShift;
        private Label lblUserName;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnExit;
        private Label lblUsernameErrorMessage;
        private Label lblPasswordErrorMessage;
    }
}
