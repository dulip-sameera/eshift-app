using eshift.Controller;
using eshift.Controller.Impl;
using eshift.Dto;
using eshift.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eshift.View.Job
{
    public partial class JobRequestAcceptForm : Form
    {
        private JobGridDto? selectedJobRequest;
        private JobWithLoadsDto consideringJob;
        private readonly IJobController jobController;

        public JobRequestAcceptForm(JobGridDto? selectedJobRequest)
        {
            InitializeComponent();
            this.selectedJobRequest = selectedJobRequest;
            jobController = new JobControllerImpl();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedJobRequest == null || string.IsNullOrWhiteSpace(selectedJobRequest.JobID))
                {
                    MessageBox.Show("No job request selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string jobId = selectedJobRequest.JobID;
                string estimatedCostText = txtEstimatedCost.Text.Trim();

                // Validate estimated cost
                if (string.IsNullOrWhiteSpace(estimatedCostText) || !double.TryParse(estimatedCostText, out double estimatedCost))
                {
                    MessageBox.Show("Please enter a valid estimated cost.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Create JobDto
                var jobDto = new JobDto
                {
                    JobId = jobId,
                    EstimatedCost = estimatedCost
                };

                // Accept job request
                bool success = jobController.AcceptJobRequest(jobDto);
                if (success)
                {
                    MessageBox.Show($"Job request {jobId} has been accepted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    // Close this form and refresh parent form
                    this.DialogResult = DialogResult.OK;
                    windowClose();
                }
                else
                {
                    MessageBox.Show("Failed to accept the job request. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in btnAccept_Click: {ex.Message}");
                MessageBox.Show($"An error occurred while accepting the job request: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedJobRequest == null || string.IsNullOrWhiteSpace(selectedJobRequest.JobID))
                {
                    MessageBox.Show("No job request selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string jobId = selectedJobRequest.JobID;

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
                        
                        // Close this form and refresh parent form
                        this.DialogResult = DialogResult.OK;
                        windowClose();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            windowClose();
        }

        private void windowClose()
        {
            this.Close();
        }

        private void JobRequestAcceptForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (selectedJobRequest == null || string.IsNullOrWhiteSpace(selectedJobRequest.JobID))
                {
                    MessageBox.Show("No job request selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    windowClose();
                    return;
                }

                // Get job data with loads
                var jobWithLoads = jobController.GetJobWithLoadsByJobId(selectedJobRequest.JobID);
                if (jobWithLoads != null) {
                    consideringJob = jobWithLoads;
                }

                if (jobWithLoads == null)
                {
                    MessageBox.Show($"Job request {selectedJobRequest.JobID} not found.", "Job Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    windowClose();
                    return;
                }

                // Populate form fields
                lblFormTitle.Text = $"Accept Job Request #{jobWithLoads.JobId}";
                txtCustomer.Text = jobWithLoads.Customer;
                rchTxtPickup.Text = jobWithLoads.PickupLocation;
                rchTxtDelivery.Text = jobWithLoads.DeliveryLocation;
                dtTmPckrScheduledDate.Value = jobWithLoads.ScheduledDate;
                txtEstimatedCost.Text = jobWithLoads.EstimatedCost?.ToString() ?? "";
                rchTxtDescription.Text = jobWithLoads.Description ?? "";
                
                // Populate loads data grid
                dgLoads.DataSource = jobWithLoads.Loads;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in JobRequestAcceptForm_Load: {ex.Message}");
                MessageBox.Show($"An error occurred while loading job request data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                windowClose();
            }
        }
    }
}
