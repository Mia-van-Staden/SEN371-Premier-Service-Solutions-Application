using SEN371_Project.Forms.Update;
using SEN371_Project.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twilio;

namespace SEN371_Project.Forms
{
    public partial class Caller : Form
    {
        private int seconds;
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
                seconds = 0;
                timer1.Enabled = true;
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
                timer1.Enabled = false;
                lblTime.Text = "";
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

                //Ask what call what about
                

                bool repeatAsk = true;

                while (repeatAsk)
                {
                    string clientID = Microsoft.VisualBasic.Interaction.InputBox("Please provide clientID?", "ClientID", "");
                    string[] result = Database_handler.GetClient(clientID);
                    if (result[1] != "")
                    {
                        string Description = Microsoft.VisualBasic.Interaction.InputBox("What was this call about?", "Description", "");
                        repeatAsk = false;
                        string Name = result[1];
                        string Surname = result[2];
                        string PhoneNum = result[3];
                        string Location = result[5];

                        string query = "INSERT INTO CallLogDetails (ClientNumber, ClientName, ClientSurname, ClientPhoneNumber, Location, JobDescription, CallLength)" +
                                   "VALUES (" + clientID + ",'" + Name + "','" + Surname + "','" + PhoneNum + "','" + Location + "','" + Description + "', "+seconds+")";
                        Database_handler.Insert(query);

                    }
                    else
                    {
                        MessageBox.Show(string.Format("Invalid clientID: {0}", clientID), "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }




            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                gJobID = Int32.Parse(Microsoft.VisualBasic.Interaction.InputBox("Please Provide a JobID   ", "Merge Jobs", "", 0, 0));
                UpdateJob Form = new UpdateJob();
                Form.ShowDialog();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message.ToString(), "Error");
            }
            
        }

        private void Caller_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;
            TimeSpan t = TimeSpan.FromSeconds(seconds);
            string Time = string.Format("{0:D2}:{1:D2}:{2:D2}",t.Hours,t.Minutes,t.Seconds);
            lblTime.Text = Time.ToString();
        }
    }
}
