using System.Text.RegularExpressions;
using eshift.Controller;
using eshift.Controller.Impl;
using eshift.Enums;
using eshift.Dto;
using eshift.Utils.Validation;

namespace eshift.View
{
    public partial class CreateUserAccountForm : Form
    {
        private bool passwordFieldVisibility = false;
        private readonly ICustomerController customerController;
        private readonly IStaffController staffController;
        private readonly IUserController userController;
        private Dictionary<string, Label> errorLabels = new();

        public CreateUserAccountForm()
        {
            InitializeComponent();
            customerController = new CustomerControllerImpl();
            staffController = new StaffControllerImpl();
            userController = new UserControllerImpl();
            errorLabels = new Dictionary<string, Label>
            {
                { "username", lblUsernameErrorMessage },
                { "password", lblPasswordErrorMessage }
            };
            HideAllErrorLabels();
        }

        private void rdBtnCustomer_CheckedChanged(object sender, EventArgs e)
        {
            lblReferenceId.Text = "Customer ID";
        }

        private void rdBtnAdmin_CheckedChanged(object sender, EventArgs e)
        {
            lblReferenceId.Text = "Staff ID";
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            passwordFieldVisibility = !passwordFieldVisibility;
            if (passwordFieldVisibility)
            {
                txtVisiblePassword.Text = txtPassword.Text;
                btnShowPassword.Text = "Hide";
                txtPassword.Hide();
                txtVisiblePassword.Show();
            }
            else
            {
                txtPassword.Text = txtVisiblePassword.Text;
                btnShowPassword.Text = "Show";
                txtVisiblePassword.Hide();
                txtPassword.Show();
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            try
            {
                // Check which radio button is selected
                if (!rdBtnCustomer.Checked && !rdBtnAdmin.Checked)
                {
                    MessageBox.Show("Please select a role (Customer or Admin).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string referenceId = txtReferenceId.Text.Trim();
                if (string.IsNullOrWhiteSpace(referenceId))
                {
                    MessageBox.Show("Please enter a Reference ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate pattern and get record based on selected radio button
                if (rdBtnCustomer.Checked)
                {
                    var customerPattern = @"^CUS\d{9}$";
                    if (!Regex.IsMatch(referenceId, customerPattern))
                    {
                        MessageBox.Show("Please enter a valid Customer ID pattern: CUSXXXXXXXXX (where X are numeric digits).", "Invalid Pattern", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Get customer record
                    var customer = customerController.GetCustomerByCusId(referenceId);
                    if (customer == null)
                    {
                        MessageBox.Show("Customer not found with the provided Customer ID.", "Customer Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Check if customer is deleted
                    if (customer.Status.Id == (int)CustomerStatusEnum.DELETED)
                    {
                        MessageBox.Show("The customer record with this Customer ID is deleted and cannot be used.", "Customer Deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Check if customer already has a user account
                    if (customer.UserAccount != null)
                    {
                        MessageBox.Show("This customer already has an associated user account.", "User Account Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Set name fields
                    txtFirstName.Text = customer.FirstName;
                    txtLastName.Text = customer.LastName;
                }
                else if (rdBtnAdmin.Checked)
                {
                    var staffPattern = @"^STF\d{9}$";
                    if (!Regex.IsMatch(referenceId, staffPattern))
                    {
                        MessageBox.Show("Please enter a valid Staff ID pattern: STFXXXXXXXXX (where X are numeric digits).", "Invalid Pattern", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Get staff record
                    var staff = staffController.GetStaffByStaffId(referenceId);
                    if (staff == null)
                    {
                        MessageBox.Show("Admin/Staff not found with the provided Staff ID.", "Admin Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Check if staff is deleted
                    if (staff.Status == StaffStatusEnum.DELETED)
                    {
                        MessageBox.Show("The staff record with this Staff ID is deleted and cannot be used.", "Staff Deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // check if staff already has a user account
                    if (staff.UserAccount != null)
                    {
                        MessageBox.Show("This staff already has an associated user account.", "User Account Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Set name fields
                    txtFirstName.Text = staff.FirstName;
                    txtLastName.Text = staff.LastName;
                }

                MessageBox.Show("Reference ID validated successfully. Name fields have been populated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in btnAddUser_Click: {ex.Message}");
                MessageBox.Show($"An error occurred while validating the reference ID: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                // Check which radio button is selected
                if (!rdBtnCustomer.Checked && !rdBtnAdmin.Checked)
                {
                    MessageBox.Show("Please select a role (Customer or Admin).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Determine user role
                UserRoleEnum userRole = rdBtnCustomer.Checked ? UserRoleEnum.CUSTOMER : UserRoleEnum.ADMIN;

                // Extract username and password
                string username = txtUsername.Text.Trim();
                string password = passwordFieldVisibility ? txtVisiblePassword.Text.Trim() : txtPassword.Text.Trim();
                string referenceId = txtReferenceId.Text.Trim();

                // Validate username and password
                var errors = UserValidator.Validate(username, password);
                if (errors.Count > 0)
                {
                    ShowErrorMessages(errors);
                    return;
                }

                // Validate reference ID is provided
                if (string.IsNullOrWhiteSpace(referenceId))
                {
                    MessageBox.Show("Please provide a valid Reference ID by clicking 'Add User' button first.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Create UserCreateFromDto
                var userCreateDto = new UserCreateFromDto(username, password, userRole, referenceId);

                // Create user through controller
                bool success = userController.CreateUser(userCreateDto);
                if (success)
                {
                    MessageBox.Show("User account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    windowClose();
                }
                else
                {
                    MessageBox.Show("Failed to create user account. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in btnCreate_Click: {ex.Message}");
                MessageBox.Show($"An error occurred while creating the user account: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
