using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eshift.View.Job
{
    public partial class CustomerJobForm : Form
    {
        public CustomerJobForm()
        {
            InitializeComponent();
        }

        private void btnCreateJob_Click(object sender, EventArgs e)
        {
            CustomerCreateJobForm customerCreateJobForm = new CustomerCreateJobForm();
            customerCreateJobForm.Show();
        }

        private void btnUpdateJob_Click(object sender, EventArgs e)
        {
            CustomerJobUpdateForm customerJobUpdateForm = new CustomerJobUpdateForm();
            customerJobUpdateForm.Show();
        }

        private void btnDeleteJob_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
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

        private void btnJobSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
