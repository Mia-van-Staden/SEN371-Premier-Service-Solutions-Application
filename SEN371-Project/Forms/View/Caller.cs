using SEN371_Project.Forms.Update;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEN371_Project.Forms
{
    public partial class Caller : Form
    {
        public static int gJobID { get; set; }
        public Caller()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Employess Form = new Employess();
            this.Hide();
            Form.ShowDialog();
            this.Close();
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Visible)
            { 
                pictureBox1.Visible = false;
                pictureBox1.Enabled = false;
                pictureBox2.Visible = true;
                pictureBox2.Enabled = true;
                lblStatus.Location = new Point(98, 61);
                lblStatus.Text = "Talking To Client";
                lblStatus.ForeColor = Color.Green;
                btnLog.Enabled = true;
                btnLog.Visible = true;
                btnMerge.Enabled = true;
                btnMerge.Visible = true;
                btnClose.Enabled = false;
                btnClose.Visible = false;
            }
          
        }



        private void btnLog_Click(object sender, EventArgs e)
        {
            LogJob Form = new LogJob();
            Form.ShowDialog();
        }


        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            if (pictureBox2.Visible)
            {
                pictureBox1.Visible = true;
                pictureBox1.Enabled = true;
                pictureBox2.Visible = false;
                pictureBox2.Enabled = false;
                lblStatus.Location = new Point(29, 57);
                lblStatus.Text = "Awaiting Incomming Calls";
                lblStatus.ForeColor = Color.Gray;
                btnLog.Enabled = false;
                btnLog.Visible = false;
                btnMerge.Enabled = false;
                btnMerge.Visible = false;
                btnClose.Enabled = true;
                btnClose.Visible = true;


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gJobID = Int32.Parse(Microsoft.VisualBasic.Interaction.InputBox("Please Provide a JobID   ","Merge Jobs","",0,0));
            UpdateJob Form = new UpdateJob();
            Form.ShowDialog();
        }

        private void Caller_Load(object sender, EventArgs e)
        {

        }
    }
}
