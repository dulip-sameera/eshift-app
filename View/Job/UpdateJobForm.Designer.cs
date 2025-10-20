namespace eshift.View.Job
{
    partial class UpdateJobForm
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
            btnRemoveTransportUnit = new Button();
            btnClearTransportUnit = new Button();
            btnAddTransportUnit = new Button();
            txtTransportUnitId = new TextBox();
            lblTransportUnitId = new Label();
            btnRemoveLoad = new Button();
            btnClearLoad = new Button();
            btnAddLoad = new Button();
            nmrcLoadWeight = new NumericUpDown();
            lblWeight = new Label();
            nmrcLoadVolume = new NumericUpDown();
            lblLoadVolume = new Label();
            txtLoadDescription = new TextBox();
            label1 = new Label();
            txtCustomer = new TextBox();
            lblCustomerName = new Label();
            cmbStatus = new ComboBox();
            lblStatus = new Label();
            txtActualCost = new TextBox();
            lblAcutalCost = new Label();
            dgTransportUnit = new DataGridView();
            TId = new DataGridViewTextBoxColumn();
            TuId = new DataGridViewTextBoxColumn();
            VehicleId = new DataGridViewTextBoxColumn();
            VehicleRegNo = new DataGridViewTextBoxColumn();
            DriverId = new DataGridViewTextBoxColumn();
            AssistantId = new DataGridViewTextBoxColumn();
            Available = new DataGridViewTextBoxColumn();
            lblTransportUnit = new Label();
            lblLoad = new Label();
            dgLoads = new DataGridView();
            LoadID = new DataGridViewTextBoxColumn();
            Id = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Volume = new DataGridViewTextBoxColumn();
            Weight = new DataGridViewTextBoxColumn();
            JobId = new DataGridViewTextBoxColumn();
            txtEstimatedCost = new TextBox();
            lblEstimatedCost = new Label();
            dtTmPckrScheduledDate = new DateTimePicker();
            rchTxtDescription = new RichTextBox();
            rchTxtDelivery = new RichTextBox();
            rchTxtPickup = new RichTextBox();
            btnCancel = new Button();
            btnUpdate = new Button();
            lblScheduledDate = new Label();
            lblDescription = new Label();
            lblDelivery = new Label();
            lblPickup = new Label();
            lblFormTitle = new Label();
            lblPickUpErrorMessage = new Label();
            lblDeliveryErrorMessage = new Label();
            lblScheduleDateErrorMessage = new Label();
            lblEstimatedCostErrorMessage = new Label();
            lblActualCostErrorMessage = new Label();
            lblStatusErrorMessage = new Label();
            lblLoadVoloumeErrorMessage = new Label();
            lblLoadWeightErrorMessage = new Label();
            ((System.ComponentModel.ISupportInitialize)nmrcLoadWeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrcLoadVolume).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgTransportUnit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgLoads).BeginInit();
            SuspendLayout();
            // 
            // btnRemoveTransportUnit
            // 
            btnRemoveTransportUnit.BackColor = Color.FromArgb(198, 40, 40);
            btnRemoveTransportUnit.Cursor = Cursors.Hand;
            btnRemoveTransportUnit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemoveTransportUnit.ForeColor = Color.White;
            btnRemoveTransportUnit.Location = new Point(852, 771);
            btnRemoveTransportUnit.Margin = new Padding(2, 3, 2, 3);
            btnRemoveTransportUnit.Name = "btnRemoveTransportUnit";
            btnRemoveTransportUnit.Padding = new Padding(0, 6, 0, 6);
            btnRemoveTransportUnit.Size = new Size(94, 39);
            btnRemoveTransportUnit.TabIndex = 216;
            btnRemoveTransportUnit.Text = "Remove";
            btnRemoveTransportUnit.UseVisualStyleBackColor = false;
            btnRemoveTransportUnit.Click += btnRemoveTransportUnit_Click;
            // 
            // btnClearTransportUnit
            // 
            btnClearTransportUnit.BackColor = SystemColors.ButtonHighlight;
            btnClearTransportUnit.Cursor = Cursors.Hand;
            btnClearTransportUnit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClearTransportUnit.ForeColor = SystemColors.WindowText;
            btnClearTransportUnit.Location = new Point(1051, 772);
            btnClearTransportUnit.Margin = new Padding(2, 3, 2, 3);
            btnClearTransportUnit.Name = "btnClearTransportUnit";
            btnClearTransportUnit.Padding = new Padding(0, 6, 0, 6);
            btnClearTransportUnit.Size = new Size(94, 39);
            btnClearTransportUnit.TabIndex = 215;
            btnClearTransportUnit.Text = "Clear";
            btnClearTransportUnit.UseVisualStyleBackColor = false;
            btnClearTransportUnit.Click += btnClearTransportUnit_Click;
            // 
            // btnAddTransportUnit
            // 
            btnAddTransportUnit.BackColor = SystemColors.HotTrack;
            btnAddTransportUnit.Cursor = Cursors.Hand;
            btnAddTransportUnit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddTransportUnit.ForeColor = Color.White;
            btnAddTransportUnit.Location = new Point(952, 772);
            btnAddTransportUnit.Margin = new Padding(2, 3, 2, 3);
            btnAddTransportUnit.Name = "btnAddTransportUnit";
            btnAddTransportUnit.Padding = new Padding(0, 6, 0, 6);
            btnAddTransportUnit.Size = new Size(94, 39);
            btnAddTransportUnit.TabIndex = 214;
            btnAddTransportUnit.Text = "Add";
            btnAddTransportUnit.UseVisualStyleBackColor = false;
            btnAddTransportUnit.Click += btnAddTransportUnit_Click;
            // 
            // txtTransportUnitId
            // 
            txtTransportUnitId.Font = new Font("Segoe UI", 11.25F);
            txtTransportUnitId.Location = new Point(910, 724);
            txtTransportUnitId.Margin = new Padding(2, 3, 2, 3);
            txtTransportUnitId.Name = "txtTransportUnitId";
            txtTransportUnitId.Size = new Size(235, 27);
            txtTransportUnitId.TabIndex = 212;
            // 
            // lblTransportUnitId
            // 
            lblTransportUnitId.AutoSize = true;
            lblTransportUnitId.Font = new Font("Segoe UI Semibold", 12F);
            lblTransportUnitId.Location = new Point(791, 724);
            lblTransportUnitId.Margin = new Padding(2, 0, 2, 0);
            lblTransportUnitId.Name = "lblTransportUnitId";
            lblTransportUnitId.Size = new Size(50, 21);
            lblTransportUnitId.TabIndex = 213;
            lblTransportUnitId.Text = "TU ID";
            // 
            // btnRemoveLoad
            // 
            btnRemoveLoad.BackColor = Color.FromArgb(198, 40, 40);
            btnRemoveLoad.Cursor = Cursors.Hand;
            btnRemoveLoad.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemoveLoad.ForeColor = Color.White;
            btnRemoveLoad.Location = new Point(466, 846);
            btnRemoveLoad.Margin = new Padding(2, 3, 2, 3);
            btnRemoveLoad.Name = "btnRemoveLoad";
            btnRemoveLoad.Padding = new Padding(0, 6, 0, 6);
            btnRemoveLoad.Size = new Size(94, 39);
            btnRemoveLoad.TabIndex = 211;
            btnRemoveLoad.Text = "Remove";
            btnRemoveLoad.UseVisualStyleBackColor = false;
            btnRemoveLoad.Click += btnRemoveLoad_Click;
            // 
            // btnClearLoad
            // 
            btnClearLoad.BackColor = SystemColors.ButtonHighlight;
            btnClearLoad.Cursor = Cursors.Hand;
            btnClearLoad.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClearLoad.ForeColor = SystemColors.WindowText;
            btnClearLoad.Location = new Point(666, 846);
            btnClearLoad.Margin = new Padding(2, 3, 2, 3);
            btnClearLoad.Name = "btnClearLoad";
            btnClearLoad.Padding = new Padding(0, 6, 0, 6);
            btnClearLoad.Size = new Size(94, 39);
            btnClearLoad.TabIndex = 210;
            btnClearLoad.Text = "Clear";
            btnClearLoad.UseVisualStyleBackColor = false;
            btnClearLoad.Click += btnClearLoad_Click;
            // 
            // btnAddLoad
            // 
            btnAddLoad.BackColor = SystemColors.HotTrack;
            btnAddLoad.Cursor = Cursors.Hand;
            btnAddLoad.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddLoad.ForeColor = Color.White;
            btnAddLoad.Location = new Point(566, 846);
            btnAddLoad.Margin = new Padding(2, 3, 2, 3);
            btnAddLoad.Name = "btnAddLoad";
            btnAddLoad.Padding = new Padding(0, 6, 0, 6);
            btnAddLoad.Size = new Size(94, 39);
            btnAddLoad.TabIndex = 209;
            btnAddLoad.Text = "Add Load";
            btnAddLoad.UseVisualStyleBackColor = false;
            btnAddLoad.Click += btnAddLoad_Click;
            // 
            // nmrcLoadWeight
            // 
            nmrcLoadWeight.DecimalPlaces = 2;
            nmrcLoadWeight.Font = new Font("Segoe UI", 11.25F);
            nmrcLoadWeight.Location = new Point(666, 790);
            nmrcLoadWeight.Margin = new Padding(2, 3, 2, 3);
            nmrcLoadWeight.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            nmrcLoadWeight.Name = "nmrcLoadWeight";
            nmrcLoadWeight.Size = new Size(94, 27);
            nmrcLoadWeight.TabIndex = 208;
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Font = new Font("Segoe UI Semibold", 12F);
            lblWeight.Location = new Point(602, 790);
            lblWeight.Margin = new Padding(2, 0, 2, 0);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(63, 21);
            lblWeight.TabIndex = 207;
            lblWeight.Text = "Weight";
            // 
            // nmrcLoadVolume
            // 
            nmrcLoadVolume.DecimalPlaces = 2;
            nmrcLoadVolume.Font = new Font("Segoe UI", 11.25F);
            nmrcLoadVolume.Location = new Point(470, 788);
            nmrcLoadVolume.Margin = new Padding(2, 3, 2, 3);
            nmrcLoadVolume.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            nmrcLoadVolume.Name = "nmrcLoadVolume";
            nmrcLoadVolume.Size = new Size(110, 27);
            nmrcLoadVolume.TabIndex = 206;
            // 
            // lblLoadVolume
            // 
            lblLoadVolume.AutoSize = true;
            lblLoadVolume.Font = new Font("Segoe UI Semibold", 12F);
            lblLoadVolume.Location = new Point(405, 788);
            lblLoadVolume.Margin = new Padding(2, 0, 2, 0);
            lblLoadVolume.Name = "lblLoadVolume";
            lblLoadVolume.Size = new Size(65, 21);
            lblLoadVolume.TabIndex = 205;
            lblLoadVolume.Text = "Volume";
            // 
            // txtLoadDescription
            // 
            txtLoadDescription.Font = new Font("Segoe UI", 11.25F);
            txtLoadDescription.Location = new Point(525, 724);
            txtLoadDescription.Margin = new Padding(2, 3, 2, 3);
            txtLoadDescription.Name = "txtLoadDescription";
            txtLoadDescription.Size = new Size(235, 27);
            txtLoadDescription.TabIndex = 203;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F);
            label1.Location = new Point(405, 724);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(94, 21);
            label1.TabIndex = 204;
            label1.Text = "Description";
            // 
            // txtCustomer
            // 
            txtCustomer.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCustomer.Location = new Point(137, 95);
            txtCustomer.Margin = new Padding(2, 3, 2, 3);
            txtCustomer.Name = "txtCustomer";
            txtCustomer.ReadOnly = true;
            txtCustomer.Size = new Size(216, 27);
            txtCustomer.TabIndex = 202;
            txtCustomer.Text = "Supun";
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Font = new Font("Segoe UI Semibold", 12F);
            lblCustomerName.Location = new Point(20, 95);
            lblCustomerName.Margin = new Padding(2, 0, 2, 0);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(81, 21);
            lblCustomerName.TabIndex = 201;
            lblCustomerName.Text = "Customer";
            // 
            // cmbStatus
            // 
            cmbStatus.Font = new Font("Segoe UI", 11.25F);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "PENDING", "ACCEPTED", "IN_PROGRESS", "COMPLETED", "CANCELED", "REJECTED", "DELETED" });
            cmbStatus.Location = new Point(140, 728);
            cmbStatus.Margin = new Padding(2, 3, 2, 3);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(214, 28);
            cmbStatus.TabIndex = 200;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI Semibold", 12F);
            lblStatus.Location = new Point(21, 730);
            lblStatus.Margin = new Padding(2, 0, 2, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(55, 21);
            lblStatus.TabIndex = 199;
            lblStatus.Text = "Status";
            // 
            // txtActualCost
            // 
            txtActualCost.Font = new Font("Segoe UI", 11.25F);
            txtActualCost.Location = new Point(140, 666);
            txtActualCost.Margin = new Padding(2, 3, 2, 3);
            txtActualCost.Name = "txtActualCost";
            txtActualCost.Size = new Size(214, 27);
            txtActualCost.TabIndex = 196;
            // 
            // lblAcutalCost
            // 
            lblAcutalCost.AutoSize = true;
            lblAcutalCost.Font = new Font("Segoe UI Semibold", 12F);
            lblAcutalCost.Location = new Point(20, 666);
            lblAcutalCost.Margin = new Padding(2, 0, 2, 0);
            lblAcutalCost.Name = "lblAcutalCost";
            lblAcutalCost.Size = new Size(93, 21);
            lblAcutalCost.TabIndex = 197;
            lblAcutalCost.Text = "Actual Cost";
            // 
            // dgTransportUnit
            // 
            dgTransportUnit.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgTransportUnit.BackgroundColor = Color.Azure;
            dgTransportUnit.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgTransportUnit.Columns.AddRange(new DataGridViewColumn[] { TId, TuId, VehicleId, VehicleRegNo, DriverId, AssistantId, Available });
            dgTransportUnit.Location = new Point(790, 95);
            dgTransportUnit.Margin = new Padding(2, 3, 2, 3);
            dgTransportUnit.Name = "dgTransportUnit";
            dgTransportUnit.RowHeadersWidth = 51;
            dgTransportUnit.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgTransportUnit.Size = new Size(356, 599);
            dgTransportUnit.TabIndex = 195;
            // 
            // TId
            // 
            TId.DataPropertyName = "Id";
            TId.HeaderText = "TId";
            TId.Name = "TId";
            TId.Visible = false;
            // 
            // TuId
            // 
            TuId.DataPropertyName = "TuId";
            TuId.HeaderText = "TuId";
            TuId.Name = "TuId";
            // 
            // VehicleId
            // 
            VehicleId.DataPropertyName = "VehicleId";
            VehicleId.HeaderText = "VehicleId";
            VehicleId.Name = "VehicleId";
            VehicleId.Visible = false;
            // 
            // VehicleRegNo
            // 
            VehicleRegNo.DataPropertyName = "VehicleRegistrationNumber";
            VehicleRegNo.HeaderText = "Vehicle Reg No";
            VehicleRegNo.Name = "VehicleRegNo";
            // 
            // DriverId
            // 
            DriverId.DataPropertyName = "DriverId";
            DriverId.HeaderText = "DriverId";
            DriverId.Name = "DriverId";
            DriverId.Visible = false;
            // 
            // AssistantId
            // 
            AssistantId.DataPropertyName = "AssistantId";
            AssistantId.HeaderText = "AssistantId";
            AssistantId.Name = "AssistantId";
            AssistantId.Visible = false;
            // 
            // Available
            // 
            Available.DataPropertyName = "Available";
            Available.HeaderText = "Available";
            Available.Name = "Available";
            Available.Visible = false;
            // 
            // lblTransportUnit
            // 
            lblTransportUnit.AutoSize = true;
            lblTransportUnit.Font = new Font("Segoe UI Semibold", 12F);
            lblTransportUnit.Location = new Point(787, 51);
            lblTransportUnit.Margin = new Padding(2, 0, 2, 0);
            lblTransportUnit.Name = "lblTransportUnit";
            lblTransportUnit.Size = new Size(114, 21);
            lblTransportUnit.TabIndex = 194;
            lblTransportUnit.Text = "Transport Unit";
            // 
            // lblLoad
            // 
            lblLoad.AutoSize = true;
            lblLoad.Font = new Font("Segoe UI Semibold", 12F);
            lblLoad.Location = new Point(404, 51);
            lblLoad.Margin = new Padding(2, 0, 2, 0);
            lblLoad.Name = "lblLoad";
            lblLoad.Size = new Size(53, 21);
            lblLoad.TabIndex = 193;
            lblLoad.Text = "Loads";
            // 
            // dgLoads
            // 
            dgLoads.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgLoads.BackgroundColor = Color.Azure;
            dgLoads.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgLoads.Columns.AddRange(new DataGridViewColumn[] { LoadID, Id, Description, Volume, Weight, JobId });
            dgLoads.Location = new Point(404, 95);
            dgLoads.Margin = new Padding(2, 3, 2, 3);
            dgLoads.Name = "dgLoads";
            dgLoads.RowHeadersWidth = 51;
            dgLoads.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgLoads.Size = new Size(356, 599);
            dgLoads.TabIndex = 192;
            // 
            // LoadID
            // 
            LoadID.DataPropertyName = "LoadId";
            LoadID.HeaderText = "Load ID";
            LoadID.Name = "LoadID";
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.Visible = false;
            // 
            // Description
            // 
            Description.DataPropertyName = "Description";
            Description.HeaderText = "Description";
            Description.Name = "Description";
            // 
            // Volume
            // 
            Volume.DataPropertyName = "Volume";
            Volume.HeaderText = "Volume";
            Volume.Name = "Volume";
            // 
            // Weight
            // 
            Weight.DataPropertyName = "Weight";
            Weight.HeaderText = "Weight";
            Weight.Name = "Weight";
            // 
            // JobId
            // 
            JobId.DataPropertyName = "JobId";
            JobId.HeaderText = "JobId";
            JobId.Name = "JobId";
            JobId.Visible = false;
            // 
            // txtEstimatedCost
            // 
            txtEstimatedCost.Font = new Font("Segoe UI", 11.25F);
            txtEstimatedCost.Location = new Point(140, 604);
            txtEstimatedCost.Margin = new Padding(2, 3, 2, 3);
            txtEstimatedCost.Name = "txtEstimatedCost";
            txtEstimatedCost.Size = new Size(214, 27);
            txtEstimatedCost.TabIndex = 185;
            // 
            // lblEstimatedCost
            // 
            lblEstimatedCost.AutoSize = true;
            lblEstimatedCost.Font = new Font("Segoe UI Semibold", 12F);
            lblEstimatedCost.Location = new Point(20, 604);
            lblEstimatedCost.Margin = new Padding(2, 0, 2, 0);
            lblEstimatedCost.Name = "lblEstimatedCost";
            lblEstimatedCost.Size = new Size(119, 21);
            lblEstimatedCost.TabIndex = 191;
            lblEstimatedCost.Text = "Estimated Cost";
            // 
            // dtTmPckrScheduledDate
            // 
            dtTmPckrScheduledDate.Font = new Font("Segoe UI", 11.25F);
            dtTmPckrScheduledDate.Location = new Point(140, 521);
            dtTmPckrScheduledDate.Margin = new Padding(2, 3, 2, 3);
            dtTmPckrScheduledDate.Name = "dtTmPckrScheduledDate";
            dtTmPckrScheduledDate.Size = new Size(214, 27);
            dtTmPckrScheduledDate.TabIndex = 183;
            // 
            // rchTxtDescription
            // 
            rchTxtDescription.Font = new Font("Segoe UI", 11.25F);
            rchTxtDescription.Location = new Point(139, 405);
            rchTxtDescription.Margin = new Padding(2, 3, 2, 3);
            rchTxtDescription.Name = "rchTxtDescription";
            rchTxtDescription.Size = new Size(214, 87);
            rchTxtDescription.TabIndex = 182;
            rchTxtDescription.Text = "";
            // 
            // rchTxtDelivery
            // 
            rchTxtDelivery.Font = new Font("Segoe UI", 11.25F);
            rchTxtDelivery.Location = new Point(139, 278);
            rchTxtDelivery.Margin = new Padding(2, 3, 2, 3);
            rchTxtDelivery.Name = "rchTxtDelivery";
            rchTxtDelivery.Size = new Size(214, 87);
            rchTxtDelivery.TabIndex = 181;
            rchTxtDelivery.Text = "";
            // 
            // rchTxtPickup
            // 
            rchTxtPickup.Font = new Font("Segoe UI", 11.25F);
            rchTxtPickup.Location = new Point(140, 154);
            rchTxtPickup.Margin = new Padding(2, 3, 2, 3);
            rchTxtPickup.Name = "rchTxtPickup";
            rchTxtPickup.Size = new Size(214, 87);
            rchTxtPickup.TabIndex = 180;
            rchTxtPickup.Text = "";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ButtonHighlight;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = SystemColors.WindowText;
            btnCancel.Location = new Point(271, 790);
            btnCancel.Margin = new Padding(2, 3, 2, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Padding = new Padding(0, 6, 0, 6);
            btnCancel.Size = new Size(94, 39);
            btnCancel.TabIndex = 187;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.HotTrack;
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(153, 790);
            btnUpdate.Margin = new Padding(2, 3, 2, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Padding = new Padding(0, 6, 0, 6);
            btnUpdate.Size = new Size(94, 39);
            btnUpdate.TabIndex = 186;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lblScheduledDate
            // 
            lblScheduledDate.AutoSize = true;
            lblScheduledDate.Font = new Font("Segoe UI Semibold", 12F);
            lblScheduledDate.Location = new Point(20, 521);
            lblScheduledDate.Margin = new Padding(2, 0, 2, 0);
            lblScheduledDate.Name = "lblScheduledDate";
            lblScheduledDate.Size = new Size(125, 21);
            lblScheduledDate.TabIndex = 190;
            lblScheduledDate.Text = "Scheduled Date";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI Semibold", 12F);
            lblDescription.Location = new Point(19, 402);
            lblDescription.Margin = new Padding(2, 0, 2, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(94, 21);
            lblDescription.TabIndex = 189;
            lblDescription.Text = "Description";
            // 
            // lblDelivery
            // 
            lblDelivery.AutoSize = true;
            lblDelivery.Font = new Font("Segoe UI Semibold", 12F);
            lblDelivery.Location = new Point(19, 276);
            lblDelivery.Margin = new Padding(2, 0, 2, 0);
            lblDelivery.Name = "lblDelivery";
            lblDelivery.Size = new Size(70, 21);
            lblDelivery.TabIndex = 188;
            lblDelivery.Text = "Delivery";
            // 
            // lblPickup
            // 
            lblPickup.AutoSize = true;
            lblPickup.Font = new Font("Segoe UI Semibold", 12F);
            lblPickup.Location = new Point(20, 152);
            lblPickup.Margin = new Padding(2, 0, 2, 0);
            lblPickup.Name = "lblPickup";
            lblPickup.Size = new Size(58, 21);
            lblPickup.TabIndex = 184;
            lblPickup.Text = "Pickup";
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormTitle.ForeColor = SystemColors.WindowText;
            lblFormTitle.Location = new Point(20, 29);
            lblFormTitle.Margin = new Padding(2, 0, 2, 0);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(306, 30);
            lblFormTitle.TabIndex = 177;
            lblFormTitle.Text = "Update Job #JOB20250720001";
            // 
            // lblPickUpErrorMessage
            // 
            lblPickUpErrorMessage.AutoSize = true;
            lblPickUpErrorMessage.ForeColor = Color.Red;
            lblPickUpErrorMessage.Location = new Point(140, 244);
            lblPickUpErrorMessage.Name = "lblPickUpErrorMessage";
            lblPickUpErrorMessage.Size = new Size(81, 15);
            lblPickUpErrorMessage.TabIndex = 217;
            lblPickUpErrorMessage.Text = "error message";
            // 
            // lblDeliveryErrorMessage
            // 
            lblDeliveryErrorMessage.AutoSize = true;
            lblDeliveryErrorMessage.ForeColor = Color.Red;
            lblDeliveryErrorMessage.Location = new Point(137, 368);
            lblDeliveryErrorMessage.Name = "lblDeliveryErrorMessage";
            lblDeliveryErrorMessage.Size = new Size(81, 15);
            lblDeliveryErrorMessage.TabIndex = 218;
            lblDeliveryErrorMessage.Text = "error message";
            // 
            // lblScheduleDateErrorMessage
            // 
            lblScheduleDateErrorMessage.AutoSize = true;
            lblScheduleDateErrorMessage.ForeColor = Color.Red;
            lblScheduleDateErrorMessage.Location = new Point(140, 560);
            lblScheduleDateErrorMessage.Name = "lblScheduleDateErrorMessage";
            lblScheduleDateErrorMessage.Size = new Size(81, 15);
            lblScheduleDateErrorMessage.TabIndex = 219;
            lblScheduleDateErrorMessage.Text = "error message";
            // 
            // lblEstimatedCostErrorMessage
            // 
            lblEstimatedCostErrorMessage.AutoSize = true;
            lblEstimatedCostErrorMessage.ForeColor = Color.Red;
            lblEstimatedCostErrorMessage.Location = new Point(140, 634);
            lblEstimatedCostErrorMessage.Name = "lblEstimatedCostErrorMessage";
            lblEstimatedCostErrorMessage.Size = new Size(81, 15);
            lblEstimatedCostErrorMessage.TabIndex = 220;
            lblEstimatedCostErrorMessage.Text = "error message";
            // 
            // lblActualCostErrorMessage
            // 
            lblActualCostErrorMessage.AutoSize = true;
            lblActualCostErrorMessage.ForeColor = Color.Red;
            lblActualCostErrorMessage.Location = new Point(139, 696);
            lblActualCostErrorMessage.Name = "lblActualCostErrorMessage";
            lblActualCostErrorMessage.Size = new Size(81, 15);
            lblActualCostErrorMessage.TabIndex = 221;
            lblActualCostErrorMessage.Text = "error message";
            // 
            // lblStatusErrorMessage
            // 
            lblStatusErrorMessage.AutoSize = true;
            lblStatusErrorMessage.ForeColor = Color.Red;
            lblStatusErrorMessage.Location = new Point(140, 759);
            lblStatusErrorMessage.Name = "lblStatusErrorMessage";
            lblStatusErrorMessage.Size = new Size(81, 15);
            lblStatusErrorMessage.TabIndex = 222;
            lblStatusErrorMessage.Text = "error message";
            // 
            // lblLoadVoloumeErrorMessage
            // 
            lblLoadVoloumeErrorMessage.AutoSize = true;
            lblLoadVoloumeErrorMessage.ForeColor = Color.Red;
            lblLoadVoloumeErrorMessage.Location = new Point(470, 818);
            lblLoadVoloumeErrorMessage.Name = "lblLoadVoloumeErrorMessage";
            lblLoadVoloumeErrorMessage.Size = new Size(81, 15);
            lblLoadVoloumeErrorMessage.TabIndex = 223;
            lblLoadVoloumeErrorMessage.Text = "error message";
            // 
            // lblLoadWeightErrorMessage
            // 
            lblLoadWeightErrorMessage.AutoSize = true;
            lblLoadWeightErrorMessage.ForeColor = Color.Red;
            lblLoadWeightErrorMessage.Location = new Point(666, 820);
            lblLoadWeightErrorMessage.Name = "lblLoadWeightErrorMessage";
            lblLoadWeightErrorMessage.Size = new Size(81, 15);
            lblLoadWeightErrorMessage.TabIndex = 224;
            lblLoadWeightErrorMessage.Text = "error message";
            // 
            // UpdateJobForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            BackColor = Color.Azure;
            ClientSize = new Size(1180, 923);
            Controls.Add(lblLoadWeightErrorMessage);
            Controls.Add(lblLoadVoloumeErrorMessage);
            Controls.Add(lblStatusErrorMessage);
            Controls.Add(lblActualCostErrorMessage);
            Controls.Add(lblEstimatedCostErrorMessage);
            Controls.Add(lblScheduleDateErrorMessage);
            Controls.Add(lblDeliveryErrorMessage);
            Controls.Add(lblPickUpErrorMessage);
            Controls.Add(btnRemoveTransportUnit);
            Controls.Add(btnClearTransportUnit);
            Controls.Add(btnAddTransportUnit);
            Controls.Add(txtTransportUnitId);
            Controls.Add(lblTransportUnitId);
            Controls.Add(btnRemoveLoad);
            Controls.Add(btnClearLoad);
            Controls.Add(btnAddLoad);
            Controls.Add(nmrcLoadWeight);
            Controls.Add(lblWeight);
            Controls.Add(nmrcLoadVolume);
            Controls.Add(lblLoadVolume);
            Controls.Add(txtLoadDescription);
            Controls.Add(label1);
            Controls.Add(txtCustomer);
            Controls.Add(lblCustomerName);
            Controls.Add(cmbStatus);
            Controls.Add(lblStatus);
            Controls.Add(txtActualCost);
            Controls.Add(lblAcutalCost);
            Controls.Add(dgTransportUnit);
            Controls.Add(lblTransportUnit);
            Controls.Add(lblLoad);
            Controls.Add(dgLoads);
            Controls.Add(txtEstimatedCost);
            Controls.Add(lblEstimatedCost);
            Controls.Add(dtTmPckrScheduledDate);
            Controls.Add(rchTxtDescription);
            Controls.Add(rchTxtDelivery);
            Controls.Add(rchTxtPickup);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(lblScheduledDate);
            Controls.Add(lblDescription);
            Controls.Add(lblDelivery);
            Controls.Add(lblPickup);
            Controls.Add(lblFormTitle);
            Margin = new Padding(2, 3, 2, 3);
            MaximizeBox = false;
            Name = "UpdateJobForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Update Job";
            Load += UpdateJobForm_Load;
            ((System.ComponentModel.ISupportInitialize)nmrcLoadWeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrcLoadVolume).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgTransportUnit).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgLoads).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRemoveTransportUnit;
        private Button btnClearTransportUnit;
        private Button btnAddTransportUnit;
        private TextBox txtTransportUnitId;
        private Label lblTransportUnitId;
        private Button btnRemoveLoad;
        private Button btnClearLoad;
        private Button btnAddLoad;
        private NumericUpDown nmrcLoadWeight;
        private Label lblWeight;
        private NumericUpDown nmrcLoadVolume;
        private Label lblLoadVolume;
        private TextBox txtLoadDescription;
        private Label label1;
        private TextBox txtCustomer;
        private Label lblCustomerName;
        private ComboBox cmbStatus;
        private Label lblStatus;
        private TextBox txtActualCost;
        private Label lblAcutalCost;
        private DataGridView dgTransportUnit;
        private Label lblTransportUnit;
        private Label lblLoad;
        private DataGridView dgLoads;
        private TextBox txtEstimatedCost;
        private Label lblEstimatedCost;
        private DateTimePicker dtTmPckrScheduledDate;
        private RichTextBox rchTxtDescription;
        private RichTextBox rchTxtDelivery;
        private RichTextBox rchTxtPickup;
        private Button btnCancel;
        private Button btnUpdate;
        private Label lblScheduledDate;
        private Label lblDescription;
        private Label lblDelivery;
        private Label lblPickup;
        private Label lblFormTitle;
        private Label lblPickUpErrorMessage;
        private Label lblDeliveryErrorMessage;
        private Label lblScheduleDateErrorMessage;
        private Label lblEstimatedCostErrorMessage;
        private Label lblActualCostErrorMessage;
        private Label lblStatusErrorMessage;
        private Label lblLoadVoloumeErrorMessage;
        private Label lblLoadWeightErrorMessage;
        private DataGridViewTextBoxColumn TId;
        private DataGridViewTextBoxColumn TuId;
        private DataGridViewTextBoxColumn VehicleId;
        private DataGridViewTextBoxColumn VehicleRegNo;
        private DataGridViewTextBoxColumn DriverId;
        private DataGridViewTextBoxColumn AssistantId;
        private DataGridViewTextBoxColumn Available;
        private DataGridViewTextBoxColumn LoadID;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Volume;
        private DataGridViewTextBoxColumn Weight;
        private DataGridViewTextBoxColumn JobId;
    }
}