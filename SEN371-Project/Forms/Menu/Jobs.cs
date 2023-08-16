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
    public partial class Jobs : Form
    {
        public Jobs()
        {
            InitializeComponent();
        }

        private void btnProgress_Click(object sender, EventArgs e)
        {
            Progress Form = new Progress();
            this.Hide();
            Form.ShowDialog();
            this.Close();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            Details Form = new Details();
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

        private void btnLog_Click(object sender, EventArgs e)
        {
            LogJob Form = new LogJob();
            Form.ShowDialog();
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
