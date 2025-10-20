using eshift.Controller;
using eshift.Controller.Impl;
using eshift.Dto;
using eshift.Enums;
using eshift.Utils;
using eshift.Utils.Validation;
using System.ComponentModel;
using System.Configuration;


namespace eshift.View.Job
{
    public partial class CustomerJobUpdateForm : Form
    {
        private readonly IJobController jobController = new JobControllerImpl();
        private JobGridDto? selectedJob = null;
        private BindingList<LoadDto> loadList = new();
        private Dictionary<string, Label> errorLabels = new();
        private List<LoadDto> removedLoads = new();
        private List<LoadDto> newLoads = new();
        private JobWithLoadsDto updatingJob;

        public CustomerJobUpdateForm(JobGridDto? jobGridDto)
        {
            InitializeComponent();
            selectedJob = jobGridDto;
            dgLoads.DataSource = loadList;
            errorLabels = new Dictionary<string, Label>
            {
                { "pickup", lblPickUpErrorMessage },
                { "delivery", lblDeliveryErrorMessage },
                { "scheduledDate", lblScheduleDateErrorMessage },
                { "estimatedCost", lblEstimatedCostErrorMessage },
                { "volume", lblLoadVoloumeErrorMessage },
                { "weight", lblLoadWeightErrorMessage }
            };
            HideAllErrorLabels();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                HideAllErrorLabels();

                // Get form values
                string pickup = rchTxtPickup.Text.Trim();
                string delivery = rchTxtDelivery.Text.Trim();
                DateTime scheduledDate = dtTmPckrScheduledDate.Value;
                string estimatedCostStr = txtEstimatedCost.Text.Trim();
                string description = rchTxtDescription.Text.Trim();

                // Validate basic fields
                var errors = JobFormValidator.Validate(pickup, delivery, scheduledDate, estimatedCostStr);
                if (errors.Count > 0)
                {
                    if (errors.ContainsKey("pickup"))
                        lblPickUpErrorMessage.Text = errors["pickup"];
                    if (errors.ContainsKey("delivery"))
                        lblDeliveryErrorMessage.Text = errors["delivery"];
                    if (errors.ContainsKey("scheduledDate"))
                        lblScheduleDateErrorMessage.Text = errors["scheduledDate"];
                    if (errors.ContainsKey("estimatedCost"))
                        lblEstimatedCostErrorMessage.Text = errors["estimatedCost"];
                    return;
                }

                // Parse costs
                double estimatedCost = double.Parse(estimatedCostStr);

                // Create DTO
                var dto = new JobWithLoadsAndTransportUnitDto
                {
                    JobId = updatingJob.JobId,
                    CustomerId = UserSession.SpecialId ?? string.Empty,
                    PickupLocation = pickup,
                    DeliveryLocation = delivery,
                    ScheduledDate = scheduledDate,
                    EstimatedCost = estimatedCost,
                    ActualCost = 0,
                    Description = string.IsNullOrWhiteSpace(description) ? null : description,
                    statusEnum = JobStatusEnum.PENDING,
                    Loads = new List<LoadDto>(loadList),
                    TransportUnits = new List<TransportUnitDto>(), // No transport units for customer
                    RemvoedLoads = removedLoads,
                    RemovedTransportUnits = new List<TransportUnitDto>(), // No transport units for customer
                    NewLoads = newLoads,
                    NewTransportUnits = new List<TransportUnitDto>() // No transport units for customer
                };

                // Update job
                jobController.UpdateJobWithLoadsAndTransportUnitsByJobId(updatingJob.JobId, dto);
                MessageBox.Show("Job updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                windowClose();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in btnUpdate_Click: {ex.Message}");
                MessageBox.Show($"Error updating job: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void HideAllErrorLabels()
        {
            foreach (var label in errorLabels.Values)
            {
                label.Text = "";
            }
        }

        private void btnAddLoad_Click(object sender, EventArgs e)
        {
            try
            {
                HideAllErrorLabels();
                string description = txtLoadDescription.Text.Trim();
                double volume = Convert.ToDouble(nmrcLoadVolume.Value);
                double weight = Convert.ToDouble(nmrcLoadWeight.Value);
                var errors = LoadValidator.Validate(volume, weight);
                if (errors.Count > 0)
                {
                    if (errors.ContainsKey("volume"))
                        lblLoadVoloumeErrorMessage.Text = errors["volume"];
                    if (errors.ContainsKey("weight"))
                        lblLoadWeightErrorMessage.Text = errors["weight"];
                    return;
                }
                var loadDto = new LoadDto(null, null, description, volume, weight, 0); // JobId will be set later
                loadList.Add(loadDto);
                dgLoads.DataSource = null;
                dgLoads.DataSource = loadList;
                UpdateEstimatedCost();

                // Add to newLoads list for tracking
                newLoads.Add(loadDto);

                clearLoadInputFields();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding load: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoveLoad_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgLoads.SelectedRows.Count > 0)
                {
                    var selectedLoad = dgLoads.SelectedRows[0].DataBoundItem as LoadDto;
                    if (selectedLoad != null)
                    {
                        loadList.Remove(selectedLoad);
                        UpdateEstimatedCost();
                    }

                    // Add to removedLoads list for tracking unless it's a new load
                    if (!newLoads.Contains(selectedLoad))
                    {
                        removedLoads.Add(selectedLoad);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error removing load: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearLoad_Click(object sender, EventArgs e)
        {
            try
            {
                // Add all existing loads to removedLoads list for tracking, unless they are new loads
                foreach (var load in loadList)
                {
                    if (!newLoads.Contains(load))
                    {
                        removedLoads.Add(load);
                    }
                }

                loadList.Clear();
                UpdateEstimatedCost();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error clearing loads: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CustomerJobUpdateForm_Load(object sender, EventArgs e)
        {
            try
            {

                // Get job data with loads
                var jobWithLoads = jobController.GetJobWithLoadsByJobId(selectedJob.JobID);
                if (jobWithLoads != null)
                {
                    updatingJob = jobWithLoads;
                }


                if (jobWithLoads == null)
                {
                    MessageBox.Show($"Job request {selectedJob.JobID} not found.", "Job Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    windowClose();
                    return;
                }

                // Populate form fields
                lblFormTitle.Text = $"Update Job Request #{jobWithLoads.JobId}";
                rchTxtPickup.Text = jobWithLoads.PickupLocation;
                rchTxtDelivery.Text = jobWithLoads.DeliveryLocation;
                dtTmPckrScheduledDate.Value = jobWithLoads.ScheduledDate;
                txtEstimatedCost.Text = jobWithLoads.EstimatedCost?.ToString() ?? "";
                rchTxtDescription.Text = jobWithLoads.Description ?? "";

                // Populate loadList with existing loads
                loadList.Clear();
                foreach (var load in jobWithLoads.Loads)
                {
                    loadList.Add(load);
                }
                
                // Populate loads data grid
                dgLoads.DataSource = loadList;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in JobRequestAcceptForm_Load: {ex.Message}");
                MessageBox.Show($"An error occurred while loading job request data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                windowClose();
            }
        }

        private void UpdateEstimatedCost()
        {
            try
            {
                double volumeUnitPrice = double.Parse(ConfigurationManager.AppSettings["VolumeUnitPrice"] ?? "50.0");
                double weightUnitPrice = double.Parse(ConfigurationManager.AppSettings["WeightUnitPrice"] ?? "10.0");

                double totalVolume = loadList.Sum(load => load.Volume);
                double totalWeight = loadList.Sum(load => load.Weight);

                double estimatedCost = (totalVolume * volumeUnitPrice) + (totalWeight * weightUnitPrice);
                txtEstimatedCost.Text = estimatedCost.ToString("F2");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error calculating estimated cost: {ex.Message}");
            }
        }

        private void clearLoadInputFields()
        {
            txtLoadDescription.Text = "";
            nmrcLoadVolume.Value = 0;
            nmrcLoadWeight.Value = 0;
        }
    }
}
