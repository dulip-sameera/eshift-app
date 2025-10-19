namespace eshift.View
{
    partial class CustomerDashboardForm
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
            lblWelcomeMessage = new Label();
            btnLogOut = new Button();
            btnJob = new Button();
            btnAccount = new Button();
            SuspendLayout();
            // 
            // lblWelcomeMessage
            // 
            lblWelcomeMessage.AutoSize = true;
            lblWelcomeMessage.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcomeMessage.ForeColor = SystemColors.WindowText;
            lblWelcomeMessage.Location = new Point(29, 28);
            lblWelcomeMessage.Name = "lblWelcomeMessage";
            lblWelcomeMessage.Size = new Size(162, 30);
            lblWelcomeMessage.TabIndex = 1;
            lblWelcomeMessage.Text = "Welcome, Dulip";
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.FromArgb(198, 40, 40);
            btnLogOut.Cursor = Cursors.Hand;
            btnLogOut.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogOut.ForeColor = Color.White;
            btnLogOut.Location = new Point(707, 189);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(190, 81);
            btnLogOut.TabIndex = 12;
            btnLogOut.Text = "Log out";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnJob
            // 
            btnJob.BackColor = Color.FromArgb(67, 160, 71);
            btnJob.Cursor = Cursors.Hand;
            btnJob.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnJob.ForeColor = Color.White;
            btnJob.Location = new Point(465, 189);
            btnJob.Name = "btnJob";
            btnJob.Size = new Size(190, 81);
            btnJob.TabIndex = 11;
            btnJob.Text = "Job";
            btnJob.UseVisualStyleBackColor = false;
            btnJob.Click += btnJob_Click;
            // 
            // btnAccount
            // 
            btnAccount.BackColor = Color.FromArgb(230, 81, 49);
            btnAccount.Cursor = Cursors.Hand;
            btnAccount.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAccount.ForeColor = Color.White;
            btnAccount.Location = new Point(239, 189);
            btnAccount.Name = "btnAccount";
            btnAccount.Size = new Size(190, 81);
            btnAccount.TabIndex = 10;
            btnAccount.Text = "Account";
            btnAccount.UseVisualStyleBackColor = false;
            btnAccount.Click += btnAccount_Click;
            // 
            // CustomerDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1125, 557);
            Controls.Add(btnLogOut);
            Controls.Add(btnJob);
            Controls.Add(btnAccount);
            Controls.Add(lblWelcomeMessage);
            MaximizeBox = false;
            Name = "CustomerDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer Dashboard";
            Load += CustomerDashboardForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcomeMessage;
        private Button btnLogOut;
        private Button btnJob;
        private Button btnAccount;
    }
}