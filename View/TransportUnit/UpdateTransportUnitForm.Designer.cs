namespace eshift.View.TransportUnit
{
    partial class UpdateTransportUnitForm
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
            btnCancel = new Button();
            btnUpdate = new Button();
            lblMaxWeight = new Label();
            txtContainerMaxWeight = new TextBox();
            lblContainerVolume = new Label();
            txtContainerVolume = new TextBox();
            lblContainerDetails = new Label();
            txtVehicleName = new TextBox();
            lblVehicleName = new Label();
            btnAddVehicle = new Button();
            txtVehicleRegNo = new TextBox();
            lblVehicleRegNo = new Label();
            txtAssistantName = new TextBox();
            lblAssistantName = new Label();
            btnAddAssistant = new Button();
            txtAssistantId = new TextBox();
            lblAssistantId = new Label();
            txtDriverName = new TextBox();
            lblDriverName = new Label();
            btnAddDriver = new Button();
            txtDriverId = new TextBox();
            lblDriverId = new Label();
            lblFormTitle = new Label();
            lblDriverErrorMessage = new Label();
            lblAssistantErrorMessage = new Label();
            lblVehicleErrorMessage = new Label();
            lblAvailability = new Label();
            cmbAvailability = new ComboBox();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ButtonHighlight;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = SystemColors.WindowText;
            btnCancel.Location = new Point(277, 589);
            btnCancel.Name = "btnCancel";
            btnCancel.Padding = new Padding(0, 5, 0, 5);
            btnCancel.Size = new Size(103, 37);
            btnCancel.TabIndex = 101;
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
            btnUpdate.Location = new Point(153, 589);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Padding = new Padding(0, 5, 0, 5);
            btnUpdate.Size = new Size(103, 37);
            btnUpdate.TabIndex = 100;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lblMaxWeight
            // 
            lblMaxWeight.AutoSize = true;
            lblMaxWeight.Font = new Font("Segoe UI Semibold", 12F);
            lblMaxWeight.Location = new Point(25, 498);
            lblMaxWeight.Name = "lblMaxWeight";
            lblMaxWeight.Size = new Size(98, 21);
            lblMaxWeight.TabIndex = 99;
            lblMaxWeight.Text = "Max Weight";
            // 
            // txtContainerMaxWeight
            // 
            txtContainerMaxWeight.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContainerMaxWeight.Location = new Point(153, 496);
            txtContainerMaxWeight.Name = "txtContainerMaxWeight";
            txtContainerMaxWeight.ReadOnly = true;
            txtContainerMaxWeight.Size = new Size(227, 27);
            txtContainerMaxWeight.TabIndex = 98;
            txtContainerMaxWeight.Text = "750";
            // 
            // lblContainerVolume
            // 
            lblContainerVolume.AutoSize = true;
            lblContainerVolume.Font = new Font("Segoe UI Semibold", 12F);
            lblContainerVolume.Location = new Point(25, 448);
            lblContainerVolume.Name = "lblContainerVolume";
            lblContainerVolume.Size = new Size(65, 21);
            lblContainerVolume.TabIndex = 97;
            lblContainerVolume.Text = "Volume";
            // 
            // txtContainerVolume
            // 
            txtContainerVolume.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContainerVolume.Location = new Point(153, 446);
            txtContainerVolume.Name = "txtContainerVolume";
            txtContainerVolume.ReadOnly = true;
            txtContainerVolume.Size = new Size(227, 27);
            txtContainerVolume.TabIndex = 96;
            txtContainerVolume.Text = "1000";
            // 
            // lblContainerDetails
            // 
            lblContainerDetails.AutoSize = true;
            lblContainerDetails.Font = new Font("Segoe UI Semibold", 12F);
            lblContainerDetails.Location = new Point(25, 402);
            lblContainerDetails.Name = "lblContainerDetails";
            lblContainerDetails.Size = new Size(134, 21);
            lblContainerDetails.TabIndex = 95;
            lblContainerDetails.Text = "Container Details";
            // 
            // txtVehicleName
            // 
            txtVehicleName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtVehicleName.Location = new Point(153, 351);
            txtVehicleName.Name = "txtVehicleName";
            txtVehicleName.ReadOnly = true;
            txtVehicleName.Size = new Size(227, 27);
            txtVehicleName.TabIndex = 94;
            txtVehicleName.Text = "Toyota |  Dyna";
            // 
            // lblVehicleName
            // 
            lblVehicleName.AutoSize = true;
            lblVehicleName.Font = new Font("Segoe UI Semibold", 12F);
            lblVehicleName.Location = new Point(25, 351);
            lblVehicleName.Name = "lblVehicleName";
            lblVehicleName.Size = new Size(116, 21);
            lblVehicleName.TabIndex = 93;
            lblVehicleName.Text = "Brand / Model";
            // 
            // btnAddVehicle
            // 
            btnAddVehicle.Cursor = Cursors.Hand;
            btnAddVehicle.Location = new Point(421, 304);
            btnAddVehicle.Name = "btnAddVehicle";
            btnAddVehicle.Size = new Size(75, 27);
            btnAddVehicle.TabIndex = 92;
            btnAddVehicle.Text = "Add";
            btnAddVehicle.UseVisualStyleBackColor = true;
            btnAddVehicle.Click += btnAddVehicle_Click;
            // 
            // txtVehicleRegNo
            // 
            txtVehicleRegNo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtVehicleRegNo.Location = new Point(153, 304);
            txtVehicleRegNo.Name = "txtVehicleRegNo";
            txtVehicleRegNo.Size = new Size(227, 27);
            txtVehicleRegNo.TabIndex = 91;
            // 
            // lblVehicleRegNo
            // 
            lblVehicleRegNo.AutoSize = true;
            lblVehicleRegNo.Font = new Font("Segoe UI Semibold", 12F);
            lblVehicleRegNo.Location = new Point(25, 306);
            lblVehicleRegNo.Name = "lblVehicleRegNo";
            lblVehicleRegNo.Size = new Size(121, 21);
            lblVehicleRegNo.TabIndex = 90;
            lblVehicleRegNo.Text = "Vehicle Reg No";
            // 
            // txtAssistantName
            // 
            txtAssistantName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAssistantName.Location = new Point(153, 238);
            txtAssistantName.Name = "txtAssistantName";
            txtAssistantName.ReadOnly = true;
            txtAssistantName.Size = new Size(227, 27);
            txtAssistantName.TabIndex = 89;
            txtAssistantName.Text = "Supun";
            // 
            // lblAssistantName
            // 
            lblAssistantName.AutoSize = true;
            lblAssistantName.Font = new Font("Segoe UI Semibold", 12F);
            lblAssistantName.Location = new Point(25, 238);
            lblAssistantName.Name = "lblAssistantName";
            lblAssistantName.Size = new Size(53, 21);
            lblAssistantName.TabIndex = 88;
            lblAssistantName.Text = "Name";
            // 
            // btnAddAssistant
            // 
            btnAddAssistant.Cursor = Cursors.Hand;
            btnAddAssistant.Location = new Point(421, 190);
            btnAddAssistant.Name = "btnAddAssistant";
            btnAddAssistant.Size = new Size(75, 27);
            btnAddAssistant.TabIndex = 87;
            btnAddAssistant.Text = "Add";
            btnAddAssistant.UseVisualStyleBackColor = true;
            btnAddAssistant.Click += btnAddAssistant_Click;
            // 
            // txtAssistantId
            // 
            txtAssistantId.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAssistantId.Location = new Point(153, 191);
            txtAssistantId.Name = "txtAssistantId";
            txtAssistantId.Size = new Size(227, 27);
            txtAssistantId.TabIndex = 86;
            // 
            // lblAssistantId
            // 
            lblAssistantId.AutoSize = true;
            lblAssistantId.Font = new Font("Segoe UI Semibold", 12F);
            lblAssistantId.Location = new Point(25, 193);
            lblAssistantId.Name = "lblAssistantId";
            lblAssistantId.Size = new Size(95, 21);
            lblAssistantId.TabIndex = 85;
            lblAssistantId.Text = "Assistant ID";
            // 
            // txtDriverName
            // 
            txtDriverName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDriverName.Location = new Point(153, 131);
            txtDriverName.Name = "txtDriverName";
            txtDriverName.ReadOnly = true;
            txtDriverName.Size = new Size(227, 27);
            txtDriverName.TabIndex = 84;
            txtDriverName.Text = "Kasun";
            // 
            // lblDriverName
            // 
            lblDriverName.AutoSize = true;
            lblDriverName.Font = new Font("Segoe UI Semibold", 12F);
            lblDriverName.Location = new Point(25, 131);
            lblDriverName.Name = "lblDriverName";
            lblDriverName.Size = new Size(53, 21);
            lblDriverName.TabIndex = 83;
            lblDriverName.Text = "Name";
            // 
            // btnAddDriver
            // 
            btnAddDriver.Cursor = Cursors.Hand;
            btnAddDriver.Location = new Point(421, 83);
            btnAddDriver.Name = "btnAddDriver";
            btnAddDriver.Size = new Size(75, 27);
            btnAddDriver.TabIndex = 82;
            btnAddDriver.Text = "Add";
            btnAddDriver.UseVisualStyleBackColor = true;
            btnAddDriver.Click += btnAddDriver_Click;
            // 
            // txtDriverId
            // 
            txtDriverId.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDriverId.Location = new Point(153, 84);
            txtDriverId.Name = "txtDriverId";
            txtDriverId.Size = new Size(227, 27);
            txtDriverId.TabIndex = 81;
            // 
            // lblDriverId
            // 
            lblDriverId.AutoSize = true;
            lblDriverId.Font = new Font("Segoe UI Semibold", 12F);
            lblDriverId.Location = new Point(25, 86);
            lblDriverId.Name = "lblDriverId";
            lblDriverId.Size = new Size(74, 21);
            lblDriverId.TabIndex = 80;
            lblDriverId.Text = "Driver ID";
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormTitle.ForeColor = SystemColors.WindowText;
            lblFormTitle.Location = new Point(25, 26);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(229, 30);
            lblFormTitle.TabIndex = 79;
            lblFormTitle.Text = "Update Transport Unit";
            // 
            // lblDriverErrorMessage
            // 
            lblDriverErrorMessage.AutoSize = true;
            lblDriverErrorMessage.ForeColor = Color.Red;
            lblDriverErrorMessage.Location = new Point(153, 111);
            lblDriverErrorMessage.Name = "lblDriverErrorMessage";
            lblDriverErrorMessage.Size = new Size(81, 15);
            lblDriverErrorMessage.TabIndex = 102;
            lblDriverErrorMessage.Text = "error message";
            lblDriverErrorMessage.Visible = false;
            // 
            // lblAssistantErrorMessage
            // 
            lblAssistantErrorMessage.AutoSize = true;
            lblAssistantErrorMessage.ForeColor = Color.Red;
            lblAssistantErrorMessage.Location = new Point(153, 220);
            lblAssistantErrorMessage.Name = "lblAssistantErrorMessage";
            lblAssistantErrorMessage.Size = new Size(81, 15);
            lblAssistantErrorMessage.TabIndex = 103;
            lblAssistantErrorMessage.Text = "error message";
            lblAssistantErrorMessage.Visible = false;
            // 
            // lblVehicleErrorMessage
            // 
            lblVehicleErrorMessage.AutoSize = true;
            lblVehicleErrorMessage.ForeColor = Color.Red;
            lblVehicleErrorMessage.Location = new Point(153, 333);
            lblVehicleErrorMessage.Name = "lblVehicleErrorMessage";
            lblVehicleErrorMessage.Size = new Size(81, 15);
            lblVehicleErrorMessage.TabIndex = 104;
            lblVehicleErrorMessage.Text = "error message";
            lblVehicleErrorMessage.Visible = false;
            // 
            // lblAvailability
            // 
            lblAvailability.AutoSize = true;
            lblAvailability.Font = new Font("Segoe UI Semibold", 12F);
            lblAvailability.Location = new Point(27, 552);
            lblAvailability.Name = "lblAvailability";
            lblAvailability.Size = new Size(89, 21);
            lblAvailability.TabIndex = 106;
            lblAvailability.Text = "Availability";
            // 
            // cmbAvailability
            // 
            cmbAvailability.BackColor = SystemColors.Window;
            cmbAvailability.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAvailability.FormattingEnabled = true;
            cmbAvailability.Items.AddRange(new object[] { "Yes", "No" });
            cmbAvailability.Location = new Point(153, 552);
            cmbAvailability.Margin = new Padding(3, 2, 3, 2);
            cmbAvailability.Name = "cmbAvailability";
            cmbAvailability.Size = new Size(227, 23);
            cmbAvailability.TabIndex = 105;
            // 
            // UpdateTransportUnitForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(532, 654);
            Controls.Add(lblAvailability);
            Controls.Add(cmbAvailability);
            Controls.Add(lblVehicleErrorMessage);
            Controls.Add(lblAssistantErrorMessage);
            Controls.Add(lblDriverErrorMessage);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(lblMaxWeight);
            Controls.Add(txtContainerMaxWeight);
            Controls.Add(lblContainerVolume);
            Controls.Add(txtContainerVolume);
            Controls.Add(lblContainerDetails);
            Controls.Add(txtVehicleName);
            Controls.Add(lblVehicleName);
            Controls.Add(btnAddVehicle);
            Controls.Add(txtVehicleRegNo);
            Controls.Add(lblVehicleRegNo);
            Controls.Add(txtAssistantName);
            Controls.Add(lblAssistantName);
            Controls.Add(btnAddAssistant);
            Controls.Add(txtAssistantId);
            Controls.Add(lblAssistantId);
            Controls.Add(txtDriverName);
            Controls.Add(lblDriverName);
            Controls.Add(btnAddDriver);
            Controls.Add(txtDriverId);
            Controls.Add(lblDriverId);
            Controls.Add(lblFormTitle);
            MaximizeBox = false;
            Name = "UpdateTransportUnitForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateTransportUnitForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnUpdate;
        private Label lblMaxWeight;
        private TextBox txtContainerMaxWeight;
        private Label lblContainerVolume;
        private TextBox txtContainerVolume;
        private Label lblContainerDetails;
        private TextBox txtVehicleName;
        private Label lblVehicleName;
        private Button btnAddVehicle;
        private TextBox txtVehicleRegNo;
        private Label lblVehicleRegNo;
        private TextBox txtAssistantName;
        private Label lblAssistantName;
        private Button btnAddAssistant;
        private TextBox txtAssistantId;
        private Label lblAssistantId;
        private TextBox txtDriverName;
        private Label lblDriverName;
        private Button btnAddDriver;
        private TextBox txtDriverId;
        private Label lblDriverId;
        private Label lblFormTitle;
        private Label lblDriverErrorMessage;
        private Label lblAssistantErrorMessage;
        private Label lblVehicleErrorMessage;
        private Label lblAvailability;
        private ComboBox cmbAvailability;
    }
}