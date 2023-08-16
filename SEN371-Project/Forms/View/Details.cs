using SEN371_Project.Util;
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
            /*string equipmentDetails = "Example text";
            string jobDescription = "Example text";
            string location = "Example text";
            string startDate = "Example text";
            string endDate = "Example text";
            int expectedTime = 1;
            int possibleSlack = 2;

            //Replace values here with database stuff
            JobDetails details = new JobDetails(equipmentDetails, jobDescription,location,startDate,endDate,expectedTime, possibleSlack);*/
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
            string query = "SELECT * from JobDetails";
            DataTable dt = Database_handler.AdaptSelect(query);
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
            }
        }
    }
}
