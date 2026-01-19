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
    public partial class welcome1 : Form
    {
        private TextBox txtID;
        private TextBox txtname;
        private TextBox txtemail;
        private TextBox txtaddress;

        public welcome1()
        {
            InitializeComponent();
            TextBox textBox = new TextBox();
            txtID = textBox;
            txtname = textBox;
            txtemail = textBox;
            txtaddress = textBox;
        }
        

        private void btnadmin_Click(object sender, EventArgs e)
        {
           
        }

        private void btncustomer_Click(object sender, EventArgs e)
        {
            customer nextForm = new customer();
            nextForm.Show();
            this.Hide();
        }

        private void btnemp_Click(object sender, EventArgs e)
        {
            string name = txtbname.Text;
            string password = txtbpass.Text;

            if (name == "" || password == "")
            {
                MessageBox.Show("Please enter both name and password.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = $"SELECT COUNT(*) FROM emp WHERE Name = '{name}' AND Password = '{password}'";
            DataTable result = DbHelper.GetData(query);

            if (result.Rows.Count > 0 && Convert.ToInt32(result.Rows[0][0]) > 0)
            {
                reception nextForm = new reception();
                nextForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid credentials. Access denied.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtbname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtadmin_TextChanged(object sender, EventArgs e)
        {
            string enteredPin = txtadmin.Text.Trim();
            string correctPin = "1"; // fixed PIN

            if (enteredPin == correctPin)
            {
                // Navigate to Admin form
                tables Table = new tables();   // assuming your Admin form is called "table"
                Table.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid PIN. Access denied.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtadmin.Clear();
            }

        }
    }

}




