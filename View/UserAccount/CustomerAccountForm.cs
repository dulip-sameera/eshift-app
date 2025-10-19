namespace eshift.View.UserAccount
{
    public partial class CustomerAccountForm : Form
    {
        public CustomerAccountForm()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {

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
    }
}
