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
            if (Validate(username,password))
            {
                optionScreen options = new optionScreen();
                this.Hide();
                options.ShowDialog();
                this.Close();
                
            }
            else
            {
                MessageBox.Show("Login failed. Invalid username or password.");
            }
        }

        public Boolean Validate(String Username, String Password)
        {
            SQLiteConnection conn = new SQLiteConnection(@"data source=..\..\Database\Premier_SQLite_Final.db");


            using (var cmd = new SQLiteCommand(conn))
            {
                using (var command = new SQLiteCommand(conn))
                {
                    conn.Open();
                    command.CommandText = "SELECT * FROM Login";
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            String user = reader["Username"].ToString();
                            String pass = reader["Password"].ToString();

                            if ((user.Equals(Username)) && (pass.Equals(Password)))
                            { 
                                return true;
                            }
                        }
                    }
                    conn.Close();
                }
            }
            return false;
        }

    }
}
