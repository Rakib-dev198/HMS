using System;
using System.Data;
using System.Windows.Forms;

namespace HMS
{
    public partial class tables : Form
    {
        public tables()
        {
            InitializeComponent();
        }

        // Show customer table
        private void customer_Click(object sender, EventArgs e)
        {
            string query = "SELECT ID, NAME, EMAIL, MOBILE, GENDER FROM customer";
            DataTable dt = DbHelper.GetData(query);
            dataGridView1.DataSource = dt;
        }

        // Show employee table
        private void emp_Click(object sender, EventArgs e)
        {
            string query = "SELECT Name, Salary, Role, Attendence FROM emp";
            DataTable dt = DbHelper.GetData(query);
            dataGridView1.DataSource = dt;
        }

        // Populate textboxes when a row is selected (for employee only)
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Columns.Count >= 4)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtname.Text = row.Cells[0].Value.ToString();       // Name
                txtsalary.Text = row.Cells[1].Value.ToString();     // Salary
                txtrole.Text = row.Cells[2].Value.ToString();       // Role
                txtattendence.Text = row.Cells[3].Value.ToString(); // Attendance
            }
        }

        // Delete selected employee
        private void delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string name = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string query = $"DELETE FROM emp WHERE Name = '{name}'";
                DbHelper.ExecuteQuery(query);

                MessageBox.Show("Employee deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                emp_Click(sender, e); // Refresh employee table
            }
            else
            {
                MessageBox.Show("Please select an employee to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Update selected employee
        private void update_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string name = txtname.Text;
                string salary = txtsalary.Text;
                string role = txtrole.Text;
                string attendance = txtattendence.Text;

                string query = $"UPDATE emp SET Salary={salary}, Role='{role}', Attendence={attendance} WHERE Name='{name}'";
                DbHelper.ExecuteQuery(query);

                MessageBox.Show("Employee updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                emp_Click(sender, e); // Refresh employee table
            }
            else
            {
                MessageBox.Show("Please select an employee to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Back to welcome screen
        private void btnback_Click_1(object sender, EventArgs e)
        {
            welcome1 welcome = new welcome1();
            welcome.Show();
            this.Hide();
        }

        private void checkout_Click(object sender, EventArgs e)
        {
            // Optional: implement checkout logic here
        }
    }
}