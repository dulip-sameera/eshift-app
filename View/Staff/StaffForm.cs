using System.Text.RegularExpressions;
using eshift.Controller;
using eshift.Controller.Impl;
using eshift.Dto;
using eshift.Enums;

namespace eshift.View.Staff
{
    public partial class StaffForm : Form
    {
        private readonly IStaffController staffController;

        public StaffForm()
        {
            InitializeComponent();
            staffController = new StaffControllerImpl();
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            try
            {
                List<StaffGridDto>? staffList = staffController.GetAllStaffForGrid();
                dgStaff.DataSource = staffList;
            }
            catch (KeyNotFoundException ex)
            {
                MessageBox.Show($"No staff found: {ex.Message}", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgStaff.DataSource = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading staff: {ex.Message}");
                MessageBox.Show($"An error occurred while loading staff: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreateStaff_Click(object sender, EventArgs e)
        {
            try
            {
                CreateStaffForm createStaffForm = new CreateStaffForm();
                createStaffForm.Show();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show($"Could not open the Create Staff form: {ex.Message}", "Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error opening Create Staff form: {ex.Message}");
                MessageBox.Show($"An unexpected error occurred while opening the Create Staff form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateStaff_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgStaff.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a staff member to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var selectedRow = dgStaff.SelectedRows[0];
                var staffGridDto = selectedRow.DataBoundItem as StaffGridDto;
                if (staffGridDto == null || string.IsNullOrWhiteSpace(staffGridDto.StaffId))
                {
                    MessageBox.Show("Selected row does not have a valid Staff ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                UpdateStaffForm updateStaffForm = new UpdateStaffForm(staffGridDto);
                updateStaffForm.Show();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error opening Update Staff form: {ex.Message}");
                MessageBox.Show($"An error occurred while opening the Update Staff form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgStaff.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a staff member to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var selectedRow = dgStaff.SelectedRows[0];
                var staffGridDto = selectedRow.DataBoundItem as StaffGridDto;
                if (staffGridDto == null || string.IsNullOrWhiteSpace(staffGridDto.StaffId))
                {
                    MessageBox.Show("Selected row does not have a valid Staff ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Confirm deletion
                var confirmResult = MessageBox.Show(
                    $"Are you sure you want to delete staff member {staffGridDto.Name} ({staffGridDto.StaffId})?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmResult != DialogResult.Yes)
                    return;

                staffController.DeleteStaffByStaffId(staffGridDto.StaffId, StaffStatusEnum.DELETED);
                MessageBox.Show($"Staff member {staffGridDto.Name} deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                Console.WriteLine($"Error deleting staff: {ex.Message}");
                MessageBox.Show($"An error occurred while deleting the staff member: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (!string.IsNullOrWhiteSpace(txtStaffSearch.Text))
                txtStaffSearch.Text = string.Empty;
            this.StaffForm_Load(sender, e);
        }

        private void btnStaffSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string staffId = txtStaffSearch.Text.Trim();
                var pattern = @"^STF\d{4}\d{5}$";
                if (string.IsNullOrWhiteSpace(staffId))
                {
                    MessageBox.Show("Please enter a Staff ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!Regex.IsMatch(staffId, pattern))
                {
                    MessageBox.Show("Staff ID must follow the pattern: STFYYYYNNNNN", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                StaffGridDto? staff = staffController.GetStaffForGridByStaffId(staffId);
                if (staff != null)
                {
                    dgStaff.DataSource = new List<StaffGridDto> { staff };
                }
                else
                {
                    MessageBox.Show($"No staff found with ID: {staffId}", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgStaff.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error searching staff: {ex.Message}");
                MessageBox.Show($"An error occurred while searching for the staff: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
