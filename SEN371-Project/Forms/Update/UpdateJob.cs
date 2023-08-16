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

namespace SEN371_Project.Forms.Update
{
    public partial class UpdateJob : Form
    {
        private int jobID;
        public UpdateJob()
        {
            InitializeComponent();
        }

        private void UpdateJob_Load(object sender, EventArgs e)
        {
            jobID = Caller.gJobID;
            string[] arr = Database_handler.GetJob(jobID.ToString());


            if (arr[0] != "" && arr != null)
            {
                txtClientID.Text = arr[0];
                txtEmployeeID.Text = arr[1];
                txtAdress.Text = arr[2];
                txtEquipmentDetails.Text = arr[3];
                dtpStartDate.Text = arr[4];
                dtpEndDate.Text = arr[5];
                txtExpected.Text = arr[6];
                txtSlack.Text = arr[7];
                txtDescription.Text = arr[8];
            }
            else
            {
                MessageBox.Show(string.Format("Invalid JobID: {0}", jobID), "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Hide();
                this.Close();
            }


        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int SlackTime = Int32.Parse(txtSlack.Text);
            int ClientID = Int32.Parse(txtClientID.Text);
            int employeeID = Int32.Parse(txtEmployeeID.Text);
            string equipmentDetails = txtEquipmentDetails.Text;
            string jobDescription = txtDescription.Text;
            int expectedTime = int.Parse(txtExpected.Text);
            string clientAddress = txtAdress.Text;
            string startTime = dtpStartDate.Value.ToString();
            string endDate = dtpEndDate.Value.ToString();

            string query = "UPDATE JobDetails SET EmployeeID="+employeeID+", EquipmentDetails='"+equipmentDetails+"', JobDescription='"+jobDescription+"', Location='"+clientAddress+"', StartDate='"+startTime+"', EndDate='"+endDate+"', ExpectedTime="+expectedTime+", PossibleSlackTime="+SlackTime+", ClientID="+ClientID+ " WHERE JobID="+jobID;
            MessageBox.Show("Job merge was successfully added", "Successfull");


            //Send query to database handler
            Database_handler.Update(query);

            this.Hide();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
}
