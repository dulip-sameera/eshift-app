namespace eshift.View.TransportUnit
{
    partial class CreateTransportUnitForm
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
            txtDriverName = new TextBox();
            lblDriverName = new Label();
            btnAddDriver = new Button();
            txtDriverId = new TextBox();
            lblReferenceId = new Label();
            txtAssistantName = new TextBox();
            lblAssistantName = new Label();
            btnAddAssistant = new Button();
            txtAssistantId = new TextBox();
            lblAssistantId = new Label();
            txtVehicleName = new TextBox();
            lblVehicleName = new Label();
            btnAddVehicle = new Button();
            txtVehicleRegNo = new TextBox();
            lblVehicleRegNo = new Label();
            txtContainerVolume = new TextBox();
            lblContainerDetails = new Label();
            lblContainerVolume = new Label();
            lblMaxWeight = new Label();
            txtContainerMaxWeight = new TextBox();
            btnCancel = new Button();
            btnCreate = new Button();
            lblDriverErrorMessage = new Label();
            lblAssistantErrorMessage = new Label();
            lblVehicleErrorMessage = new Label();
            SuspendLayout();
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormTitle.ForeColor = SystemColors.WindowText;
            lblFormTitle.Location = new Point(24, 33);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(280, 37);
            lblFormTitle.TabIndex = 54;
            lblFormTitle.Text = "Create Transport Unit";
            // 
            // txtDriverName
            // 
            txtDriverName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDriverName.Location = new Point(170, 173);
            txtDriverName.Margin = new Padding(3, 4, 3, 4);
            txtDriverName.Name = "txtDriverName";
            txtDriverName.ReadOnly = true;
            txtDriverName.Size = new Size(259, 32);
            txtDriverName.TabIndex = 59;
            // 
            // lblDriverName
            // 
            lblDriverName.AutoSize = true;
            lblDriverName.Font = new Font("Segoe UI Semibold", 12F);
            lblDriverName.Location = new Point(24, 173);
            lblDriverName.Name = "lblDriverName";
            lblDriverName.Size = new Size(66, 28);
            lblDriverName.TabIndex = 58;
            lblDriverName.Text = "Name";
            // 
            // btnAddDriver
            // 
            btnAddDriver.Cursor = Cursors.Hand;
            btnAddDriver.Location = new Point(437, 113);
            btnAddDriver.Margin = new Padding(3, 4, 3, 4);
            btnAddDriver.Name = "btnAddDriver";
            btnAddDriver.Size = new Size(86, 36);
            btnAddDriver.TabIndex = 57;
            btnAddDriver.Text = "Add";
            btnAddDriver.UseVisualStyleBackColor = true;
            btnAddDriver.Click += btnAddDriver_Click;
            // 
            // txtDriverId
            // 
            txtDriverId.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDriverId.Location = new Point(170, 111);
            txtDriverId.Margin = new Padding(3, 4, 3, 4);
            txtDriverId.Name = "txtDriverId";
            txtDriverId.Size = new Size(259, 32);
            txtDriverId.TabIndex = 56;
            // 
            // lblReferenceId
            // 
            lblReferenceId.AutoSize = true;
            lblReferenceId.Font = new Font("Segoe UI Semibold", 12F);
            lblReferenceId.Location = new Point(24, 113);
            lblReferenceId.Name = "lblReferenceId";
            lblReferenceId.Size = new Size(92, 28);
            lblReferenceId.TabIndex = 55;
            lblReferenceId.Text = "Driver ID";
            // 
            // txtAssistantName
            // 
            txtAssistantName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAssistantName.Location = new Point(170, 316);
            txtAssistantName.Margin = new Padding(3, 4, 3, 4);
            txtAssistantName.Name = "txtAssistantName";
            txtAssistantName.ReadOnly = true;
            txtAssistantName.Size = new Size(259, 32);
            txtAssistantName.TabIndex = 66;
            // 
            // lblAssistantName
            // 
            lblAssistantName.AutoSize = true;
            lblAssistantName.Font = new Font("Segoe UI Semibold", 12F);
            lblAssistantName.Location = new Point(24, 316);
            lblAssistantName.Name = "lblAssistantName";
            lblAssistantName.Size = new Size(66, 28);
            lblAssistantName.TabIndex = 65;
            lblAssistantName.Text = "Name";
            // 
            // btnAddAssistant
            // 
            btnAddAssistant.Cursor = Cursors.Hand;
            btnAddAssistant.Location = new Point(437, 256);
            btnAddAssistant.Margin = new Padding(3, 4, 3, 4);
            btnAddAssistant.Name = "btnAddAssistant";
            btnAddAssistant.Size = new Size(86, 36);
            btnAddAssistant.TabIndex = 64;
            btnAddAssistant.Text = "Add";
            btnAddAssistant.UseVisualStyleBackColor = true;
            btnAddAssistant.Click += btnAddAssistant_Click;
            // 
            // txtAssistantId
            // 
            txtAssistantId.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAssistantId.Location = new Point(170, 253);
            txtAssistantId.Margin = new Padding(3, 4, 3, 4);
            txtAssistantId.Name = "txtAssistantId";
            txtAssistantId.Size = new Size(259, 32);
            txtAssistantId.TabIndex = 63;
            // 
            // lblAssistantId
            // 
            lblAssistantId.AutoSize = true;
            lblAssistantId.Font = new Font("Segoe UI Semibold", 12F);
            lblAssistantId.Location = new Point(24, 256);
            lblAssistantId.Name = "lblAssistantId";
            lblAssistantId.Size = new Size(119, 28);
            lblAssistantId.TabIndex = 62;
            lblAssistantId.Text = "Assistant ID";
            // 
            // txtVehicleName
            // 
            txtVehicleName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtVehicleName.Location = new Point(170, 467);
            txtVehicleName.Margin = new Padding(3, 4, 3, 4);
            txtVehicleName.Name = "txtVehicleName";
            txtVehicleName.ReadOnly = true;
            txtVehicleName.Size = new Size(259, 32);
            txtVehicleName.TabIndex = 71;
            // 
            // lblVehicleName
            // 
            lblVehicleName.AutoSize = true;
            lblVehicleName.Font = new Font("Segoe UI Semibold", 12F);
            lblVehicleName.Location = new Point(24, 467);
            lblVehicleName.Name = "lblVehicleName";
            lblVehicleName.Size = new Size(143, 28);
            lblVehicleName.TabIndex = 70;
            lblVehicleName.Text = "Brand / Model";
            // 
            // btnAddVehicle
            // 
            btnAddVehicle.Cursor = Cursors.Hand;
            btnAddVehicle.Location = new Point(437, 407);
            btnAddVehicle.Margin = new Padding(3, 4, 3, 4);
            btnAddVehicle.Name = "btnAddVehicle";
            btnAddVehicle.Size = new Size(86, 36);
            btnAddVehicle.TabIndex = 69;
            btnAddVehicle.Text = "Add";
            btnAddVehicle.UseVisualStyleBackColor = true;
            btnAddVehicle.Click += btnAddVehicle_Click;
            // 
            // txtVehicleRegNo
            // 
            txtVehicleRegNo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtVehicleRegNo.Location = new Point(170, 404);
            txtVehicleRegNo.Margin = new Padding(3, 4, 3, 4);
            txtVehicleRegNo.Name = "txtVehicleRegNo";
            txtVehicleRegNo.Size = new Size(259, 32);
            txtVehicleRegNo.TabIndex = 68;
            // 
            // lblVehicleRegNo
            // 
            lblVehicleRegNo.AutoSize = true;
            lblVehicleRegNo.Font = new Font("Segoe UI Semibold", 12F);
            lblVehicleRegNo.Location = new Point(24, 407);
            lblVehicleRegNo.Name = "lblVehicleRegNo";
            lblVehicleRegNo.Size = new Size(150, 28);
            lblVehicleRegNo.TabIndex = 67;
            lblVehicleRegNo.Text = "Vehicle Reg No";
            // 
            // txtContainerVolume
            // 
            txtContainerVolume.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContainerVolume.Location = new Point(170, 593);
            txtContainerVolume.Margin = new Padding(3, 4, 3, 4);
            txtContainerVolume.Name = "txtContainerVolume";
            txtContainerVolume.ReadOnly = true;
            txtContainerVolume.Size = new Size(259, 32);
            txtContainerVolume.TabIndex = 73;
            // 
            // lblContainerDetails
            // 
            lblContainerDetails.AutoSize = true;
            lblContainerDetails.Font = new Font("Segoe UI Semibold", 12F);
            lblContainerDetails.Location = new Point(24, 535);
            lblContainerDetails.Name = "lblContainerDetails";
            lblContainerDetails.Size = new Size(167, 28);
            lblContainerDetails.TabIndex = 72;
            lblContainerDetails.Text = "Container Details";
            // 
            // lblContainerVolume
            // 
            lblContainerVolume.AutoSize = true;
            lblContainerVolume.Font = new Font("Segoe UI Semibold", 12F);
            lblContainerVolume.Location = new Point(24, 596);
            lblContainerVolume.Name = "lblContainerVolume";
            lblContainerVolume.Size = new Size(82, 28);
            lblContainerVolume.TabIndex = 74;
            lblContainerVolume.Text = "Volume";
            // 
            // lblMaxWeight
            // 
            lblMaxWeight.AutoSize = true;
            lblMaxWeight.Font = new Font("Segoe UI Semibold", 12F);
            lblMaxWeight.Location = new Point(24, 663);
            lblMaxWeight.Name = "lblMaxWeight";
            lblMaxWeight.Size = new Size(121, 28);
            lblMaxWeight.TabIndex = 76;
            lblMaxWeight.Text = "Max Weight";
            // 
            // txtContainerMaxWeight
            // 
            txtContainerMaxWeight.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContainerMaxWeight.Location = new Point(170, 660);
            txtContainerMaxWeight.Margin = new Padding(3, 4, 3, 4);
            txtContainerMaxWeight.Name = "txtContainerMaxWeight";
            txtContainerMaxWeight.ReadOnly = true;
            txtContainerMaxWeight.Size = new Size(259, 32);
            txtContainerMaxWeight.TabIndex = 75;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ButtonHighlight;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = SystemColors.WindowText;
            btnCancel.Location = new Point(312, 735);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Padding = new Padding(0, 7, 0, 7);
            btnCancel.Size = new Size(118, 49);
            btnCancel.TabIndex = 78;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = SystemColors.HotTrack;
            btnCreate.Cursor = Cursors.Hand;
            btnCreate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(170, 735);
            btnCreate.Margin = new Padding(3, 4, 3, 4);
            btnCreate.Name = "btnCreate";
            btnCreate.Padding = new Padding(0, 7, 0, 7);
            btnCreate.Size = new Size(118, 49);
            btnCreate.TabIndex = 77;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // lblDriverErrorMessage
            // 
            lblDriverErrorMessage.AutoSize = true;
            lblDriverErrorMessage.ForeColor = Color.Red;
            lblDriverErrorMessage.Location = new Point(170, 149);
            lblDriverErrorMessage.Name = "lblDriverErrorMessage";
            lblDriverErrorMessage.Size = new Size(103, 20);
            lblDriverErrorMessage.TabIndex = 79;
            lblDriverErrorMessage.Text = "error message";
            lblDriverErrorMessage.Visible = false;
            // 
            // lblAssistantErrorMessage
            // 
            lblAssistantErrorMessage.AutoSize = true;
            lblAssistantErrorMessage.ForeColor = Color.Red;
            lblAssistantErrorMessage.Location = new Point(170, 292);
            lblAssistantErrorMessage.Name = "lblAssistantErrorMessage";
            lblAssistantErrorMessage.Size = new Size(103, 20);
            lblAssistantErrorMessage.TabIndex = 80;
            lblAssistantErrorMessage.Text = "error message";
            lblAssistantErrorMessage.Visible = false;
            // 
            // lblVehicleErrorMessage
            // 
            lblVehicleErrorMessage.AutoSize = true;
            lblVehicleErrorMessage.ForeColor = Color.Red;
            lblVehicleErrorMessage.Location = new Point(170, 440);
            lblVehicleErrorMessage.Name = "lblVehicleErrorMessage";
            lblVehicleErrorMessage.Size = new Size(103, 20);
            lblVehicleErrorMessage.TabIndex = 81;
            lblVehicleErrorMessage.Text = "error message";
            lblVehicleErrorMessage.Visible = false;
            // 
            // CreateTransportUnitForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(575, 872);
            Controls.Add(lblVehicleErrorMessage);
            Controls.Add(lblAssistantErrorMessage);
            Controls.Add(lblDriverErrorMessage);
            Controls.Add(btnCancel);
            Controls.Add(btnCreate);
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
            Controls.Add(lblReferenceId);
            Controls.Add(lblFormTitle);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "CreateTransportUnitForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create Transport Unit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFormTitle;
        private TextBox txtDriverName;
        private Label lblDriverName;
        private Button btnAddDriver;
        private TextBox txtDriverId;
        private Label lblReferenceId;
        private TextBox txtAssistantName;
        private Label lblAssistantName;
        private Button btnAddAssistant;
        private TextBox txtAssistantId;
        private Label lblAssistantId;
        private TextBox txtVehicleName;
        private Label lblVehicleName;
        private Button btnAddVehicle;
        private TextBox txtVehicleRegNo;
        private Label lblVehicleRegNo;
        private TextBox txtContainerVolume;
        private Label lblContainerDetails;
        private Label lblContainerVolume;
        private Label lblMaxWeight;
        private TextBox txtContainerMaxWeight;
        private Button btnCancel;
        private Button btnCreate;
        private Label lblDriverErrorMessage;
        private Label lblAssistantErrorMessage;
        private Label lblVehicleErrorMessage;
    }
}