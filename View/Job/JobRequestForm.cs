using eshift.Controller;
using eshift.Controller.Impl;
using eshift.Dto;
using eshift.Enums;
using System.Data;


namespace eshift.View.Job
{
    public partial class JobRequestForm : Form
    {
        private readonly IJobController jobController;

        public JobRequestForm()
        {
            InitializeComponent();
            jobController = new JobControllerImpl();
        }

        private void btnJobRequestSearch_Click(object sender, EventArgs e)
        {
            try
            {
                // Get job ID from search text box
                string jobId = txtJobRequestSearch.Text.Trim();
                
                if (string.IsNullOrWhiteSpace(jobId))
                {
                    MessageBox.Show("Please enter a Job ID to search.", "Search Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Filter jobs by job ID
                var filteredJobs = jobController.FilterJobByJobId(jobId);
                
                if (filteredJobs.Count == 0)
                {
                    MessageBox.Show($"No job requests found matching '{jobId}'.", "No Results Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgJobRequest.DataSource = null; // Clear the grid
                }
                else
                {
                    // Filter to only show PENDING jobs
                    var pendingJobs = filteredJobs.Where(j => j.Status == JobStatusEnum.PENDING.ToString()).ToList();
                    
                    if (pendingJobs.Count == 0)
                    {
                        MessageBox.Show($"No pending job requests found matching '{jobId}'.", "No Pending Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgJobRequest.DataSource = null;
                    }
                    else
                    {
                        dgJobRequest.DataSource = pendingJobs;
                        MessageBox.Show($"Found {pendingJobs.Count} pending job request(s) matching '{jobId}'.", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in btnJobRequestSearch_Click: {ex.Message}");
                MessageBox.Show($"An error occurred while searching for job requests: {ex.Message}", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                // check if any row is selected
                if (dgJobRequest.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a job request to accept.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // get the first selected row
                DataGridViewRow selectedRow = dgJobRequest.SelectedRows[0];
                JobGridDto? selectedJobRequest = selectedRow.DataBoundItem as JobGridDto;

                JobRequestAcceptForm jobRequestAcceptForm = new JobRequestAcceptForm(selectedJobRequest);
                jobRequestAcceptForm.FormClosed += async (s, args) =>
                {
                    if (jobRequestAcceptForm.DialogResult == DialogResult.OK)
                    {
                        await LoadJobRequestsAsync(); // Refresh the grid
                    }
                };
                jobRequestAcceptForm.Show();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in btnAccept_Click: {ex.Message}");
                MessageBox.Show($"An error occurred while accepting the job request: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnReject_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if any row is selected
                if (dgJobRequest.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a job request to reject.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Get the first selected row
                DataGridViewRow selectedRow = dgJobRequest.SelectedRows[0];
                string? jobId = selectedRow.Cells["JobId"].Value?.ToString();
                
                if (string.IsNullOrWhiteSpace(jobId))
                {
                    MessageBox.Show("Selected row does not have a valid Job ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Get confirmation to reject the job
                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to reject job request {jobId}?", 
                    "Confirm Rejection", 
                    MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Update job status to rejected
                    bool success = jobController.UpdateJobStatusByJobId(jobId, JobStatusEnum.REJECTED);
                    if (success)
                    {
                        MessageBox.Show($"Job request {jobId} has been rejected successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await LoadJobRequestsAsync(); // Refresh the grid
                    }
                    else
                    {
                        MessageBox.Show("Failed to reject the job request. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in btnReject_Click: {ex.Message}");
                MessageBox.Show($"An error occurred while rejecting the job request: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await LoadJobRequestsAsync();
        }

        private async void JobRequestForm_Load(object sender, EventArgs e)
        {
            await LoadJobRequestsAsync();
        }

        private async Task LoadJobRequestsAsync()
        {
            try
            {
                var jobRequests = await Task.Run(() => jobController.GetJobRequestByStatus(JobStatusEnum.PENDING));
                dgJobRequest.DataSource = jobRequests;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading job requests: {ex.Message}");
                MessageBox.Show(
                    "Failed to load job requests. Please check your database connection and try again.",
                    "Error Loading Data",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
