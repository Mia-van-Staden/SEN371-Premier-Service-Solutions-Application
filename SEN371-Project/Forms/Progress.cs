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
    public partial class Progress : Form
    {
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
            dataGridView1.DataSource = dt;
        }
    }
}
