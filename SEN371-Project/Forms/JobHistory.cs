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
    public partial class JobHistory : Form
    {
        public JobHistory()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string clientName = "Example text";
            string clientSurname = "Example text";
            string jobDescription = "Example text";
            string employeeName = "Example text";
            string employeeSurname = "Example text";
            int clientPhoneNumber = 1;
            int performanceRating = 2;
            string location = "Example text";
            string endDate = "Example text";

            //Replace values here with database stuff
            HistoryJob history = new HistoryJob(clientName, clientSurname, jobDescription, employeeName, employeeSurname, clientPhoneNumber, performanceRating, location, endDate);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            optionScreen option = new optionScreen( );
            option.ShowDialog();
            this.Close();
        }

        private void JobHistory_Load(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection(@"data source=..\..\Database\Premier_SQLite_Final.db");
            conn.Open();
            string query = "SELECT * from JobHistory";
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
