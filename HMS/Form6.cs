using System;
using System.Windows.Forms;

namespace HMS
{
    public partial class Receipt : Form
    {
        private readonly string customerName;
        private readonly string roomType;
        private readonly string servicesUsed;
        private readonly bool parking;
        private readonly decimal baseBill;

        public Receipt()
        {
            InitializeComponent();
        }

        public Receipt(string customerName, string roomType, string servicesUsed, bool parking, decimal baseBill)
        {
            InitializeComponent();
            this.customerName = customerName;
            this.roomType = roomType;
            this.servicesUsed = servicesUsed;
            this.parking = parking;
            this.baseBill = baseBill;
        }

        private void btnreceipt_Click(object sender, EventArgs e)
        {
            decimal discount = 0;
            if (!string.IsNullOrEmpty(txtCoupon.Text) &&
                txtCoupon.Text.Trim().Equals("DISCOUNT10", StringComparison.OrdinalIgnoreCase))
            {
                discount = baseBill * 0.10m;
            }

            decimal finalBill = baseBill - discount;

            // Save complaint to database using DbHelper
            string complainText = richbox.Text.Trim();
            if (!string.IsNullOrEmpty(complainText))
            {
                string safeComplaint = complainText.Replace("'", "''");
                string query = $"INSERT INTO complain (Name, Complain) VALUES ('{customerName}', '{safeComplaint}')";
                DbHelper.ExecuteQuery(query);
            }

            MessageBox.Show(
                $"--- Receipt ---\n\n" +
                $"Customer: {customerName}\n" +
                $"Room Type: {roomType}\n" +
                $"Services: {(string.IsNullOrEmpty(servicesUsed) ? "None" : servicesUsed)}\n" +
                $"Parking: {(parking ? "Yes" : "No")}\n\n" +
                $"Base Bill: {baseBill:0.00} BDT\n" +
                $"Discount: {discount:0.00} BDT\n" +
                $"Final Bill: {finalBill:0.00} BDT",
                "Final Bill",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void rbyes_CheckedChanged(object sender, EventArgs e)
        {
            txtCoupon.Enabled = rbyes.Checked;
        }

        private void rbno_CheckedChanged(object sender, EventArgs e)
        {
            txtCoupon.Enabled = false;
        }

        private void rbyes_Click(object sender, EventArgs e)
        {
            // Optional: Add logic if needed
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Booking bookingForm = new Booking(customerName);
            bookingForm.Show();
            this.Hide();
        }

        private void btnback_Click_1(object sender, EventArgs e)
        {
            welcome1 home = new welcome1();
            home.Show();    
            this.Hide();
        }
    }
}