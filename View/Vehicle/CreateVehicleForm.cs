using eshift.Dto;
using eshift.Controller;
using eshift.Controller.Impl;
using eshift.Utils.Validation;

namespace eshift.View.Vehicle
{
    public partial class CreateVehicleForm : Form
    {
        private readonly IVehicleController vehicleController = new VehilceConrollerImpl();

        // Dictionary to map error keys to error labels
        private Dictionary<string, Label> errorLabels = new();

        public CreateVehicleForm()
        {
            InitializeComponent();
            // Map error keys to error labels
            errorLabels = new Dictionary<string, Label>
            {
                { "brand", lblBrandErrorMessage },
                { "model", lblModelErrorMessage },
                { "registrationNumber", lblRegNoErrorMessage },
                { "containerVolume", lblContainerVolumeErrorMessage },
                { "maxWeight", lblMaxWeightErrorMessage }
            };
            HideAllErrorLabels();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                // Get values from controls
                string brand = txtBrand.Text.Trim();
                string model = txtModel.Text.Trim();
                string regNo = txtRegNo.Text.Trim();
                double? containerVolume = (double?)nmrcContainerVolume.Value;
                double? maxWeight = (double?)nmrcMaxWeight.Value;

                // Validate
                var errors = VehicleValidator.Validate(brand, model, regNo, containerVolume, maxWeight);

                if (errors.Count > 0)
                {
                    ShowErrorMessages(errors);
                    return;
                }

                // Create DTO
                var vehicleDto = new VehicleDto(brand, model, regNo, containerVolume.Value, maxWeight.Value);

                // Attempt to create (now throws exceptions)
                vehicleController.createVehicle(vehicleDto);
                MessageBox.Show("Vehicle created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                windowClose();
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
                Console.WriteLine($"Error creating vehicle: {ex.Message}");
                MessageBox.Show($"An error occurred while creating the vehicle: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
