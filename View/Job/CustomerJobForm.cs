using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eshift.Controller;
using eshift.Controller.Impl;
using eshift.Dto;
using eshift.Enums;
using eshift.Utils;

namespace eshift.View.Job
{
    public partial class CustomerJobForm : Form
    {
        private readonly IJobController jobController = new JobControllerImpl();
        private List<JobGridDto> jobList = new List<JobGridDto>();

        public CustomerJobForm()
        {
            InitializeComponent();
        }

        private void btnCreateJob_Click(object sender, EventArgs e)
        {
            CustomerCreateJobForm customerCreateJobForm = new CustomerCreateJobForm();
            customerCreateJobForm.Show();
        }

        private void btnUpdateJob_Click(object sender, EventArgs e)
        {
            try
            {
                // get the selected job from the data grid view
                if (dgJob.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a job to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // update only if its status is PENDING 
                JobGridDto selectedJob = (JobGridDto)dgJob.SelectedRows[0].DataBoundItem;
                if (selectedJob.Status != JobStatusEnum.PENDING.ToString())
                {
                    MessageBox.Show("Only jobs with status PENDING can be updated.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                CustomerJobUpdateForm customerJobUpdateForm = new CustomerJobUpdateForm(selectedJob);
                customerJobUpdateForm.Show();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in btnUpdateJob_Click: {ex.Message}");
                MessageBox.Show($"Error updating job: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteJob_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgJob.SelectedRows.Count > 0)
                {
                    // deleted only if its status is PENDING or REJECTED
                    string? jobStatus = dgJob.SelectedRows[0].Cells["Status"].Value.ToString();
                    if (jobStatus != JobStatusEnum.PENDING.ToString() && jobStatus != JobStatusEnum.REJECTED.ToString())
                    {
                        MessageBox.Show("Only jobs with status PENDING or REJECTED can be deleted.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Get the JobID of the selected job
                    string? jobId = dgJob.SelectedRows[0].Cells["Job ID"].Value.ToString();
                    // Confirm deletion
                    var confirmResult = MessageBox.Show("Are you sure to delete this job?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmResult != DialogResult.Yes)
                    {
                        return; // User cancelled deletion
                    }
                    jobController.DeleteJobByJobId(jobId, JobStatusEnum.DELETED);
                    MessageBox.Show("Job deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _ = LoadJobDataAsync();
                }
                else
                {
                    MessageBox.Show("Please select a job to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in btnDeleteJob_Click: {ex.Message}");
                MessageBox.Show($"Error deleting job: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerDashboardForm customerDashboardForm = new CustomerDashboardForm();
            customerDashboardForm.FormClosed += (s, args) =>
            {
                this.Close();
                Application.Exit();
            };
            customerDashboardForm.Show();
        }

        private void btnJobSearch_Click(object sender, EventArgs e)
        {
            try
            {
                // get the job id from the search box
                string jobId = txtJobSearch.Text.Trim();

                // filter the job list based on the job id
                var filteredJobs = jobList.Where(j => j.JobID != null && j.JobID.Contains(jobId, StringComparison.OrdinalIgnoreCase)).ToList();

                // if no jobs found
                if (filteredJobs.Count == 0)
                {
                    MessageBox.Show("No jobs found with the given Job ID.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // update the data grid view with the filtered job list
                dgJob.DataSource = filteredJobs;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in btnJobSearch_Click: {ex.Message}");
                MessageBox.Show($"Error searching job: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void CustomerJobForm_Load(object sender, EventArgs e)
        {
            await LoadJobDataAsync();
        }
        
        private async Task LoadJobDataAsync()
        {
            try
            {
                var customerId = UserSession.SpecialId;
                if (customerId == null)
                {
                    MessageBox.Show("User session not found. Please login again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                var jobList = await Task.Run(() => jobController.GetAllJobsForGridByCustomerId(customerId));
                dgJob.DataSource = jobList;
                this.jobList = jobList;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in LoadJobDataAsync: {ex.Message}");
                MessageBox.Show($"Error loading job data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await LoadJobDataAsync();
        }
    }
}
