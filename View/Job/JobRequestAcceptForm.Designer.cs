namespace eshift.View.Job
{
    partial class JobRequestAcceptForm
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
            btnAccept = new Button();
            lblScheduledDate = new Label();
            lblDescription = new Label();
            lblDelivery = new Label();
            lblPickup = new Label();
            txtCustomer = new TextBox();
            lblDriverName = new Label();
            lblFormTitle = new Label();
            rchTxtPickup = new RichTextBox();
            rchTxtDelivery = new RichTextBox();
            rchTxtDescription = new RichTextBox();
            dtTmPckrScheduledDate = new DateTimePicker();
            lblEstimatedCost = new Label();
            txtEstimatedCost = new TextBox();
            btnReject = new Button();
            dataGridView1 = new DataGridView();
            LoadID = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Volume = new DataGridViewTextBoxColumn();
            Weight = new DataGridViewTextBoxColumn();
            lblLoad = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ButtonHighlight;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = SystemColors.WindowText;
            btnCancel.Location = new Point(294, 671);
            btnCancel.Name = "btnCancel";
            btnCancel.Padding = new Padding(0, 5, 0, 5);
            btnCancel.Size = new Size(103, 37);
            btnCancel.TabIndex = 115;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAccept
            // 
            btnAccept.BackColor = Color.FromArgb(67, 160, 71);
            btnAccept.Cursor = Cursors.Hand;
            btnAccept.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAccept.ForeColor = Color.White;
            btnAccept.Location = new Point(55, 671);
            btnAccept.Name = "btnAccept";
            btnAccept.Padding = new Padding(0, 5, 0, 5);
            btnAccept.Size = new Size(103, 37);
            btnAccept.TabIndex = 113;
            btnAccept.Text = "Accept";
            btnAccept.UseVisualStyleBackColor = false;
            btnAccept.Click += btnAccept_Click;
            // 
            // lblScheduledDate
            // 
            lblScheduledDate.AutoSize = true;
            lblScheduledDate.Font = new Font("Segoe UI Semibold", 12F);
            lblScheduledDate.Location = new Point(33, 518);
            lblScheduledDate.Name = "lblScheduledDate";
            lblScheduledDate.Size = new Size(125, 21);
            lblScheduledDate.TabIndex = 122;
            lblScheduledDate.Text = "Scheduled Date";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI Semibold", 12F);
            lblDescription.Location = new Point(33, 386);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(94, 21);
            lblDescription.TabIndex = 118;
            lblDescription.Text = "Description";
            // 
            // lblDelivery
            // 
            lblDelivery.AutoSize = true;
            lblDelivery.Font = new Font("Segoe UI Semibold", 12F);
            lblDelivery.Location = new Point(33, 276);
            lblDelivery.Name = "lblDelivery";
            lblDelivery.Size = new Size(70, 21);
            lblDelivery.TabIndex = 116;
            lblDelivery.Text = "Delivery";
            // 
            // lblPickup
            // 
            lblPickup.AutoSize = true;
            lblPickup.Font = new Font("Segoe UI Semibold", 12F);
            lblPickup.Location = new Point(33, 172);
            lblPickup.Name = "lblPickup";
            lblPickup.Size = new Size(58, 21);
            lblPickup.TabIndex = 111;
            lblPickup.Text = "Pickup";
            // 
            // txtCustomer
            // 
            txtCustomer.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCustomer.Location = new Point(161, 108);
            txtCustomer.Name = "txtCustomer";
            txtCustomer.ReadOnly = true;
            txtCustomer.Size = new Size(236, 27);
            txtCustomer.TabIndex = 107;
            txtCustomer.Text = "Supun";
            // 
            // lblDriverName
            // 
            lblDriverName.AutoSize = true;
            lblDriverName.Font = new Font("Segoe UI Semibold", 12F);
            lblDriverName.Location = new Point(33, 108);
            lblDriverName.Name = "lblDriverName";
            lblDriverName.Size = new Size(81, 21);
            lblDriverName.TabIndex = 106;
            lblDriverName.Text = "Customer";
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormTitle.ForeColor = SystemColors.WindowText;
            lblFormTitle.Location = new Point(33, 46);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(268, 30);
            lblFormTitle.TabIndex = 102;
            lblFormTitle.Text = "Accept Job Request#JobID";
            // 
            // rchTxtPickup
            // 
            rchTxtPickup.Font = new Font("Segoe UI", 11.25F);
            rchTxtPickup.Location = new Point(164, 174);
            rchTxtPickup.Name = "rchTxtPickup";
            rchTxtPickup.ReadOnly = true;
            rchTxtPickup.Size = new Size(233, 82);
            rchTxtPickup.TabIndex = 108;
            rchTxtPickup.Text = "72, Supun Avenue, Kalutara";
            // 
            // rchTxtDelivery
            // 
            rchTxtDelivery.Font = new Font("Segoe UI", 11.25F);
            rchTxtDelivery.Location = new Point(164, 278);
            rchTxtDelivery.Name = "rchTxtDelivery";
            rchTxtDelivery.ReadOnly = true;
            rchTxtDelivery.Size = new Size(233, 82);
            rchTxtDelivery.TabIndex = 109;
            rchTxtDelivery.Text = "56, Galle Road, Panadura";
            // 
            // rchTxtDescription
            // 
            rchTxtDescription.Font = new Font("Segoe UI", 11.25F);
            rchTxtDescription.Location = new Point(164, 388);
            rchTxtDescription.Name = "rchTxtDescription";
            rchTxtDescription.ReadOnly = true;
            rchTxtDescription.Size = new Size(233, 82);
            rchTxtDescription.TabIndex = 110;
            rchTxtDescription.Text = "";
            // 
            // dtTmPckrScheduledDate
            // 
            dtTmPckrScheduledDate.Font = new Font("Segoe UI", 11.25F);
            dtTmPckrScheduledDate.Location = new Point(164, 518);
            dtTmPckrScheduledDate.Name = "dtTmPckrScheduledDate";
            dtTmPckrScheduledDate.Size = new Size(233, 27);
            dtTmPckrScheduledDate.TabIndex = 111;
            // 
            // lblEstimatedCost
            // 
            lblEstimatedCost.AutoSize = true;
            lblEstimatedCost.Font = new Font("Segoe UI Semibold", 12F);
            lblEstimatedCost.Location = new Point(33, 596);
            lblEstimatedCost.Name = "lblEstimatedCost";
            lblEstimatedCost.Size = new Size(119, 21);
            lblEstimatedCost.TabIndex = 129;
            lblEstimatedCost.Text = "Estimated Cost";
            // 
            // txtEstimatedCost
            // 
            txtEstimatedCost.Font = new Font("Segoe UI", 11.25F);
            txtEstimatedCost.Location = new Point(164, 596);
            txtEstimatedCost.Name = "txtEstimatedCost";
            txtEstimatedCost.Size = new Size(233, 27);
            txtEstimatedCost.TabIndex = 112;
            // 
            // btnReject
            // 
            btnReject.BackColor = Color.FromArgb(216, 27, 96);
            btnReject.Cursor = Cursors.Hand;
            btnReject.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReject.ForeColor = Color.White;
            btnReject.Location = new Point(174, 671);
            btnReject.Name = "btnReject";
            btnReject.Padding = new Padding(0, 5, 0, 5);
            btnReject.Size = new Size(103, 37);
            btnReject.TabIndex = 114;
            btnReject.Text = "Reject";
            btnReject.UseVisualStyleBackColor = false;
            btnReject.Click += btnReject_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.Azure;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { LoadID, Description, Volume, Weight });
            dataGridView1.Location = new Point(466, 146);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(672, 562);
            dataGridView1.TabIndex = 130;
            // 
            // LoadID
            // 
            LoadID.HeaderText = "Load ID";
            LoadID.Name = "LoadID";
            // 
            // Description
            // 
            Description.HeaderText = "Description";
            Description.Name = "Description";
            // 
            // Volume
            // 
            Volume.HeaderText = "Volume";
            Volume.Name = "Volume";
            // 
            // Weight
            // 
            Weight.HeaderText = "Weight";
            Weight.Name = "Weight";
            // 
            // lblLoad
            // 
            lblLoad.AutoSize = true;
            lblLoad.Font = new Font("Segoe UI Semibold", 12F);
            lblLoad.Location = new Point(466, 110);
            lblLoad.Name = "lblLoad";
            lblLoad.Size = new Size(53, 21);
            lblLoad.TabIndex = 131;
            lblLoad.Text = "Loads";
            // 
            // JobRequestAcceptForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1167, 750);
            Controls.Add(lblLoad);
            Controls.Add(dataGridView1);
            Controls.Add(btnReject);
            Controls.Add(txtEstimatedCost);
            Controls.Add(lblEstimatedCost);
            Controls.Add(dtTmPckrScheduledDate);
            Controls.Add(rchTxtDescription);
            Controls.Add(rchTxtDelivery);
            Controls.Add(rchTxtPickup);
            Controls.Add(btnCancel);
            Controls.Add(btnAccept);
            Controls.Add(lblScheduledDate);
            Controls.Add(lblDescription);
            Controls.Add(lblDelivery);
            Controls.Add(lblPickup);
            Controls.Add(txtCustomer);
            Controls.Add(lblDriverName);
            Controls.Add(lblFormTitle);
            MaximizeBox = false;
            Name = "JobRequestAcceptForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Job Request Accept";
            Load += JobRequestAcceptForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnAccept;
        private Label lblScheduledDate;
        private Label lblDescription;
        private TextBox textBox1;
        private Label lblDelivery;
        private TextBox txtPickupAddress;
        private Label lblPickup;
        private TextBox txtCustomer;
        private Label lblDriverName;
        private Label lblFormTitle;
        private RichTextBox rchTxtPickup;
        private RichTextBox rchTxtDelivery;
        private RichTextBox rchTxtDescription;
        private DateTimePicker dtTmPckrScheduledDate;
        private Label lblEstimatedCost;
        private TextBox txtEstimatedCost;
        private Button btnReject;
        private DataGridView dataGridView1;
        private Label lblLoad;
        private DataGridViewTextBoxColumn LoadID;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Volume;
        private DataGridViewTextBoxColumn Weight;
    }
}