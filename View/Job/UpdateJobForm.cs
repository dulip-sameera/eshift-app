using eshift.Controller;
using eshift.Controller.Impl;
using eshift.Dto;
using eshift.Enums;
using eshift.Utils.Validation;
using System.ComponentModel;

namespace eshift.View.Job
{
    public partial class UpdateJobForm : Form
    {
        private readonly IJobController jobController = new JobControllerImpl();
        private readonly JobGridDto jobGridDto;
        private BindingList<LoadDto> loadList = new();
        private BindingList<TransportUnitDto> transportUnitList = new();
        private Dictionary<string, Label> errorLabels = new();
        private List<LoadDto> removedLoads = new();
        private List<TransportUnitDto> removedTransportUnits = new();
        private List<LoadDto> newLoads = new();
        private List<TransportUnitDto> newTransportUnits = new();

        public UpdateJobForm(JobGridDto jobGridDto)
        {
            InitializeComponent();
            this.jobGridDto = jobGridDto;
            dgLoads.DataSource = loadList;
            dgTransportUnit.DataSource = transportUnitList;
            errorLabels = new Dictionary<string, Label>
            {
                { "pickup", lblPickUpErrorMessage },
                { "delivery", lblDeliveryErrorMessage },
                { "scheduledDate", lblScheduleDateErrorMessage },
                { "estimatedCost", lblEstimatedCostErrorMessage },
                { "volume", lblLoadVoloumeErrorMessage },
                { "weight", lblLoadWeightErrorMessage },
                { "actualCost", lblActualCostErrorMessage},
                {"status", lblStatusErrorMessage   }
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
                string actualCostStr = txtActualCost.Text.Trim();
                string description = rchTxtDescription.Text.Trim();
                string statusStr = cmbStatus.SelectedItem?.ToString();

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

                // Validate status
                if (string.IsNullOrWhiteSpace(statusStr))
                {
                    lblStatusErrorMessage.Text = "Please select a status.";
                    return;
                }

                // Parse costs
                double estimatedCost = double.Parse(estimatedCostStr);
                double? actualCost = null;
                if (!string.IsNullOrWhiteSpace(actualCostStr))
                {
                    if (!double.TryParse(actualCostStr, out double parsedActualCost))
                    {
                        lblActualCostErrorMessage.Text = "Invalid actual cost format.";
                        return;
                    }
                    actualCost = parsedActualCost;
                }

                // Parse status enum
                var statusMap = new Dictionary<string, JobStatusEnum>
                {
                    ["PENDING"] = JobStatusEnum.PENDING,
                    ["ACCEPTED"] = JobStatusEnum.ACCEPTED,
                    ["IN_PROGRESS"] = JobStatusEnum.IN_PROGRESS,
                    ["COMPLETED"] = JobStatusEnum.COMPLETED,
                    ["CANCELED"] = JobStatusEnum.CANCELED,
                    ["REJECTED"] = JobStatusEnum.REJECTED,
                    ["DELETED"] = JobStatusEnum.DELETED
                };

                Console.WriteLine($"Status selected: {statusStr}");

                if (!statusMap.ContainsKey(statusStr))
                {
                    lblStatusErrorMessage.Text = "Invalid status selected.";
                    return;
                }

                var statusEnum = statusMap[statusStr];


                // Check transport unit capacity vs load capacity
                if (transportUnitList.Count > 0)
                {
                    double tuTotalVolume = 0, tuTotalWeight = 0;
                    foreach (var tu in transportUnitList)
                    {
                        var vehicle = jobController.GetVehicleById(tu.VehicleId);
                        tuTotalVolume += vehicle.ContainerVolume;
                        tuTotalWeight += vehicle.MaxWeight;
                    }
                    double loadTotalVolume = 0, loadTotalWeight = 0;
                    foreach (var load in loadList)
                    {
                        loadTotalVolume += load.Volume;
                        loadTotalWeight += load.Weight;
                    }
                    if (tuTotalVolume < loadTotalVolume || tuTotalWeight < loadTotalWeight)
                    {
                        MessageBox.Show("Transport units do not have enough capacity for the loads. Add more transport units or reduce loads.", "Capacity Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Create DTO
                var dto = new JobWithLoadsAndTransportUnitDto
                {
                    JobId = jobGridDto.JobID,
                    CustomerId = txtCustomer.Text,
                    PickupLocation = pickup,
                    DeliveryLocation = delivery,
                    ScheduledDate = scheduledDate,
                    EstimatedCost = estimatedCost,
                    ActualCost = actualCost,
                    Description = string.IsNullOrWhiteSpace(description) ? null : description,
                    statusEnum = statusEnum,
                    Loads = new List<LoadDto>(loadList),
                    TransportUnits = new List<TransportUnitDto>(transportUnitList),
                    RemvoedLoads = removedLoads,
                    RemovedTransportUnits = removedTransportUnits,
                    NewLoads = newLoads,
                    NewTransportUnits = newTransportUnits
                };

                // Update job
                jobController.UpdateJobWithLoadsAndTransportUnitsByJobId(jobGridDto.JobID, dto);
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
                        loadList.Remove(selectedLoad);

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
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error clearing loads: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddTransportUnit_Click(object sender, EventArgs e)
        {
            try
            {
                string tuId = txtTransportUnitId.Text.Trim();
                var pattern = @"^TU\d{4}\d{5}$";
                if (string.IsNullOrWhiteSpace(tuId) || !System.Text.RegularExpressions.Regex.IsMatch(tuId, pattern))
                {
                    MessageBox.Show("Transport Unit ID must follow the pattern: TUYYYYNNNNN", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var tu = jobController.GetTransportUnitById(tuId);
                if (tu == null)
                {
                    MessageBox.Show("Transport unit not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                transportUnitList.Add(tu);

                // Add to newTransportUnits list for tracking
                newTransportUnits.Add(tu);

                clearTransportUnitInputFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving transport unit: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoveTransportUnit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgTransportUnit.SelectedRows.Count > 0)
                {
                    var selectedTU = dgTransportUnit.SelectedRows[0].DataBoundItem as TransportUnitDto;
                    if (selectedTU != null)
                        transportUnitList.Remove(selectedTU);

                    // Add to removedTransportUnits list for tracking unless it's a new transport unit
                    if (!newTransportUnits.Contains(selectedTU))
                    {
                        removedTransportUnits.Add(selectedTU);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error removing transport unit: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearTransportUnit_Click(object sender, EventArgs e)
        {
            try
            {
                // Add all existing transport units to removedTransportUnits list for tracking, unless they are new transport units
                foreach (var tu in transportUnitList)
                {
                    if (!newTransportUnits.Contains(tu))
                    {
                        removedTransportUnits.Add(tu);
                    }
                }

                transportUnitList.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error clearing transport units: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void windowClose()
        {
            this.Close();
        }

        private void UpdateJobForm_Load(object sender, EventArgs e)
        {
            try
            {
                var jobData = jobController.GetJobWithLoadsAndTransportUnitsByJobId(jobGridDto.JobID);
                if (jobData == null)
                {
                    MessageBox.Show($"Job with ID {jobGridDto.JobID} not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    windowClose();
                    return;
                }

                // Populate form fields
                lblFormTitle.Text = $"Update Job #{jobData.JobId}";
                txtCustomer.Text = jobData.CustomerId;
                rchTxtPickup.Text = jobData.PickupLocation;
                rchTxtDelivery.Text = jobData.DeliveryLocation;
                dtTmPckrScheduledDate.Value = jobData.ScheduledDate;
                txtEstimatedCost.Text = jobData.EstimatedCost?.ToString() ?? "";
                txtActualCost.Text = jobData.ActualCost?.ToString() ?? "";
                rchTxtDescription.Text = jobData.Description ?? "";
                cmbStatus.SelectedItem = jobData.statusEnum?.ToString() ?? "PENDING";

                // Populate loads
                loadList.Clear();
                foreach (var load in jobData.Loads)
                {
                    loadList.Add(load);
                }

                // Populate transport units
                transportUnitList.Clear();
                foreach (var tu in jobData.TransportUnits)
                {
                    transportUnitList.Add(tu);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in UpdateJobForm_Load: {ex.Message}");
                MessageBox.Show($"Error loading job data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                windowClose();
            }
        }
        private void HideAllErrorLabels()
        {
            foreach (var label in errorLabels.Values)
            {
                label.Text = "";
            }
        }

        private void clearLoadInputFields()
        {
            txtLoadDescription.Text = "";
            nmrcLoadVolume.Value = 0;
            nmrcLoadWeight.Value = 0;
        }

        private void clearTransportUnitInputFields()
        {
            txtTransportUnitId.Text = "";
        }
    }
}
