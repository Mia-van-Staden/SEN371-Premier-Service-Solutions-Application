﻿using SEN371_Project.Forms.Insert;
using SEN371_Project.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEN371_Project.Forms
{
    public partial class EmployeeDetailsForm : Form
    {
        public EmployeeDetailsForm()
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

        private void EmployeeDetailsForm_Load(object sender, EventArgs e)
        {
          
            string query = "SELECT * from EmployeeDetails";
            DataTable dt = Database_handler.AdaptSelect(query);
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(!textBox1.Text.Equals(""))
            {
                string query = "SELECT * from EmployeeDetails WHERE EmployeeNumber = " + textBox1.Text + "";
                DataTable dt = Database_handler.AdaptSelect(query);
                dataGridView1.DataSource = dt;
            }
            else if (textBox1.Text.Equals(""))
            {
                string query = "SELECT * from EmployeeDetails";
                DataTable dt = Database_handler.AdaptSelect(query);
                dataGridView1.DataSource = dt;
            }

        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployee Form = new AddEmployee();
            this.Hide();
            Form.ShowDialog();
            this.Close();
        }
    }
}
