using System;
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
    public partial class Employess : Form
    {
        public Employess()
        {
            InitializeComponent();
        }

        private void btnEmpDetails_Click(object sender, EventArgs e)
        {
            employeeDetails employeeInstance = new employeeDetails(/*Here we will get the details form the database*/);
        }

        private void btnPerformance_Click(object sender, EventArgs e)
        {
            PerformanceRating performanceInstance = new PerformanceRating(/*Here we will get the details form the database*/);
        }
    }
}
