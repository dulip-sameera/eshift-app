using eshift.Dto;
using eshift.Controller;
using eshift.Controller.Impl;
using eshift.Enums;
using eshift.Utils.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eshift.View
{
    public partial class UpdateUserAccountForm : Form
    {
        private bool passwordFieldVisibility = false;
        private UserGridDto updatingUser;
        private readonly IUserController userController;
        private Dictionary<string, Label> errorLabels = new();

        public UpdateUserAccountForm(UserGridDto updatingUser)
        {
            InitializeComponent();
            this.updatingUser = updatingUser;
            userController = new UserControllerImpl();
            errorLabels = new Dictionary<string, Label>
            {
                { "username", lblUsernameErrorMessage },
                { "password", lblPasswordErrorMessage }
            };
            HideAllErrorLabels();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Extract username and password
                string username = txtUsername.Text.Trim();
                string password = passwordFieldVisibility ? txtVisiblePassword.Text.Trim() : txtPassword.Text.Trim();
                
                // Set password to null if empty (no password change)
                string? passwordToUpdate = string.IsNullOrWhiteSpace(password) ? null : password;

                // Validate username and password
                var errors = UserValidator.ValidateForUpdate(username, password);
                if (errors.Count > 0)
                {
                    ShowErrorMessages(errors);
                    return;
                }

                // Determine user role
                UserRoleEnum userRole = updatingUser.Role == "CUSTOMER" ? UserRoleEnum.CUSTOMER : UserRoleEnum.ADMIN;

                // Create UserUpdateFormDto
                var userUpdateDto = new UserUpdateFormDto(
                    updatingUser.Username, // old username
                    username, // new username
                    passwordToUpdate,
                    userRole,
                    updatingUser.Id // reference ID
                );

                // Update user through controller
                bool success = userController.UpdateUser(userUpdateDto);
                if (success)
                {
                    MessageBox.Show("User account updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    windowClose();
                }
                else
                {
                    MessageBox.Show("Failed to update user account. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in btnUpdate_Click: {ex.Message}");
                MessageBox.Show($"An error occurred while updating the user account: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void UpdateUserAccountForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Set role
                txtRole.Text = updatingUser.Role;

                // Set reference ID
                txtReferenceId.Text = updatingUser.Id;

                // Split FullName and assign to first and last name
                if (!string.IsNullOrWhiteSpace(updatingUser.FullName))
                {
                    string[] nameParts = updatingUser.FullName.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    if (nameParts.Length >= 1)
                    {
                        txtFirstName.Text = nameParts[0];
                    }
                    if (nameParts.Length >= 2)
                    {
                        txtLastName.Text = nameParts[1];
                    }
                }

                // Set username
                txtUsername.Text = updatingUser.Username;

                txtUsername.Focus();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in UpdateUserAccountForm_Load: {ex.Message}");
                MessageBox.Show($"An error occurred while loading user account data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
