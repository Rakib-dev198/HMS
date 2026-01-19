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
    public partial class reception : Form
    {
        public reception()
        {
            InitializeComponent();
        }

        // Populate textboxes when a row is selected
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtID.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                txtEmail.Text = row.Cells[2].Value.ToString();
                txtMobile.Text = row.Cells[3].Value.ToString();
                txtGender.Text = row.Cells[4].Value.ToString();
            }
        }

        // Upload new customer
        private void btnupload_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtEmail.Text == "" || txtMobile.Text == "" || txtGender.Text == "")
            {
                MessageBox.Show("Please fill in all fields except ID.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = $"INSERT INTO customer (NAME, EMAIL, MOBILE, GENDER) " +
                           $"VALUES ('{txtName.Text}', '{txtEmail.Text}', '{txtMobile.Text}', '{txtGender.Text}')";
            DbHelper.ExecuteQuery(query);

            MessageBox.Show("New customer uploaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnshow_Click(sender, e);
        }

        // Update selected customer
        private void btnupdate_Click(object sender, EventArgs e)
        {
            string query = $"UPDATE customer SET NAME='{txtName.Text}', EMAIL='{txtEmail.Text}', " +
                           $"MOBILE='{txtMobile.Text}', GENDER='{txtGender.Text}' WHERE ID={txtID.Text}";
            DbHelper.ExecuteQuery(query);

            MessageBox.Show("Customer updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnshow_Click(sender, e);
        }

        // Delete selected customer
        private void btndelete_Click(object sender, EventArgs e)
        {
            string query = $"DELETE FROM customer WHERE ID={txtID.Text}";
            DbHelper.ExecuteQuery(query);

            MessageBox.Show("Customer deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnshow_Click(sender, e);
        }

        // Show all customers
        private void btnshow_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM customer";
            DataTable dt = DbHelper.GetData(query);
            dataGridView1.DataSource = dt;
        }

        // Navigate to registration form
        private void btnnew_Click(object sender, EventArgs e)
        {
            register accountForm = new register();
            accountForm.Show();
            this.Hide();
        }

        // Navigate back to welcome screen
        private void btnback_Click(object sender, EventArgs e)
        {
            welcome1 home = new welcome1();
            home.Show();
            this.Hide();
        }

        // Access complain box with PIN
        private void btncomplain_Click(object sender, EventArgs e)
        {
            string enteredPin = txtpin.Text;
            string correctPin = "a"; // Replace with secure logic or database lookup

            if (enteredPin == correctPin)
            {
                complain complainForm = new complain();
                complainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect PIN. Access denied.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpin.Clear();
            }
        }

        // Optional: search by name
        private void btnselect_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                string query = $"SELECT * FROM customer WHERE NAME LIKE '%{txtName.Text}%'";
                DataTable dt = DbHelper.GetData(query);
                dataGridView1.DataSource = dt;

                // If at least one row is found, populate the textboxes
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    txtID.Text = row["ID"].ToString();
                    txtName.Text = row["NAME"].ToString();
                    txtEmail.Text = row["EMAIL"].ToString();
                    txtMobile.Text = row["MOBILE"].ToString();
                    txtGender.Text = row["GENDER"].ToString();
                }
                else
                {
                    MessageBox.Show("No matching customer found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please enter a name to search.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}