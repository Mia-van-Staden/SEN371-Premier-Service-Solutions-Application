﻿using SEN371_Project.Forms;
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

            //Get data from FORM
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


            //Get phone numbers from database tables.
            string ClientPhoneNum = GetClient.PhoneNum(ClientID.ToString());
            string EmployeePhoneNum = GetEmployee.PhoneNum(employeeID.ToString());


            if (!(EmployeePhoneNum.Equals("")) && !(ClientPhoneNum.Equals("")))
            {
                
                string query1 = "INSERT INTO JobDetails (JobID, EmployeeID, EquipmentDetails, JobDescription, Location, StartDate, EndDate, ExpectedTime, PossibleSlackTime, ClientID)" +
                               "VALUES (" + RandomJobID + "," + employeeID + ",'" + equipmentDetails + "','" + jobDescription + "','" + clientAddress + "','" + startTime + "','" + endDate + "'," + expectedTime + "," + SlackTime + "," + ClientID + ")";
                string query2 = "INSERT INTO JobsInProgress (JobID, EmployeeID, ClientID, Details)" +
                               "VALUES (" + RandomJobID + "," + employeeID + "," + ClientID + ",'" + jobDescription+"')";

                //Send queries to database handler
                Database_handler.Insert(query1);
                Database_handler.Insert(query2);

                //Request to send messages to client and employee


                API_handler.sendMessageClient(RandomJobID.ToString(), startTime, ClientPhoneNum);
                API_handler.sendMessageEmployee(RandomJobID.ToString(), ClientID.ToString(), startTime, EmployeePhoneNum);


                MessageBox.Show("Job was successfully added", "Successfull");

                var form = Application.OpenForms["Caller"];
                if (form != null)
                {
                    Caller Form = new Caller();
                    this.Hide();
                    Form.ShowDialog();
                    this.Close();
                }
                else
                {
                    Jobs Form = new Jobs();
                    this.Hide();
                    Form.ShowDialog();
                    this.Close();
                }
                

                
            }
            else {
                MessageBox.Show("Number is invalid", "Failed");
            }
            




        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            var form = Application.OpenForms["Caller"];
            if (form != null)
            {
                this.Hide();
                //this.Close();
            }
            else
            {
                this.Hide();
            }
        }

        private void LogJob_Load(object sender, EventArgs e)
        {

        }
    }
}

