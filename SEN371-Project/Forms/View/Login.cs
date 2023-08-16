using SEN371_Project.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static SEN371_Project.userLogin;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SEN371_Project
{
    public partial class Login : Form
    {
        private static int Tries = 3;
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void loginBut_Click(object sender, EventArgs e)
        {
            //Getting Input
            string username = txtUsername.Text;
            string password = txtPassword.Text;


            /* 

             You can use

             username = admin
             password = admin

            */

            //Validation Checking
            if (LoginValidation.Validate(username, password) && Tries != 0)
            {
                optionScreen options = new optionScreen();
                this.Hide();
                options.ShowDialog();
                this.Close();

            }
            else if (Tries != 0)
            {
                MessageBox.Show(string.Format("Invalid username or password\n(Tries Left: {0})", Tries),"Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Tries--;
            }
            else
            {
                MessageBox.Show("You have been locked out","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
