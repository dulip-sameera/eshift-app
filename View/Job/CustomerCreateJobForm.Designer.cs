namespace eshift.View.Job
{
    partial class CustomerCreateJobForm
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
            numericUpDown2 = new NumericUpDown();
            lblWeight = new Label();
            numericUpDown1 = new NumericUpDown();
            lblLoadVolume = new Label();
            txtLoadDescription = new TextBox();
            label1 = new Label();
            lblLoad = new Label();
            dgLoads = new DataGridView();
            dtTmPckrScheduledDate = new DateTimePicker();
            rchTxtDescription = new RichTextBox();
            rchTxtDelivery = new RichTextBox();
            rchTxtPickup = new RichTextBox();
            btnCancel = new Button();
            btnCreate = new Button();
            lblScheduledDate = new Label();
            lblDescription = new Label();
            lblDelivery = new Label();
            lblPickup = new Label();
            lblFormTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgLoads).BeginInit();
            SuspendLayout();
            // 
            // btnRemoveLoad
            // 
            btnRemoveLoad.BackColor = Color.FromArgb(198, 40, 40);
            btnRemoveLoad.Cursor = Cursors.Hand;
            btnRemoveLoad.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemoveLoad.ForeColor = Color.White;
            btnRemoveLoad.Location = new Point(510, 607);
            btnRemoveLoad.Name = "btnRemoveLoad";
            btnRemoveLoad.Padding = new Padding(0, 5, 0, 5);
            btnRemoveLoad.Size = new Size(103, 37);
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
            btnClearLoad.Location = new Point(728, 607);
            btnClearLoad.Name = "btnClearLoad";
            btnClearLoad.Padding = new Padding(0, 5, 0, 5);
            btnClearLoad.Size = new Size(103, 37);
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
            btnAddLoad.Location = new Point(619, 607);
            btnAddLoad.Name = "btnAddLoad";
            btnAddLoad.Padding = new Padding(0, 5, 0, 5);
            btnAddLoad.Size = new Size(103, 37);
            btnAddLoad.TabIndex = 209;
            btnAddLoad.Text = "Add Load";
            btnAddLoad.UseVisualStyleBackColor = false;
            btnAddLoad.Click += btnAddLoad_Click;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Font = new Font("Segoe UI", 11.25F);
            numericUpDown2.Location = new Point(728, 554);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(103, 27);
            numericUpDown2.TabIndex = 208;
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Font = new Font("Segoe UI Semibold", 12F);
            lblWeight.Location = new Point(659, 554);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(63, 21);
            lblWeight.TabIndex = 207;
            lblWeight.Text = "Weight";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 11.25F);
            numericUpDown1.Location = new Point(514, 553);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 27);
            numericUpDown1.TabIndex = 206;
            // 
            // lblLoadVolume
            // 
            lblLoadVolume.AutoSize = true;
            lblLoadVolume.Font = new Font("Segoe UI Semibold", 12F);
            lblLoadVolume.Location = new Point(443, 553);
            lblLoadVolume.Name = "lblLoadVolume";
            lblLoadVolume.Size = new Size(65, 21);
            lblLoadVolume.TabIndex = 205;
            lblLoadVolume.Text = "Volume";
            // 
            // txtLoadDescription
            // 
            txtLoadDescription.Font = new Font("Segoe UI", 11.25F);
            txtLoadDescription.Location = new Point(574, 493);
            txtLoadDescription.Name = "txtLoadDescription";
            txtLoadDescription.Size = new Size(257, 27);
            txtLoadDescription.TabIndex = 203;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F);
            label1.Location = new Point(443, 493);
            label1.Name = "label1";
            label1.Size = new Size(94, 21);
            label1.TabIndex = 204;
            label1.Text = "Description";
            // 
            // lblLoad
            // 
            lblLoad.AutoSize = true;
            lblLoad.Font = new Font("Segoe UI Semibold", 12F);
            lblLoad.Location = new Point(442, 48);
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
            dgLoads.Location = new Point(442, 89);
            dgLoads.Name = "dgLoads";
            dgLoads.Size = new Size(389, 372);
            dgLoads.TabIndex = 192;
            // 
            // dtTmPckrScheduledDate
            // 
            dtTmPckrScheduledDate.Font = new Font("Segoe UI", 11.25F);
            dtTmPckrScheduledDate.Location = new Point(153, 434);
            dtTmPckrScheduledDate.Name = "dtTmPckrScheduledDate";
            dtTmPckrScheduledDate.Size = new Size(233, 27);
            dtTmPckrScheduledDate.TabIndex = 183;
            // 
            // rchTxtDescription
            // 
            rchTxtDescription.Font = new Font("Segoe UI", 11.25F);
            rchTxtDescription.Location = new Point(153, 304);
            rchTxtDescription.Name = "rchTxtDescription";
            rchTxtDescription.Size = new Size(233, 82);
            rchTxtDescription.TabIndex = 182;
            rchTxtDescription.Text = "";
            // 
            // rchTxtDelivery
            // 
            rchTxtDelivery.Font = new Font("Segoe UI", 11.25F);
            rchTxtDelivery.Location = new Point(153, 194);
            rchTxtDelivery.Name = "rchTxtDelivery";
            rchTxtDelivery.Size = new Size(233, 82);
            rchTxtDelivery.TabIndex = 181;
            rchTxtDelivery.Text = "";
            // 
            // rchTxtPickup
            // 
            rchTxtPickup.Font = new Font("Segoe UI", 11.25F);
            rchTxtPickup.Location = new Point(153, 90);
            rchTxtPickup.Name = "rchTxtPickup";
            rchTxtPickup.Size = new Size(233, 82);
            rchTxtPickup.TabIndex = 180;
            rchTxtPickup.Text = "";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ButtonHighlight;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = SystemColors.WindowText;
            btnCancel.Location = new Point(283, 493);
            btnCancel.Name = "btnCancel";
            btnCancel.Padding = new Padding(0, 5, 0, 5);
            btnCancel.Size = new Size(103, 37);
            btnCancel.TabIndex = 187;
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
            btnCreate.Location = new Point(153, 493);
            btnCreate.Name = "btnCreate";
            btnCreate.Padding = new Padding(0, 5, 0, 5);
            btnCreate.Size = new Size(103, 37);
            btnCreate.TabIndex = 186;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // lblScheduledDate
            // 
            lblScheduledDate.AutoSize = true;
            lblScheduledDate.Font = new Font("Segoe UI Semibold", 12F);
            lblScheduledDate.Location = new Point(22, 434);
            lblScheduledDate.Name = "lblScheduledDate";
            lblScheduledDate.Size = new Size(125, 21);
            lblScheduledDate.TabIndex = 190;
            lblScheduledDate.Text = "Scheduled Date";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI Semibold", 12F);
            lblDescription.Location = new Point(22, 302);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(94, 21);
            lblDescription.TabIndex = 189;
            lblDescription.Text = "Description";
            // 
            // lblDelivery
            // 
            lblDelivery.AutoSize = true;
            lblDelivery.Font = new Font("Segoe UI Semibold", 12F);
            lblDelivery.Location = new Point(22, 192);
            lblDelivery.Name = "lblDelivery";
            lblDelivery.Size = new Size(70, 21);
            lblDelivery.TabIndex = 188;
            lblDelivery.Text = "Delivery";
            // 
            // lblPickup
            // 
            lblPickup.AutoSize = true;
            lblPickup.Font = new Font("Segoe UI Semibold", 12F);
            lblPickup.Location = new Point(22, 88);
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
            lblFormTitle.Location = new Point(22, 27);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(197, 30);
            lblFormTitle.TabIndex = 177;
            lblFormTitle.Text = "Create Job Request";
            // 
            // CustomerCreateJobForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(865, 660);
            Controls.Add(btnRemoveLoad);
            Controls.Add(btnClearLoad);
            Controls.Add(btnAddLoad);
            Controls.Add(numericUpDown2);
            Controls.Add(lblWeight);
            Controls.Add(numericUpDown1);
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
            Controls.Add(btnCreate);
            Controls.Add(lblScheduledDate);
            Controls.Add(lblDescription);
            Controls.Add(lblDelivery);
            Controls.Add(lblPickup);
            Controls.Add(lblFormTitle);
            MaximizeBox = false;
            Name = "CustomerCreateJobForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create Job Request";
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgLoads).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnRemoveLoad;
        private Button btnClearLoad;
        private Button btnAddLoad;
        private NumericUpDown numericUpDown2;
        private Label lblWeight;
        private NumericUpDown numericUpDown1;
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
        private Button btnCreate;
        private Label lblScheduledDate;
        private Label lblDescription;
        private Label lblDelivery;
        private Label lblPickup;
        private Label lblFormTitle;
    }
}