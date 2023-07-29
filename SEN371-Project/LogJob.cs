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
    public partial class LogJob : Form
    {
        public LogJob()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string clientName = txtName.Text;
            string clientSurname = txtSurname.Text;
            int clientPhoneNumber = int.Parse(txtNumber.Text);
            string clientAddress = txtAdress.Text;
            int clientZipCode = int.Parse(txtZipCode.Text);
            string equipmentDetails = txtEquipmentDetails.Text;
            DateTime startTime = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;
            int expectedTime = int.Parse(txtExpected.Text);
            string location = txtLocation.Text;
            string jobDescription = txtDescription.Text;

            // Create an instance of JobLog class with the user input
            JobLog job = new JobLog
            {
                /*Add into Dtaabase here*/
            };
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            optionScreen option = new optionScreen();
            option.ShowDialog();
            this.Close();
        }
    }
}
