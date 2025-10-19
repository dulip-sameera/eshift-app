using eshift.Controller;
using eshift.Controller.Impl;
using eshift.Dto;
using eshift.Enums;
using eshift.Utils.Validation;
using System.Text.RegularExpressions;

namespace eshift.View.Customer
{
    public partial class CreateCustomerForm : Form
    {
        private readonly ICustomerController customerController = new CustomerControllerImpl();

        // Dictionary to map error keys to error labels
        private Dictionary<string, Label> errorLabels = new();

        public CreateCustomerForm()
        {
            InitializeComponent();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                windowClose();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error closing the form: " + ex.Message);
                MessageBox.Show("Error closing the form. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                string address = rchTxtAddress.Text.Trim();
                string city = txtCity.Text.Trim();
                string zipCode = txtZipCode.Text.Trim();

                // Validate
                var errors = CustomerValidator.Validate(firstName, lastName, email, phone, address, city, zipCode);

                if (errors.Count > 0)
                {
                    ShowErrorMessages(errors);
                    return;
                }

                var statusDto = new CustomerStatusDto((int)CustomerStatusEnum.ACTIVE, "ACTIVE");
                // Pass null for cusId
                var customerDto = new CustomerDto(null,null, firstName, lastName, email, phone, address, city, zipCode, statusDto, null);

                string generatedCusId = customerController.CreateCustomer(customerDto);
                MessageBox.Show($"Customer created successfully. Customer ID: {generatedCusId}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                Console.WriteLine("Error creating customer: " + ex.Message);
                MessageBox.Show($"An error occurred while creating the customer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void windowClose()
        {
            this.Close();
        }
    }
}
