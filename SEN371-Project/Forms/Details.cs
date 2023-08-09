using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEN371_Project
{
    public partial class Details : Form
    {
        public Details()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string equipmentDetails = "Example text";
            string jobDescription = "Example text";
            string location = "Example text";
            string startDate = "Example text";
            string endDate = "Example text";
            int expectedTime = 1;
            int possibleSlack = 2;

            //Replace values here with database stuff
            JobDetails details = new JobDetails(equipmentDetails, jobDescription,location,startDate,endDate,expectedTime, possibleSlack);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Jobs Form = new Jobs();
            this.Hide();
            Form.ShowDialog();
            this.Close();
        }

        private void Details_Load(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection(@"data source=..\..\Database\Premier_SQLite_Final.db");
            conn.Open();
            string query = "SELECT * from JobDetails";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);

            //Used to store data in gridview
            DataTable dt = new DataTable();

            //This will get the data from the database using the cmd and store it in our dt object
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
            conn.Close();
        }
    }
}
