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
            ClientDetails details = new ClientDetails();
            details.Show();
            this.Close();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            HistoryCall call = new HistoryCall();
            call.Show();
            this.Close();
        }
    }
}
