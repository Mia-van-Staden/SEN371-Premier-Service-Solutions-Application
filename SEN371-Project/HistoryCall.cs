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
    public partial class HistoryCall : Form
    {
        public HistoryCall()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CallHistory history = new CallHistory(/*Here we will inport form the Database*/);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            optionScreen option = new optionScreen();
            option.ShowDialog();
            this.Close();
        }
    }
}
