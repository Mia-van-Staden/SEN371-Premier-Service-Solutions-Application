using SEN371_Project.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SEN371_Project
{
    public partial class Progress : Form
    {
        private string gJobID, gEmployeeID, gClientID, gDetails;
        public Progress()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           /* string employeeName = "Example text"; 
            string employeeSurname = "Example text"; 
            string equipmentDetails = "Example text"; 
            string jobDescription = "Example text"; 
            string location = "Example text";
            int activeTime = 1;
            bool onTime = false;

            JobsProgresscs jobs = new JobsProgresscs(employeeName,employeeSurname,equipmentDetails,jobDescription,location,activeTime,onTime);*/
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Jobs Form = new Jobs();
            this.Hide();
            Form.ShowDialog();
            this.Close();
        }

        private void Progress_Load(object sender, EventArgs e)
        {
            string query = "SELECT * from JobsInProgress";
            DataTable dt = Database_handler.AdaptSelect(query);
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnHistory.Enabled = true;
            btnHistory.Visible = true;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                gJobID = row.Cells[1].Value.ToString();
                gEmployeeID = row.Cells[2].Value.ToString();
                gClientID = row.Cells[3].Value.ToString();
                gDetails = row.Cells[4].Value.ToString();

            }
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM JobsInProgress WHERE JobID=" + gJobID;
            MessageBox.Show("Attempting to end Job", "Successfull");
            //Send query to database handler
            Database_handler.Update(query);

            string query1 = "INSERT INTO JobHistory (OldJobID, EmployeeID, ClientID, JobDescription, EndDate)" +
                          "VALUES (" + gJobID + "," + gEmployeeID + "," + gClientID + ",'" + gDetails + "','" + DateTime.Now.ToString() + "')";

            //Send queries to database handler
            Database_handler.Insert(query1);
            Database_handler.Delete(query);

            //Refresh grid view
            string query2 = "SELECT * from JobsInProgress";
            DataTable dt = Database_handler.AdaptSelect(query2);
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
            }


        }
    }
}
