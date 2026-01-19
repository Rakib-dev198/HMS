using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS
{
    public partial class customer : Form
    {
        public customer()
        {
            InitializeComponent();
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            register nextForm = new register(this);
            nextForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e) // back button
        {
            welcome1 welcomeForm = new welcome1();
            welcomeForm.Show();
            this.Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string enteredName = txtName.Text.Trim();
            string enteredPassword = txtPass.Text.Trim();

            if (string.IsNullOrEmpty(enteredName) || string.IsNullOrEmpty(enteredPassword))
            {
                MessageBox.Show("Please enter both name and password.");
                return;
            }

            // Query to validate login
            string query = $"SELECT * FROM customer WHERE NAME = '{enteredName}' AND PASSWORD = '{enteredPassword}'";
            DataTable dt = DbHelper.GetData(query);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login successful! Logged in as: " + enteredName);

                // Pass the actual typed name to Booking form
                Booking bookingForm = new Booking(enteredName);
                bookingForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid name or password.");
            }
        }
    }

}
