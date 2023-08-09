using SEN371_Project.Forms;
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
            string name = "Example text"; 
            string surname = "Example text"; 
            string phoneNumber = "Example text"; 
            string email = "Example text"; 
            string address = "Example text"; 
            string country = "Example text"; 
            string zipCode = "Example text";

            //Replace vars here with database stuff
            employeeDetails employeeInstance = new employeeDetails(name,surname,phoneNumber,email,address,country,zipCode);

            EmployeeDetailsForm Form = new EmployeeDetailsForm();
            this.Hide();
            Form.ShowDialog();
            this.Close();

        }

        private void btnPerformance_Click(object sender, EventArgs e)
        {
            string name = "Example text"; 
            string surname = "Example text"; 
            string jobDescription = "Example text"; 
            string endDate = "Example text";
            int performanceRating = 1;

            //Replace vars here with database stuff
            PerformanceRating performanceInstance = new PerformanceRating(name,surname,jobDescription,endDate,performanceRating);

            EmployeePerformanceForm Form = new EmployeePerformanceForm();
            this.Hide();
            Form.ShowDialog();
            this.Close();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            optionScreen Form = new optionScreen();
            this.Hide();
            Form.ShowDialog();
            this.Close();
        }
    }
}
