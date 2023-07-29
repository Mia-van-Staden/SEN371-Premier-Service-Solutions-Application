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
            Progress progress = new Progress();
            progress.ShowDialog();
            this.Close();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            Details details = new Details();
            details.ShowDialog();
            this.Close();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            HistoryCall historyCall = new HistoryCall();
            historyCall.ShowDialog();
            this.Close();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            LogJob logJob = new LogJob();
            logJob.ShowDialog();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            optionScreen option = new optionScreen();
            option.ShowDialog();
            this.Close();
        }
    }
}
