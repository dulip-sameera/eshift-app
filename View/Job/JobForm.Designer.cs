namespace eshift.View.Job
{
    partial class JobForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnClose = new Button();
            btnDeleteJob = new Button();
            btnUpdateJob = new Button();
            btnCreateJob = new Button();
            btnJobSearch = new Button();
            txtJobSearch = new TextBox();
            lblJobId = new Label();
            dgJob = new DataGridView();
            lblFormTitle = new Label();
            btnRefresh = new Button();
            JobID = new DataGridViewTextBoxColumn();
            Customer = new DataGridViewTextBoxColumn();
            PickUp = new DataGridViewTextBoxColumn();
            Delivery = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            ScheduledDate = new DataGridViewTextBoxColumn();
            EstimatedCost = new DataGridViewTextBoxColumn();
            ActualCost = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgJob).BeginInit();
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
            btnClose.TabIndex = 35;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnDeleteJob
            // 
            btnDeleteJob.BackColor = Color.FromArgb(198, 40, 40);
            btnDeleteJob.Cursor = Cursors.Hand;
            btnDeleteJob.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteJob.ForeColor = Color.White;
            btnDeleteJob.Location = new Point(878, 29);
            btnDeleteJob.Name = "btnDeleteJob";
            btnDeleteJob.Padding = new Padding(0, 5, 0, 5);
            btnDeleteJob.Size = new Size(84, 37);
            btnDeleteJob.TabIndex = 34;
            btnDeleteJob.Text = "Delete";
            btnDeleteJob.UseVisualStyleBackColor = false;
            btnDeleteJob.Click += btnDeleteJob_Click;
            // 
            // btnUpdateJob
            // 
            btnUpdateJob.BackColor = Color.FromArgb(255, 145, 0);
            btnUpdateJob.Cursor = Cursors.Hand;
            btnUpdateJob.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateJob.ForeColor = Color.White;
            btnUpdateJob.Location = new Point(774, 28);
            btnUpdateJob.Name = "btnUpdateJob";
            btnUpdateJob.Padding = new Padding(0, 5, 0, 5);
            btnUpdateJob.Size = new Size(84, 37);
            btnUpdateJob.TabIndex = 33;
            btnUpdateJob.Text = "Update";
            btnUpdateJob.UseVisualStyleBackColor = false;
            btnUpdateJob.Click += btnUpdateJob_Click;
            // 
            // btnCreateJob
            // 
            btnCreateJob.BackColor = Color.FromArgb(30, 136, 229);
            btnCreateJob.Cursor = Cursors.Hand;
            btnCreateJob.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateJob.ForeColor = Color.White;
            btnCreateJob.Location = new Point(667, 28);
            btnCreateJob.Name = "btnCreateJob";
            btnCreateJob.Padding = new Padding(0, 5, 0, 5);
            btnCreateJob.Size = new Size(84, 37);
            btnCreateJob.TabIndex = 32;
            btnCreateJob.Text = "Create";
            btnCreateJob.UseVisualStyleBackColor = false;
            btnCreateJob.Click += btnCreateJob_Click;
            // 
            // btnJobSearch
            // 
            btnJobSearch.BackColor = SystemColors.HotTrack;
            btnJobSearch.Cursor = Cursors.Hand;
            btnJobSearch.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnJobSearch.ForeColor = Color.White;
            btnJobSearch.Location = new Point(362, 26);
            btnJobSearch.Name = "btnJobSearch";
            btnJobSearch.Padding = new Padding(0, 5, 0, 5);
            btnJobSearch.Size = new Size(84, 37);
            btnJobSearch.TabIndex = 31;
            btnJobSearch.Text = "Search";
            btnJobSearch.UseVisualStyleBackColor = false;
            btnJobSearch.Click += btnJobSearch_Click;
            // 
            // txtJobSearch
            // 
            txtJobSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtJobSearch.Location = new Point(196, 30);
            txtJobSearch.Name = "txtJobSearch";
            txtJobSearch.Size = new Size(160, 29);
            txtJobSearch.TabIndex = 30;
            // 
            // lblJobId
            // 
            lblJobId.AutoSize = true;
            lblJobId.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJobId.Location = new Point(97, 33);
            lblJobId.Name = "lblJobId";
            lblJobId.Size = new Size(52, 20);
            lblJobId.TabIndex = 29;
            lblJobId.Text = "Job ID";
            // 
            // dgJob
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgJob.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgJob.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgJob.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgJob.BackgroundColor = Color.Azure;
            dgJob.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgJob.Columns.AddRange(new DataGridViewColumn[] { JobID, Customer, PickUp, Delivery, Description, ScheduledDate, EstimatedCost, ActualCost, Status });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgJob.DefaultCellStyle = dataGridViewCellStyle2;
            dgJob.Location = new Point(16, 85);
            dgJob.Name = "dgJob";
            dgJob.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgJob.Size = new Size(1089, 445);
            dgJob.TabIndex = 28;
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormTitle.ForeColor = SystemColors.WindowText;
            lblFormTitle.Location = new Point(16, 26);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(47, 30);
            lblFormTitle.TabIndex = 27;
            lblFormTitle.Text = "Job";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = SystemColors.HotTrack;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(452, 26);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Padding = new Padding(0, 5, 0, 5);
            btnRefresh.Size = new Size(84, 37);
            btnRefresh.TabIndex = 36;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
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
            PickUp.HeaderText = "Pick Up";
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
            // ActualCost
            // 
            ActualCost.DataPropertyName = "ActualCost";
            ActualCost.HeaderText = "Actual Cost";
            ActualCost.Name = "ActualCost";
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Status";
            Status.Name = "Status";
            // 
            // JobForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1125, 557);
            Controls.Add(btnRefresh);
            Controls.Add(btnClose);
            Controls.Add(btnDeleteJob);
            Controls.Add(btnUpdateJob);
            Controls.Add(btnCreateJob);
            Controls.Add(btnJobSearch);
            Controls.Add(txtJobSearch);
            Controls.Add(lblJobId);
            Controls.Add(dgJob);
            Controls.Add(lblFormTitle);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "JobForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Job";
            Load += JobForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgJob).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Button btnDeleteJob;
        private Button btnUpdateJob;
        private Button btnCreateJob;
        private Button btnJobSearch;
        private TextBox txtJobSearch;
        private Label lblJobId;
        private DataGridView dgJob;
        private Label lblFormTitle;
        private Button btnRefresh;
        private DataGridViewTextBoxColumn JobID;
        private DataGridViewTextBoxColumn Customer;
        private DataGridViewTextBoxColumn PickUp;
        private DataGridViewTextBoxColumn Delivery;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn ScheduledDate;
        private DataGridViewTextBoxColumn EstimatedCost;
        private DataGridViewTextBoxColumn ActualCost;
        private DataGridViewTextBoxColumn Status;
    }
}