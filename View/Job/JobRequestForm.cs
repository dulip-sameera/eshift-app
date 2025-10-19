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
    public partial class JobRequestForm : Form
    {
        public JobRequestForm()
        {
            InitializeComponent();
        }

        private void btnJobRequestSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            JobRequestAcceptForm jobRequestAcceptForm = new JobRequestAcceptForm();
            jobRequestAcceptForm.Show();
        }

        private void btnReject_Click(object sender, EventArgs e)
        {

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

        }

        private void JobRequestForm_Load(object sender, EventArgs e)
        {

        }
    }
}
