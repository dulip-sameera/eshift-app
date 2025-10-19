using eshift.Controller;
using eshift.Controller.Impl;
using eshift.Dto;
using eshift.Enums;
using eshift.Utils.Validation;

namespace eshift.View.Staff
{
    public partial class CreateStaffForm : Form
    {
        private readonly IStaffController staffController = new StaffControllerImpl();

        // Dictionary to map error keys to error labels
        private Dictionary<string, Label> errorLabels = new();

        public CreateStaffForm()
        {
            InitializeComponent();
            errorLabels = new Dictionary<string, Label>
            {
                { "firstName", lblFirstNameErrorMessage },
                { "lastName", lblLastNameErrorMessage },
                { "email", lblEmailErrorMessage },
                { "phone", lblPhoneErrorMessage },
                { "licenseNumber", lblLicenseNumberErrorMessage },
                { "position", lblPositionErrorMessage }
            };
            HideAllErrorLabels();
            PopulatePositionCombo();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                // Get values from controls
                string firstName = txtFirstName.Text.Trim();
                string lastName = txtLastName.Text.Trim();
                string email = txtEmail.Text.Trim();
                string phone = txtPhone.Text.Trim();
                string? licenseNumber = txtLicenseNumber.Text.Trim();
                string position = cmbPosition.SelectedItem?.ToString() ?? string.Empty;

                // Validate
                var errors = StaffValidator.Validate(firstName, lastName, email, phone, licenseNumber, position);

                if (errors.Count > 0)
                {
                    ShowErrorMessages(errors);
                    return;
                }

                var typeDto = new StaffTypeDto((int)Enum.Parse<StaffTypeEnum>(position), position);
                var status = StaffStatusEnum.ACTIVE;
                var staffDto = new StaffDto(null,null, firstName, lastName, phone, email, licenseNumber, typeDto, null, status);

                string generatedStaffId = staffController.CreateStaff(staffDto);
                MessageBox.Show($"Staff member created successfully. Staff ID: {generatedStaffId}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                Console.WriteLine("Error creating staff: " + ex.Message);
                MessageBox.Show($"An error occurred while creating the staff member: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void PopulatePositionCombo()
        {
            cmbPosition.Items.Clear();
            foreach (var value in Enum.GetValues(typeof(StaffTypeEnum)))
            {
                cmbPosition.Items.Add(value.ToString());
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
