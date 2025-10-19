using eshift.Controller;
using eshift.Controller.Impl;
using eshift.Dto;
using eshift.Utils.Validation;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using eshift.Enums;

namespace eshift.View.Customer
{
    public partial class UpdateCustomerForm : Form
    {
        private readonly ICustomerController customerController = new CustomerControllerImpl();
        private readonly CustomerGridDto customerGridDto;
        private Dictionary<string, Label> errorLabels = new();

        public UpdateCustomerForm(CustomerGridDto customerGridDto)
        {
            InitializeComponent();
            this.customerGridDto = customerGridDto;
            errorLabels = new Dictionary<string, Label>
            {
                { "firstName", lblFirstNameErrorMessage },
                { "lastName", lblLastNameErrorMessage },
                { "email", lblEmailErrorMessage },
                { "phone", lblPhoneErrorMessage },
                { "city", lblCityErrorMessage },
                { "zipCode", lblZipCodeErrorMessage }
            };
            HideAllErrorLabels();
        }

        private void UpdateCustomerForm_Load(object sender, EventArgs e)
        {
            lblFormTitle.Text = $"Update Customer {customerGridDto.CusId}";
            txtFirstName.Text = GetFirstName(customerGridDto.Name);
            txtLastName.Text = GetLastName(customerGridDto.Name);
            txtEmail.Text = customerGridDto.Email;
            txtPhone.Text = customerGridDto.Phone;
            tchTxtAddress.Text = customerGridDto.Address;
            txtCity.Text = customerGridDto.City;
            txtZipCode.Text = customerGridDto.ZipCode;

            // Populate status combo box with enum values
            cmbStatus.Items.Clear();
            foreach (CustomerStatusEnum status in Enum.GetValues(typeof(CustomerStatusEnum)))
            {
                cmbStatus.Items.Add(status.ToString());
            }
            // Set current status
            cmbStatus.SelectedItem = customerGridDto.Status;
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
                string address = tchTxtAddress.Text.Trim();
                string city = txtCity.Text.Trim();
                string zipCode = txtZipCode.Text.Trim();

                var errors = CustomerValidator.Validate(firstName, lastName, email, phone, address, city, zipCode);

                if (errors.Count > 0)
                {
                    ShowErrorMessages(errors);
                    return;
                }

                // Get status from combo box
                CustomerStatusEnum selectedStatus;
                if (cmbStatus.SelectedItem == null || !Enum.TryParse<CustomerStatusEnum>(cmbStatus.SelectedItem.ToString(), out selectedStatus))
                {
                    MessageBox.Show("Please select a valid status.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var statusDto = new CustomerStatusDto((int)selectedStatus, selectedStatus.ToString());

                var customerDto = new CustomerDto(
                    null,
                    customerGridDto.CusId, // CusId cannot be changed
                    firstName,
                    lastName,
                    email,
                    phone,
                    address,
                    city,
                    zipCode,
                    statusDto,
                    null
                );

                customerController.UpdateCustomer(customerGridDto.CusId, customerDto);
                MessageBox.Show("Customer updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                Console.WriteLine("Error updating customer: " + ex.Message);
                MessageBox.Show($"An error occurred while updating the customer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
