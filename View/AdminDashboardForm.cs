using eshift.Utils;
using eshift.View.Customer;
using eshift.View.Job;
using eshift.View.Report;
using eshift.View.Staff;
using eshift.View.TransportUnit;
using eshift.View.Vehicle;
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
    public partial class AdminDashboardForm : Form
    {
        public AdminDashboardForm()
        {
            InitializeComponent();
        }

        private void btnUserAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserAccountForm userAccountForm = new UserAccountForm();
            userAccountForm.FormClosed += (s, args) =>
            {
                this.Close();
                Application.Exit();
            };
            userAccountForm.Show();
        }

        private void btnJobRequest_Click(object sender, EventArgs e)
        {
            this.Hide();
            JobRequestForm jobRequestForm = new JobRequestForm();
            jobRequestForm.FormClosed += (s, args) =>
            {
                this.Close();
                Application.Exit();
            };
            jobRequestForm.Show();
        }

        private void btnJob_Click(object sender, EventArgs e)
        {
            this.Hide();
            JobForm jobForm = new JobForm();
            jobForm.FormClosed += (s, args) =>
            {
                this.Close();
                Application.Exit();
            };
            jobForm.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReportForm reportForm = new ReportForm();
            reportForm.FormClosed += (s, args) =>
            {
                this.Close();
                Application.Exit();
            };
            reportForm.Show();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerForm customerForm = new CustomerForm();
            customerForm.FormClosed += (s, args) =>
            {
                this.Close();
                Application.Exit();
            };
            customerForm.Show();
        }

        private void btnTransportUnit_Click(object sender, EventArgs e)
        {
            this.Hide();
            TransportUnitForm transportUnitForm = new TransportUnitForm();
            transportUnitForm.FormClosed += (s, args) =>
            {
                this.Close();
                Application.Exit();
            };
            transportUnitForm.Show();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaffForm staffForm = new StaffForm();
            staffForm.FormClosed += (s, args) =>
            {
                this.Close();
                Application.Exit();
            };
            staffForm.Show();
        }

        private void btnVehicle_Click(object sender, EventArgs e)
        {
            this.Hide();
            VehicleForm vehicleForm = new VehicleForm();
            vehicleForm.FormClosed += (s, args) =>
            {
                this.Close();
                Application.Exit();
            };
            vehicleForm.Show();
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

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            lblWelcomeMessage.Text = $"Welcome, {UserSession.FullName}!";
        }
    }
}
