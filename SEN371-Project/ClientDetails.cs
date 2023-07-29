using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            DetailsClient client = new DetailsClient(/*Here we will import data from the database*/);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            optionScreen options = new optionScreen( );
            options.Show();
            this.Close();
        }
    }
}
