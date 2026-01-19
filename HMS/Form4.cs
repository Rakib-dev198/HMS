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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtMobile.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtGender.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                
            }
        }

        private void btnselect_Click(object sender, EventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string query = $"UPDATE customer SET NAME='{txtName.Text}', EMAIL='{txtEmail.Text}', MOBILE='{txtMobile.Text}', GENDER='{txtGender.Text}' WHERE ID={txtID.Text}";
            DbHelper.ExecuteQuery(query);
            MessageBox.Show("Customer updated successfully.");
            btnshow_Click(sender, e); // Refresh grid
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string query = $"DELETE FROM customer WHERE ID={txtID.Text}";
            DbHelper.ExecuteQuery(query);
            MessageBox.Show("Customer deleted successfully.");
            btnshow_Click(sender, e); // Refresh grid
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            register accountForm = new register(); // Replace with your actual form name
            accountForm.Show();
            this.Hide();
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM customer";
            DataTable dt = DbHelper.GetData(query);
            dataGridView1.DataSource = dt;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            welcome1 home = new welcome1();
            home.Show();
            this.Hide();
        }
    }
}
