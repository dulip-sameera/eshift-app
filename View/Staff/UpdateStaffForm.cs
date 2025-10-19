using eshift.Controller;
using eshift.Controller.Impl;
using eshift.Dto;
using eshift.Enums;
using eshift.Utils.Validation;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace eshift.View.Staff
{
    public partial class UpdateStaffForm : Form
    {
        private readonly IStaffController staffController = new StaffControllerImpl();
        private readonly StaffGridDto staffGridDto;
        private Dictionary<string, Label> errorLabels = new();

        public UpdateStaffForm(StaffGridDto staffGridDto)
        {
            InitializeComponent();
            this.staffGridDto = staffGridDto;
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
        }

        private string GetFirstName(string name)
        {
            var parts = name.Split(' ');
            return parts.Length > 0 ? parts[0] : "";
        }

        private string GetLastName(string name)
        {
            var parts = name.Split(' ');
            return parts.Length > 1 ? string.Join(" ", parts, 1, parts.Length - 1) : "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string firstName = txtFirstName.Text.Trim();
                string lastName = txtLastName.Text.Trim();
                string email = txtEmail.Text.Trim();
                string phone = txtPhone.Text.Trim();
                string? licenseNumber = txtLicenseNumber.Text.Trim();
                string position = cmbPosition.SelectedItem?.ToString() ?? string.Empty;

                var errors = StaffValidator.Validate(firstName, lastName, email, phone, licenseNumber, position);

                if (errors.Count > 0)
                {
                    ShowErrorMessages(errors);
                    return;
                }

                StaffStatusEnum selectedStatus;
                if (cmbStatus.SelectedItem == null || !Enum.TryParse<StaffStatusEnum>(cmbStatus.SelectedItem.ToString(), out selectedStatus))
                {
                    MessageBox.Show("Please select a valid status.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var typeDto = new StaffTypeDto((int)Enum.Parse<StaffTypeEnum>(position), position);
                var staffDto = new StaffDto(
                    null, // Id not updated
                    staffGridDto.StaffId, // StaffId not updated
                    firstName,
                    lastName,
                    phone,
                    email,
                    licenseNumber,
                    typeDto,
                    staffGridDto.Username == null ? null : staffGridDto.Username.GetHashCode(), // UserAccount not updated, placeholder if needed
                    selectedStatus
                );

                staffController.UpdateStaff(staffGridDto.StaffId, staffDto);
                MessageBox.Show("Staff member updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                Console.WriteLine("Error updating staff: " + ex.Message);
                MessageBox.Show($"An error occurred while updating the staff member: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void UpdateStaffForm_Load(object sender, EventArgs e)
        {
            lblFormTitle.Text = $"Update Form # {staffGridDto.StaffId}";
            txtFirstName.Text = GetFirstName(staffGridDto.Name);
            txtLastName.Text = GetLastName(staffGridDto.Name);
            txtEmail.Text = staffGridDto.Email;
            txtPhone.Text = staffGridDto.Phone;
            txtLicenseNumber.Text = staffGridDto.LicenseNumber ?? string.Empty;

            cmbPosition.Items.Clear();
            foreach (var value in Enum.GetValues(typeof(StaffTypeEnum)))
            {
                cmbPosition.Items.Add(value.ToString());
            }
            cmbPosition.SelectedItem = staffGridDto.Position;

            cmbStatus.Items.Clear();
            foreach (StaffStatusEnum status in Enum.GetValues(typeof(StaffStatusEnum)))
            {
                cmbStatus.Items.Add(status.ToString());
            }
            cmbStatus.SelectedItem = staffGridDto.Status;
        }
    }
}
