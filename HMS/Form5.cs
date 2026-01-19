using System;
using System.Windows.Forms;

namespace HMS
{
    public partial class Booking : Form
    {
        private string customerName;

        public Booking(string name)
        {
            InitializeComponent();
            customerName = name;
            this.Load += Booking_Load;
        }

        private void Booking_Load(object sender, EventArgs e)
        {
            txtName.Text = customerName;
            txtName.ReadOnly = true;
        }

        private void btnbook_Click(object sender, EventArgs e)
        {
            string roomType = "";
            if (rbsingle.Checked) roomType = "Single";
            else if (rbdouble.Checked) roomType = "Double";
            else if (rbsuite.Checked) roomType = "Suite";

            if (string.IsNullOrEmpty(roomType))
            {
                MessageBox.Show("Please select a room type.");
                return;
            }

            DateTime checkIn = dateTimePicker1.Value;
            DateTime checkOut = dateTimePicker2.Value;

            string servicesUsed = "";
            if (cbcleaning.Checked) servicesUsed += "Room Cleaning, ";
            if (cbLaundry.Checked) servicesUsed += "Laundry, ";
            if (cbFood.Checked) servicesUsed += "Food Service, ";
            servicesUsed = servicesUsed.TrimEnd(',', ' ');

            bool parking = rbyes.Checked;

            int days = (checkOut - checkIn).Days;
            if (days <= 0)
            {
                MessageBox.Show("Check-out date must be after check-in date.");
                return;
            }

            decimal roomRate = roomType == "Single" ? 3000 :
                               roomType == "Double" ? 5000 :
                               roomType == "Suite" ? 8000 : 0;

            decimal baseBill = roomRate * days;
            if (cbcleaning.Checked) baseBill += 500;
            if (cbLaundry.Checked) baseBill += 700;
            if (cbFood.Checked) baseBill += 1000;
            if (parking) baseBill += 300;

            // Insert into database including FinalBill (initially same as baseBill)
            string query = $"INSERT INTO Bookings (Name, RoomType, CheckIN, CheckOut, RoomServiceUsed, ParkingUsed, BaseBill, FinalBill) " +
                           $"VALUES ('{customerName}', '{roomType}', '{checkIn:yyyy-MM-dd}', '{checkOut:yyyy-MM-dd}', '{servicesUsed}', {(parking ? 1 : 0)}, {baseBill}, {baseBill})";

            int result = DbHelper.ExecuteQuery(query);

            if (result > 0)
            {
                Receipt receiptForm = new Receipt(customerName, roomType, servicesUsed, parking, baseBill);
                receiptForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Booking failed. Please try again.");
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            customer customerForm = new customer(); // Pass the name back if needed
            customerForm.Show();
            this.Hide();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            customer customerForm = new customer(); // Pass the name back if needed
            customerForm.Show();
            this.Hide();
        }
    }
}