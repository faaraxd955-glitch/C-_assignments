
using System;
using System.Windows.Forms;

namespace project_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        // CALCULATE BUTTON
        private void Calculate_Click(object sender, EventArgs e)
        {
            string name = txtname.Text.Trim();

            int age, tickets;
            double baggage;

            if (name == "")
            {
                MessageBox.Show("Enter passenger name");
                txtname.Focus();
                return;
            }

            if (!int.TryParse(txtAge.Text, out age) ||
                !int.TryParse(txtTickets.Text, out tickets) ||
                !double.TryParse(txtBaggage.Text, out baggage))
            {
                MessageBox.Show("Enter valid numbers");
                return;
            }

            if (age < 1 || age > 100)
            {
                MessageBox.Show("Age must be between 1 and 100");
                return;
            }

            if (tickets < 1 || tickets > 5)
            {
                MessageBox.Show("Tickets must be between 1 and 5");
                return;
            }

            if (baggage < 0 || baggage > 50)
            {
                MessageBox.Show("Baggage must be between 0 and 50 kg");
                return;
            }

            bool bookingApproved = true;

            if (age < 12 && rdoFirst.Checked)
            {
                bookingApproved = false;

                Details.Items.Clear();
                Details.Items.Add("AIRLINE BOOKING");
                Details.Items.Add("Booking Rejected");
                Details.Items.Add("Reason: Children below 12 cannot book First Class");

                MessageBox.Show("Child cannot book First Class");
                return;
            }

            string travelClass = "";
            double price = 0;

            if (rdoFirst.Checked)
            {
                travelClass = "First Class";
                price = 300;
            }
            else if (rdoNormal.Checked)
            {
                travelClass = "Normal Class";
                price = 100;
            }
            else if (rdoBusiness.Checked)
            {
                travelClass = "Business Class";
                price = 200;
            }
            else
            {
                MessageBox.Show("Please select travel class");
                return;
            }

            double basicCost = price * tickets;
            double discount = 0;

            if (tickets >= 3 && tickets <= 4)
                discount += basicCost * 0.05;
            else if (tickets == 5)
                discount += basicCost * 0.10;

            if (age < 12)
                discount += basicCost * 0.20;
            else if (age >= 60)
                discount += basicCost * 0.10;

            double insurance = 0;

            if (chkInsurance.Checked)
                insurance = 25 * tickets;

            double total = basicCost - discount + insurance;

            // DISPLAY RESULTS IN DETAILS LISTBOX
            Details.Items.Clear();

            Details.Items.Add("AIRLINE BOOKING DETAILS");
            Details.Items.Add("------------------------------");
            Details.Items.Add("Passenger Name: " + name);
            Details.Items.Add("Passenger Age: " + age);
            Details.Items.Add("Travel Class: " + travelClass);
            Details.Items.Add("Number of Tickets: " + tickets);
            Details.Items.Add("Ticket Price: $" + price.ToString("0.00"));
            Details.Items.Add("Basic Ticket Cost: $" + basicCost.ToString("0.00"));
            Details.Items.Add("Discount: $" + discount.ToString("0.00"));
            Details.Items.Add("Travel Insurance: $" + insurance.ToString("0.00"));
            Details.Items.Add("Baggage Weight: " + baggage + " kg");
            Details.Items.Add("Final Cost: $" + total.ToString("0.00"));
            Details.Items.Add("Booking Approved: " + bookingApproved);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Calculate_Click(sender, e);
        }

        // CLEAR BUTTON
        private void Clear_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtAge.Clear();
            txtTickets.Clear();
            txtBaggage.Clear();

            rdoFirst.Checked = false;
            rdoNormal.Checked = false;
            rdoBusiness.Checked = false;

            chkInsurance.Checked = false;

            Details.Items.Clear();

            txtname.Focus();
        }

        // EXIT BUTTON
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PassengerName_Click(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
    }
}
