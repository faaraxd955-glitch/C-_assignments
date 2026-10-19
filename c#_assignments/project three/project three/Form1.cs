
using System;
using System.Windows.Forms;

namespace project_three
{
    public partial class VehecleRentalManagement : Form
    {
        public VehecleRentalManagement()
        {
            InitializeComponent();
        }

        private void VehecleRentalManagement_Load(object sender, EventArgs e)
        {
        }

        // CLEAR BUTTON
        private void button2_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtage.Clear();
            txtdays.Clear();
            txtexperience.Clear();

            rdoeconomy.Checked = false;
            rdosuv.Checked = false;
            rdoluxury.Checked = false;
            chkinsurance.Checked = false;

            Rental.Items.Clear();
            txtname.Focus();
        }

        // CALCULATE BUTTON
        private void Calculate_Click(object sender, EventArgs e)
        {
            string name = txtname.Text.Trim();

            int age, days, experience;

            if (name == "")
            {
                MessageBox.Show("Please enter customer name.");
                txtname.Focus();
                return;
            }

            if (!int.TryParse(txtage.Text, out age))
            {
                MessageBox.Show("Enter valid customer age.");
                return;
            }

            if (!int.TryParse(txtdays.Text, out days))
            {
                MessageBox.Show("Enter valid rental days.");
                return;
            }

            if (!int.TryParse(txtexperience.Text, out experience))
            {
                MessageBox.Show("Enter valid driving experience.");
                return;
            }

            if (age < 18 || age > 80)
            {
                MessageBox.Show("Age must be between 18 and 80.");
                return;
            }

            if (days < 1 || days > 30)
            {
                MessageBox.Show("Rental days must be between 1 and 30.");
                return;
            }

            if (experience < 0)
            {
                MessageBox.Show("Driving experience cannot be negative.");
                return;
            }

            string vehicle = "";
            decimal rate = 0;

            if (rdoeconomy.Checked)
            {
                vehicle = "Economy";
                rate = 35;
            }
            else if (rdosuv.Checked)
            {
                vehicle = "SUV";
                rate = 60;
            }
            else if (rdoluxury.Checked)
            {
                vehicle = "Luxury";
                rate = 100;
            }
            else
            {
                MessageBox.Show("Please select vehicle type.");
                return;
            }

            bool eligible = true;
            string reason = "";

            if (age < 21)
            {
                eligible = false;
                reason = "Customer must be at least 21 years old.";
            }
            else if (experience < 1)
            {
                eligible = false;
                reason = "At least 1 year driving experience required.";
            }
            else if (vehicle == "Luxury" &&
                     (age < 25 || experience < 3))
            {
                eligible = false;
                reason = "Luxury requires age 25+ and 3 years experience.";
            }

            Rental.Items.Clear();

            if (!eligible)
            {
                Rental.Items.Add("RENTAL STATUS: NOT ELIGIBLE");
                Rental.Items.Add(reason);
                MessageBox.Show(reason);
                return;
            }

            decimal basicCost = rate * days;
            decimal discountRate = 0;

            if (days >= 14)
                discountRate = 0.10m;
            else if (days >= 7)
                discountRate = 0.05m;

            decimal discount = basicCost * discountRate;

            decimal insuranceCost = 0;

            if (chkinsurance.Checked)
                insuranceCost = 15 * days;

            decimal surcharge = 0;

            if (age >= 21 && age <= 24)
                surcharge = basicCost * 0.10m;

            decimal finalCost = basicCost - discount
                              + insuranceCost + surcharge;

            // DISPLAY RESULTS IN LISTBOX
            Rental.Items.Add("RENTAL DETAILS");
            Rental.Items.Add("------------------------------");
            Rental.Items.Add("Customer Name: " + name);
            Rental.Items.Add("Customer Age: " + age);
            Rental.Items.Add("Driving Experience: " + experience + " years");
            Rental.Items.Add("Vehicle Type: " + vehicle);
            Rental.Items.Add("Daily Rate: $" + rate.ToString("F2"));
            Rental.Items.Add("Rental Days: " + days);
            Rental.Items.Add("Basic Rental Cost: $" + basicCost.ToString("F2"));
            Rental.Items.Add("Discount: $" + discount.ToString("F2"));
            Rental.Items.Add("Insurance Cost: $" + insuranceCost.ToString("F2"));
            Rental.Items.Add("Young Driver Surcharge: $" + surcharge.ToString("F2"));
            Rental.Items.Add("Final Rental Cost: $" + finalCost.ToString("F2"));
            Rental.Items.Add("Rental Status: Eligible");
        }

        // EXIT BUTTON
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
