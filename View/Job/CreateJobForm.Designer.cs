namespace eshift.View.Job
{
    partial class CreateJobForm
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
            lblLoad = new Label();
            dgLoads = new DataGridView();
            txtEstimatedCost = new TextBox();
            lblEstimatedCost = new Label();
            dtTmPckrScheduledDate = new DateTimePicker();
            rchTxtJobDescription = new RichTextBox();
            rchTxtDelivery = new RichTextBox();
            rchTxtPickup = new RichTextBox();
            btnCancel = new Button();
            btnCreate = new Button();
            lblScheduledDate = new Label();
            lblJobDescription = new Label();
            lblDelivery = new Label();
            lblPickup = new Label();
            txtCustomerId = new TextBox();
            lblCustomerId = new Label();
            lblFormTitle = new Label();
            lblTransportUnit = new Label();
            dgTransportUnit = new DataGridView();
            btnAddCustomer = new Button();
            txtCustomerName = new TextBox();
            lblCustomerName = new Label();
            txtLoadDescription = new TextBox();
            lblLoadDescription = new Label();
            lblLoadVolume = new Label();
            nmrcLoadVolume = new NumericUpDown();
            lblWeight = new Label();
            nmrcLoadWeight = new NumericUpDown();
            btnAddLoad = new Button();
            btnClearLoad = new Button();
            btnRemoveLoad = new Button();
            btnRemoveTransportUnit = new Button();
            btnClearTransportUnit = new Button();
            btnAddTransportUnit = new Button();
            txtTransportUnitId = new TextBox();
            lblTransportUnitId = new Label();
            lblPickUpErrorMessage = new Label();
            lblDeliveryErrorMessage = new Label();
            lblScheduleDateErrorMessage = new Label();
            lblEstimatedCostErrorMessage = new Label();
            lblLoadVoloumeErrorMessage = new Label();
            lblLoadWeightErrorMessage = new Label();
            ((System.ComponentModel.ISupportInitialize)dgLoads).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgTransportUnit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrcLoadVolume).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrcLoadWeight).BeginInit();
            SuspendLayout();
            // 
            // lblLoad
            // 
            lblLoad.AutoSize = true;
            lblLoad.Font = new Font("Segoe UI Semibold", 12F);
            lblLoad.Location = new Point(395, 49);
            lblLoad.Name = "lblLoad";
            lblLoad.Size = new Size(53, 21);
            lblLoad.TabIndex = 149;
            lblLoad.Text = "Loads";
            // 
            // dgLoads
            // 
            dgLoads.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgLoads.BackgroundColor = Color.Azure;
            dgLoads.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgLoads.Location = new Point(395, 80);
            dgLoads.Margin = new Padding(3, 2, 3, 2);
            dgLoads.Name = "dgLoads";
            dgLoads.RowHeadersWidth = 51;
            dgLoads.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgLoads.Size = new Size(340, 422);
            dgLoads.TabIndex = 148;
            // 
            // txtEstimatedCost
            // 
            txtEstimatedCost.Font = new Font("Segoe UI", 11.25F);
            txtEstimatedCost.Location = new Point(175, 496);
            txtEstimatedCost.Margin = new Padding(3, 2, 3, 2);
            txtEstimatedCost.Name = "txtEstimatedCost";
            txtEstimatedCost.Size = new Size(204, 27);
            txtEstimatedCost.TabIndex = 140;
            // 
            // lblEstimatedCost
            // 
            lblEstimatedCost.AutoSize = true;
            lblEstimatedCost.Font = new Font("Segoe UI Semibold", 12F);
            lblEstimatedCost.Location = new Point(27, 496);
            lblEstimatedCost.Name = "lblEstimatedCost";
            lblEstimatedCost.Size = new Size(146, 21);
            lblEstimatedCost.TabIndex = 147;
            lblEstimatedCost.Text = "Estimated Cost(Rs)";
            // 
            // dtTmPckrScheduledDate
            // 
            dtTmPckrScheduledDate.Font = new Font("Segoe UI", 11.25F);
            dtTmPckrScheduledDate.Location = new Point(175, 438);
            dtTmPckrScheduledDate.Margin = new Padding(3, 2, 3, 2);
            dtTmPckrScheduledDate.Name = "dtTmPckrScheduledDate";
            dtTmPckrScheduledDate.Size = new Size(204, 27);
            dtTmPckrScheduledDate.TabIndex = 138;
            // 
            // rchTxtJobDescription
            // 
            rchTxtJobDescription.Font = new Font("Segoe UI", 11.25F);
            rchTxtJobDescription.Location = new Point(175, 340);
            rchTxtJobDescription.Margin = new Padding(3, 2, 3, 2);
            rchTxtJobDescription.Name = "rchTxtJobDescription";
            rchTxtJobDescription.Size = new Size(204, 62);
            rchTxtJobDescription.TabIndex = 137;
            rchTxtJobDescription.Text = "";
            // 
            // rchTxtDelivery
            // 
            rchTxtDelivery.Font = new Font("Segoe UI", 11.25F);
            rchTxtDelivery.Location = new Point(175, 253);
            rchTxtDelivery.Margin = new Padding(3, 2, 3, 2);
            rchTxtDelivery.Name = "rchTxtDelivery";
            rchTxtDelivery.Size = new Size(204, 62);
            rchTxtDelivery.TabIndex = 136;
            rchTxtDelivery.Text = "";
            // 
            // rchTxtPickup
            // 
            rchTxtPickup.Font = new Font("Segoe UI", 11.25F);
            rchTxtPickup.Location = new Point(175, 162);
            rchTxtPickup.Margin = new Padding(3, 2, 3, 2);
            rchTxtPickup.Name = "rchTxtPickup";
            rchTxtPickup.Size = new Size(204, 62);
            rchTxtPickup.TabIndex = 135;
            rchTxtPickup.Text = "";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ButtonHighlight;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = SystemColors.WindowText;
            btnCancel.Location = new Point(289, 552);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Padding = new Padding(0, 4, 0, 4);
            btnCancel.Size = new Size(90, 45);
            btnCancel.TabIndex = 143;
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
            btnCreate.Location = new Point(175, 552);
            btnCreate.Margin = new Padding(3, 2, 3, 2);
            btnCreate.Name = "btnCreate";
            btnCreate.Padding = new Padding(0, 4, 0, 4);
            btnCreate.Size = new Size(90, 45);
            btnCreate.TabIndex = 141;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // lblScheduledDate
            // 
            lblScheduledDate.AutoSize = true;
            lblScheduledDate.Font = new Font("Segoe UI Semibold", 12F);
            lblScheduledDate.Location = new Point(27, 438);
            lblScheduledDate.Name = "lblScheduledDate";
            lblScheduledDate.Size = new Size(125, 21);
            lblScheduledDate.TabIndex = 146;
            lblScheduledDate.Text = "Scheduled Date";
            // 
            // lblJobDescription
            // 
            lblJobDescription.AutoSize = true;
            lblJobDescription.Font = new Font("Segoe UI Semibold", 12F);
            lblJobDescription.Location = new Point(27, 339);
            lblJobDescription.Name = "lblJobDescription";
            lblJobDescription.Size = new Size(94, 21);
            lblJobDescription.TabIndex = 145;
            lblJobDescription.Text = "Description";
            // 
            // lblDelivery
            // 
            lblDelivery.AutoSize = true;
            lblDelivery.Font = new Font("Segoe UI Semibold", 12F);
            lblDelivery.Location = new Point(27, 251);
            lblDelivery.Name = "lblDelivery";
            lblDelivery.Size = new Size(70, 21);
            lblDelivery.TabIndex = 144;
            lblDelivery.Text = "Delivery";
            // 
            // lblPickup
            // 
            lblPickup.AutoSize = true;
            lblPickup.Font = new Font("Segoe UI Semibold", 12F);
            lblPickup.Location = new Point(27, 160);
            lblPickup.Name = "lblPickup";
            lblPickup.Size = new Size(58, 21);
            lblPickup.TabIndex = 139;
            lblPickup.Text = "Pickup";
            // 
            // txtCustomerId
            // 
            txtCustomerId.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCustomerId.Location = new Point(172, 80);
            txtCustomerId.Margin = new Padding(3, 2, 3, 2);
            txtCustomerId.Name = "txtCustomerId";
            txtCustomerId.Size = new Size(154, 27);
            txtCustomerId.TabIndex = 134;
            // 
            // lblCustomerId
            // 
            lblCustomerId.AutoSize = true;
            lblCustomerId.Font = new Font("Segoe UI Semibold", 12F);
            lblCustomerId.Location = new Point(27, 80);
            lblCustomerId.Name = "lblCustomerId";
            lblCustomerId.Size = new Size(101, 21);
            lblCustomerId.TabIndex = 133;
            lblCustomerId.Text = "Customer ID";
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormTitle.ForeColor = SystemColors.WindowText;
            lblFormTitle.Location = new Point(27, 33);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(115, 30);
            lblFormTitle.TabIndex = 132;
            lblFormTitle.Text = "Create Job";
            // 
            // lblTransportUnit
            // 
            lblTransportUnit.AutoSize = true;
            lblTransportUnit.Font = new Font("Segoe UI Semibold", 12F);
            lblTransportUnit.Location = new Point(761, 49);
            lblTransportUnit.Name = "lblTransportUnit";
            lblTransportUnit.Size = new Size(114, 21);
            lblTransportUnit.TabIndex = 150;
            lblTransportUnit.Text = "Transport Unit";
            // 
            // dgTransportUnit
            // 
            dgTransportUnit.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgTransportUnit.BackgroundColor = Color.Azure;
            dgTransportUnit.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgTransportUnit.Location = new Point(764, 80);
            dgTransportUnit.Margin = new Padding(3, 2, 3, 2);
            dgTransportUnit.Name = "dgTransportUnit";
            dgTransportUnit.RowHeadersWidth = 51;
            dgTransportUnit.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgTransportUnit.Size = new Size(340, 422);
            dgTransportUnit.TabIndex = 151;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Location = new Point(331, 80);
            btnAddCustomer.Margin = new Padding(3, 2, 3, 2);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(48, 27);
            btnAddCustomer.TabIndex = 154;
            btnAddCustomer.Text = "Add";
            btnAddCustomer.UseVisualStyleBackColor = true;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCustomerName.Location = new Point(172, 120);
            txtCustomerName.Margin = new Padding(3, 2, 3, 2);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.ReadOnly = true;
            txtCustomerName.Size = new Size(207, 27);
            txtCustomerName.TabIndex = 158;
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Font = new Font("Segoe UI Semibold", 12F);
            lblCustomerName.Location = new Point(27, 120);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(81, 21);
            lblCustomerName.TabIndex = 157;
            lblCustomerName.Text = "Customer";
            // 
            // txtLoadDescription
            // 
            txtLoadDescription.Font = new Font("Segoe UI", 11.25F);
            txtLoadDescription.Location = new Point(510, 522);
            txtLoadDescription.Margin = new Padding(3, 2, 3, 2);
            txtLoadDescription.Name = "txtLoadDescription";
            txtLoadDescription.Size = new Size(225, 27);
            txtLoadDescription.TabIndex = 159;
            // 
            // lblLoadDescription
            // 
            lblLoadDescription.AutoSize = true;
            lblLoadDescription.Font = new Font("Segoe UI Semibold", 12F);
            lblLoadDescription.Location = new Point(396, 522);
            lblLoadDescription.Name = "lblLoadDescription";
            lblLoadDescription.Size = new Size(94, 21);
            lblLoadDescription.TabIndex = 160;
            lblLoadDescription.Text = "Description";
            // 
            // lblLoadVolume
            // 
            lblLoadVolume.AutoSize = true;
            lblLoadVolume.Font = new Font("Segoe UI Semibold", 12F);
            lblLoadVolume.Location = new Point(396, 570);
            lblLoadVolume.Name = "lblLoadVolume";
            lblLoadVolume.Size = new Size(95, 21);
            lblLoadVolume.TabIndex = 161;
            lblLoadVolume.Text = "Volume(m³)";
            // 
            // nmrcLoadVolume
            // 
            nmrcLoadVolume.DecimalPlaces = 2;
            nmrcLoadVolume.Font = new Font("Segoe UI", 11.25F);
            nmrcLoadVolume.Location = new Point(510, 564);
            nmrcLoadVolume.Margin = new Padding(3, 2, 3, 2);
            nmrcLoadVolume.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            nmrcLoadVolume.Name = "nmrcLoadVolume";
            nmrcLoadVolume.Size = new Size(225, 27);
            nmrcLoadVolume.TabIndex = 162;
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Font = new Font("Segoe UI Semibold", 12F);
            lblWeight.Location = new Point(396, 618);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(97, 21);
            lblWeight.TabIndex = 163;
            lblWeight.Text = "Weight (Kg)";
            // 
            // nmrcLoadWeight
            // 
            nmrcLoadWeight.DecimalPlaces = 2;
            nmrcLoadWeight.Font = new Font("Segoe UI", 11.25F);
            nmrcLoadWeight.Location = new Point(510, 612);
            nmrcLoadWeight.Margin = new Padding(3, 2, 3, 2);
            nmrcLoadWeight.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            nmrcLoadWeight.Name = "nmrcLoadWeight";
            nmrcLoadWeight.Size = new Size(225, 27);
            nmrcLoadWeight.TabIndex = 164;
            // 
            // btnAddLoad
            // 
            btnAddLoad.BackColor = SystemColors.HotTrack;
            btnAddLoad.Cursor = Cursors.Hand;
            btnAddLoad.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddLoad.ForeColor = Color.White;
            btnAddLoad.Location = new Point(550, 662);
            btnAddLoad.Margin = new Padding(3, 2, 3, 2);
            btnAddLoad.Name = "btnAddLoad";
            btnAddLoad.Padding = new Padding(0, 4, 0, 4);
            btnAddLoad.Size = new Size(90, 45);
            btnAddLoad.TabIndex = 165;
            btnAddLoad.Text = "Add Load";
            btnAddLoad.UseVisualStyleBackColor = false;
            btnAddLoad.Click += btnAddLoad_Click;
            // 
            // btnClearLoad
            // 
            btnClearLoad.BackColor = SystemColors.ButtonHighlight;
            btnClearLoad.Cursor = Cursors.Hand;
            btnClearLoad.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClearLoad.ForeColor = SystemColors.WindowText;
            btnClearLoad.Location = new Point(645, 662);
            btnClearLoad.Margin = new Padding(3, 2, 3, 2);
            btnClearLoad.Name = "btnClearLoad";
            btnClearLoad.Padding = new Padding(0, 4, 0, 4);
            btnClearLoad.Size = new Size(90, 45);
            btnClearLoad.TabIndex = 166;
            btnClearLoad.Text = "Clear";
            btnClearLoad.UseVisualStyleBackColor = false;
            btnClearLoad.Click += btnClearLoad_Click;
            // 
            // btnRemoveLoad
            // 
            btnRemoveLoad.BackColor = Color.FromArgb(198, 40, 40);
            btnRemoveLoad.Cursor = Cursors.Hand;
            btnRemoveLoad.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemoveLoad.ForeColor = Color.White;
            btnRemoveLoad.Location = new Point(454, 662);
            btnRemoveLoad.Margin = new Padding(3, 2, 3, 2);
            btnRemoveLoad.Name = "btnRemoveLoad";
            btnRemoveLoad.Padding = new Padding(0, 4, 0, 4);
            btnRemoveLoad.Size = new Size(90, 45);
            btnRemoveLoad.TabIndex = 167;
            btnRemoveLoad.Text = "Remove";
            btnRemoveLoad.UseVisualStyleBackColor = false;
            btnRemoveLoad.Click += btnRemoveLoad_Click;
            // 
            // btnRemoveTransportUnit
            // 
            btnRemoveTransportUnit.BackColor = Color.FromArgb(198, 40, 40);
            btnRemoveTransportUnit.Cursor = Cursors.Hand;
            btnRemoveTransportUnit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemoveTransportUnit.ForeColor = Color.White;
            btnRemoveTransportUnit.Location = new Point(823, 555);
            btnRemoveTransportUnit.Margin = new Padding(3, 2, 3, 2);
            btnRemoveTransportUnit.Name = "btnRemoveTransportUnit";
            btnRemoveTransportUnit.Padding = new Padding(0, 4, 0, 4);
            btnRemoveTransportUnit.Size = new Size(90, 45);
            btnRemoveTransportUnit.TabIndex = 176;
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
            btnClearTransportUnit.Location = new Point(1014, 556);
            btnClearTransportUnit.Margin = new Padding(3, 2, 3, 2);
            btnClearTransportUnit.Name = "btnClearTransportUnit";
            btnClearTransportUnit.Padding = new Padding(0, 4, 0, 4);
            btnClearTransportUnit.Size = new Size(90, 45);
            btnClearTransportUnit.TabIndex = 175;
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
            btnAddTransportUnit.Location = new Point(919, 556);
            btnAddTransportUnit.Margin = new Padding(3, 2, 3, 2);
            btnAddTransportUnit.Name = "btnAddTransportUnit";
            btnAddTransportUnit.Padding = new Padding(0, 4, 0, 4);
            btnAddTransportUnit.Size = new Size(90, 45);
            btnAddTransportUnit.TabIndex = 174;
            btnAddTransportUnit.Text = "Add";
            btnAddTransportUnit.UseVisualStyleBackColor = false;
            btnAddTransportUnit.Click += btnAddTransportUnit_Click;
            // 
            // txtTransportUnitId
            // 
            txtTransportUnitId.Font = new Font("Segoe UI", 11.25F);
            txtTransportUnitId.Location = new Point(879, 522);
            txtTransportUnitId.Margin = new Padding(3, 2, 3, 2);
            txtTransportUnitId.Name = "txtTransportUnitId";
            txtTransportUnitId.Size = new Size(225, 27);
            txtTransportUnitId.TabIndex = 168;
            // 
            // lblTransportUnitId
            // 
            lblTransportUnitId.AutoSize = true;
            lblTransportUnitId.Font = new Font("Segoe UI Semibold", 12F);
            lblTransportUnitId.Location = new Point(765, 522);
            lblTransportUnitId.Name = "lblTransportUnitId";
            lblTransportUnitId.Size = new Size(50, 21);
            lblTransportUnitId.TabIndex = 169;
            lblTransportUnitId.Text = "TU ID";
            // 
            // lblPickUpErrorMessage
            // 
            lblPickUpErrorMessage.AutoSize = true;
            lblPickUpErrorMessage.ForeColor = Color.Red;
            lblPickUpErrorMessage.Location = new Point(175, 226);
            lblPickUpErrorMessage.Name = "lblPickUpErrorMessage";
            lblPickUpErrorMessage.Size = new Size(81, 15);
            lblPickUpErrorMessage.TabIndex = 177;
            lblPickUpErrorMessage.Text = "error message";
            // 
            // lblDeliveryErrorMessage
            // 
            lblDeliveryErrorMessage.AutoSize = true;
            lblDeliveryErrorMessage.ForeColor = Color.Red;
            lblDeliveryErrorMessage.Location = new Point(175, 317);
            lblDeliveryErrorMessage.Name = "lblDeliveryErrorMessage";
            lblDeliveryErrorMessage.Size = new Size(81, 15);
            lblDeliveryErrorMessage.TabIndex = 178;
            lblDeliveryErrorMessage.Text = "error message";
            // 
            // lblScheduleDateErrorMessage
            // 
            lblScheduleDateErrorMessage.AutoSize = true;
            lblScheduleDateErrorMessage.ForeColor = Color.Red;
            lblScheduleDateErrorMessage.Location = new Point(175, 467);
            lblScheduleDateErrorMessage.Name = "lblScheduleDateErrorMessage";
            lblScheduleDateErrorMessage.Size = new Size(81, 15);
            lblScheduleDateErrorMessage.TabIndex = 179;
            lblScheduleDateErrorMessage.Text = "error message";
            // 
            // lblEstimatedCostErrorMessage
            // 
            lblEstimatedCostErrorMessage.AutoSize = true;
            lblEstimatedCostErrorMessage.ForeColor = Color.Red;
            lblEstimatedCostErrorMessage.Location = new Point(175, 527);
            lblEstimatedCostErrorMessage.Name = "lblEstimatedCostErrorMessage";
            lblEstimatedCostErrorMessage.Size = new Size(81, 15);
            lblEstimatedCostErrorMessage.TabIndex = 180;
            lblEstimatedCostErrorMessage.Text = "error message";
            // 
            // lblLoadVoloumeErrorMessage
            // 
            lblLoadVoloumeErrorMessage.AutoSize = true;
            lblLoadVoloumeErrorMessage.ForeColor = Color.Red;
            lblLoadVoloumeErrorMessage.Location = new Point(510, 593);
            lblLoadVoloumeErrorMessage.Name = "lblLoadVoloumeErrorMessage";
            lblLoadVoloumeErrorMessage.Size = new Size(81, 15);
            lblLoadVoloumeErrorMessage.TabIndex = 181;
            lblLoadVoloumeErrorMessage.Text = "error message";
            // 
            // lblLoadWeightErrorMessage
            // 
            lblLoadWeightErrorMessage.AutoSize = true;
            lblLoadWeightErrorMessage.ForeColor = Color.Red;
            lblLoadWeightErrorMessage.Location = new Point(510, 641);
            lblLoadWeightErrorMessage.Name = "lblLoadWeightErrorMessage";
            lblLoadWeightErrorMessage.Size = new Size(81, 15);
            lblLoadWeightErrorMessage.TabIndex = 182;
            lblLoadWeightErrorMessage.Text = "error message";
            // 
            // CreateJobForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Azure;
            ClientSize = new Size(1180, 721);
            Controls.Add(lblLoadWeightErrorMessage);
            Controls.Add(lblLoadVoloumeErrorMessage);
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
            Controls.Add(lblLoadDescription);
            Controls.Add(txtCustomerName);
            Controls.Add(lblCustomerName);
            Controls.Add(btnAddCustomer);
            Controls.Add(dgTransportUnit);
            Controls.Add(lblTransportUnit);
            Controls.Add(lblLoad);
            Controls.Add(dgLoads);
            Controls.Add(txtEstimatedCost);
            Controls.Add(lblEstimatedCost);
            Controls.Add(dtTmPckrScheduledDate);
            Controls.Add(rchTxtJobDescription);
            Controls.Add(rchTxtDelivery);
            Controls.Add(rchTxtPickup);
            Controls.Add(btnCancel);
            Controls.Add(btnCreate);
            Controls.Add(lblScheduledDate);
            Controls.Add(lblJobDescription);
            Controls.Add(lblDelivery);
            Controls.Add(lblPickup);
            Controls.Add(txtCustomerId);
            Controls.Add(lblCustomerId);
            Controls.Add(lblFormTitle);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CreateJobForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create Job";
            ((System.ComponentModel.ISupportInitialize)dgLoads).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgTransportUnit).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrcLoadVolume).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrcLoadWeight).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLoad;
        private DataGridView dgLoads;
        private Button btnReject;
        private TextBox txtEstimatedCost;
        private Label lblEstimatedCost;
        private DateTimePicker dtTmPckrScheduledDate;
        private RichTextBox rchTxtJobDescription;
        private RichTextBox rchTxtDelivery;
        private RichTextBox rchTxtPickup;
        private Button btnCancel;
        private Button btnCreate;
        private Label lblScheduledDate;
        private Label lblJobDescription;
        private Label lblDelivery;
        private Label lblPickup;
        private TextBox txtCustomerId;
        private Label lblCustomerId;
        private Label lblFormTitle;
        private Label lblTransportUnit;
        private DataGridView dgTransportUnit;
        private Button btnAddCustomer;
        private TextBox txtCustomerName;
        private Label lblCustomerName;
        private TextBox txtLoadDescription;
        private Label lblLoadDescription;
        private Label lblLoadVolume;
        private NumericUpDown nmrcLoadVolume;
        private Label lblWeight;
        private NumericUpDown nmrcLoadWeight;
        private Button btnAddLoad;
        private Button btnClearLoad;
        private Button btnRemoveLoad;
        private Button btnRemoveTransportUnit;
        private Button btnClearTransportUnit;
        private Button btnAddTransportUnit;
        private TextBox txtTransportUnitId;
        private Label lblTransportUnitId;
        private Label lblPickUpErrorMessage;
        private Label lblDeliveryErrorMessage;
        private Label lblScheduleDateErrorMessage;
        private Label lblEstimatedCostErrorMessage;
        private Label lblLoadVoloumeErrorMessage;
        private Label lblLoadWeightErrorMessage;
    }
}