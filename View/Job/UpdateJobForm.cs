using eshift.Controller;
using eshift.Controller.Impl;
using eshift.Dto;

namespace eshift.View.Job
{
    public partial class UpdateJobForm : Form
    {
        private readonly IJobController jobController = new JobControllerImpl();
        private readonly JobGridDto jobGridDto;

        public UpdateJobForm(JobGridDto jobGridDto)
        {
            InitializeComponent();
            this.jobGridDto = jobGridDto;
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            windowClose();
        }

        private void btnAddLoad_Click(object sender, EventArgs e)
        {

        }

        private void btnRemoveLoad_Click(object sender, EventArgs e)
        {

        }

        private void btnClearLoad_Click(object sender, EventArgs e)
        {

        }

        private void btnAddTransportUnit_Click(object sender, EventArgs e)
        {

        }

        private void btnRemoveTransportUnit_Click(object sender, EventArgs e)
        {

        }

        private void btnClearTransportUnit_Click(object sender, EventArgs e)
        {

        }

        private void windowClose()
        {
            this.Close();
        }
    }
}
