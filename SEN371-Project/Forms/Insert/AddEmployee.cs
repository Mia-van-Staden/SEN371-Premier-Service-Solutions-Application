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
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

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

            string query = "INSERT INTO EmployeeDetails (EmployeeNumber, EmployeeName, EmployeeSurname, EmployeePhoneNumber, EmployeeEmailAddress, EmployeeAddress, EmployeeCountry, EmployeeZipcode)" +
                               "VALUES (" + EmID + ",'" + Name + "','" + Surname + "','" + PhoneNum + "','" + Email + "','" + Address + "','" + Country + "'," + ZipCode +")";


            //Send query to database handler
            Database_handler.Insert(query);


            MessageBox.Show(string.Format("Successfully Added\n{0}({1})", Name, EmID), "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
            EmployeeDetailsForm Form = new EmployeeDetailsForm();
            this.Hide();
            Form.ShowDialog();
            this.Close();

        }

        private void txtZipCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCountry_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
