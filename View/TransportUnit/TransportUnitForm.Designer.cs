namespace eshift.View.TransportUnit
{
    partial class TransportUnitForm
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
            btnDeleteTransportUnit = new Button();
            btnUpdateTransportUnit = new Button();
            btnCreateTransportUnit = new Button();
            btnTransportUnitSearch = new Button();
            txtTransportUnitSearch = new TextBox();
            lblTransportUnitId = new Label();
            dgTransportUnit = new DataGridView();
            TUID = new DataGridViewTextBoxColumn();
            Vehicle = new DataGridViewTextBoxColumn();
            Driver = new DataGridViewTextBoxColumn();
            Assistant = new DataGridViewTextBoxColumn();
            Available = new DataGridViewTextBoxColumn();
            lblFormTitle = new Label();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dgTransportUnit).BeginInit();
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
            // btnDeleteTransportUnit
            // 
            btnDeleteTransportUnit.BackColor = Color.FromArgb(198, 40, 40);
            btnDeleteTransportUnit.Cursor = Cursors.Hand;
            btnDeleteTransportUnit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteTransportUnit.ForeColor = Color.White;
            btnDeleteTransportUnit.Location = new Point(878, 29);
            btnDeleteTransportUnit.Name = "btnDeleteTransportUnit";
            btnDeleteTransportUnit.Padding = new Padding(0, 5, 0, 5);
            btnDeleteTransportUnit.Size = new Size(84, 37);
            btnDeleteTransportUnit.TabIndex = 34;
            btnDeleteTransportUnit.Text = "Delete";
            btnDeleteTransportUnit.UseVisualStyleBackColor = false;
            btnDeleteTransportUnit.Click += btnDeleteTransportUnit_Click;
            // 
            // btnUpdateTransportUnit
            // 
            btnUpdateTransportUnit.BackColor = Color.FromArgb(255, 145, 0);
            btnUpdateTransportUnit.Cursor = Cursors.Hand;
            btnUpdateTransportUnit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateTransportUnit.ForeColor = Color.White;
            btnUpdateTransportUnit.Location = new Point(774, 28);
            btnUpdateTransportUnit.Name = "btnUpdateTransportUnit";
            btnUpdateTransportUnit.Padding = new Padding(0, 5, 0, 5);
            btnUpdateTransportUnit.Size = new Size(84, 37);
            btnUpdateTransportUnit.TabIndex = 33;
            btnUpdateTransportUnit.Text = "Update";
            btnUpdateTransportUnit.UseVisualStyleBackColor = false;
            btnUpdateTransportUnit.Click += btnUpdateTransportUnit_Click;
            // 
            // btnCreateTransportUnit
            // 
            btnCreateTransportUnit.BackColor = Color.FromArgb(30, 136, 229);
            btnCreateTransportUnit.Cursor = Cursors.Hand;
            btnCreateTransportUnit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateTransportUnit.ForeColor = Color.White;
            btnCreateTransportUnit.Location = new Point(667, 28);
            btnCreateTransportUnit.Name = "btnCreateTransportUnit";
            btnCreateTransportUnit.Padding = new Padding(0, 5, 0, 5);
            btnCreateTransportUnit.Size = new Size(84, 37);
            btnCreateTransportUnit.TabIndex = 32;
            btnCreateTransportUnit.Text = "Create";
            btnCreateTransportUnit.UseVisualStyleBackColor = false;
            btnCreateTransportUnit.Click += btnCreateTransportUnit_Click;
            // 
            // btnTransportUnitSearch
            // 
            btnTransportUnitSearch.BackColor = SystemColors.HotTrack;
            btnTransportUnitSearch.Cursor = Cursors.Hand;
            btnTransportUnitSearch.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTransportUnitSearch.ForeColor = Color.White;
            btnTransportUnitSearch.Location = new Point(411, 36);
            btnTransportUnitSearch.Name = "btnTransportUnitSearch";
            btnTransportUnitSearch.Padding = new Padding(0, 5, 0, 5);
            btnTransportUnitSearch.Size = new Size(84, 37);
            btnTransportUnitSearch.TabIndex = 31;
            btnTransportUnitSearch.Text = "Search";
            btnTransportUnitSearch.UseVisualStyleBackColor = false;
            btnTransportUnitSearch.Click += btnTransportUnitSearch_Click;
            // 
            // txtTransportUnitSearch
            // 
            txtTransportUnitSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTransportUnitSearch.Location = new Point(245, 40);
            txtTransportUnitSearch.Name = "txtTransportUnitSearch";
            txtTransportUnitSearch.Size = new Size(160, 29);
            txtTransportUnitSearch.TabIndex = 30;
            // 
            // lblTransportUnitId
            // 
            lblTransportUnitId.AutoSize = true;
            lblTransportUnitId.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTransportUnitId.Location = new Point(192, 44);
            lblTransportUnitId.Name = "lblTransportUnitId";
            lblTransportUnitId.Size = new Size(47, 20);
            lblTransportUnitId.TabIndex = 29;
            lblTransportUnitId.Text = "TU ID";
            // 
            // dgTransportUnit
            // 
            dgTransportUnit.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgTransportUnit.BackgroundColor = Color.Azure;
            dgTransportUnit.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgTransportUnit.Columns.AddRange(new DataGridViewColumn[] { TUID, Vehicle, Driver, Assistant, Available });
            dgTransportUnit.Location = new Point(16, 85);
            dgTransportUnit.Name = "dgTransportUnit";
            dgTransportUnit.RowHeadersWidth = 51;
            dgTransportUnit.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgTransportUnit.Size = new Size(1089, 445);
            dgTransportUnit.TabIndex = 28;
            // 
            // TUID
            // 
            TUID.DataPropertyName = "TransportUnitId";
            TUID.HeaderText = "TU ID";
            TUID.MinimumWidth = 6;
            TUID.Name = "TUID";
            // 
            // Vehicle
            // 
            Vehicle.DataPropertyName = "Vehicle";
            Vehicle.HeaderText = "Vehicle";
            Vehicle.MinimumWidth = 6;
            Vehicle.Name = "Vehicle";
            // 
            // Driver
            // 
            Driver.DataPropertyName = "Driver";
            Driver.HeaderText = "Driver";
            Driver.MinimumWidth = 6;
            Driver.Name = "Driver";
            // 
            // Assistant
            // 
            Assistant.DataPropertyName = "Assistant";
            Assistant.HeaderText = "Assistant";
            Assistant.MinimumWidth = 6;
            Assistant.Name = "Assistant";
            // 
            // Available
            // 
            Available.DataPropertyName = "Available";
            Available.HeaderText = "Available";
            Available.MinimumWidth = 6;
            Available.Name = "Available";
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormTitle.ForeColor = SystemColors.WindowText;
            lblFormTitle.Location = new Point(16, 26);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(152, 30);
            lblFormTitle.TabIndex = 27;
            lblFormTitle.Text = "Transport Unit";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = SystemColors.HotTrack;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(500, 36);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Padding = new Padding(0, 5, 0, 5);
            btnRefresh.Size = new Size(84, 37);
            btnRefresh.TabIndex = 36;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // TransportUnitForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1125, 557);
            Controls.Add(btnRefresh);
            Controls.Add(btnClose);
            Controls.Add(btnDeleteTransportUnit);
            Controls.Add(btnUpdateTransportUnit);
            Controls.Add(btnCreateTransportUnit);
            Controls.Add(btnTransportUnitSearch);
            Controls.Add(txtTransportUnitSearch);
            Controls.Add(lblTransportUnitId);
            Controls.Add(dgTransportUnit);
            Controls.Add(lblFormTitle);
            MaximizeBox = false;
            Name = "TransportUnitForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Transport Unit Form";
            Load += TransportUnitForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgTransportUnit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Button btnDeleteTransportUnit;
        private Button btnUpdateTransportUnit;
        private Button btnCreateTransportUnit;
        private Button btnTransportUnitSearch;
        private TextBox txtTransportUnitSearch;
        private Label lblTransportUnitId;
        private DataGridView dgTransportUnit;
        private Label lblFormTitle;
        private Button btnRefresh;
        private DataGridViewTextBoxColumn TUID;
        private DataGridViewTextBoxColumn Vehicle;
        private DataGridViewTextBoxColumn Driver;
        private DataGridViewTextBoxColumn Assistant;
        private DataGridViewTextBoxColumn Available;
    }
}