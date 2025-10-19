using System.Text.RegularExpressions;
using eshift.Controller;
using eshift.Controller.Impl;
using eshift.Dto;

namespace eshift.View.Customer
{
    public partial class CustomerForm : Form
    {
        private readonly ICustomerController customerController;

        public CustomerForm()
        {
            InitializeComponent();
            customerController = new CustomerControllerImpl();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            try
            {
                List<CustomerGridDto>? customerList = customerController.GetAllCustomersForGrid();
                dgCustomer.DataSource = customerList;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading customers: {ex.Message}");
                MessageBox.Show($"An error occurred while loading customers: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreateCustomer_Click(object sender, EventArgs e)
        {
            CreateCustomerForm createCustomerForm = new CreateCustomerForm();
            createCustomerForm.Show();
        }

        private void btnCustomerSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string cusId = txtCustomerSearch.Text.Trim();
                var pattern = @"^CUS\d{4}\d{5}$";
                if (string.IsNullOrWhiteSpace(cusId))
                {
                    MessageBox.Show("Please enter a Customer ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!Regex.IsMatch(cusId, pattern))
                {
                    MessageBox.Show("Customer ID must follow the pattern: CUSYYYY#####", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                CustomerGridDto? customer = customerController.GetCustomerForGridByCusId(cusId);
                if (customer != null)
                {
                    dgCustomer.DataSource = new List<CustomerGridDto> { customer };
                }
                else
                {
                    MessageBox.Show($"No customer found with ID: {cusId}", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgCustomer.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error searching customer: {ex.Message}");
                MessageBox.Show($"An error occurred while searching for the customer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (dgCustomer.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a customer to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var selectedRow = dgCustomer.SelectedRows[0];
            var customerGridDto = selectedRow.DataBoundItem as CustomerGridDto;
            if (customerGridDto == null)
            {
                MessageBox.Show("Selected row does not have a valid customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            UpdateCustomerForm updateCustomerForm = new UpdateCustomerForm(customerGridDto);
            updateCustomerForm.Show();
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgCustomer.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a customer to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var selectedRow = dgCustomer.SelectedRows[0];
                string? cusId = selectedRow.Cells["CusId"].Value?.ToString();
                if (string.IsNullOrWhiteSpace(cusId))
                {
                    MessageBox.Show("Selected row does not have a valid Customer ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                customerController.DeleteCustomerByCusId(cusId);
                MessageBox.Show($"Customer with ID {cusId} deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnRefresh.PerformClick();
            }
            catch (KeyNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting customer: {ex.Message}");
                MessageBox.Show($"An error occurred while deleting the customer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            CustomerForm_Load(sender, e);
        }
    }
}
