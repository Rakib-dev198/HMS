using System;
using System.Data;
using System.Windows.Forms;

namespace HMS
{
    public partial class complain : Form
    {
        public complain()
        {
            InitializeComponent();
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            string query = "SELECT Name, Complain FROM complain ORDER BY Name";
            DataTable table = DbHelper.GetData(query);
            dataGridView1.DataSource = table;
        }

        private void btnsolved_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Use column indexes: 0 = Name, 1 = Complain
                string customerName = dataGridView1.SelectedRows[0].Cells[0].Value.ToString().Replace("'", "''");
                string complaintText = dataGridView1.SelectedRows[0].Cells[1].Value.ToString().Replace("'", "''");

                string query = $"DELETE FROM complain WHERE Name = '{customerName}' AND Complain = '{complaintText}'";
                DbHelper.ExecuteQuery(query);

                MessageBox.Show("Complaint removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnshow_Click(sender, e); // Refresh the grid
            }
            else
            {
                MessageBox.Show("⚠️ Please select a complaint to remove.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void btnback_Click(object sender, EventArgs e)
        {
            reception receptionForm = new reception();
            receptionForm.Show();
            this.Hide();
        }
    }
}