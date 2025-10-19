namespace eshift.View.Customer
{
    partial class CustomerForm
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
            btnClose = new Button();
            btnDeleteCustomer = new Button();
            btnUpdateCustomer = new Button();
            btnCreateCustomer = new Button();
            btnCustomerSearch = new Button();
            txtCustomerSearch = new TextBox();
            lblCustomerId = new Label();
            dgCustomer = new DataGridView();
            btnRefresh = new Button();
            CusID = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            City = new DataGridViewTextBoxColumn();
            ZipCode = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            UserName = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgCustomer).BeginInit();
            SuspendLayout();
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormTitle.ForeColor = SystemColors.WindowText;
            lblFormTitle.Location = new Point(17, 51);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(136, 37);
            lblFormTitle.TabIndex = 2;
            lblFormTitle.Text = "Customer";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(230, 81, 49);
            btnClose.Cursor = Cursors.Hand;
            btnClose.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1169, 55);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Padding = new Padding(0, 7, 0, 7);
            btnClose.Size = new Size(96, 49);
            btnClose.TabIndex = 17;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnDeleteCustomer
            // 
            btnDeleteCustomer.BackColor = Color.FromArgb(198, 40, 40);
            btnDeleteCustomer.Cursor = Cursors.Hand;
            btnDeleteCustomer.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteCustomer.ForeColor = Color.White;
            btnDeleteCustomer.Location = new Point(1002, 55);
            btnDeleteCustomer.Margin = new Padding(3, 4, 3, 4);
            btnDeleteCustomer.Name = "btnDeleteCustomer";
            btnDeleteCustomer.Padding = new Padding(0, 7, 0, 7);
            btnDeleteCustomer.Size = new Size(96, 49);
            btnDeleteCustomer.TabIndex = 16;
            btnDeleteCustomer.Text = "Delete";
            btnDeleteCustomer.UseVisualStyleBackColor = false;
            btnDeleteCustomer.Click += btnDeleteCustomer_Click;
            // 
            // btnUpdateCustomer
            // 
            btnUpdateCustomer.BackColor = Color.FromArgb(255, 145, 0);
            btnUpdateCustomer.Cursor = Cursors.Hand;
            btnUpdateCustomer.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateCustomer.ForeColor = Color.White;
            btnUpdateCustomer.Location = new Point(883, 53);
            btnUpdateCustomer.Margin = new Padding(3, 4, 3, 4);
            btnUpdateCustomer.Name = "btnUpdateCustomer";
            btnUpdateCustomer.Padding = new Padding(0, 7, 0, 7);
            btnUpdateCustomer.Size = new Size(96, 49);
            btnUpdateCustomer.TabIndex = 15;
            btnUpdateCustomer.Text = "Update";
            btnUpdateCustomer.UseVisualStyleBackColor = false;
            btnUpdateCustomer.Click += btnUpdateCustomer_Click;
            // 
            // btnCreateCustomer
            // 
            btnCreateCustomer.BackColor = Color.FromArgb(30, 136, 229);
            btnCreateCustomer.Cursor = Cursors.Hand;
            btnCreateCustomer.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateCustomer.ForeColor = Color.White;
            btnCreateCustomer.Location = new Point(761, 53);
            btnCreateCustomer.Margin = new Padding(3, 4, 3, 4);
            btnCreateCustomer.Name = "btnCreateCustomer";
            btnCreateCustomer.Padding = new Padding(0, 7, 0, 7);
            btnCreateCustomer.Size = new Size(96, 49);
            btnCreateCustomer.TabIndex = 14;
            btnCreateCustomer.Text = "Create";
            btnCreateCustomer.UseVisualStyleBackColor = false;
            btnCreateCustomer.Click += btnCreateCustomer_Click;
            // 
            // btnCustomerSearch
            // 
            btnCustomerSearch.BackColor = SystemColors.HotTrack;
            btnCustomerSearch.Cursor = Cursors.Hand;
            btnCustomerSearch.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCustomerSearch.ForeColor = Color.White;
            btnCustomerSearch.Location = new Point(477, 55);
            btnCustomerSearch.Margin = new Padding(3, 4, 3, 4);
            btnCustomerSearch.Name = "btnCustomerSearch";
            btnCustomerSearch.Padding = new Padding(0, 7, 0, 7);
            btnCustomerSearch.Size = new Size(96, 49);
            btnCustomerSearch.TabIndex = 13;
            btnCustomerSearch.Text = "Search";
            btnCustomerSearch.UseVisualStyleBackColor = false;
            btnCustomerSearch.Click += btnCustomerSearch_Click;
            // 
            // txtCustomerSearch
            // 
            txtCustomerSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCustomerSearch.Location = new Point(289, 61);
            txtCustomerSearch.Margin = new Padding(3, 4, 3, 4);
            txtCustomerSearch.Name = "txtCustomerSearch";
            txtCustomerSearch.Size = new Size(182, 34);
            txtCustomerSearch.TabIndex = 12;
            // 
            // lblCustomerId
            // 
            lblCustomerId.AutoSize = true;
            lblCustomerId.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomerId.Location = new Point(168, 65);
            lblCustomerId.Name = "lblCustomerId";
            lblCustomerId.Size = new Size(120, 25);
            lblCustomerId.TabIndex = 11;
            lblCustomerId.Text = "Customer ID";
            // 
            // dgCustomer
            // 
            dgCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgCustomer.BackgroundColor = Color.Azure;
            dgCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCustomer.Columns.AddRange(new DataGridViewColumn[] { CusID, FullName, Phone, Address, email, City, ZipCode, Status, UserName });
            dgCustomer.Location = new Point(17, 129);
            dgCustomer.Margin = new Padding(3, 4, 3, 4);
            dgCustomer.Name = "dgCustomer";
            dgCustomer.RowHeadersWidth = 51;
            dgCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgCustomer.Size = new Size(1245, 593);
            dgCustomer.TabIndex = 10;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = SystemColors.HotTrack;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(591, 55);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Padding = new Padding(0, 7, 0, 7);
            btnRefresh.Size = new Size(96, 49);
            btnRefresh.TabIndex = 18;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // CusID
            // 
            CusID.DataPropertyName = "CusId";
            CusID.HeaderText = "Customer ID";
            CusID.MinimumWidth = 6;
            CusID.Name = "CusID";
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
            // Address
            // 
            Address.DataPropertyName = "Address";
            Address.HeaderText = "Address";
            Address.MinimumWidth = 6;
            Address.Name = "Address";
            // 
            // email
            // 
            email.DataPropertyName = "email";
            email.HeaderText = "Email";
            email.MinimumWidth = 6;
            email.Name = "email";
            // 
            // City
            // 
            City.DataPropertyName = "City";
            City.HeaderText = "City";
            City.MinimumWidth = 6;
            City.Name = "City";
            // 
            // ZipCode
            // 
            ZipCode.DataPropertyName = "ZipCode";
            ZipCode.HeaderText = "ZipCode";
            ZipCode.MinimumWidth = 6;
            ZipCode.Name = "ZipCode";
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            // 
            // UserName
            // 
            UserName.DataPropertyName = "Username";
            UserName.HeaderText = "Username";
            UserName.MinimumWidth = 6;
            UserName.Name = "UserName";
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1286, 743);
            Controls.Add(btnRefresh);
            Controls.Add(btnClose);
            Controls.Add(btnDeleteCustomer);
            Controls.Add(btnUpdateCustomer);
            Controls.Add(btnCreateCustomer);
            Controls.Add(btnCustomerSearch);
            Controls.Add(txtCustomerSearch);
            Controls.Add(lblCustomerId);
            Controls.Add(dgCustomer);
            Controls.Add(lblFormTitle);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CustomerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer Form";
            Load += CustomerForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgCustomer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFormTitle;
        private Button btnClose;
        private Button btnDeleteCustomer;
        private Button btnUpdateCustomer;
        private Button btnCreateCustomer;
        private Button btnCustomerSearch;
        private TextBox txtCustomerSearch;
        private Label lblCustomerId;
        private DataGridView dgCustomer;
        private Button btnRefresh;
        private DataGridViewTextBoxColumn CusID;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn City;
        private DataGridViewTextBoxColumn ZipCode;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn UserName;
    }
}