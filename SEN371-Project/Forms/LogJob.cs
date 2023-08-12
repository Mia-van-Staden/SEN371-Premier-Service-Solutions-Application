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
using Twilio.Types;

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


            Random rnd = new Random();
            int RandomJobID = rnd.Next(100, 1000);
            int SlackTime = Int32.Parse(txtSlack.Text);
            
            int ClientID = Int32.Parse(txtClientID.Text);
            int employeeID = Int32.Parse(txtEmployeeID.Text);
            string equipmentDetails = txtEquipmentDetails.Text;
            string jobDescription = txtDescription.Text;
            int expectedTime = int.Parse(txtExpected.Text);
            string clientAddress = txtAdress.Text;
            string startTime = dtpStartDate.Value.ToString();
            string endDate = dtpEndDate.Value.ToString();


            string clientPhoneNum = GetClient.PhoneNum(ClientID.ToString());

            if (!clientPhoneNum.Equals(""))
            {

                SQLiteConnection conn = new SQLiteConnection(@"data source=..\..\Database\Premier_SQLite_Final.db");
                conn.Open();

                string query = "INSERT INTO JobDetails (JobID, EmployeeID, EquipmentDetails, JobDescription, Location, StartDate, EndDate, ExpectedTime, PossibleSlackTime, ClientID)" +
                               "VALUES (" + RandomJobID + "," + employeeID + ",'" + equipmentDetails + "','" + jobDescription + "','" + clientAddress + "','" + startTime + "','" + endDate + "'," + expectedTime + "," + SlackTime + "," + ClientID + ")";

                //Initialize the SqliteCommand
                var SqliteCmd = new SQLiteCommand();

                //Create the SqliteCommand
                SqliteCmd = conn.CreateCommand();

                //Assigning the query to CommandText
                SqliteCmd.CommandText = query;

                //Execute the SqliteCommand
                SqliteCmd.ExecuteNonQuery();
                conn.Close();

                API_handler.sendMessage(RandomJobID.ToString(), ClientID.ToString(), startTime, clientPhoneNum);
                MessageBox.Show("Job was successfully added", "Successfull");

                Jobs Form = new Jobs();
                this.Hide();
                Form.ShowDialog();
                this.Close();
            }
            




        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Jobs Form = new Jobs();
            this.Hide();
            Form.ShowDialog();
            this.Close();
        }
    }
}
