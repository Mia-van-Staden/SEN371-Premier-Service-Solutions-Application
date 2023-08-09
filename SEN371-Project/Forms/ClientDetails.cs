using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace SEN371_Project
{
    public partial class ClientDetails : Form
    {
        public ClientDetails()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string name = "Example text";
            string surname = "Example text";
            string phoneNumber = "Example text";
            string emailAddress = "Example text";
            string address = "Example text";
            string country = "Example text";
            string zipCode = "Example text";

            //Replace vars here with database stuff
            DetailsClient client = new DetailsClient(name,surname,phoneNumber,emailAddress,address,country,zipCode);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Clients Form = new Clients();
            this.Hide();
            Form.ShowDialog();
            this.Close();
        }

        private void ClientDetails_Load(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection(@"data source=..\..\Database\Premier_SQLite_Final.db");
            conn.Open();
            string query = "SELECT * from ClientDetails";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);

            //Used to store data in gridview
            DataTable dt = new DataTable();

            //This will get the data from the database using the cmd and store it in our dt object
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }
    }
}
