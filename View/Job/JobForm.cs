using eshift.Controller;
using eshift.Controller.Impl;
using eshift.Dto;
using eshift.Enums;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eshift.View.Job
{
    public partial class JobForm : Form
    {
        private readonly IJobController jobController;

        public JobForm()
        {
            InitializeComponent();
            jobController = new JobControllerImpl();
        }

        private void btnJobSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string jobId = txtJobSearch.Text.Trim();
                var pattern = @"^JB\d{4}\d{5}$";
                if (string.IsNullOrWhiteSpace(jobId))
                {
                    MessageBox.Show("Please enter a Job ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!System.Text.RegularExpressions.Regex.IsMatch(jobId, pattern))
                {
                    MessageBox.Show("Job ID must follow the pattern: JBYYYYNNNNN", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                JobGridDto? job = jobController.GetJobForGridByJobId(jobId);
                if (job != null)
                {
                    dgJob.DataSource = new List<JobGridDto> { job };
                }
                else
                {
                    MessageBox.Show($"No job found with ID: {jobId}", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgJob.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error searching job: {ex.Message}");
                MessageBox.Show($"An error occurred while searching for the job: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreateJob_Click(object sender, EventArgs e)
        {
            CreateJobForm createJobForm = new CreateJobForm();
            createJobForm.Show();
        }

        private void btnUpdateJob_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgJob.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a job to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var selectedRow = dgJob.SelectedRows[0];
                var jobGridDto = selectedRow.DataBoundItem as JobGridDto;
                if (jobGridDto == null)
                {
                    MessageBox.Show("Selected row does not have a valid job.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                UpdateJobForm updateJobForm = new UpdateJobForm(jobGridDto);
                updateJobForm.Show();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error opening Update Job form: {ex.Message}");
                MessageBox.Show($"An error occurred while opening the Update Job form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteJob_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgJob.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a job to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var selectedRow = dgJob.SelectedRows[0];
                var jobGridDto = selectedRow.DataBoundItem as JobGridDto;
                if (jobGridDto == null || string.IsNullOrWhiteSpace(jobGridDto.JobID))
                {
                    MessageBox.Show("Selected row does not have a valid Job ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var confirmResult = MessageBox.Show(
                    $"Are you sure you want to delete job {jobGridDto.JobID}?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmResult != DialogResult.Yes)
                    return;

                jobController.DeleteJobByJobId(jobGridDto.JobID, JobStatusEnum.DELETED);
                MessageBox.Show($"Job {jobGridDto.JobID} deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnRefresh.PerformClick();
            }
            catch (KeyNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting job: {ex.Message}");
                MessageBox.Show($"An error occurred while deleting the job: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private async void JobForm_Load(object sender, EventArgs e)
        {
            await loadJobFormAsync();
        }

        private async Task loadJobFormAsync()
        {
            try
            {
                List<JobGridDto>? jobList = await Task.Run(() => jobController.GetAllJobsForGrid());
                dgJob.DataSource = jobList;
            }
            catch (KeyNotFoundException ex)
            {
                MessageBox.Show($"No jobs found: {ex.Message}", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgJob.DataSource = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading jobs: {ex.Message}");
                MessageBox.Show($"An error occurred while loading jobs: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtJobSearch.Text))
                txtJobSearch.Clear();
            await loadJobFormAsync();
        }
    }
}
