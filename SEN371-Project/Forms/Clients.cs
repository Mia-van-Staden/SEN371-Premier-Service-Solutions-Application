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
    public partial class Clients : Form
    {
        public Clients()
        {
            InitializeComponent();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            ClientDetails Form = new ClientDetails();
            this.Hide();
            Form.ShowDialog();
            this.Close();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            HistoryCall Form = new HistoryCall();
            this.Hide();
            Form.ShowDialog();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            optionScreen Form = new optionScreen();
            this.Hide();
            Form.ShowDialog();
            this.Close();
        }
    }
}
