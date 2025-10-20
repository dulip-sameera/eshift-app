using eshift.Controller;
using eshift.Controller.Impl;
using eshift.Dao;
using eshift.Dto;
using eshift.Utils;
using eshift.Utils.Validation;

namespace eshift.View.UserAccount
{
    public partial class CustomerAccountForm : Form
    {
        private readonly ICustomerController customerController = new CustomerControllerImpl();
        private Dictionary<string, Label> errorLabels = new();
        private CustomerDto customer;

        public CustomerAccountForm()
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

        private void btnUpdate_Click(object sender, EventArgs e)
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

                var updatedCustomer = new CustomerDto
                {
                    Id = customer.Id,
                    CusId = customer.CusId,
                    FirstName = firstName,
                    LastName = lastName,
                    Email = email,
                    Phone = phone,
                    Address = address,
                    City = city,
                    ZipCode = zipCode,
                    Status = customer.Status,
                    UserAccount = customer.UserAccount
                };

                customerController.UpdateCustomer(customer.CusId, updatedCustomer);
                MessageBox.Show("Customer updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating customer details: {ex.Message}");
                MessageBox.Show($"Error updating customer details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerDashboardForm customerDashboardForm = new CustomerDashboardForm();
            customerDashboardForm.FormClosed += (s, args) =>
            {
                this.Close();
                Application.Exit();
            };
            customerDashboardForm.Show();
        }

        private void CustomerAccountForm_Load(object sender, EventArgs e)
        {
            try
            {
                string cusId = UserSession.SpecialId;
                if (string.IsNullOrEmpty(cusId))
                {
                    Console.WriteLine("Error: Customer ID not found in session");
                    MessageBox.Show("Customer session not found. Please login again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var customer = customerController.GetCustomerByCusId(cusId);
                if (customer == null)
                {
                    Console.WriteLine($"Error: Customer not found for CusId: {cusId}");
                    MessageBox.Show("Customer details not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                this.customer = customer;


                txtFirstName.Text = customer.FirstName ?? "";
                txtLastName.Text = customer.LastName ?? "";
                txtEmail.Text = customer.Email ?? "";
                txtPhone.Text = customer.Phone ?? "";
                rchTxtAddress.Text = customer.Address ?? "";
                txtCity.Text = customer.City ?? "";
                txtZipCode.Text = customer.ZipCode ?? "";
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in CustomerAccountForm_Load: {ex.Message}");
                MessageBox.Show($"Error loading customer details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
