namespace eshift.View.Job
{
    partial class JobRequestForm
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
            btnJobRequestSearch = new Button();
            txtJobRequestSearch = new TextBox();
            lblJobId = new Label();
            dgJobRequest = new DataGridView();
            JobID = new DataGridViewTextBoxColumn();
            Customer = new DataGridViewTextBoxColumn();
            PickUp = new DataGridViewTextBoxColumn();
            Delivery = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            ScheduledDate = new DataGridViewTextBoxColumn();
            EstimatedCost = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            ActualCost = new DataGridViewTextBoxColumn();
            lblFormTitle = new Label();
            btnAccept = new Button();
            btnReject = new Button();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dgJobRequest).BeginInit();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(230, 81, 49);
            btnClose.Cursor = Cursors.Hand;
            btnClose.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1024, 29);
            btnClose.Name = "btnClose";
            btnClose.Padding = new Padding(0, 5, 0, 5);
            btnClose.Size = new Size(84, 37);
            btnClose.TabIndex = 34;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnJobRequestSearch
            // 
            btnJobRequestSearch.BackColor = SystemColors.HotTrack;
            btnJobRequestSearch.Cursor = Cursors.Hand;
            btnJobRequestSearch.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnJobRequestSearch.ForeColor = Color.White;
            btnJobRequestSearch.Location = new Point(393, 31);
            btnJobRequestSearch.Name = "btnJobRequestSearch";
            btnJobRequestSearch.Padding = new Padding(0, 5, 0, 5);
            btnJobRequestSearch.Size = new Size(84, 37);
            btnJobRequestSearch.TabIndex = 31;
            btnJobRequestSearch.Text = "Search";
            btnJobRequestSearch.UseVisualStyleBackColor = false;
            btnJobRequestSearch.Click += btnJobRequestSearch_Click;
            // 
            // txtJobRequestSearch
            // 
            txtJobRequestSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtJobRequestSearch.Location = new Point(227, 35);
            txtJobRequestSearch.Name = "txtJobRequestSearch";
            txtJobRequestSearch.Size = new Size(160, 29);
            txtJobRequestSearch.TabIndex = 30;
            // 
            // lblJobId
            // 
            lblJobId.AutoSize = true;
            lblJobId.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJobId.Location = new Point(160, 39);
            lblJobId.Name = "lblJobId";
            lblJobId.Size = new Size(52, 20);
            lblJobId.TabIndex = 29;
            lblJobId.Text = "Job ID";
            // 
            // dgJobRequest
            // 
            dgJobRequest.AllowUserToDeleteRows = false;
            dgJobRequest.AllowUserToOrderColumns = true;
            dgJobRequest.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgJobRequest.BackgroundColor = Color.Azure;
            dgJobRequest.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgJobRequest.Columns.AddRange(new DataGridViewColumn[] { JobID, Customer, PickUp, Delivery, Description, ScheduledDate, EstimatedCost, Status, ActualCost });
            dgJobRequest.Location = new Point(16, 84);
            dgJobRequest.MultiSelect = false;
            dgJobRequest.Name = "dgJobRequest";
            dgJobRequest.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgJobRequest.Size = new Size(1089, 445);
            dgJobRequest.TabIndex = 28;
            // 
            // JobID
            // 
            JobID.DataPropertyName = "JobID";
            JobID.HeaderText = "Job ID";
            JobID.Name = "JobID";
            // 
            // Customer
            // 
            Customer.DataPropertyName = "Customer";
            Customer.HeaderText = "Customer";
            Customer.Name = "Customer";
            // 
            // PickUp
            // 
            PickUp.DataPropertyName = "PickUp";
            PickUp.HeaderText = "PickUp";
            PickUp.Name = "PickUp";
            // 
            // Delivery
            // 
            Delivery.DataPropertyName = "Delivery";
            Delivery.HeaderText = "Delivery";
            Delivery.Name = "Delivery";
            // 
            // Description
            // 
            Description.DataPropertyName = "Description";
            Description.HeaderText = "Description";
            Description.Name = "Description";
            // 
            // ScheduledDate
            // 
            ScheduledDate.DataPropertyName = "ScheduledDate";
            ScheduledDate.HeaderText = "Scheduled Date";
            ScheduledDate.Name = "ScheduledDate";
            // 
            // EstimatedCost
            // 
            EstimatedCost.DataPropertyName = "EstimatedCost";
            EstimatedCost.HeaderText = "Estimated Cost";
            EstimatedCost.Name = "EstimatedCost";
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Status";
            Status.Name = "Status";
            // 
            // ActualCost
            // 
            ActualCost.DataPropertyName = "ActualCost";
            ActualCost.HeaderText = "Actual Cost";
            ActualCost.Name = "ActualCost";
            ActualCost.Visible = false;
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormTitle.ForeColor = SystemColors.WindowText;
            lblFormTitle.Location = new Point(16, 26);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(129, 30);
            lblFormTitle.TabIndex = 27;
            lblFormTitle.Text = "Job Request";
            // 
            // btnAccept
            // 
            btnAccept.BackColor = Color.FromArgb(67, 160, 71);
            btnAccept.Cursor = Cursors.Hand;
            btnAccept.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAccept.ForeColor = Color.White;
            btnAccept.Location = new Point(787, 32);
            btnAccept.Name = "btnAccept";
            btnAccept.Padding = new Padding(0, 5, 0, 5);
            btnAccept.Size = new Size(84, 37);
            btnAccept.TabIndex = 32;
            btnAccept.Text = "Accept";
            btnAccept.UseVisualStyleBackColor = false;
            btnAccept.Click += btnAccept_Click;
            // 
            // btnReject
            // 
            btnReject.BackColor = Color.FromArgb(216, 27, 96);
            btnReject.Cursor = Cursors.Hand;
            btnReject.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReject.ForeColor = Color.White;
            btnReject.Location = new Point(893, 32);
            btnReject.Name = "btnReject";
            btnReject.Padding = new Padding(0, 5, 0, 5);
            btnReject.Size = new Size(84, 37);
            btnReject.TabIndex = 33;
            btnReject.Text = "Reject";
            btnReject.UseVisualStyleBackColor = false;
            btnReject.Click += btnReject_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = SystemColors.HotTrack;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(483, 32);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Padding = new Padding(0, 5, 0, 5);
            btnRefresh.Size = new Size(84, 37);
            btnRefresh.TabIndex = 35;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // JobRequestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1125, 542);
            Controls.Add(btnRefresh);
            Controls.Add(btnReject);
            Controls.Add(btnAccept);
            Controls.Add(btnClose);
            Controls.Add(btnJobRequestSearch);
            Controls.Add(txtJobRequestSearch);
            Controls.Add(lblJobId);
            Controls.Add(dgJobRequest);
            Controls.Add(lblFormTitle);
            MaximizeBox = false;
            Name = "JobRequestForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Job Request";
            Load += JobRequestForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgJobRequest).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Button btnJobRequestSearch;
        private TextBox txtJobRequestSearch;
        private Label lblJobId;
        private DataGridView dgJobRequest;
        private Label lblFormTitle;
        private Button btnAccept;
        private Button btnReject;
        private Button btnRefresh;
        private DataGridViewTextBoxColumn JobID;
        private DataGridViewTextBoxColumn Customer;
        private DataGridViewTextBoxColumn PickUp;
        private DataGridViewTextBoxColumn Delivery;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn ScheduledDate;
        private DataGridViewTextBoxColumn EstimatedCost;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn ActualCost;
    }
}