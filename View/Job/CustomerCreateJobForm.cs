using eshift.Controller;
using eshift.Controller.Impl;
using eshift.Dto;
using eshift.Utils;
using eshift.Utils.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eshift.View.Job
{
    public partial class CustomerCreateJobForm : Form
    {
        private readonly IJobController jobController = new JobControllerImpl();
        private BindingList<LoadDto> loadList = new();
        private Dictionary<string, Label> errorLabels = new();


        public CustomerCreateJobForm()
        {
            InitializeComponent();
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
            dtTmPckrScheduledDate.Format = DateTimePickerFormat.Short;
            HideAllErrorLabels();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                HideAllErrorLabels();

                // Get form values
                string pickup = rchTxtPickup.Text.Trim();
                string delivery = rchTxtDelivery.Text.Trim();
                DateTime scheduledDate = dtTmPckrScheduledDate.Value.Date;
                string estimatedCostStr = txtEstimatedCost.Text.Trim();
                string description = rchTxtDescription.Text.Trim();

                // validate the fields
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

                double estimatedCost = double.Parse(estimatedCostStr);

                // create the CreateJobFormDto
                var createJobFormDto = new CreateJobFormDto(
                    customerId: UserSession.DbId ?? 0,
                    pickup: pickup,
                    delivery: delivery,
                    description: string.IsNullOrEmpty(description) ? null : description,
                    scheduledDate: scheduledDate,
                    estimatedCost: estimatedCost,
                    loads: loadList.ToList(),
                    transportUnits: new List<TransportUnitDto>(), // tranport units will not be added by customer
                    status: Enums.JobStatusEnum.PENDING
                );

                jobController.CreateJob(createJobFormDto);
                MessageBox.Show("Job created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                windowClose();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating job: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error removing load: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding load: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearLoad_Click(object sender, EventArgs e)
        {
            loadList.Clear();
            UpdateEstimatedCost();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            windowClose();
        }

        private void HideAllErrorLabels()
        {
            foreach (var label in errorLabels.Values)
            {
                label.Text = "";
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

        private void windowClose()
        {
            this.Close();
        }
    }
}
