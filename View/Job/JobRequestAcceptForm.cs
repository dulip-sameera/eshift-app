﻿using System;
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
    public partial class JobRequestAcceptForm : Form
    {
        public JobRequestAcceptForm()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {

        }

        private void btnReject_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            windowClose();
        }

        private void windowClose()
        {
            this.Close();
        }

        private void JobRequestAcceptForm_Load(object sender, EventArgs e)
        {

        }
    }
}
