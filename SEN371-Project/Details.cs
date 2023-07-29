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
    public partial class Details : Form
    {
        public Details()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            JobDetails details = new JobDetails(/*Get Info from database*/);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            optionScreen options = new optionScreen( );
            options.ShowDialog();
            this.Close();
        }
    }
}
