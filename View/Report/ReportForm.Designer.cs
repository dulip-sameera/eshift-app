namespace eshift.View.Report
{
    partial class ReportForm
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
            btnRrefresh = new Button();
            grpBxCustomer = new GroupBox();
            lblTotalInactiveCustomers = new Label();
            lblTotalActiveCustomers = new Label();
            lblTotalCustomers = new Label();
            grpBxJob = new GroupBox();
            lblRejectedJobs = new Label();
            lblCancelledJobs = new Label();
            lblCompletedJobs = new Label();
            lblInProgressJobs = new Label();
            lblPendingJobs = new Label();
            lblTotalJobs = new Label();
            grpBxLoad = new GroupBox();
            lblTotalVolume = new Label();
            lblTotalWeight = new Label();
            lblTotalLoad = new Label();
            grpBxTransportUnit = new GroupBox();
            lblUnavailableTransportUnits = new Label();
            lblAvailableTransportUnits = new Label();
            lblTotalTransportUnits = new Label();
            grpBxRevenue = new GroupBox();
            lblRejectedRevenue = new Label();
            lblCancelledRevenue = new Label();
            lblInProgressRevenue = new Label();
            lblPendingRevenue = new Label();
            lblCompletedRevenue = new Label();
            lblTotalRevenue = new Label();
            grpBxToThisDay = new GroupBox();
            grpBxSelectedPeriod = new GroupBox();
            lblExplanation = new Label();
            btnFilter = new Button();
            dtTmPckrTo = new DateTimePicker();
            lblTo = new Label();
            dtTmPckrFrom = new DateTimePicker();
            lblFrom = new Label();
            btnClose = new Button();
            grpBxCustomer.SuspendLayout();
            grpBxJob.SuspendLayout();
            grpBxLoad.SuspendLayout();
            grpBxTransportUnit.SuspendLayout();
            grpBxRevenue.SuspendLayout();
            grpBxToThisDay.SuspendLayout();
            grpBxSelectedPeriod.SuspendLayout();
            SuspendLayout();
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormTitle.ForeColor = SystemColors.WindowText;
            lblFormTitle.Location = new Point(26, 33);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(190, 30);
            lblFormTitle.TabIndex = 2;
            lblFormTitle.Text = "Report Dashboard";
            // 
            // btnRrefresh
            // 
            btnRrefresh.BackColor = SystemColors.HotTrack;
            btnRrefresh.Cursor = Cursors.Hand;
            btnRrefresh.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRrefresh.ForeColor = Color.White;
            btnRrefresh.Location = new Point(605, 26);
            btnRrefresh.Name = "btnRrefresh";
            btnRrefresh.Padding = new Padding(0, 5, 0, 5);
            btnRrefresh.Size = new Size(84, 37);
            btnRrefresh.TabIndex = 6;
            btnRrefresh.Text = "Reresh";
            btnRrefresh.UseVisualStyleBackColor = false;
            btnRrefresh.Click += btnRrefresh_Click;
            // 
            // grpBxCustomer
            // 
            grpBxCustomer.Controls.Add(lblTotalInactiveCustomers);
            grpBxCustomer.Controls.Add(lblTotalActiveCustomers);
            grpBxCustomer.Controls.Add(lblTotalCustomers);
            grpBxCustomer.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpBxCustomer.ForeColor = Color.Navy;
            grpBxCustomer.Location = new Point(70, 28);
            grpBxCustomer.Name = "grpBxCustomer";
            grpBxCustomer.Size = new Size(199, 251);
            grpBxCustomer.TabIndex = 0;
            grpBxCustomer.TabStop = false;
            grpBxCustomer.Text = "Customer Statistics";
            // 
            // lblTotalInactiveCustomers
            // 
            lblTotalInactiveCustomers.AutoSize = true;
            lblTotalInactiveCustomers.Font = new Font("Calibri", 11F);
            lblTotalInactiveCustomers.ForeColor = Color.FromArgb(0, 0, 64);
            lblTotalInactiveCustomers.Location = new Point(9, 89);
            lblTotalInactiveCustomers.Name = "lblTotalInactiveCustomers";
            lblTotalInactiveCustomers.Size = new Size(175, 18);
            lblTotalInactiveCustomers.TabIndex = 2;
            lblTotalInactiveCustomers.Text = "Total Inactive Customers : 0";
            // 
            // lblTotalActiveCustomers
            // 
            lblTotalActiveCustomers.AutoSize = true;
            lblTotalActiveCustomers.Font = new Font("Calibri", 11F);
            lblTotalActiveCustomers.ForeColor = Color.FromArgb(0, 0, 64);
            lblTotalActiveCustomers.Location = new Point(9, 62);
            lblTotalActiveCustomers.Name = "lblTotalActiveCustomers";
            lblTotalActiveCustomers.Size = new Size(165, 18);
            lblTotalActiveCustomers.TabIndex = 1;
            lblTotalActiveCustomers.Text = "Total Active Customers : 0";
            // 
            // lblTotalCustomers
            // 
            lblTotalCustomers.AutoSize = true;
            lblTotalCustomers.Font = new Font("Calibri", 11F);
            lblTotalCustomers.ForeColor = Color.FromArgb(0, 0, 64);
            lblTotalCustomers.Location = new Point(6, 34);
            lblTotalCustomers.Name = "lblTotalCustomers";
            lblTotalCustomers.Size = new Size(124, 18);
            lblTotalCustomers.TabIndex = 0;
            lblTotalCustomers.Text = "Total Customers : 0";
            // 
            // grpBxJob
            // 
            grpBxJob.Controls.Add(lblRejectedJobs);
            grpBxJob.Controls.Add(lblCancelledJobs);
            grpBxJob.Controls.Add(lblCompletedJobs);
            grpBxJob.Controls.Add(lblInProgressJobs);
            grpBxJob.Controls.Add(lblPendingJobs);
            grpBxJob.Controls.Add(lblTotalJobs);
            grpBxJob.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpBxJob.ForeColor = Color.Navy;
            grpBxJob.Location = new Point(55, 121);
            grpBxJob.Name = "grpBxJob";
            grpBxJob.Size = new Size(199, 251);
            grpBxJob.TabIndex = 1;
            grpBxJob.TabStop = false;
            grpBxJob.Text = "Job Statistics";
            // 
            // lblRejectedJobs
            // 
            lblRejectedJobs.AutoSize = true;
            lblRejectedJobs.Font = new Font("Calibri", 11F);
            lblRejectedJobs.ForeColor = Color.FromArgb(0, 0, 64);
            lblRejectedJobs.Location = new Point(6, 170);
            lblRejectedJobs.Name = "lblRejectedJobs";
            lblRejectedJobs.Size = new Size(107, 18);
            lblRejectedJobs.TabIndex = 5;
            lblRejectedJobs.Text = "Rejected Jobs: 0";
            // 
            // lblCancelledJobs
            // 
            lblCancelledJobs.AutoSize = true;
            lblCancelledJobs.Font = new Font("Calibri", 11F);
            lblCancelledJobs.ForeColor = Color.FromArgb(0, 0, 64);
            lblCancelledJobs.Location = new Point(6, 145);
            lblCancelledJobs.Name = "lblCancelledJobs";
            lblCancelledJobs.Size = new Size(113, 18);
            lblCancelledJobs.TabIndex = 4;
            lblCancelledJobs.Text = "Cancelled Jobs: 0";
            // 
            // lblCompletedJobs
            // 
            lblCompletedJobs.AutoSize = true;
            lblCompletedJobs.Font = new Font("Calibri", 11F);
            lblCompletedJobs.ForeColor = Color.FromArgb(0, 0, 64);
            lblCompletedJobs.Location = new Point(6, 119);
            lblCompletedJobs.Name = "lblCompletedJobs";
            lblCompletedJobs.Size = new Size(121, 18);
            lblCompletedJobs.TabIndex = 3;
            lblCompletedJobs.Text = "Completed Jobs: 0";
            // 
            // lblInProgressJobs
            // 
            lblInProgressJobs.AutoSize = true;
            lblInProgressJobs.Font = new Font("Calibri", 11F);
            lblInProgressJobs.ForeColor = Color.FromArgb(0, 0, 64);
            lblInProgressJobs.Location = new Point(6, 89);
            lblInProgressJobs.Name = "lblInProgressJobs";
            lblInProgressJobs.Size = new Size(120, 18);
            lblInProgressJobs.TabIndex = 2;
            lblInProgressJobs.Text = "In Progress Jobs: 0";
            // 
            // lblPendingJobs
            // 
            lblPendingJobs.AutoSize = true;
            lblPendingJobs.Font = new Font("Calibri", 11F);
            lblPendingJobs.ForeColor = Color.FromArgb(0, 0, 64);
            lblPendingJobs.Location = new Point(6, 62);
            lblPendingJobs.Name = "lblPendingJobs";
            lblPendingJobs.Size = new Size(103, 18);
            lblPendingJobs.TabIndex = 1;
            lblPendingJobs.Text = "Pending Jobs: 0";
            // 
            // lblTotalJobs
            // 
            lblTotalJobs.AutoSize = true;
            lblTotalJobs.Font = new Font("Calibri", 11F);
            lblTotalJobs.ForeColor = Color.FromArgb(0, 0, 64);
            lblTotalJobs.Location = new Point(6, 34);
            lblTotalJobs.Name = "lblTotalJobs";
            lblTotalJobs.Size = new Size(82, 18);
            lblTotalJobs.TabIndex = 0;
            lblTotalJobs.Text = "Total Jobs: 0";
            // 
            // grpBxLoad
            // 
            grpBxLoad.Controls.Add(lblTotalVolume);
            grpBxLoad.Controls.Add(lblTotalWeight);
            grpBxLoad.Controls.Add(lblTotalLoad);
            grpBxLoad.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpBxLoad.ForeColor = Color.Navy;
            grpBxLoad.Location = new Point(274, 121);
            grpBxLoad.Name = "grpBxLoad";
            grpBxLoad.Size = new Size(199, 251);
            grpBxLoad.TabIndex = 6;
            grpBxLoad.TabStop = false;
            grpBxLoad.Text = "Load Statistics";
            // 
            // lblTotalVolume
            // 
            lblTotalVolume.AutoSize = true;
            lblTotalVolume.Font = new Font("Calibri", 11F);
            lblTotalVolume.ForeColor = Color.FromArgb(0, 0, 64);
            lblTotalVolume.Location = new Point(6, 89);
            lblTotalVolume.Name = "lblTotalVolume";
            lblTotalVolume.Size = new Size(149, 18);
            lblTotalVolume.TabIndex = 2;
            lblTotalVolume.Text = "Total Volumen: 0.00 m³";
            // 
            // lblTotalWeight
            // 
            lblTotalWeight.AutoSize = true;
            lblTotalWeight.Font = new Font("Calibri", 11F);
            lblTotalWeight.ForeColor = Color.FromArgb(0, 0, 64);
            lblTotalWeight.Location = new Point(6, 62);
            lblTotalWeight.Name = "lblTotalWeight";
            lblTotalWeight.Size = new Size(135, 18);
            lblTotalWeight.TabIndex = 1;
            lblTotalWeight.Text = "Total Weight: 0.00 Kg";
            // 
            // lblTotalLoad
            // 
            lblTotalLoad.AutoSize = true;
            lblTotalLoad.Font = new Font("Calibri", 11F);
            lblTotalLoad.ForeColor = Color.FromArgb(0, 0, 64);
            lblTotalLoad.Location = new Point(6, 34);
            lblTotalLoad.Name = "lblTotalLoad";
            lblTotalLoad.Size = new Size(90, 18);
            lblTotalLoad.TabIndex = 0;
            lblTotalLoad.Text = "Total Loads: 0";
            // 
            // grpBxTransportUnit
            // 
            grpBxTransportUnit.Controls.Add(lblUnavailableTransportUnits);
            grpBxTransportUnit.Controls.Add(lblAvailableTransportUnits);
            grpBxTransportUnit.Controls.Add(lblTotalTransportUnits);
            grpBxTransportUnit.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpBxTransportUnit.ForeColor = Color.Navy;
            grpBxTransportUnit.Location = new Point(375, 28);
            grpBxTransportUnit.Name = "grpBxTransportUnit";
            grpBxTransportUnit.Size = new Size(199, 251);
            grpBxTransportUnit.TabIndex = 7;
            grpBxTransportUnit.TabStop = false;
            grpBxTransportUnit.Text = "Transport Unit Statistics";
            // 
            // lblUnavailableTransportUnits
            // 
            lblUnavailableTransportUnits.AutoSize = true;
            lblUnavailableTransportUnits.Font = new Font("Calibri", 11F);
            lblUnavailableTransportUnits.ForeColor = Color.FromArgb(0, 0, 64);
            lblUnavailableTransportUnits.Location = new Point(6, 89);
            lblUnavailableTransportUnits.Name = "lblUnavailableTransportUnits";
            lblUnavailableTransportUnits.Size = new Size(177, 18);
            lblUnavailableTransportUnits.TabIndex = 2;
            lblUnavailableTransportUnits.Text = "Unavailable Transport Units";
            // 
            // lblAvailableTransportUnits
            // 
            lblAvailableTransportUnits.AutoSize = true;
            lblAvailableTransportUnits.Font = new Font("Calibri", 11F);
            lblAvailableTransportUnits.ForeColor = Color.FromArgb(0, 0, 64);
            lblAvailableTransportUnits.Location = new Point(6, 62);
            lblAvailableTransportUnits.Name = "lblAvailableTransportUnits";
            lblAvailableTransportUnits.Size = new Size(176, 18);
            lblAvailableTransportUnits.TabIndex = 1;
            lblAvailableTransportUnits.Text = "Available Transport Units: 0";
            // 
            // lblTotalTransportUnits
            // 
            lblTotalTransportUnits.AutoSize = true;
            lblTotalTransportUnits.Font = new Font("Calibri", 11F);
            lblTotalTransportUnits.ForeColor = Color.FromArgb(0, 0, 64);
            lblTotalTransportUnits.Location = new Point(6, 34);
            lblTotalTransportUnits.Name = "lblTotalTransportUnits";
            lblTotalTransportUnits.Size = new Size(148, 18);
            lblTotalTransportUnits.TabIndex = 0;
            lblTotalTransportUnits.Text = "Total Transport Units: 0";
            // 
            // grpBxRevenue
            // 
            grpBxRevenue.Controls.Add(lblRejectedRevenue);
            grpBxRevenue.Controls.Add(lblCancelledRevenue);
            grpBxRevenue.Controls.Add(lblInProgressRevenue);
            grpBxRevenue.Controls.Add(lblPendingRevenue);
            grpBxRevenue.Controls.Add(lblCompletedRevenue);
            grpBxRevenue.Controls.Add(lblTotalRevenue);
            grpBxRevenue.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpBxRevenue.ForeColor = Color.Navy;
            grpBxRevenue.Location = new Point(490, 121);
            grpBxRevenue.Name = "grpBxRevenue";
            grpBxRevenue.Size = new Size(199, 251);
            grpBxRevenue.TabIndex = 8;
            grpBxRevenue.TabStop = false;
            grpBxRevenue.Text = "Revenue Statistics";
            // 
            // lblRejectedRevenue
            // 
            lblRejectedRevenue.AutoSize = true;
            lblRejectedRevenue.Font = new Font("Calibri", 11F);
            lblRejectedRevenue.ForeColor = Color.FromArgb(0, 0, 64);
            lblRejectedRevenue.Location = new Point(7, 170);
            lblRejectedRevenue.Name = "lblRejectedRevenue";
            lblRejectedRevenue.Size = new Size(102, 18);
            lblRejectedRevenue.TabIndex = 5;
            lblRejectedRevenue.Text = "Rejected: $0.00";
            // 
            // lblCancelledRevenue
            // 
            lblCancelledRevenue.AutoSize = true;
            lblCancelledRevenue.Font = new Font("Calibri", 11F);
            lblCancelledRevenue.ForeColor = Color.FromArgb(0, 0, 64);
            lblCancelledRevenue.Location = new Point(7, 145);
            lblCancelledRevenue.Name = "lblCancelledRevenue";
            lblCancelledRevenue.Size = new Size(108, 18);
            lblCancelledRevenue.TabIndex = 4;
            lblCancelledRevenue.Text = "Cancelled: $0.00";
            // 
            // lblInProgressRevenue
            // 
            lblInProgressRevenue.AutoSize = true;
            lblInProgressRevenue.Font = new Font("Calibri", 11F);
            lblInProgressRevenue.ForeColor = Color.FromArgb(0, 0, 64);
            lblInProgressRevenue.Location = new Point(7, 89);
            lblInProgressRevenue.Name = "lblInProgressRevenue";
            lblInProgressRevenue.Size = new Size(115, 18);
            lblInProgressRevenue.TabIndex = 3;
            lblInProgressRevenue.Text = "In Progress: $0.00";
            // 
            // lblPendingRevenue
            // 
            lblPendingRevenue.AutoSize = true;
            lblPendingRevenue.Font = new Font("Calibri", 11F);
            lblPendingRevenue.ForeColor = Color.FromArgb(0, 0, 64);
            lblPendingRevenue.Location = new Point(6, 62);
            lblPendingRevenue.Name = "lblPendingRevenue";
            lblPendingRevenue.Size = new Size(98, 18);
            lblPendingRevenue.TabIndex = 2;
            lblPendingRevenue.Text = "Pending: $0.00";
            // 
            // lblCompletedRevenue
            // 
            lblCompletedRevenue.AutoSize = true;
            lblCompletedRevenue.Font = new Font("Calibri", 11F);
            lblCompletedRevenue.ForeColor = Color.FromArgb(0, 0, 64);
            lblCompletedRevenue.Location = new Point(6, 119);
            lblCompletedRevenue.Name = "lblCompletedRevenue";
            lblCompletedRevenue.Size = new Size(116, 18);
            lblCompletedRevenue.TabIndex = 1;
            lblCompletedRevenue.Text = "Completed: $0.00";
            // 
            // lblTotalRevenue
            // 
            lblTotalRevenue.AutoSize = true;
            lblTotalRevenue.Font = new Font("Calibri", 11F);
            lblTotalRevenue.ForeColor = Color.FromArgb(0, 0, 64);
            lblTotalRevenue.Location = new Point(6, 34);
            lblTotalRevenue.Name = "lblTotalRevenue";
            lblTotalRevenue.Size = new Size(135, 18);
            lblTotalRevenue.TabIndex = 0;
            lblTotalRevenue.Text = "Total Revenue: $0.00";
            // 
            // grpBxToThisDay
            // 
            grpBxToThisDay.Controls.Add(grpBxCustomer);
            grpBxToThisDay.Controls.Add(grpBxTransportUnit);
            grpBxToThisDay.Controls.Add(btnRrefresh);
            grpBxToThisDay.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            grpBxToThisDay.ForeColor = Color.Navy;
            grpBxToThisDay.Location = new Point(26, 87);
            grpBxToThisDay.Name = "grpBxToThisDay";
            grpBxToThisDay.Size = new Size(732, 291);
            grpBxToThisDay.TabIndex = 8;
            grpBxToThisDay.TabStop = false;
            grpBxToThisDay.Text = "To This Day";
            // 
            // grpBxSelectedPeriod
            // 
            grpBxSelectedPeriod.Controls.Add(lblExplanation);
            grpBxSelectedPeriod.Controls.Add(btnFilter);
            grpBxSelectedPeriod.Controls.Add(dtTmPckrTo);
            grpBxSelectedPeriod.Controls.Add(lblTo);
            grpBxSelectedPeriod.Controls.Add(dtTmPckrFrom);
            grpBxSelectedPeriod.Controls.Add(lblFrom);
            grpBxSelectedPeriod.Controls.Add(grpBxJob);
            grpBxSelectedPeriod.Controls.Add(grpBxRevenue);
            grpBxSelectedPeriod.Controls.Add(grpBxLoad);
            grpBxSelectedPeriod.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            grpBxSelectedPeriod.ForeColor = Color.Navy;
            grpBxSelectedPeriod.Location = new Point(26, 428);
            grpBxSelectedPeriod.Name = "grpBxSelectedPeriod";
            grpBxSelectedPeriod.Size = new Size(732, 378);
            grpBxSelectedPeriod.TabIndex = 9;
            grpBxSelectedPeriod.TabStop = false;
            grpBxSelectedPeriod.Text = "Selected Period";
            // 
            // lblExplanation
            // 
            lblExplanation.AutoSize = true;
            lblExplanation.Location = new Point(61, 85);
            lblExplanation.Name = "lblExplanation";
            lblExplanation.Size = new Size(565, 20);
            lblExplanation.TabIndex = 6;
            lblExplanation.Text = "The Following statistics are belong to the jobs created between above time period";
            // 
            // btnFilter
            // 
            btnFilter.BackColor = SystemColors.HotTrack;
            btnFilter.Cursor = Cursors.Hand;
            btnFilter.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFilter.ForeColor = Color.White;
            btnFilter.Location = new Point(605, 32);
            btnFilter.Name = "btnFilter";
            btnFilter.Padding = new Padding(0, 5, 0, 5);
            btnFilter.Size = new Size(84, 37);
            btnFilter.TabIndex = 10;
            btnFilter.Text = "Report";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // dtTmPckrTo
            // 
            dtTmPckrTo.Location = new Point(390, 38);
            dtTmPckrTo.Name = "dtTmPckrTo";
            dtTmPckrTo.Size = new Size(200, 27);
            dtTmPckrTo.TabIndex = 12;
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.Location = new Point(345, 39);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(25, 20);
            lblTo.TabIndex = 11;
            lblTo.Text = "To";
            // 
            // dtTmPckrFrom
            // 
            dtTmPckrFrom.Location = new Point(106, 37);
            dtTmPckrFrom.Name = "dtTmPckrFrom";
            dtTmPckrFrom.Size = new Size(200, 27);
            dtTmPckrFrom.TabIndex = 10;
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.Location = new Point(55, 39);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(45, 20);
            lblFrom.TabIndex = 9;
            lblFrom.Text = "From";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(230, 81, 49);
            btnClose.Cursor = Cursors.Hand;
            btnClose.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(631, 34);
            btnClose.Name = "btnClose";
            btnClose.Padding = new Padding(0, 5, 0, 5);
            btnClose.Size = new Size(84, 37);
            btnClose.TabIndex = 10;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(782, 818);
            Controls.Add(btnClose);
            Controls.Add(grpBxSelectedPeriod);
            Controls.Add(grpBxToThisDay);
            Controls.Add(lblFormTitle);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ReportForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Report";
            Load += ReportForm_Load;
            grpBxCustomer.ResumeLayout(false);
            grpBxCustomer.PerformLayout();
            grpBxJob.ResumeLayout(false);
            grpBxJob.PerformLayout();
            grpBxLoad.ResumeLayout(false);
            grpBxLoad.PerformLayout();
            grpBxTransportUnit.ResumeLayout(false);
            grpBxTransportUnit.PerformLayout();
            grpBxRevenue.ResumeLayout(false);
            grpBxRevenue.PerformLayout();
            grpBxToThisDay.ResumeLayout(false);
            grpBxSelectedPeriod.ResumeLayout(false);
            grpBxSelectedPeriod.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFormTitle;
        private Button btnRrefresh;
        private GroupBox grpBxCustomer;
        private Label lblTotalCustomers;
        private GroupBox grpBxJob;
        private Label lblTotalJobs;
        private Label lblCompletedJobs;
        private Label lblInProgressJobs;
        private Label lblPendingJobs;
        private Label lblRejectedJobs;
        private Label lblCancelledJobs;
        private GroupBox grpBxLoad;
        private Label lblTotalVolume;
        private Label lblTotalWeight;
        private Label lblTotalLoad;
        private GroupBox grpBxTransportUnit;
        private Label lblUnavailableTransportUnits;
        private Label lblAvailableTransportUnits;
        private Label lblTotalTransportUnits;
        private GroupBox grpBxRevenue;
        private Label lblPendingRevenue;
        private Label lblCompletedRevenue;
        private Label lblTotalRevenue;
        private GroupBox grpBxToThisDay;
        private GroupBox grpBxSelectedPeriod;
        private Label lblFrom;
        private DateTimePicker dtTmPckrTo;
        private Label lblTo;
        private DateTimePicker dtTmPckrFrom;
        private Button btnFilter;
        private Button btnClose;
        private Label lblExplanation;
        private Label lblTotalInactiveCustomers;
        private Label lblTotalActiveCustomers;
        private Label lblInProgressRevenue;
        private Label lblCancelledRevenue;
        private Label lblRejectedRevenue;
    }
}