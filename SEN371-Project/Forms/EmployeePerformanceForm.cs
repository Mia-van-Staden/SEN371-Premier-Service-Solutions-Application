using SEN371_Project.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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

        private void EmployeePerformanceForm_Load(object sender, EventArgs e)
        {
            solidGauge1.From = 0;
            solidGauge1.To = 10;
        /*    solidGauge1.Value = 5; */
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            String checkID = textBox1.Text;
            String[] Result = Database_handler.Select(checkID);

            if (!Result[0].Equals(""))
            {
                solidGauge1.Value = Double.Parse(Result[3]);
                lblNameSurname.Text = string.Format("{0} {1}", Result[1], Result[2]);
                lblJob.Text = Result[4];
            }
            else 
            { 
                solidGauge1.Value = 0;
                lblNameSurname.Text = "";
                lblJob.Text = "";
            }

        }
    }
}
