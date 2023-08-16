using SEN371_Project.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEN371_Project.Forms.Insert
{
    public partial class AddClient : Form
    {
        public AddClient()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int EmID = Int32.Parse(txtID.Text);
            string Name = txtName.Text;
            string Surname = txtSurname.Text;
            string PhoneNum = txtPhone.Text;
            string Email = txtEmail.Text;
            string Address = txtAddress.Text;
            string Country = txtCountry.Text;
            string ZipCode = txtZipCode.Text;

            string query = "INSERT INTO ClientDetails (ClientNumber, ClientName, ClientSurname, ClientPhoneNumber, ClientEmailAddress, ClientAddress, ClientCountry, ClientZipcode)" +
                               "VALUES (" + EmID + ",'" + Name + "','" + Surname + "','" + PhoneNum + "','" + Email + "','" + Address + "','" + Country + "'," + ZipCode + ")";


            //Send query to database handler
            Database_handler.Insert(query);


            MessageBox.Show(string.Format("Successfully Added\n{0}({1})", Name, EmID), "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClientDetails Form = new ClientDetails();
            this.Hide();
            Form.ShowDialog();
            this.Close();
        }
    }
}
