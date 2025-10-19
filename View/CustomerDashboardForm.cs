using eshift.Utils;
using eshift.View.Job;
using eshift.View.UserAccount;

namespace eshift.View
{
    public partial class CustomerDashboardForm : Form
    {
        public CustomerDashboardForm()
        {
            InitializeComponent();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerAccountForm customerAccountForm = new CustomerAccountForm();
            customerAccountForm.FormClosed += (s, args) =>
            {
                this.Close();
                Application.Exit();
            };
            customerAccountForm.Show();
        }

        private void btnJob_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerJobForm customerJobForm = new CustomerJobForm();
            customerJobForm.FormClosed += (s, args) =>
            {
                this.Close();
                Application.Exit();
            };
            customerJobForm.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            UserSession.Clear();
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.FormClosed += (s, args) =>
            {
                this.Close();
                Application.Exit();
            };
            mainForm.Show();
        }

        private void CustomerDashboardForm_Load(object sender, EventArgs e)
        {
            lblWelcomeMessage.Text = $"Welcome, {UserSession.FullName}!";
        }
    }
}
