﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEN371_Project
{
    public partial class optionScreen : Form
    {
        public optionScreen()
        {
            InitializeComponent();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            Employess employess = new Employess();
            employess.ShowDialog();
            this.Close();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            Clients clients = new Clients();
            clients.ShowDialog();
            this.Close();
        }

        private void btnJobs_Click(object sender, EventArgs e)
        {
            Jobs jobs = new Jobs();
            jobs.ShowDialog();
            this.Close();
        }
    }
}
