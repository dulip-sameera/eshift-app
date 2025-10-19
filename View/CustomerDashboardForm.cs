using eshift.View.Job;
using eshift.View.UserAccount;
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
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.FormClosed += (s, args) =>
            {
                this.Close();
                Application.Exit();
            };
            mainForm.Show();
        }
    }
}
