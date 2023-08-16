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
    public partial class HistoryCall : Form
    {
        public HistoryCall()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*string clientName = "Example text";
            string clientSurname = "Example text";
            int clientPhoneNumber = 1;
            string location = "Example text";
            string jobDescription = "Example text";


            //Replace values with database stuff
            CallHistory history = new CallHistory(clientName, clientSurname, clientPhoneNumber, location, jobDescription);*/
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Clients Form = new Clients();
            this.Hide();
            Form.ShowDialog();
            this.Close();
        }

        private void HistoryCall_Load(object sender, EventArgs e)
        {
            string query = "SELECT * from CallLogDetails";
            DataTable dt = Database_handler.AdaptSelect(query);
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
            }
        }
    }
}
