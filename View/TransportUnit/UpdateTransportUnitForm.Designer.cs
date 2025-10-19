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
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ButtonHighlight;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = SystemColors.WindowText;
            btnCancel.Location = new Point(317, 736);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Padding = new Padding(0, 7, 0, 7);
            btnCancel.Size = new Size(118, 49);
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
            btnUpdate.Location = new Point(175, 736);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Padding = new Padding(0, 7, 0, 7);
            btnUpdate.Size = new Size(118, 49);
            btnUpdate.TabIndex = 100;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lblMaxWeight
            // 
            lblMaxWeight.AutoSize = true;
            lblMaxWeight.Font = new Font("Segoe UI Semibold", 12F);
            lblMaxWeight.Location = new Point(29, 664);
            lblMaxWeight.Name = "lblMaxWeight";
            lblMaxWeight.Size = new Size(121, 28);
            lblMaxWeight.TabIndex = 99;
            lblMaxWeight.Text = "Max Weight";
            // 
            // txtContainerMaxWeight
            // 
            txtContainerMaxWeight.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContainerMaxWeight.Location = new Point(175, 661);
            txtContainerMaxWeight.Margin = new Padding(3, 4, 3, 4);
            txtContainerMaxWeight.Name = "txtContainerMaxWeight";
            txtContainerMaxWeight.ReadOnly = true;
            txtContainerMaxWeight.Size = new Size(259, 32);
            txtContainerMaxWeight.TabIndex = 98;
            txtContainerMaxWeight.Text = "750";
            // 
            // lblContainerVolume
            // 
            lblContainerVolume.AutoSize = true;
            lblContainerVolume.Font = new Font("Segoe UI Semibold", 12F);
            lblContainerVolume.Location = new Point(29, 597);
            lblContainerVolume.Name = "lblContainerVolume";
            lblContainerVolume.Size = new Size(82, 28);
            lblContainerVolume.TabIndex = 97;
            lblContainerVolume.Text = "Volume";
            // 
            // txtContainerVolume
            // 
            txtContainerVolume.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContainerVolume.Location = new Point(175, 595);
            txtContainerVolume.Margin = new Padding(3, 4, 3, 4);
            txtContainerVolume.Name = "txtContainerVolume";
            txtContainerVolume.ReadOnly = true;
            txtContainerVolume.Size = new Size(259, 32);
            txtContainerVolume.TabIndex = 96;
            txtContainerVolume.Text = "1000";
            // 
            // lblContainerDetails
            // 
            lblContainerDetails.AutoSize = true;
            lblContainerDetails.Font = new Font("Segoe UI Semibold", 12F);
            lblContainerDetails.Location = new Point(29, 536);
            lblContainerDetails.Name = "lblContainerDetails";
            lblContainerDetails.Size = new Size(167, 28);
            lblContainerDetails.TabIndex = 95;
            lblContainerDetails.Text = "Container Details";
            // 
            // txtVehicleName
            // 
            txtVehicleName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtVehicleName.Location = new Point(175, 468);
            txtVehicleName.Margin = new Padding(3, 4, 3, 4);
            txtVehicleName.Name = "txtVehicleName";
            txtVehicleName.ReadOnly = true;
            txtVehicleName.Size = new Size(259, 32);
            txtVehicleName.TabIndex = 94;
            txtVehicleName.Text = "Toyota |  Dyna";
            // 
            // lblVehicleName
            // 
            lblVehicleName.AutoSize = true;
            lblVehicleName.Font = new Font("Segoe UI Semibold", 12F);
            lblVehicleName.Location = new Point(29, 468);
            lblVehicleName.Name = "lblVehicleName";
            lblVehicleName.Size = new Size(143, 28);
            lblVehicleName.TabIndex = 93;
            lblVehicleName.Text = "Brand / Model";
            // 
            // btnAddVehicle
            // 
            btnAddVehicle.Cursor = Cursors.Hand;
            btnAddVehicle.Location = new Point(481, 406);
            btnAddVehicle.Margin = new Padding(3, 4, 3, 4);
            btnAddVehicle.Name = "btnAddVehicle";
            btnAddVehicle.Size = new Size(86, 36);
            btnAddVehicle.TabIndex = 92;
            btnAddVehicle.Text = "Add";
            btnAddVehicle.UseVisualStyleBackColor = true;
            btnAddVehicle.Click += btnAddVehicle_Click;
            // 
            // txtVehicleRegNo
            // 
            txtVehicleRegNo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtVehicleRegNo.Location = new Point(175, 405);
            txtVehicleRegNo.Margin = new Padding(3, 4, 3, 4);
            txtVehicleRegNo.Name = "txtVehicleRegNo";
            txtVehicleRegNo.Size = new Size(259, 32);
            txtVehicleRegNo.TabIndex = 91;
            // 
            // lblVehicleRegNo
            // 
            lblVehicleRegNo.AutoSize = true;
            lblVehicleRegNo.Font = new Font("Segoe UI Semibold", 12F);
            lblVehicleRegNo.Location = new Point(29, 408);
            lblVehicleRegNo.Name = "lblVehicleRegNo";
            lblVehicleRegNo.Size = new Size(150, 28);
            lblVehicleRegNo.TabIndex = 90;
            lblVehicleRegNo.Text = "Vehicle Reg No";
            // 
            // txtAssistantName
            // 
            txtAssistantName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAssistantName.Location = new Point(175, 317);
            txtAssistantName.Margin = new Padding(3, 4, 3, 4);
            txtAssistantName.Name = "txtAssistantName";
            txtAssistantName.ReadOnly = true;
            txtAssistantName.Size = new Size(259, 32);
            txtAssistantName.TabIndex = 89;
            txtAssistantName.Text = "Supun";
            // 
            // lblAssistantName
            // 
            lblAssistantName.AutoSize = true;
            lblAssistantName.Font = new Font("Segoe UI Semibold", 12F);
            lblAssistantName.Location = new Point(29, 317);
            lblAssistantName.Name = "lblAssistantName";
            lblAssistantName.Size = new Size(66, 28);
            lblAssistantName.TabIndex = 88;
            lblAssistantName.Text = "Name";
            // 
            // btnAddAssistant
            // 
            btnAddAssistant.Cursor = Cursors.Hand;
            btnAddAssistant.Location = new Point(481, 254);
            btnAddAssistant.Margin = new Padding(3, 4, 3, 4);
            btnAddAssistant.Name = "btnAddAssistant";
            btnAddAssistant.Size = new Size(86, 36);
            btnAddAssistant.TabIndex = 87;
            btnAddAssistant.Text = "Add";
            btnAddAssistant.UseVisualStyleBackColor = true;
            btnAddAssistant.Click += btnAddAssistant_Click;
            // 
            // txtAssistantId
            // 
            txtAssistantId.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAssistantId.Location = new Point(175, 255);
            txtAssistantId.Margin = new Padding(3, 4, 3, 4);
            txtAssistantId.Name = "txtAssistantId";
            txtAssistantId.Size = new Size(259, 32);
            txtAssistantId.TabIndex = 86;
            // 
            // lblAssistantId
            // 
            lblAssistantId.AutoSize = true;
            lblAssistantId.Font = new Font("Segoe UI Semibold", 12F);
            lblAssistantId.Location = new Point(29, 257);
            lblAssistantId.Name = "lblAssistantId";
            lblAssistantId.Size = new Size(119, 28);
            lblAssistantId.TabIndex = 85;
            lblAssistantId.Text = "Assistant ID";
            // 
            // txtDriverName
            // 
            txtDriverName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDriverName.Location = new Point(175, 175);
            txtDriverName.Margin = new Padding(3, 4, 3, 4);
            txtDriverName.Name = "txtDriverName";
            txtDriverName.ReadOnly = true;
            txtDriverName.Size = new Size(259, 32);
            txtDriverName.TabIndex = 84;
            txtDriverName.Text = "Kasun";
            // 
            // lblDriverName
            // 
            lblDriverName.AutoSize = true;
            lblDriverName.Font = new Font("Segoe UI Semibold", 12F);
            lblDriverName.Location = new Point(29, 175);
            lblDriverName.Name = "lblDriverName";
            lblDriverName.Size = new Size(66, 28);
            lblDriverName.TabIndex = 83;
            lblDriverName.Text = "Name";
            // 
            // btnAddDriver
            // 
            btnAddDriver.Cursor = Cursors.Hand;
            btnAddDriver.Location = new Point(481, 111);
            btnAddDriver.Margin = new Padding(3, 4, 3, 4);
            btnAddDriver.Name = "btnAddDriver";
            btnAddDriver.Size = new Size(86, 36);
            btnAddDriver.TabIndex = 82;
            btnAddDriver.Text = "Add";
            btnAddDriver.UseVisualStyleBackColor = true;
            btnAddDriver.Click += btnAddDriver_Click;
            // 
            // txtDriverId
            // 
            txtDriverId.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDriverId.Location = new Point(175, 112);
            txtDriverId.Margin = new Padding(3, 4, 3, 4);
            txtDriverId.Name = "txtDriverId";
            txtDriverId.Size = new Size(259, 32);
            txtDriverId.TabIndex = 81;
            // 
            // lblDriverId
            // 
            lblDriverId.AutoSize = true;
            lblDriverId.Font = new Font("Segoe UI Semibold", 12F);
            lblDriverId.Location = new Point(29, 115);
            lblDriverId.Name = "lblDriverId";
            lblDriverId.Size = new Size(92, 28);
            lblDriverId.TabIndex = 80;
            lblDriverId.Text = "Driver ID";
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormTitle.ForeColor = SystemColors.WindowText;
            lblFormTitle.Location = new Point(29, 35);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(290, 37);
            lblFormTitle.TabIndex = 79;
            lblFormTitle.Text = "Update Transport Unit";
            // 
            // lblDriverErrorMessage
            // 
            lblDriverErrorMessage.AutoSize = true;
            lblDriverErrorMessage.ForeColor = Color.Red;
            lblDriverErrorMessage.Location = new Point(175, 148);
            lblDriverErrorMessage.Name = "lblDriverErrorMessage";
            lblDriverErrorMessage.Size = new Size(103, 20);
            lblDriverErrorMessage.TabIndex = 102;
            lblDriverErrorMessage.Text = "error message";
            lblDriverErrorMessage.Visible = false;
            // 
            // lblAssistantErrorMessage
            // 
            lblAssistantErrorMessage.AutoSize = true;
            lblAssistantErrorMessage.ForeColor = Color.Red;
            lblAssistantErrorMessage.Location = new Point(175, 293);
            lblAssistantErrorMessage.Name = "lblAssistantErrorMessage";
            lblAssistantErrorMessage.Size = new Size(103, 20);
            lblAssistantErrorMessage.TabIndex = 103;
            lblAssistantErrorMessage.Text = "error message";
            lblAssistantErrorMessage.Visible = false;
            // 
            // lblVehicleErrorMessage
            // 
            lblVehicleErrorMessage.AutoSize = true;
            lblVehicleErrorMessage.ForeColor = Color.Red;
            lblVehicleErrorMessage.Location = new Point(175, 444);
            lblVehicleErrorMessage.Name = "lblVehicleErrorMessage";
            lblVehicleErrorMessage.Size = new Size(103, 20);
            lblVehicleErrorMessage.TabIndex = 104;
            lblVehicleErrorMessage.Text = "error message";
            lblVehicleErrorMessage.Visible = false;
            // 
            // UpdateTransportUnitForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(608, 872);
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
            Margin = new Padding(3, 4, 3, 4);
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
    }
}