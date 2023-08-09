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
            int RandomID = rnd.Next(100, 1000);
            int employeeID = 321;
            int SlackTime = 1;
            int ClientID = 123;
            

            string clientName = txtName.Text;
            string clientSurname = txtSurname.Text;
            string equipmentDetails = txtEquipmentDetails.Text;
            string jobDescription = txtDescription.Text;
            string clientPhoneNumber = txtNumber.Text;
            string clientZipCode = txtZipCode.Text;
            int expectedTime = int.Parse(txtExpected.Text);
            string clientAddress = txtAdress.Text;
            string location = txtLocation.Text;
            string startTime = dtpStartDate.Value.ToString();
            string endDate = dtpEndDate.Value.ToString();




            // Create an instance of JobLog class with the user input
          //  JobLog job = new JobLog(clientName, clientSurname, equipmentDetails, jobDescription, clientPhoneNumber, clientZipCode, expectedTime, clientAddress, location, startTime, endDate);


            SQLiteConnection conn = new SQLiteConnection(@"data source=..\..\Database\Premier_SQLite_Final.db");
            conn.Open();

            // INSERT INTO _StudyInfo"+"(Param,Val)"+"Values('Name','" + snbox.Text + "')";//insert the studyinfo into Db
            string query = "INSERT INTO JobDetails (JobID, EmployeeID, EquipmentDetails, JobDescription, Location, StartDate, EndDate, ExpectedTime, PossibleSlackTime, ClientID)" +
                           "VALUES ("+RandomID+","+ employeeID+ ",'"+equipmentDetails+ "','"+jobDescription+ "','"+location+ "','"+startTime+ "','"+endDate+ "',"+expectedTime+ ","+ SlackTime + ","+ ClientID + ")";

            //Initialize the SqliteCommand
            var SqliteCmd = new SQLiteCommand();

            //Create the SqliteCommand
            SqliteCmd = conn.CreateCommand();

            //Assigning the query to CommandText
            SqliteCmd.CommandText = query;

            //Execute the SqliteCommand
            SqliteCmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Job was successfully added", "Successfull");

            Jobs Form = new Jobs();
            this.Hide();
            Form.ShowDialog();
            this.Close();


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
