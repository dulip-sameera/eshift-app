namespace eshift.View.Vehicle
{
    partial class CreateVehicleForm
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
            lblMaxWeight = new Label();
            lblContainerVolume = new Label();
            txtRegNo = new TextBox();
            lblRegNo = new Label();
            txtModel = new TextBox();
            lblModel = new Label();
            txtBrand = new TextBox();
            btnCancel = new Button();
            btnCreate = new Button();
            lblBrand = new Label();
            lblFormTitle = new Label();
            nmrcContainerVolume = new NumericUpDown();
            nmrcMaxWeight = new NumericUpDown();
            lblBrandErrorMessage = new Label();
            lblModelErrorMessage = new Label();
            lblRegNoErrorMessage = new Label();
            lblContainerVolumeErrorMessage = new Label();
            lblMaxWeightErrorMessage = new Label();
            ((System.ComponentModel.ISupportInitialize)nmrcContainerVolume).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrcMaxWeight).BeginInit();
            SuspendLayout();
            // 
            // lblMaxWeight
            // 
            lblMaxWeight.AutoSize = true;
            lblMaxWeight.Font = new Font("Segoe UI Semibold", 12F);
            lblMaxWeight.Location = new Point(45, 440);
            lblMaxWeight.Name = "lblMaxWeight";
            lblMaxWeight.Size = new Size(121, 28);
            lblMaxWeight.TabIndex = 79;
            lblMaxWeight.Text = "Max Weight";
            // 
            // lblContainerVolume
            // 
            lblContainerVolume.AutoSize = true;
            lblContainerVolume.Font = new Font("Segoe UI Semibold", 12F);
            lblContainerVolume.Location = new Point(45, 364);
            lblContainerVolume.Name = "lblContainerVolume";
            lblContainerVolume.Size = new Size(176, 28);
            lblContainerVolume.TabIndex = 77;
            lblContainerVolume.Text = "Container Volume";
            // 
            // txtRegNo
            // 
            txtRegNo.Font = new Font("Segoe UI", 11.25F);
            txtRegNo.Location = new Point(243, 287);
            txtRegNo.Margin = new Padding(3, 4, 3, 4);
            txtRegNo.Name = "txtRegNo";
            txtRegNo.Size = new Size(259, 32);
            txtRegNo.TabIndex = 76;
            // 
            // lblRegNo
            // 
            lblRegNo.AutoSize = true;
            lblRegNo.Font = new Font("Segoe UI Semibold", 12F);
            lblRegNo.Location = new Point(45, 287);
            lblRegNo.Name = "lblRegNo";
            lblRegNo.Size = new Size(153, 28);
            lblRegNo.TabIndex = 75;
            lblRegNo.Text = "Registration No";
            // 
            // txtModel
            // 
            txtModel.Font = new Font("Segoe UI", 11.25F);
            txtModel.Location = new Point(243, 205);
            txtModel.Margin = new Padding(3, 4, 3, 4);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(259, 32);
            txtModel.TabIndex = 74;
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Font = new Font("Segoe UI Semibold", 12F);
            lblModel.Location = new Point(43, 205);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(70, 28);
            lblModel.TabIndex = 73;
            lblModel.Text = "Model";
            // 
            // txtBrand
            // 
            txtBrand.Font = new Font("Segoe UI", 11.25F);
            txtBrand.Location = new Point(243, 129);
            txtBrand.Margin = new Padding(3, 4, 3, 4);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(259, 32);
            txtBrand.TabIndex = 72;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ButtonHighlight;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = SystemColors.WindowText;
            btnCancel.Location = new Point(353, 540);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Padding = new Padding(0, 7, 0, 7);
            btnCancel.Size = new Size(118, 49);
            btnCancel.TabIndex = 71;
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
            btnCreate.Location = new Point(211, 540);
            btnCreate.Margin = new Padding(3, 4, 3, 4);
            btnCreate.Name = "btnCreate";
            btnCreate.Padding = new Padding(0, 7, 0, 7);
            btnCreate.Size = new Size(118, 49);
            btnCreate.TabIndex = 70;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Font = new Font("Segoe UI Semibold", 12F);
            lblBrand.Location = new Point(41, 129);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(65, 28);
            lblBrand.TabIndex = 69;
            lblBrand.Text = "Brand";
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormTitle.ForeColor = SystemColors.WindowText;
            lblFormTitle.Location = new Point(33, 40);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(189, 37);
            lblFormTitle.TabIndex = 68;
            lblFormTitle.Text = "Create Vehicle";
            // 
            // nmrcContainerVolume
            // 
            nmrcContainerVolume.DecimalPlaces = 2;
            nmrcContainerVolume.Font = new Font("Segoe UI", 11.25F);
            nmrcContainerVolume.Location = new Point(243, 365);
            nmrcContainerVolume.Margin = new Padding(3, 4, 3, 4);
            nmrcContainerVolume.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            nmrcContainerVolume.Name = "nmrcContainerVolume";
            nmrcContainerVolume.Size = new Size(259, 32);
            nmrcContainerVolume.TabIndex = 83;
            // 
            // nmrcMaxWeight
            // 
            nmrcMaxWeight.DecimalPlaces = 2;
            nmrcMaxWeight.Font = new Font("Segoe UI", 11.25F);
            nmrcMaxWeight.Location = new Point(243, 441);
            nmrcMaxWeight.Margin = new Padding(3, 4, 3, 4);
            nmrcMaxWeight.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            nmrcMaxWeight.Name = "nmrcMaxWeight";
            nmrcMaxWeight.Size = new Size(259, 32);
            nmrcMaxWeight.TabIndex = 84;
            // 
            // lblBrandErrorMessage
            // 
            lblBrandErrorMessage.AutoSize = true;
            lblBrandErrorMessage.ForeColor = Color.Red;
            lblBrandErrorMessage.Location = new Point(243, 165);
            lblBrandErrorMessage.Name = "lblBrandErrorMessage";
            lblBrandErrorMessage.Size = new Size(146, 20);
            lblBrandErrorMessage.TabIndex = 85;
            lblBrandErrorMessage.Text = "brand error message";
            lblBrandErrorMessage.Visible = false;
            // 
            // lblModelErrorMessage
            // 
            lblModelErrorMessage.AutoSize = true;
            lblModelErrorMessage.ForeColor = Color.Red;
            lblModelErrorMessage.Location = new Point(243, 241);
            lblModelErrorMessage.Name = "lblModelErrorMessage";
            lblModelErrorMessage.Size = new Size(150, 20);
            lblModelErrorMessage.TabIndex = 86;
            lblModelErrorMessage.Text = "model error message";
            lblModelErrorMessage.Visible = false;
            // 
            // lblRegNoErrorMessage
            // 
            lblRegNoErrorMessage.AutoSize = true;
            lblRegNoErrorMessage.ForeColor = Color.Red;
            lblRegNoErrorMessage.Location = new Point(243, 323);
            lblRegNoErrorMessage.Name = "lblRegNoErrorMessage";
            lblRegNoErrorMessage.Size = new Size(150, 20);
            lblRegNoErrorMessage.TabIndex = 87;
            lblRegNoErrorMessage.Text = "reg no error message";
            lblRegNoErrorMessage.Visible = false;
            // 
            // lblContainerVolumeErrorMessage
            // 
            lblContainerVolumeErrorMessage.AutoSize = true;
            lblContainerVolumeErrorMessage.ForeColor = Color.Red;
            lblContainerVolumeErrorMessage.Location = new Point(243, 401);
            lblContainerVolumeErrorMessage.Name = "lblContainerVolumeErrorMessage";
            lblContainerVolumeErrorMessage.Size = new Size(222, 20);
            lblContainerVolumeErrorMessage.TabIndex = 88;
            lblContainerVolumeErrorMessage.Text = "container volume error message";
            lblContainerVolumeErrorMessage.Visible = false;
            // 
            // lblMaxWeightErrorMessage
            // 
            lblMaxWeightErrorMessage.AutoSize = true;
            lblMaxWeightErrorMessage.ForeColor = Color.Red;
            lblMaxWeightErrorMessage.Location = new Point(243, 477);
            lblMaxWeightErrorMessage.Name = "lblMaxWeightErrorMessage";
            lblMaxWeightErrorMessage.Size = new Size(184, 20);
            lblMaxWeightErrorMessage.TabIndex = 89;
            lblMaxWeightErrorMessage.Text = "max weight error message";
            lblMaxWeightErrorMessage.Visible = false;
            // 
            // CreateVehicleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(578, 615);
            Controls.Add(lblMaxWeightErrorMessage);
            Controls.Add(lblContainerVolumeErrorMessage);
            Controls.Add(lblRegNoErrorMessage);
            Controls.Add(lblModelErrorMessage);
            Controls.Add(lblBrandErrorMessage);
            Controls.Add(nmrcMaxWeight);
            Controls.Add(nmrcContainerVolume);
            Controls.Add(lblMaxWeight);
            Controls.Add(lblContainerVolume);
            Controls.Add(txtRegNo);
            Controls.Add(lblRegNo);
            Controls.Add(txtModel);
            Controls.Add(lblModel);
            Controls.Add(txtBrand);
            Controls.Add(btnCancel);
            Controls.Add(btnCreate);
            Controls.Add(lblBrand);
            Controls.Add(lblFormTitle);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "CreateVehicleForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create Vehicle Form";
            ((System.ComponentModel.ISupportInitialize)nmrcContainerVolume).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrcMaxWeight).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblMaxWeight;
        private Label lblContainerVolume;
        private TextBox txtRegNo;
        private Label lblRegNo;
        private TextBox txtModel;
        private Label lblModel;
        private TextBox txtBrand;
        private Button btnCancel;
        private Button btnCreate;
        private Label lblBrand;
        private Label lblFormTitle;
        private NumericUpDown nmrcContainerVolume;
        private NumericUpDown nmrcMaxWeight;
        private Label lblBrandErrorMessage;
        private Label lblModelErrorMessage;
        private Label lblRegNoErrorMessage;
        private Label lblContainerVolumeErrorMessage;
        private Label lblMaxWeightErrorMessage;
    }
}