using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HMS
{
    public partial class register : Form
    {
        private customer customer1;

        public register()
        {
            InitializeComponent();
        }

        public register(customer customer)
        {
            InitializeComponent();
            customer1 = customer;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
          customer1.Show();
          this.Close();
        }

        private void btnreg_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string name = txtName.Text;
            string email = txtEmail.Text;
            string gender = cbmale.Checked ? "Male" : cbfemale.Checked ? "Female" : "";
            string mobile = txtMobile.Text;
            string password = txtPass.Text;
            string confirmPassword = txtCpass.Text;

            // Basic validation
            if (name == "" || email == "" || gender == "" || mobile == "" || password == "")
            {
                MessageBox.Show("Please fill all required fields.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            // Insert query
            string query = $"INSERT INTO customer (NAME, EMAIL, GENDER, MOBILE, PASSWORD) " +
                           $"VALUES ('{name}', '{email}', '{gender}', '{mobile}', '{password}')";

            int result = DbHelper.ExecuteQuery(query);

            if (result > 0)
            {
                MessageBox.Show("Customer registered successfully.");
                txtID.Text = txtName.Text = txtEmail.Text = txtMobile.Text = txtPass.Text = txtCpass.Text = "";
                cbmale.Checked = cbfemale.Checked = false;
            }
            else
            {
                MessageBox.Show("Registration failed. Please try again.");
            }

        }

        private void cbmale_CheckedChanged(object sender, EventArgs e)
        {
            if (cbmale.Checked)
            {
                cbfemale.Checked = false;
            }
        }

        private void cbfemale_CheckedChanged(object sender, EventArgs e)
        {
            if (cbfemale.Checked)
            {
                cbmale.Checked = false;
            }
        }
    }
}
