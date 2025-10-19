namespace eshift.View.Staff
{
    partial class StaffForm
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
            btnClose = new Button();
            btnDeleteStaff = new Button();
            btnUpdateStaff = new Button();
            btnCreateStaff = new Button();
            btnStaffSearch = new Button();
            txtStaffSearch = new TextBox();
            lblStaffId = new Label();
            dgStaff = new DataGridView();
            StaffID = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Position = new DataGridViewTextBoxColumn();
            LicenseNumber = new DataGridViewTextBoxColumn();
            Username = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            lblFormTitle = new Label();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dgStaff).BeginInit();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(230, 81, 49);
            btnClose.Cursor = Cursors.Hand;
            btnClose.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1170, 39);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Padding = new Padding(0, 7, 0, 7);
            btnClose.Size = new Size(96, 49);
            btnClose.TabIndex = 26;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnDeleteStaff
            // 
            btnDeleteStaff.BackColor = Color.FromArgb(198, 40, 40);
            btnDeleteStaff.Cursor = Cursors.Hand;
            btnDeleteStaff.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteStaff.ForeColor = Color.White;
            btnDeleteStaff.Location = new Point(1003, 39);
            btnDeleteStaff.Margin = new Padding(3, 4, 3, 4);
            btnDeleteStaff.Name = "btnDeleteStaff";
            btnDeleteStaff.Padding = new Padding(0, 7, 0, 7);
            btnDeleteStaff.Size = new Size(96, 49);
            btnDeleteStaff.TabIndex = 25;
            btnDeleteStaff.Text = "Delete";
            btnDeleteStaff.UseVisualStyleBackColor = false;
            btnDeleteStaff.Click += btnDeleteStaff_Click;
            // 
            // btnUpdateStaff
            // 
            btnUpdateStaff.BackColor = Color.FromArgb(255, 145, 0);
            btnUpdateStaff.Cursor = Cursors.Hand;
            btnUpdateStaff.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateStaff.ForeColor = Color.White;
            btnUpdateStaff.Location = new Point(885, 37);
            btnUpdateStaff.Margin = new Padding(3, 4, 3, 4);
            btnUpdateStaff.Name = "btnUpdateStaff";
            btnUpdateStaff.Padding = new Padding(0, 7, 0, 7);
            btnUpdateStaff.Size = new Size(96, 49);
            btnUpdateStaff.TabIndex = 24;
            btnUpdateStaff.Text = "Update";
            btnUpdateStaff.UseVisualStyleBackColor = false;
            btnUpdateStaff.Click += btnUpdateStaff_Click;
            // 
            // btnCreateStaff
            // 
            btnCreateStaff.BackColor = Color.FromArgb(30, 136, 229);
            btnCreateStaff.Cursor = Cursors.Hand;
            btnCreateStaff.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateStaff.ForeColor = Color.White;
            btnCreateStaff.Location = new Point(762, 37);
            btnCreateStaff.Margin = new Padding(3, 4, 3, 4);
            btnCreateStaff.Name = "btnCreateStaff";
            btnCreateStaff.Padding = new Padding(0, 7, 0, 7);
            btnCreateStaff.Size = new Size(96, 49);
            btnCreateStaff.TabIndex = 23;
            btnCreateStaff.Text = "Create";
            btnCreateStaff.UseVisualStyleBackColor = false;
            btnCreateStaff.Click += btnCreateStaff_Click;
            // 
            // btnStaffSearch
            // 
            btnStaffSearch.BackColor = SystemColors.HotTrack;
            btnStaffSearch.Cursor = Cursors.Hand;
            btnStaffSearch.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStaffSearch.ForeColor = Color.White;
            btnStaffSearch.Location = new Point(419, 37);
            btnStaffSearch.Margin = new Padding(3, 4, 3, 4);
            btnStaffSearch.Name = "btnStaffSearch";
            btnStaffSearch.Padding = new Padding(0, 7, 0, 7);
            btnStaffSearch.Size = new Size(96, 49);
            btnStaffSearch.TabIndex = 22;
            btnStaffSearch.Text = "Search";
            btnStaffSearch.UseVisualStyleBackColor = false;
            btnStaffSearch.Click += btnStaffSearch_Click;
            // 
            // txtStaffSearch
            // 
            txtStaffSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStaffSearch.Location = new Point(229, 43);
            txtStaffSearch.Margin = new Padding(3, 4, 3, 4);
            txtStaffSearch.Name = "txtStaffSearch";
            txtStaffSearch.Size = new Size(182, 34);
            txtStaffSearch.TabIndex = 21;
            // 
            // lblStaffId
            // 
            lblStaffId.AutoSize = true;
            lblStaffId.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStaffId.Location = new Point(116, 47);
            lblStaffId.Name = "lblStaffId";
            lblStaffId.Size = new Size(77, 25);
            lblStaffId.TabIndex = 20;
            lblStaffId.Text = "Staff ID";
            // 
            // dgStaff
            // 
            dgStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgStaff.BackgroundColor = Color.Azure;
            dgStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgStaff.Columns.AddRange(new DataGridViewColumn[] { StaffID, FullName, Phone, Email, Position, LicenseNumber, Username, Status });
            dgStaff.Location = new Point(18, 113);
            dgStaff.Margin = new Padding(3, 4, 3, 4);
            dgStaff.Name = "dgStaff";
            dgStaff.RowHeadersWidth = 51;
            dgStaff.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgStaff.Size = new Size(1245, 593);
            dgStaff.TabIndex = 19;
            // 
            // StaffID
            // 
            StaffID.DataPropertyName = "StaffId";
            StaffID.HeaderText = "Staff ID";
            StaffID.MinimumWidth = 6;
            StaffID.Name = "StaffID";
            // 
            // FullName
            // 
            FullName.DataPropertyName = "Name";
            FullName.HeaderText = "Name";
            FullName.MinimumWidth = 6;
            FullName.Name = "FullName";
            // 
            // Phone
            // 
            Phone.DataPropertyName = "Phone";
            Phone.HeaderText = "Phone";
            Phone.MinimumWidth = 6;
            Phone.Name = "Phone";
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            // 
            // Position
            // 
            Position.DataPropertyName = "Position";
            Position.HeaderText = "Position";
            Position.MinimumWidth = 6;
            Position.Name = "Position";
            // 
            // LicenseNumber
            // 
            LicenseNumber.DataPropertyName = "LicenseNumber";
            LicenseNumber.HeaderText = "License Number";
            LicenseNumber.MinimumWidth = 6;
            LicenseNumber.Name = "LicenseNumber";
            // 
            // Username
            // 
            Username.DataPropertyName = "Username";
            Username.HeaderText = "User Name";
            Username.MinimumWidth = 6;
            Username.Name = "Username";
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormTitle.ForeColor = SystemColors.WindowText;
            lblFormTitle.Location = new Point(18, 35);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(73, 37);
            lblFormTitle.TabIndex = 18;
            lblFormTitle.Text = "Staff";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = SystemColors.HotTrack;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(521, 37);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Padding = new Padding(0, 7, 0, 7);
            btnRefresh.Size = new Size(96, 49);
            btnRefresh.TabIndex = 27;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // StaffForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1286, 743);
            Controls.Add(btnRefresh);
            Controls.Add(btnClose);
            Controls.Add(btnDeleteStaff);
            Controls.Add(btnUpdateStaff);
            Controls.Add(btnCreateStaff);
            Controls.Add(btnStaffSearch);
            Controls.Add(txtStaffSearch);
            Controls.Add(lblStaffId);
            Controls.Add(dgStaff);
            Controls.Add(lblFormTitle);
            Margin = new Padding(3, 4, 3, 4);
            Name = "StaffForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Staff Form";
            Load += StaffForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgStaff).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Button btnDeleteStaff;
        private Button btnUpdateStaff;
        private Button btnCreateStaff;
        private Button btnStaffSearch;
        private TextBox txtStaffSearch;
        private Label lblStaffId;
        private DataGridView dgStaff;
        private Label lblFormTitle;
        private DataGridViewTextBoxColumn StaffID;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Position;
        private DataGridViewTextBoxColumn LicenseNumber;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn Status;
        private Button btnRefresh;
    }
}