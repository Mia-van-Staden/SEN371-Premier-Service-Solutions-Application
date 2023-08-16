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
/*            string clientName = "Example text";
            string clientSurname = "Example text";
            string jobDescription = "Example text";
            string employeeName = "Example text";
            string employeeSurname = "Example text";
            int clientPhoneNumber = 1;
            int performanceRating = 2;
            string location = "Example text";
            string endDate = "Example text";

            //Replace values here with database stuff
            HistoryJob history = new HistoryJob(clientName, clientSurname, jobDescription, employeeName, employeeSurname, clientPhoneNumber, performanceRating, location, endDate);*/
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Jobs Form = new Jobs();
            this.Hide();
            Form.ShowDialog();
            this.Close();
        }

        private void JobHistory_Load(object sender, EventArgs e)
        {
            string query = "SELECT * from JobHistory";
            DataTable dt = Database_handler.AdaptSelect(query);
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
            }
        }
    }
}
