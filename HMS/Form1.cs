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
        //private TextBox txtphone;
        private TextBox txtaddress;

        public welcome1()
        {
            InitializeComponent();
            txtID = new TextBox();
            txtname = new TextBox();
            txtemail = new TextBox();
            //txtphone = new TextBox();
            txtaddress = new TextBox();
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
            reception nextForm = new reception();
            nextForm.Show();
            this.Hide();
        }
    }

}




