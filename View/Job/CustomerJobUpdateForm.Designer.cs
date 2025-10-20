namespace eshift.View.Job
{
    partial class CustomerJobUpdateForm
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
            btnRemoveLoad = new Button();
            btnClearLoad = new Button();
            btnAddLoad = new Button();
            nmrcLoadWeight = new NumericUpDown();
            lblWeight = new Label();
            nmrcLoadVolume = new NumericUpDown();
            lblLoadVolume = new Label();
            txtLoadDescription = new TextBox();
            label1 = new Label();
            lblLoad = new Label();
            dgLoads = new DataGridView();
            LoadID = new DataGridViewTextBoxColumn();
            Id = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Volume = new DataGridViewTextBoxColumn();
            Weight = new DataGridViewTextBoxColumn();
            JobId = new DataGridViewTextBoxColumn();
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
            txtEstimatedCost = new TextBox();
            lblEstimatedCost = new Label();
            lblPickUpErrorMessage = new Label();
            lblDeliveryErrorMessage = new Label();
            lblScheduleDateErrorMessage = new Label();
            lblEstimatedCostErrorMessage = new Label();
            lblLoadVoloumeErrorMessage = new Label();
            lblLoadWeightErrorMessage = new Label();
            ((System.ComponentModel.ISupportInitialize)nmrcLoadWeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrcLoadVolume).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgLoads).BeginInit();
            SuspendLayout();
            // 
            // btnRemoveLoad
            // 
            btnRemoveLoad.BackColor = Color.FromArgb(198, 40, 40);
            btnRemoveLoad.Cursor = Cursors.Hand;
            btnRemoveLoad.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemoveLoad.ForeColor = Color.White;
            btnRemoveLoad.Location = new Point(516, 602);
            btnRemoveLoad.Name = "btnRemoveLoad";
            btnRemoveLoad.Padding = new Padding(0, 5, 0, 5);
            btnRemoveLoad.Size = new Size(103, 37);
            btnRemoveLoad.TabIndex = 233;
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
            btnClearLoad.Location = new Point(734, 602);
            btnClearLoad.Name = "btnClearLoad";
            btnClearLoad.Padding = new Padding(0, 5, 0, 5);
            btnClearLoad.Size = new Size(103, 37);
            btnClearLoad.TabIndex = 232;
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
            btnAddLoad.Location = new Point(625, 602);
            btnAddLoad.Name = "btnAddLoad";
            btnAddLoad.Padding = new Padding(0, 5, 0, 5);
            btnAddLoad.Size = new Size(103, 37);
            btnAddLoad.TabIndex = 231;
            btnAddLoad.Text = "Add Load";
            btnAddLoad.UseVisualStyleBackColor = false;
            btnAddLoad.Click += btnAddLoad_Click;
            // 
            // nmrcLoadWeight
            // 
            nmrcLoadWeight.DecimalPlaces = 2;
            nmrcLoadWeight.Font = new Font("Segoe UI", 11.25F);
            nmrcLoadWeight.Location = new Point(734, 549);
            nmrcLoadWeight.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            nmrcLoadWeight.Name = "nmrcLoadWeight";
            nmrcLoadWeight.Size = new Size(103, 27);
            nmrcLoadWeight.TabIndex = 230;
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Font = new Font("Segoe UI Semibold", 12F);
            lblWeight.Location = new Point(665, 549);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(63, 21);
            lblWeight.TabIndex = 229;
            lblWeight.Text = "Weight";
            // 
            // nmrcLoadVolume
            // 
            nmrcLoadVolume.DecimalPlaces = 2;
            nmrcLoadVolume.Font = new Font("Segoe UI", 11.25F);
            nmrcLoadVolume.Location = new Point(520, 548);
            nmrcLoadVolume.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            nmrcLoadVolume.Name = "nmrcLoadVolume";
            nmrcLoadVolume.Size = new Size(120, 27);
            nmrcLoadVolume.TabIndex = 228;
            // 
            // lblLoadVolume
            // 
            lblLoadVolume.AutoSize = true;
            lblLoadVolume.Font = new Font("Segoe UI Semibold", 12F);
            lblLoadVolume.Location = new Point(449, 548);
            lblLoadVolume.Name = "lblLoadVolume";
            lblLoadVolume.Size = new Size(65, 21);
            lblLoadVolume.TabIndex = 227;
            lblLoadVolume.Text = "Volume";
            // 
            // txtLoadDescription
            // 
            txtLoadDescription.Font = new Font("Segoe UI", 11.25F);
            txtLoadDescription.Location = new Point(580, 488);
            txtLoadDescription.Name = "txtLoadDescription";
            txtLoadDescription.Size = new Size(257, 27);
            txtLoadDescription.TabIndex = 225;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F);
            label1.Location = new Point(449, 488);
            label1.Name = "label1";
            label1.Size = new Size(94, 21);
            label1.TabIndex = 226;
            label1.Text = "Description";
            // 
            // lblLoad
            // 
            lblLoad.AutoSize = true;
            lblLoad.Font = new Font("Segoe UI Semibold", 12F);
            lblLoad.Location = new Point(448, 43);
            lblLoad.Name = "lblLoad";
            lblLoad.Size = new Size(53, 21);
            lblLoad.TabIndex = 224;
            lblLoad.Text = "Loads";
            // 
            // dgLoads
            // 
            dgLoads.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgLoads.BackgroundColor = Color.Azure;
            dgLoads.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgLoads.Columns.AddRange(new DataGridViewColumn[] { LoadID, Id, Description, Volume, Weight, JobId });
            dgLoads.Location = new Point(448, 84);
            dgLoads.Name = "dgLoads";
            dgLoads.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgLoads.Size = new Size(389, 372);
            dgLoads.TabIndex = 223;
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
            // dtTmPckrScheduledDate
            // 
            dtTmPckrScheduledDate.Font = new Font("Segoe UI", 11.25F);
            dtTmPckrScheduledDate.Location = new Point(159, 463);
            dtTmPckrScheduledDate.Name = "dtTmPckrScheduledDate";
            dtTmPckrScheduledDate.Size = new Size(233, 27);
            dtTmPckrScheduledDate.TabIndex = 216;
            // 
            // rchTxtDescription
            // 
            rchTxtDescription.Font = new Font("Segoe UI", 11.25F);
            rchTxtDescription.Location = new Point(159, 333);
            rchTxtDescription.Name = "rchTxtDescription";
            rchTxtDescription.Size = new Size(233, 82);
            rchTxtDescription.TabIndex = 215;
            rchTxtDescription.Text = "";
            // 
            // rchTxtDelivery
            // 
            rchTxtDelivery.Font = new Font("Segoe UI", 11.25F);
            rchTxtDelivery.Location = new Point(159, 211);
            rchTxtDelivery.Name = "rchTxtDelivery";
            rchTxtDelivery.Size = new Size(233, 82);
            rchTxtDelivery.TabIndex = 214;
            rchTxtDelivery.Text = "";
            // 
            // rchTxtPickup
            // 
            rchTxtPickup.Font = new Font("Segoe UI", 11.25F);
            rchTxtPickup.Location = new Point(159, 85);
            rchTxtPickup.Name = "rchTxtPickup";
            rchTxtPickup.Size = new Size(233, 82);
            rchTxtPickup.TabIndex = 213;
            rchTxtPickup.Text = "";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ButtonHighlight;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = SystemColors.WindowText;
            btnCancel.Location = new Point(289, 602);
            btnCancel.Name = "btnCancel";
            btnCancel.Padding = new Padding(0, 5, 0, 5);
            btnCancel.Size = new Size(103, 37);
            btnCancel.TabIndex = 219;
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
            btnUpdate.Location = new Point(159, 602);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Padding = new Padding(0, 5, 0, 5);
            btnUpdate.Size = new Size(103, 37);
            btnUpdate.TabIndex = 218;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lblScheduledDate
            // 
            lblScheduledDate.AutoSize = true;
            lblScheduledDate.Font = new Font("Segoe UI Semibold", 12F);
            lblScheduledDate.Location = new Point(28, 463);
            lblScheduledDate.Name = "lblScheduledDate";
            lblScheduledDate.Size = new Size(125, 21);
            lblScheduledDate.TabIndex = 222;
            lblScheduledDate.Text = "Scheduled Date";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI Semibold", 12F);
            lblDescription.Location = new Point(28, 331);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(94, 21);
            lblDescription.TabIndex = 221;
            lblDescription.Text = "Description";
            // 
            // lblDelivery
            // 
            lblDelivery.AutoSize = true;
            lblDelivery.Font = new Font("Segoe UI Semibold", 12F);
            lblDelivery.Location = new Point(28, 209);
            lblDelivery.Name = "lblDelivery";
            lblDelivery.Size = new Size(70, 21);
            lblDelivery.TabIndex = 220;
            lblDelivery.Text = "Delivery";
            // 
            // lblPickup
            // 
            lblPickup.AutoSize = true;
            lblPickup.Font = new Font("Segoe UI Semibold", 12F);
            lblPickup.Location = new Point(28, 83);
            lblPickup.Name = "lblPickup";
            lblPickup.Size = new Size(58, 21);
            lblPickup.TabIndex = 217;
            lblPickup.Text = "Pickup";
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormTitle.ForeColor = SystemColors.WindowText;
            lblFormTitle.Location = new Point(28, 22);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(206, 30);
            lblFormTitle.TabIndex = 212;
            lblFormTitle.Text = "Update Job Request";
            // 
            // txtEstimatedCost
            // 
            txtEstimatedCost.Font = new Font("Segoe UI", 11.25F);
            txtEstimatedCost.Location = new Point(188, 542);
            txtEstimatedCost.Margin = new Padding(3, 2, 3, 2);
            txtEstimatedCost.Name = "txtEstimatedCost";
            txtEstimatedCost.Size = new Size(204, 27);
            txtEstimatedCost.TabIndex = 234;
            // 
            // lblEstimatedCost
            // 
            lblEstimatedCost.AutoSize = true;
            lblEstimatedCost.Font = new Font("Segoe UI Semibold", 12F);
            lblEstimatedCost.Location = new Point(31, 542);
            lblEstimatedCost.Name = "lblEstimatedCost";
            lblEstimatedCost.Size = new Size(146, 21);
            lblEstimatedCost.TabIndex = 235;
            lblEstimatedCost.Text = "Estimated Cost(Rs)";
            // 
            // lblPickUpErrorMessage
            // 
            lblPickUpErrorMessage.AutoSize = true;
            lblPickUpErrorMessage.ForeColor = Color.Red;
            lblPickUpErrorMessage.Location = new Point(159, 170);
            lblPickUpErrorMessage.Name = "lblPickUpErrorMessage";
            lblPickUpErrorMessage.Size = new Size(81, 15);
            lblPickUpErrorMessage.TabIndex = 236;
            lblPickUpErrorMessage.Text = "error message";
            // 
            // lblDeliveryErrorMessage
            // 
            lblDeliveryErrorMessage.AutoSize = true;
            lblDeliveryErrorMessage.ForeColor = Color.Red;
            lblDeliveryErrorMessage.Location = new Point(159, 296);
            lblDeliveryErrorMessage.Name = "lblDeliveryErrorMessage";
            lblDeliveryErrorMessage.Size = new Size(81, 15);
            lblDeliveryErrorMessage.TabIndex = 237;
            lblDeliveryErrorMessage.Text = "error message";
            // 
            // lblScheduleDateErrorMessage
            // 
            lblScheduleDateErrorMessage.AutoSize = true;
            lblScheduleDateErrorMessage.ForeColor = Color.Red;
            lblScheduleDateErrorMessage.Location = new Point(159, 500);
            lblScheduleDateErrorMessage.Name = "lblScheduleDateErrorMessage";
            lblScheduleDateErrorMessage.Size = new Size(81, 15);
            lblScheduleDateErrorMessage.TabIndex = 238;
            lblScheduleDateErrorMessage.Text = "error message";
            // 
            // lblEstimatedCostErrorMessage
            // 
            lblEstimatedCostErrorMessage.AutoSize = true;
            lblEstimatedCostErrorMessage.ForeColor = Color.Red;
            lblEstimatedCostErrorMessage.Location = new Point(188, 571);
            lblEstimatedCostErrorMessage.Name = "lblEstimatedCostErrorMessage";
            lblEstimatedCostErrorMessage.Size = new Size(81, 15);
            lblEstimatedCostErrorMessage.TabIndex = 239;
            lblEstimatedCostErrorMessage.Text = "error message";
            // 
            // lblLoadVoloumeErrorMessage
            // 
            lblLoadVoloumeErrorMessage.AutoSize = true;
            lblLoadVoloumeErrorMessage.ForeColor = Color.Red;
            lblLoadVoloumeErrorMessage.Location = new Point(520, 578);
            lblLoadVoloumeErrorMessage.Name = "lblLoadVoloumeErrorMessage";
            lblLoadVoloumeErrorMessage.Size = new Size(81, 15);
            lblLoadVoloumeErrorMessage.TabIndex = 240;
            lblLoadVoloumeErrorMessage.Text = "error message";
            // 
            // lblLoadWeightErrorMessage
            // 
            lblLoadWeightErrorMessage.AutoSize = true;
            lblLoadWeightErrorMessage.ForeColor = Color.Red;
            lblLoadWeightErrorMessage.Location = new Point(734, 578);
            lblLoadWeightErrorMessage.Name = "lblLoadWeightErrorMessage";
            lblLoadWeightErrorMessage.Size = new Size(81, 15);
            lblLoadWeightErrorMessage.TabIndex = 241;
            lblLoadWeightErrorMessage.Text = "error message";
            // 
            // CustomerJobUpdateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(865, 660);
            Controls.Add(lblLoadWeightErrorMessage);
            Controls.Add(lblLoadVoloumeErrorMessage);
            Controls.Add(lblEstimatedCostErrorMessage);
            Controls.Add(lblScheduleDateErrorMessage);
            Controls.Add(lblDeliveryErrorMessage);
            Controls.Add(lblPickUpErrorMessage);
            Controls.Add(txtEstimatedCost);
            Controls.Add(lblEstimatedCost);
            Controls.Add(btnRemoveLoad);
            Controls.Add(btnClearLoad);
            Controls.Add(btnAddLoad);
            Controls.Add(nmrcLoadWeight);
            Controls.Add(lblWeight);
            Controls.Add(nmrcLoadVolume);
            Controls.Add(lblLoadVolume);
            Controls.Add(txtLoadDescription);
            Controls.Add(label1);
            Controls.Add(lblLoad);
            Controls.Add(dgLoads);
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
            MaximizeBox = false;
            Name = "CustomerJobUpdateForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerJobUpdateForm";
            Load += CustomerJobUpdateForm_Load;
            ((System.ComponentModel.ISupportInitialize)nmrcLoadWeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrcLoadVolume).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgLoads).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRemoveLoad;
        private Button btnClearLoad;
        private Button btnAddLoad;
        private NumericUpDown nmrcLoadWeight;
        private Label lblWeight;
        private NumericUpDown nmrcLoadVolume;
        private Label lblLoadVolume;
        private TextBox txtLoadDescription;
        private Label label1;
        private Label lblLoad;
        private DataGridView dgLoads;
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
        private TextBox txtEstimatedCost;
        private Label lblEstimatedCost;
        private Label lblPickUpErrorMessage;
        private Label lblDeliveryErrorMessage;
        private Label lblScheduleDateErrorMessage;
        private Label lblEstimatedCostErrorMessage;
        private Label lblLoadVoloumeErrorMessage;
        private Label lblLoadWeightErrorMessage;
        private DataGridViewTextBoxColumn LoadID;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Volume;
        private DataGridViewTextBoxColumn Weight;
        private DataGridViewTextBoxColumn JobId;
    }
}