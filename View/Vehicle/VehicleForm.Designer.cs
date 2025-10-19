
namespace eshift.View.Vehicle
{
    partial class VehicleForm
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
            btnDeleteVehicle = new Button();
            btnUpdateVehicle = new Button();
            btnCreateVehicle = new Button();
            btnVehicleSearch = new Button();
            txtVehicleSearch = new TextBox();
            lblRegNo = new Label();
            dgVehicle = new DataGridView();
            lblFormTitle = new Label();
            btnRefresh = new Button();
            RegistrationNumber = new DataGridViewTextBoxColumn();
            Id = new DataGridViewTextBoxColumn();
            Brand = new DataGridViewTextBoxColumn();
            Model = new DataGridViewTextBoxColumn();
            ContainerVolume = new DataGridViewTextBoxColumn();
            MaxWeight = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgVehicle).BeginInit();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(230, 81, 49);
            btnClose.Cursor = Cursors.Hand;
            btnClose.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1017, 36);
            btnClose.Name = "btnClose";
            btnClose.Padding = new Padding(0, 5, 0, 5);
            btnClose.Size = new Size(84, 37);
            btnClose.TabIndex = 35;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnDeleteVehicle
            // 
            btnDeleteVehicle.BackColor = Color.FromArgb(198, 40, 40);
            btnDeleteVehicle.Cursor = Cursors.Hand;
            btnDeleteVehicle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteVehicle.ForeColor = Color.White;
            btnDeleteVehicle.Location = new Point(871, 36);
            btnDeleteVehicle.Name = "btnDeleteVehicle";
            btnDeleteVehicle.Padding = new Padding(0, 5, 0, 5);
            btnDeleteVehicle.Size = new Size(84, 37);
            btnDeleteVehicle.TabIndex = 34;
            btnDeleteVehicle.Text = "Delete";
            btnDeleteVehicle.UseVisualStyleBackColor = false;
            btnDeleteVehicle.Click += btnDeleteVehicle_Click;
            // 
            // btnUpdateVehicle
            // 
            btnUpdateVehicle.BackColor = Color.FromArgb(255, 145, 0);
            btnUpdateVehicle.Cursor = Cursors.Hand;
            btnUpdateVehicle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateVehicle.ForeColor = Color.White;
            btnUpdateVehicle.Location = new Point(767, 34);
            btnUpdateVehicle.Name = "btnUpdateVehicle";
            btnUpdateVehicle.Padding = new Padding(0, 5, 0, 5);
            btnUpdateVehicle.Size = new Size(84, 37);
            btnUpdateVehicle.TabIndex = 33;
            btnUpdateVehicle.Text = "Update";
            btnUpdateVehicle.UseVisualStyleBackColor = false;
            btnUpdateVehicle.Click += btnUpdateVehicle_Click;
            // 
            // btnCreateVehicle
            // 
            btnCreateVehicle.BackColor = Color.FromArgb(30, 136, 229);
            btnCreateVehicle.Cursor = Cursors.Hand;
            btnCreateVehicle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateVehicle.ForeColor = Color.White;
            btnCreateVehicle.Location = new Point(660, 34);
            btnCreateVehicle.Name = "btnCreateVehicle";
            btnCreateVehicle.Padding = new Padding(0, 5, 0, 5);
            btnCreateVehicle.Size = new Size(84, 37);
            btnCreateVehicle.TabIndex = 32;
            btnCreateVehicle.Text = "Create";
            btnCreateVehicle.UseVisualStyleBackColor = false;
            btnCreateVehicle.Click += btnCreateVehicle_Click;
            // 
            // btnVehicleSearch
            // 
            btnVehicleSearch.BackColor = SystemColors.HotTrack;
            btnVehicleSearch.Cursor = Cursors.Hand;
            btnVehicleSearch.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVehicleSearch.ForeColor = Color.White;
            btnVehicleSearch.Location = new Point(399, 34);
            btnVehicleSearch.Name = "btnVehicleSearch";
            btnVehicleSearch.Padding = new Padding(0, 5, 0, 5);
            btnVehicleSearch.Size = new Size(84, 37);
            btnVehicleSearch.TabIndex = 31;
            btnVehicleSearch.Text = "Search";
            btnVehicleSearch.UseVisualStyleBackColor = false;
            btnVehicleSearch.Click += btnVehicleSearch_Click;
            // 
            // txtVehicleSearch
            // 
            txtVehicleSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtVehicleSearch.Location = new Point(236, 39);
            txtVehicleSearch.Name = "txtVehicleSearch";
            txtVehicleSearch.Size = new Size(160, 29);
            txtVehicleSearch.TabIndex = 30;
            // 
            // lblRegNo
            // 
            lblRegNo.AutoSize = true;
            lblRegNo.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegNo.Location = new Point(111, 43);
            lblRegNo.Name = "lblRegNo";
            lblRegNo.Size = new Size(116, 20);
            lblRegNo.TabIndex = 29;
            lblRegNo.Text = "Registration No";
            // 
            // dgVehicle
            // 
            dgVehicle.AllowUserToAddRows = false;
            dgVehicle.AllowUserToDeleteRows = false;
            dgVehicle.AllowUserToResizeColumns = false;
            dgVehicle.AllowUserToResizeRows = false;
            dgVehicle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgVehicle.BackgroundColor = Color.Azure;
            dgVehicle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgVehicle.Columns.AddRange(new DataGridViewColumn[] { RegistrationNumber, Id, Brand, Model, ContainerVolume, MaxWeight });
            dgVehicle.Location = new Point(16, 85);
            dgVehicle.MultiSelect = false;
            dgVehicle.Name = "dgVehicle";
            dgVehicle.RowHeadersWidth = 51;
            dgVehicle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgVehicle.Size = new Size(1089, 445);
            dgVehicle.TabIndex = 28;
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormTitle.ForeColor = SystemColors.WindowText;
            lblFormTitle.Location = new Point(16, 26);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(79, 30);
            lblFormTitle.TabIndex = 27;
            lblFormTitle.Text = "Vehicle";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = SystemColors.HotTrack;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(488, 34);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Padding = new Padding(0, 5, 0, 5);
            btnRefresh.Size = new Size(84, 37);
            btnRefresh.TabIndex = 36;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // RegistrationNumber
            // 
            RegistrationNumber.DataPropertyName = "RegistrationNumber";
            RegistrationNumber.HeaderText = "Registration No";
            RegistrationNumber.Name = "RegistrationNumber";
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.Visible = false;
            // 
            // Brand
            // 
            Brand.DataPropertyName = "Brand";
            Brand.HeaderText = "Brand";
            Brand.Name = "Brand";
            // 
            // Model
            // 
            Model.DataPropertyName = "Model";
            Model.HeaderText = "Model";
            Model.Name = "Model";
            // 
            // ContainerVolume
            // 
            ContainerVolume.DataPropertyName = "ContainerVolume";
            ContainerVolume.HeaderText = "Container Volume";
            ContainerVolume.Name = "ContainerVolume";
            // 
            // MaxWeight
            // 
            MaxWeight.DataPropertyName = "MaxWeight";
            MaxWeight.HeaderText = "Max Weight";
            MaxWeight.Name = "MaxWeight";
            // 
            // VehicleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1125, 557);
            Controls.Add(btnRefresh);
            Controls.Add(btnClose);
            Controls.Add(btnDeleteVehicle);
            Controls.Add(btnUpdateVehicle);
            Controls.Add(btnCreateVehicle);
            Controls.Add(btnVehicleSearch);
            Controls.Add(txtVehicleSearch);
            Controls.Add(lblRegNo);
            Controls.Add(dgVehicle);
            Controls.Add(lblFormTitle);
            Name = "VehicleForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VehicleForm";
            Load += VehicleForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgVehicle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Button btnDeleteVehicle;
        private Button btnUpdateVehicle;
        private Button btnCreateVehicle;
        private Button btnVehicleSearch;
        private TextBox txtVehicleSearch;
        private Label lblRegNo;
        private DataGridView dgVehicle;
        private Label lblFormTitle;
        private Button btnRefresh;
        private DataGridViewTextBoxColumn RegistrationNumber;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Brand;
        private DataGridViewTextBoxColumn Model;
        private DataGridViewTextBoxColumn ContainerVolume;
        private DataGridViewTextBoxColumn MaxWeight;
    }
}