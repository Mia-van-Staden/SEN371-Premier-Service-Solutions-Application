﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEN371_Project.Forms
{
    public partial class EmployeePerformanceForm : Form
    {
        public EmployeePerformanceForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Employess Form = new Employess();
            this.Hide();
            Form.ShowDialog();
            this.Close();
        }
    }
}