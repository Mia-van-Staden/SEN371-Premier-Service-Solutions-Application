using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SEN371_Project.userLogin;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SEN371_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void loginBut_Click(object sender, EventArgs e)
        {
            //Getting Values
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            //Creating an Instance of the userLogin class and option Screen.
            Login userLogin = new Login(username, password);
            optionScreen options = new optionScreen();
            

            //Validation Checking
            if (userLogin.Username == "admin" && userLogin.Password == "password123")
            {
                options.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Login failed. Invalid username or password.");
            }
        }
    }
}
