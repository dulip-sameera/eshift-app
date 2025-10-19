namespace eshift.View
{
    partial class AdminDashboardForm
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
            btnUserAccount = new Button();
            btnJobRequest = new Button();
            btnJob = new Button();
            btnReports = new Button();
            btnCustomer = new Button();
            btnTransportUnit = new Button();
            btnLogOut = new Button();
            btnVehicle = new Button();
            btnStaff = new Button();
            SuspendLayout();
            // 
            // lblWelcomeMessage
            // 
            lblWelcomeMessage.AutoSize = true;
            lblWelcomeMessage.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcomeMessage.ForeColor = SystemColors.WindowText;
            lblWelcomeMessage.Location = new Point(34, 21);
            lblWelcomeMessage.Name = "lblWelcomeMessage";
            lblWelcomeMessage.Size = new Size(162, 30);
            lblWelcomeMessage.TabIndex = 0;
            lblWelcomeMessage.Text = "Welcome, Dulip";
            // 
            // btnUserAccount
            // 
            btnUserAccount.BackColor = Color.FromArgb(230, 81, 49);
            btnUserAccount.Cursor = Cursors.Hand;
            btnUserAccount.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUserAccount.ForeColor = Color.White;
            btnUserAccount.Location = new Point(206, 87);
            btnUserAccount.Name = "btnUserAccount";
            btnUserAccount.Size = new Size(190, 81);
            btnUserAccount.TabIndex = 1;
            btnUserAccount.Text = "User Account";
            btnUserAccount.UseVisualStyleBackColor = false;
            btnUserAccount.Click += btnUserAccount_Click;
            // 
            // btnJobRequest
            // 
            btnJobRequest.BackColor = Color.FromArgb(30, 136, 229);
            btnJobRequest.Cursor = Cursors.Hand;
            btnJobRequest.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnJobRequest.ForeColor = Color.White;
            btnJobRequest.Location = new Point(474, 87);
            btnJobRequest.Name = "btnJobRequest";
            btnJobRequest.Size = new Size(190, 81);
            btnJobRequest.TabIndex = 2;
            btnJobRequest.Text = "Job Request";
            btnJobRequest.UseVisualStyleBackColor = false;
            btnJobRequest.Click += btnJobRequest_Click;
            // 
            // btnJob
            // 
            btnJob.BackColor = Color.FromArgb(67, 160, 71);
            btnJob.Cursor = Cursors.Hand;
            btnJob.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnJob.ForeColor = Color.White;
            btnJob.Location = new Point(720, 87);
            btnJob.Name = "btnJob";
            btnJob.Size = new Size(190, 81);
            btnJob.TabIndex = 3;
            btnJob.Text = "Job";
            btnJob.UseVisualStyleBackColor = false;
            btnJob.Click += btnJob_Click;
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.FromArgb(216, 27, 96);
            btnReports.Cursor = Cursors.Hand;
            btnReports.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReports.ForeColor = Color.White;
            btnReports.Location = new Point(720, 244);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(190, 81);
            btnReports.TabIndex = 6;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = false;
            btnReports.Click += btnReports_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.BackColor = Color.FromArgb(142, 35, 196);
            btnCustomer.Cursor = Cursors.Hand;
            btnCustomer.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCustomer.ForeColor = Color.White;
            btnCustomer.Location = new Point(474, 244);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(190, 81);
            btnCustomer.TabIndex = 5;
            btnCustomer.Text = "Customer";
            btnCustomer.UseVisualStyleBackColor = false;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // btnTransportUnit
            // 
            btnTransportUnit.BackColor = Color.FromArgb(255, 145, 0);
            btnTransportUnit.Cursor = Cursors.Hand;
            btnTransportUnit.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTransportUnit.ForeColor = Color.White;
            btnTransportUnit.Location = new Point(206, 244);
            btnTransportUnit.Name = "btnTransportUnit";
            btnTransportUnit.Size = new Size(190, 81);
            btnTransportUnit.TabIndex = 4;
            btnTransportUnit.Text = "Transport Unit";
            btnTransportUnit.UseVisualStyleBackColor = false;
            btnTransportUnit.Click += btnTransportUnit_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.FromArgb(198, 40, 40);
            btnLogOut.Cursor = Cursors.Hand;
            btnLogOut.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogOut.ForeColor = Color.White;
            btnLogOut.Location = new Point(720, 385);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(190, 81);
            btnLogOut.TabIndex = 9;
            btnLogOut.Text = "Log out";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnVehicle
            // 
            btnVehicle.BackColor = Color.FromArgb(109, 76, 65);
            btnVehicle.Cursor = Cursors.Hand;
            btnVehicle.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVehicle.ForeColor = Color.White;
            btnVehicle.Location = new Point(474, 385);
            btnVehicle.Name = "btnVehicle";
            btnVehicle.Size = new Size(190, 81);
            btnVehicle.TabIndex = 8;
            btnVehicle.Text = "Vehicle";
            btnVehicle.UseVisualStyleBackColor = false;
            btnVehicle.Click += btnVehicle_Click;
            // 
            // btnStaff
            // 
            btnStaff.BackColor = Color.FromArgb(0, 145, 155);
            btnStaff.Cursor = Cursors.Hand;
            btnStaff.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStaff.ForeColor = Color.White;
            btnStaff.Location = new Point(206, 385);
            btnStaff.Name = "btnStaff";
            btnStaff.Size = new Size(190, 81);
            btnStaff.TabIndex = 7;
            btnStaff.Text = "Staff";
            btnStaff.UseVisualStyleBackColor = false;
            btnStaff.Click += btnStaff_Click;
            // 
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1125, 557);
            Controls.Add(btnLogOut);
            Controls.Add(btnVehicle);
            Controls.Add(btnStaff);
            Controls.Add(btnReports);
            Controls.Add(btnCustomer);
            Controls.Add(btnTransportUnit);
            Controls.Add(btnJob);
            Controls.Add(btnJobRequest);
            Controls.Add(btnUserAccount);
            Controls.Add(lblWelcomeMessage);
            MaximizeBox = false;
            Name = "AdminDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcomeMessage;
        private Button btnUserAccount;
        private Button btnJobRequest;
        private Button btnJob;
        private Button btnReports;
        private Button btnCustomer;
        private Button btnTransportUnit;
        private Button btnLogOut;
        private Button btnVehicle;
        private Button btnStaff;
    }
}