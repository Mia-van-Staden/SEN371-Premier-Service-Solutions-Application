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
using System.Data.Entity;
using SEN371_Project.Util;
using SEN371_Project.Forms.Insert;

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
            /*string name = "Example text";
            string surname = "Example text";
            string phoneNumber = "Example text";
            string emailAddress = "Example text";
            string address = "Example text";
            string country = "Example text";
            string zipCode = "Example text";

            //Replace vars here with database stuff
            DetailsClient client = new DetailsClient(name,surname,phoneNumber,emailAddress,address,country,zipCode);*/
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
            string query = "SELECT * from ClientDetails";
            DataTable dt = Database_handler.AdaptSelect(query);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(!textBox1.Text.Equals(""))
            {
                string query = "SELECT * from ClientDetails WHERE ClientNumber = " + textBox1.Text + "";
                DataTable dt = Database_handler.AdaptSelect(query);
                dataGridView1.DataSource = dt;
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            AddClient Form = new AddClient();
            this.Hide();
            Form.ShowDialog();
            this.Close();
        }
    }
}
