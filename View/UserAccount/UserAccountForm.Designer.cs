namespace eshift.View
{
    partial class UserAccountForm
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
            dgUserAccount = new DataGridView();
            lblUsernameSearch = new Label();
            txtUsernameSearch = new TextBox();
            btnUsernameSearch = new Button();
            btnCreateAccount = new Button();
            btnUpdateAccount = new Button();
            btnDeleteAccount = new Button();
            btnClose = new Button();
            btnRefresh = new Button();
            Id = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            Username = new DataGridViewTextBoxColumn();
            Role = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgUserAccount).BeginInit();
            SuspendLayout();
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormTitle.ForeColor = SystemColors.WindowText;
            lblFormTitle.Location = new Point(24, 37);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(141, 30);
            lblFormTitle.TabIndex = 1;
            lblFormTitle.Text = "User Account";
            // 
            // dgUserAccount
            // 
            dgUserAccount.AllowUserToAddRows = false;
            dgUserAccount.AllowUserToDeleteRows = false;
            dgUserAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgUserAccount.BackgroundColor = Color.Azure;
            dgUserAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgUserAccount.Columns.AddRange(new DataGridViewColumn[] { Id, FullName, Username, Role });
            dgUserAccount.Location = new Point(24, 100);
            dgUserAccount.Name = "dgUserAccount";
            dgUserAccount.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgUserAccount.Size = new Size(1089, 445);
            dgUserAccount.TabIndex = 2;
            // 
            // lblUsernameSearch
            // 
            lblUsernameSearch.AutoSize = true;
            lblUsernameSearch.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsernameSearch.Location = new Point(176, 48);
            lblUsernameSearch.Name = "lblUsernameSearch";
            lblUsernameSearch.Size = new Size(78, 20);
            lblUsernameSearch.TabIndex = 3;
            lblUsernameSearch.Text = "Username";
            // 
            // txtUsernameSearch
            // 
            txtUsernameSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsernameSearch.Location = new Point(257, 44);
            txtUsernameSearch.Name = "txtUsernameSearch";
            txtUsernameSearch.Size = new Size(160, 29);
            txtUsernameSearch.TabIndex = 4;
            // 
            // btnUsernameSearch
            // 
            btnUsernameSearch.BackColor = SystemColors.HotTrack;
            btnUsernameSearch.Cursor = Cursors.Hand;
            btnUsernameSearch.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUsernameSearch.ForeColor = Color.White;
            btnUsernameSearch.Location = new Point(423, 40);
            btnUsernameSearch.Name = "btnUsernameSearch";
            btnUsernameSearch.Padding = new Padding(0, 5, 0, 5);
            btnUsernameSearch.Size = new Size(84, 37);
            btnUsernameSearch.TabIndex = 5;
            btnUsernameSearch.Text = "Search";
            btnUsernameSearch.UseVisualStyleBackColor = false;
            btnUsernameSearch.Click += btnUsernameSearch_Click;
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.BackColor = Color.FromArgb(30, 136, 229);
            btnCreateAccount.Cursor = Cursors.Hand;
            btnCreateAccount.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateAccount.ForeColor = Color.White;
            btnCreateAccount.Location = new Point(675, 43);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Padding = new Padding(0, 5, 0, 5);
            btnCreateAccount.Size = new Size(84, 37);
            btnCreateAccount.TabIndex = 6;
            btnCreateAccount.Text = "Create";
            btnCreateAccount.UseVisualStyleBackColor = false;
            btnCreateAccount.Click += btnCreateAccount_Click;
            // 
            // btnUpdateAccount
            // 
            btnUpdateAccount.BackColor = Color.FromArgb(255, 145, 0);
            btnUpdateAccount.Cursor = Cursors.Hand;
            btnUpdateAccount.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateAccount.ForeColor = Color.White;
            btnUpdateAccount.Location = new Point(782, 43);
            btnUpdateAccount.Name = "btnUpdateAccount";
            btnUpdateAccount.Padding = new Padding(0, 5, 0, 5);
            btnUpdateAccount.Size = new Size(84, 37);
            btnUpdateAccount.TabIndex = 7;
            btnUpdateAccount.Text = "Update";
            btnUpdateAccount.UseVisualStyleBackColor = false;
            btnUpdateAccount.Click += btnUpdateAccount_Click;
            // 
            // btnDeleteAccount
            // 
            btnDeleteAccount.BackColor = Color.FromArgb(198, 40, 40);
            btnDeleteAccount.Cursor = Cursors.Hand;
            btnDeleteAccount.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteAccount.ForeColor = Color.White;
            btnDeleteAccount.Location = new Point(886, 44);
            btnDeleteAccount.Name = "btnDeleteAccount";
            btnDeleteAccount.Padding = new Padding(0, 5, 0, 5);
            btnDeleteAccount.Size = new Size(84, 37);
            btnDeleteAccount.TabIndex = 8;
            btnDeleteAccount.Text = "Delete";
            btnDeleteAccount.UseVisualStyleBackColor = false;
            btnDeleteAccount.Click += btnDeleteAccount_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(230, 81, 49);
            btnClose.Cursor = Cursors.Hand;
            btnClose.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1032, 44);
            btnClose.Name = "btnClose";
            btnClose.Padding = new Padding(0, 5, 0, 5);
            btnClose.Size = new Size(84, 37);
            btnClose.TabIndex = 9;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = SystemColors.HotTrack;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(513, 40);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Padding = new Padding(0, 5, 0, 5);
            btnRefresh.Size = new Size(84, 37);
            btnRefresh.TabIndex = 10;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            // 
            // FullName
            // 
            FullName.DataPropertyName = "FullName";
            FullName.HeaderText = "Full Name";
            FullName.Name = "FullName";
            FullName.Resizable = DataGridViewTriState.False;
            // 
            // Username
            // 
            Username.DataPropertyName = "Username";
            Username.HeaderText = "Username";
            Username.Name = "Username";
            // 
            // Role
            // 
            Role.DataPropertyName = "Role";
            Role.HeaderText = "Role";
            Role.Name = "Role";
            // 
            // UserAccountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1125, 557);
            Controls.Add(btnRefresh);
            Controls.Add(btnClose);
            Controls.Add(btnDeleteAccount);
            Controls.Add(btnUpdateAccount);
            Controls.Add(btnCreateAccount);
            Controls.Add(btnUsernameSearch);
            Controls.Add(txtUsernameSearch);
            Controls.Add(lblUsernameSearch);
            Controls.Add(dgUserAccount);
            Controls.Add(lblFormTitle);
            MaximizeBox = false;
            Name = "UserAccountForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User Account";
            Load += UserAccountForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgUserAccount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFormTitle;
        private DataGridView dgUserAccount;
        private Label lblUsernameSearch;
        private TextBox txtUsernameSearch;
        private Button btnUsernameSearch;
        private Button btnCreateAccount;
        private Button btnUpdateAccount;
        private Button btnClose;
        private Button btnDeleteAccount;
        private Button btnRefresh;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn Role;
    }
}