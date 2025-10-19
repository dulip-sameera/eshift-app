using eshift.Controller;
using eshift.Controller.Impl;
using eshift.Dto;
using eshift.Utils.Validation;

namespace eshift.View.Vehicle
{
    public partial class UpdateVehicleForm : Form
    {
        private readonly IVehicleController vehicleController;
        private readonly string vehicleRegNo;
        private VehicleDto? vehicleDto;

        // Dictionary to map error keys to error labels
        private Dictionary<string, Label> errorLabels = new();

        public UpdateVehicleForm(string regno)
        {
            InitializeComponent();
            this.vehicleRegNo = regno;
            vehicleController = new VehilceConrollerImpl();
        }

        private void UpdateVehicleForm_Load(object sender, EventArgs e)
        {
            // Map error keys to error labels
            errorLabels = new Dictionary<string, Label>
            {
                { "brand", lblBrandErrorMessage },
                { "model", lblModelErrorMessage },
                { "registrationNumber", lblRegNoErrorMessage },
                { "containerVolume", lblContainerVolumeErrorMessage },
                { "maxWeight", lblMaxWeightErrorMessage }
            };

            // Hide all error labels initially
            HideAllErrorLabels();

            try
            {
                if (string.IsNullOrWhiteSpace(vehicleRegNo))
                {
                    MessageBox.Show("Registration number cannot be null or empty.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    windowClose();
                }
                this.vehicleDto = vehicleController.getVehicleByRegNo(vehicleRegNo);
                if (vehicleDto != null)
                {
                    txtBrand.Text = vehicleDto.Brand;
                    txtModel.Text = vehicleDto.Model;
                    txtRegNo.Text = vehicleDto.RegistrationNumber;
                    nmrcContainerVolume.Text = vehicleDto.ContainerVolume.ToString();
                    nmrcMaxWeight.Text = vehicleDto.MaxWeight.ToString();
                }
                else
                {
                    MessageBox.Show($"No vehicle found with registration number: {vehicleRegNo}", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    windowClose();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading vehicle details: {ex.Message}");
                MessageBox.Show($"An error occurred while loading vehicle details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HideAllErrorLabels()
        {
            foreach (var label in errorLabels.Values)
            {
                label.Visible = false;
                label.Text = string.Empty;
            }
        }


        private void ShowErrorMessages(Dictionary<string, string> errors)
        {
            HideAllErrorLabels();
            foreach (var kvp in errors)
            {
                if (errorLabels.TryGetValue(kvp.Key, out var label))
                {
                    label.Text = kvp.Value;
                    label.Visible = true;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var errors = VehicleValidator.Validate(
                    txtBrand.Text.Trim(),
                    txtModel.Text.Trim(),
                    txtRegNo.Text.Trim(),
                    (double?)nmrcContainerVolume.Value,
                    (double?)nmrcMaxWeight.Value);

                if (errors.Count > 0)
                {
                    ShowErrorMessages(errors);
                    return;
                }

                if (this.vehicleDto == null)
                {
                    MessageBox.Show("Vehicle details not loaded. Cannot update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                this.vehicleDto.RegistrationNumber = txtRegNo.Text.Trim();
                this.vehicleDto.Brand = txtBrand.Text.Trim();
                this.vehicleDto.Model = txtModel.Text.Trim();
                this.vehicleDto.ContainerVolume = (double)nmrcContainerVolume.Value;
                this.vehicleDto.MaxWeight = (double)nmrcMaxWeight.Value;

                vehicleController.updateVehicle(this.vehicleRegNo, this.vehicleDto);
                MessageBox.Show("Vehicle updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnCancel.PerformClick();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (KeyNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating vehicle: {ex.Message}");
                MessageBox.Show($"An error occurred while updating the vehicle: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
