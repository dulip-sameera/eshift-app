using eshift.Controller;
using eshift.Controller.Impl;
using eshift.Dto;

namespace eshift.View.Vehicle
{
    public partial class VehicleForm : Form
    {
        private readonly IVehicleController vehicleController;
        public VehicleForm()
        {
            InitializeComponent();
            vehicleController = new VehilceConrollerImpl();
        }

        private void VehicleForm_Load(object sender, EventArgs e)
        {
            try
            {
                List<VehicleDto>? vehicleList = vehicleController.getAllVehicles();
                dgVehicle.DataSource = vehicleList;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading vehicles: {ex.Message}");
                MessageBox.Show($"An error occurred while loading vehicles: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnVehicleSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string regNo = txtVehicleSearch.Text.Trim();
                if (string.IsNullOrWhiteSpace(regNo))
                {
                    MessageBox.Show("Please enter a valid registration number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                VehicleDto? vehicle = vehicleController.getVehicleByRegNo(regNo);
                if (vehicle != null)
                {
                    dgVehicle.DataSource = new List<VehicleDto> { vehicle };
                }
                else
                {
                    MessageBox.Show($"No vehicle found with registration number: {regNo}", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgVehicle.DataSource = null; // Clear the DataGridView if no vehicle is found
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error searching vehicle: {ex.Message}");
                MessageBox.Show($"An error occurred while searching for the vehicle: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreateVehicle_Click(object sender, EventArgs e)
        {
            CreateVehicleForm createVehicleForm = new CreateVehicleForm();
            createVehicleForm.Show();
        }

        private void btnUpdateVehicle_Click(object sender, EventArgs e)
        {
            if (dgVehicle.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a vehicle to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var selectedRow = dgVehicle.SelectedRows[0];
            string? regNo = selectedRow.Cells["RegistrationNumber"].Value?.ToString();
            if (string.IsNullOrWhiteSpace(regNo))
            {
                MessageBox.Show("Selected row does not have a valid registration number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            UpdateVehicleForm updateVehicleForm = new UpdateVehicleForm(regNo);
            updateVehicleForm.Show();
        }

        private void btnDeleteVehicle_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgVehicle.SelectedRows.Count > 0)
                {
                    var selectedRow = dgVehicle.SelectedRows[0];
                    var regNo = selectedRow.Cells["RegistrationNumber"].Value?.ToString();

                    var confirmResult = MessageBox.Show(
                        $"Are you sure you want to delete Vehicle {regNo})?",
                        "Confirm Delete",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (confirmResult != DialogResult.Yes)
                        return;

                    if (!string.IsNullOrWhiteSpace(regNo))
                    {
                        vehicleController.deleteVehicleByRegNo(regNo);
                        MessageBox.Show($"Vehicle with registration number {regNo} deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnRefresh.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Selected row does not have a valid registration number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a vehicle to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting vehicle: {ex.Message}");
                MessageBox.Show($"An error occurred while deleting the vehicle: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.VehicleForm_Load(sender, e);
        }
    }
}
