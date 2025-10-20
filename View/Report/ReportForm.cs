using eshift.Controller;
using eshift.Controller.Impl;
using eshift.Service;
using eshift.Service.Impl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eshift.View.Report
{
    public partial class ReportForm : Form
    {
        private readonly IReportController reportController = new ReportControllerImpl();  

        public ReportForm()
        {
            InitializeComponent();
        }

        private async void btnRrefresh_Click(object sender, EventArgs e)
        {
            await LoadReportsAsync();
        }

        private async void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fromDate = dtTmPckrFrom.Value.Date;
                DateTime toDate = dtTmPckrTo.Value.Date;
                
                if (fromDate > toDate)
                {
                    MessageBox.Show("From date cannot be greater than To date.", "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                await LoadFilteredReportsAsync(fromDate, toDate);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in btnFilter_Click: {ex.Message}");
                MessageBox.Show($"Error filtering reports: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboardForm adminDashboardForm = new AdminDashboardForm();
            adminDashboardForm.FormClosed += (s, args) =>
            {
                this.Close();
                Application.Exit();
            };
            adminDashboardForm.Show();
        }

        private async void ReportForm_Load(object sender, EventArgs e)
        {
            await LoadReportsAsync();
        }

        private async Task LoadReportsAsync()
        {
            try
            {
                await LoadCustomerStatisticsAsync();
                await LoadTransportStatisticsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading reports: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadCustomerStatisticsAsync()
        {
            await Task.Run(() =>
            {
                var customerStats = reportController.GetCustomerStatisticsReport();
                this.Invoke(() =>
                {
                    lblTotalCustomers.Text = $"Total Customers : {customerStats.TotalCustomers}";
                    lblTotalActiveCustomers.Text = $"Total Active Customers : {customerStats.ActiveCustomers}";
                    lblTotalInactiveCustomers.Text = $"Total Inactive Customers : {customerStats.InactiveCustomers}";
                });
            });
        }

        private async Task LoadTransportStatisticsAsync()
        {
            await Task.Run(() =>
            {
                var transportStats = reportController.GetTransportStatisticsReport();
                this.Invoke(() =>
                {
                    lblTotalTransportUnits.Text = $"Total Transport Units: {transportStats.TotalTransportUnits}";
                    lblAvailableTransportUnits.Text = $"Available Transport Units: {transportStats.AvailableTransportUnits}";
                    lblUnavailableTransportUnits.Text = $"Unavailable Transport Units: {transportStats.UnavailableTransportUnits}";
                });
            });
        }

        private async Task LoadFilteredReportsAsync(DateTime fromDate, DateTime toDate)
        {
            try
            {
                await LoadJobStatisticsAsync(fromDate, toDate);
                await LoadLoadStatisticsAsync(fromDate, toDate);
                await LoadRevenueStatisticsAsync(fromDate, toDate);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in LoadFilteredReportsAsync: {ex.Message}");
                MessageBox.Show($"Error loading filtered reports: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadJobStatisticsAsync(DateTime fromDate, DateTime toDate)
        {
            try
            {
                await Task.Run(() =>
                {
                    var jobStats = reportController.GetJobStatisticsReportBetweenDates(fromDate, toDate);
                    this.Invoke(() =>
                    {
                        lblTotalJobs.Text = $"Total Jobs: {jobStats.TotalJobs}";
                        lblPendingJobs.Text = $"Pending Jobs: {jobStats.PendingJobs}";
                        lblInProgressJobs.Text = $"In Progress Jobs: {jobStats.InProgressJobs}";
                        lblCompletedJobs.Text = $"Completed Jobs: {jobStats.CompletedJobs}";
                        lblCancelledJobs.Text = $"Cancelled Jobs: {jobStats.CancelledJobs}";
                        lblRejectedJobs.Text = $"Rejected Jobs: {jobStats.RejectedJobs}";
                    });
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in LoadJobStatisticsAsync: {ex.Message}");
                throw new Exception($"Failed to load job statistics: {ex.Message}", ex);
            }
        }

        private async Task LoadLoadStatisticsAsync(DateTime fromDate, DateTime toDate)
        {
            try
            {
                await Task.Run(() =>
                {
                    var loadStats = reportController.GetLoadStatisticsReportBetweenDates(fromDate, toDate);
                    this.Invoke(() =>
                    {
                        lblTotalLoad.Text = $"Total Loads: {loadStats.TottalLoads}";
                        lblTotalWeight.Text = $"Total Weight: {loadStats.TotalWeight} Kg";
                        lblTotalVolume.Text = $"Total Volume: {loadStats.TotalVolume} m³";
                    });
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in LoadLoadStatisticsAsync: {ex.Message}");
                throw new Exception($"Failed to load load statistics: {ex.Message}", ex);
            }
        }

        private async Task LoadRevenueStatisticsAsync(DateTime fromDate, DateTime toDate)
        {
            try
            {
                await Task.Run(() =>
                {
                    var revenueStats = reportController.GetRevenueStatisticsReportBetweenDates(fromDate, toDate);
                    this.Invoke(() =>
                    {
                        lblTotalRevenue.Text = $"Total Revenue: {revenueStats.TotalRevenue}";
                        lblPendingRevenue.Text = $"Pending Revenue: {revenueStats.PendingRevenue}";
                        lblInProgressRevenue.Text = $"In Progress Revenue: {revenueStats.InProgressRevenue}";
                        lblCompletedRevenue.Text = $"Completed Revenue: {revenueStats.CompletedRevenue}";
                        lblCancelledRevenue.Text = $"Cancelled Revenue: {revenueStats.CancelledRevenue}";
                        lblRejectedRevenue.Text = $"Rejected Revenue: {revenueStats.RejectedRevenue}";
                    });
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in LoadRevenueStatisticsAsync: {ex.Message}");
                throw new Exception($"Failed to load revenue statistics: {ex.Message}", ex);
            }
        }
    }
}
