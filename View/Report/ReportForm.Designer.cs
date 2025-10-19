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
            lblTotalCustomers = new Label();
            grpBxJob = new GroupBox();
            lblRejected = new Label();
            lblCancelled = new Label();
            lblCompleted = new Label();
            lblInProgress = new Label();
            lblPending = new Label();
            lblTotalJobs = new Label();
            grpBxLoad = new GroupBox();
            label4 = new Label();
            lblTotalWeight = new Label();
            lblTotalLoad = new Label();
            grpBxTransportUnit = new GroupBox();
            lblUnavailableTransportUnits = new Label();
            lblAvailableTransportUnits = new Label();
            lblTotalTransportUnits = new Label();
            grpBxRevenue = new GroupBox();
            lblPendingRevenue = new Label();
            lblCompletedRevenue = new Label();
            lblTotalRevenue = new Label();
            grpBxToThisDay = new GroupBox();
            grpBxSelectedPeriod = new GroupBox();
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
            btnRrefresh.Location = new Point(541, 33);
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
            // lblTotalCustomers
            // 
            lblTotalCustomers.AutoSize = true;
            lblTotalCustomers.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalCustomers.ForeColor = Color.FromArgb(0, 0, 64);
            lblTotalCustomers.Location = new Point(6, 34);
            lblTotalCustomers.Name = "lblTotalCustomers";
            lblTotalCustomers.Size = new Size(111, 15);
            lblTotalCustomers.TabIndex = 0;
            lblTotalCustomers.Text = "Total Customers : 0";
            // 
            // grpBxJob
            // 
            grpBxJob.Controls.Add(lblRejected);
            grpBxJob.Controls.Add(lblCancelled);
            grpBxJob.Controls.Add(lblCompleted);
            grpBxJob.Controls.Add(lblInProgress);
            grpBxJob.Controls.Add(lblPending);
            grpBxJob.Controls.Add(lblTotalJobs);
            grpBxJob.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpBxJob.ForeColor = Color.Navy;
            grpBxJob.Location = new Point(55, 80);
            grpBxJob.Name = "grpBxJob";
            grpBxJob.Size = new Size(199, 251);
            grpBxJob.TabIndex = 1;
            grpBxJob.TabStop = false;
            grpBxJob.Text = "Job Statistics";
            // 
            // lblRejected
            // 
            lblRejected.AutoSize = true;
            lblRejected.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRejected.ForeColor = Color.FromArgb(0, 0, 64);
            lblRejected.Location = new Point(6, 170);
            lblRejected.Name = "lblRejected";
            lblRejected.Size = new Size(93, 15);
            lblRejected.TabIndex = 5;
            lblRejected.Text = "Rejected Jobs: 0";
            // 
            // lblCancelled
            // 
            lblCancelled.AutoSize = true;
            lblCancelled.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCancelled.ForeColor = Color.FromArgb(0, 0, 64);
            lblCancelled.Location = new Point(6, 145);
            lblCancelled.Name = "lblCancelled";
            lblCancelled.Size = new Size(101, 15);
            lblCancelled.TabIndex = 4;
            lblCancelled.Text = "Cancelled Jobs: 0";
            // 
            // lblCompleted
            // 
            lblCompleted.AutoSize = true;
            lblCompleted.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCompleted.ForeColor = Color.FromArgb(0, 0, 64);
            lblCompleted.Location = new Point(6, 119);
            lblCompleted.Name = "lblCompleted";
            lblCompleted.Size = new Size(105, 15);
            lblCompleted.TabIndex = 3;
            lblCompleted.Text = "Completed Jobs: 0";
            // 
            // lblInProgress
            // 
            lblInProgress.AutoSize = true;
            lblInProgress.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInProgress.ForeColor = Color.FromArgb(0, 0, 64);
            lblInProgress.Location = new Point(6, 89);
            lblInProgress.Name = "lblInProgress";
            lblInProgress.Size = new Size(109, 15);
            lblInProgress.TabIndex = 2;
            lblInProgress.Text = "In Progress Jobs: 0";
            // 
            // lblPending
            // 
            lblPending.AutoSize = true;
            lblPending.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPending.ForeColor = Color.FromArgb(0, 0, 64);
            lblPending.Location = new Point(6, 62);
            lblPending.Name = "lblPending";
            lblPending.Size = new Size(91, 15);
            lblPending.TabIndex = 1;
            lblPending.Text = "Pending Jobs: 0";
            // 
            // lblTotalJobs
            // 
            lblTotalJobs.AutoSize = true;
            lblTotalJobs.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalJobs.ForeColor = Color.FromArgb(0, 0, 64);
            lblTotalJobs.Location = new Point(6, 34);
            lblTotalJobs.Name = "lblTotalJobs";
            lblTotalJobs.Size = new Size(74, 15);
            lblTotalJobs.TabIndex = 0;
            lblTotalJobs.Text = "Total Jobs: 0";
            // 
            // grpBxLoad
            // 
            grpBxLoad.Controls.Add(label4);
            grpBxLoad.Controls.Add(lblTotalWeight);
            grpBxLoad.Controls.Add(lblTotalLoad);
            grpBxLoad.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpBxLoad.ForeColor = Color.Navy;
            grpBxLoad.Location = new Point(274, 80);
            grpBxLoad.Name = "grpBxLoad";
            grpBxLoad.Size = new Size(199, 251);
            grpBxLoad.TabIndex = 6;
            grpBxLoad.TabStop = false;
            grpBxLoad.Text = "Load Statistics";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 0, 64);
            label4.Location = new Point(6, 89);
            label4.Name = "label4";
            label4.Size = new Size(131, 15);
            label4.TabIndex = 2;
            label4.Text = "Total Volumen: 0.00 m³";
            // 
            // lblTotalWeight
            // 
            lblTotalWeight.AutoSize = true;
            lblTotalWeight.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalWeight.ForeColor = Color.FromArgb(0, 0, 64);
            lblTotalWeight.Location = new Point(6, 62);
            lblTotalWeight.Name = "lblTotalWeight";
            lblTotalWeight.Size = new Size(122, 15);
            lblTotalWeight.TabIndex = 1;
            lblTotalWeight.Text = "Total Weight: 0.00 Kg";
            // 
            // lblTotalLoad
            // 
            lblTotalLoad.AutoSize = true;
            lblTotalLoad.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalLoad.ForeColor = Color.FromArgb(0, 0, 64);
            lblTotalLoad.Location = new Point(6, 34);
            lblTotalLoad.Name = "lblTotalLoad";
            lblTotalLoad.Size = new Size(82, 15);
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
            grpBxTransportUnit.Location = new Point(311, 28);
            grpBxTransportUnit.Name = "grpBxTransportUnit";
            grpBxTransportUnit.Size = new Size(199, 251);
            grpBxTransportUnit.TabIndex = 7;
            grpBxTransportUnit.TabStop = false;
            grpBxTransportUnit.Text = "Transport Unit Statistics";
            // 
            // lblUnavailableTransportUnits
            // 
            lblUnavailableTransportUnits.AutoSize = true;
            lblUnavailableTransportUnits.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUnavailableTransportUnits.ForeColor = Color.FromArgb(0, 0, 64);
            lblUnavailableTransportUnits.Location = new Point(6, 89);
            lblUnavailableTransportUnits.Name = "lblUnavailableTransportUnits";
            lblUnavailableTransportUnits.Size = new Size(162, 15);
            lblUnavailableTransportUnits.TabIndex = 2;
            lblUnavailableTransportUnits.Text = "Unavailable Transport Units";
            // 
            // lblAvailableTransportUnits
            // 
            lblAvailableTransportUnits.AutoSize = true;
            lblAvailableTransportUnits.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAvailableTransportUnits.ForeColor = Color.FromArgb(0, 0, 64);
            lblAvailableTransportUnits.Location = new Point(6, 62);
            lblAvailableTransportUnits.Name = "lblAvailableTransportUnits";
            lblAvailableTransportUnits.Size = new Size(160, 15);
            lblAvailableTransportUnits.TabIndex = 1;
            lblAvailableTransportUnits.Text = "Available Transport Units: 0";
            // 
            // lblTotalTransportUnits
            // 
            lblTotalTransportUnits.AutoSize = true;
            lblTotalTransportUnits.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalTransportUnits.ForeColor = Color.FromArgb(0, 0, 64);
            lblTotalTransportUnits.Location = new Point(6, 34);
            lblTotalTransportUnits.Name = "lblTotalTransportUnits";
            lblTotalTransportUnits.Size = new Size(135, 15);
            lblTotalTransportUnits.TabIndex = 0;
            lblTotalTransportUnits.Text = "Total Transport Units: 0";
            // 
            // grpBxRevenue
            // 
            grpBxRevenue.Controls.Add(lblPendingRevenue);
            grpBxRevenue.Controls.Add(lblCompletedRevenue);
            grpBxRevenue.Controls.Add(lblTotalRevenue);
            grpBxRevenue.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpBxRevenue.ForeColor = Color.Navy;
            grpBxRevenue.Location = new Point(490, 80);
            grpBxRevenue.Name = "grpBxRevenue";
            grpBxRevenue.Size = new Size(199, 251);
            grpBxRevenue.TabIndex = 8;
            grpBxRevenue.TabStop = false;
            grpBxRevenue.Text = "Revenue Statistics";
            // 
            // lblPendingRevenue
            // 
            lblPendingRevenue.AutoSize = true;
            lblPendingRevenue.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPendingRevenue.ForeColor = Color.FromArgb(0, 0, 64);
            lblPendingRevenue.Location = new Point(6, 89);
            lblPendingRevenue.Name = "lblPendingRevenue";
            lblPendingRevenue.Size = new Size(88, 15);
            lblPendingRevenue.TabIndex = 2;
            lblPendingRevenue.Text = "Pending: $0.00";
            // 
            // lblCompletedRevenue
            // 
            lblCompletedRevenue.AutoSize = true;
            lblCompletedRevenue.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCompletedRevenue.ForeColor = Color.FromArgb(0, 0, 64);
            lblCompletedRevenue.Location = new Point(6, 62);
            lblCompletedRevenue.Name = "lblCompletedRevenue";
            lblCompletedRevenue.Size = new Size(102, 15);
            lblCompletedRevenue.TabIndex = 1;
            lblCompletedRevenue.Text = "Completed: $0.00";
            // 
            // lblTotalRevenue
            // 
            lblTotalRevenue.AutoSize = true;
            lblTotalRevenue.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalRevenue.ForeColor = Color.FromArgb(0, 0, 64);
            lblTotalRevenue.Location = new Point(6, 34);
            lblTotalRevenue.Name = "lblTotalRevenue";
            lblTotalRevenue.Size = new Size(119, 15);
            lblTotalRevenue.TabIndex = 0;
            lblTotalRevenue.Text = "Total Revenue: $0.00";
            // 
            // grpBxToThisDay
            // 
            grpBxToThisDay.Controls.Add(grpBxCustomer);
            grpBxToThisDay.Controls.Add(grpBxTransportUnit);
            grpBxToThisDay.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            grpBxToThisDay.ForeColor = Color.Navy;
            grpBxToThisDay.Location = new Point(26, 87);
            grpBxToThisDay.Name = "grpBxToThisDay";
            grpBxToThisDay.Size = new Size(577, 291);
            grpBxToThisDay.TabIndex = 8;
            grpBxToThisDay.TabStop = false;
            grpBxToThisDay.Text = "To This Day";
            // 
            // grpBxSelectedPeriod
            // 
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
            grpBxSelectedPeriod.Size = new Size(732, 350);
            grpBxSelectedPeriod.TabIndex = 9;
            grpBxSelectedPeriod.TabStop = false;
            grpBxSelectedPeriod.Text = "Selected Period";
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
            Controls.Add(btnRrefresh);
            Controls.Add(lblFormTitle);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ReportForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Report";
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
        private Label lblCompleted;
        private Label lblInProgress;
        private Label lblPending;
        private Label lblRejected;
        private Label lblCancelled;
        private GroupBox grpBxLoad;
        private Label label4;
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
    }
}