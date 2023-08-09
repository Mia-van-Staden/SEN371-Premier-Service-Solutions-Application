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

namespace SEN371_Project.Forms
{
    public partial class EmployeeDetailsForm : Form
    {
        public EmployeeDetailsForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Employess Form = new Employess();
            this.Hide();
            Form.ShowDialog();
            this.Close();

        }

        private void EmployeeDetailsForm_Load(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection(@"data source=..\..\Database\Premier_SQLite_Final.db");
            conn.Open();
            string query = "SELECT * from EmployeeDetails";
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
