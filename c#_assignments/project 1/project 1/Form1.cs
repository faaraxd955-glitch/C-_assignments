using System;
using System.Windows.Forms;

namespace project_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string name = txtname.Text;
            int age, nights, guests;

            bool approved = true;

            if (name == "" ||
                !int.TryParse(txtage.Text, out age) ||
                !int.TryParse(txtnumberNigth.Text, out nights) ||
                !int.TryParse(txtnumberGuest.Text, out guests))
            {
                MessageBox.Show("Enter valid information!");
                return;
            }

            if (age < 18 || age > 90 ||
                nights < 1 || nights > 30 ||
                guests < 1 || guests > 6)
            {
                MessageBox.Show("Invalid information!");
                return;
            }

            string room = "";
            double rate = 0;
            int capacity = 0;

            if (rbStandard.Checked)
            {
                room = "Standard";
                capacity = 2;
            }
            else if (rbNormal.Checked)
            {
                room = "Normal";
                capacity = 4;
            }
            else if (rbHight.Checked)
            {
                room = "Hight";
                capacity = 6;
            }
            else
            {
                MessageBox.Show("Select room type!");
                return;
            }

            if (guests > capacity)
                approved = false;

            if (!approved)
            {
                MessageBox.Show("Booking Rejected!");
                return;
            }

            switch (room)
            {
                case "Standard":
                    rate = 50;
                    break;

                case "Normal":
                    rate = 80;
                    break;

                case "Hight":
                    rate = 130;
                    break;
            }

            double roomCost = rate * nights;
            double breakfast = 0;
            double discount = 0;
            double surcharge = 0;

            if (chkbreakfast.Checked)
                breakfast = 10 * guests * nights;

            if (nights >= 5 && nights <= 9)
                discount = roomCost * 0.05;
            else if (nights >= 10)
                discount = roomCost * 0.12;

            if (age >= 60)
                discount += roomCost * 0.05;

            double subtotal = roomCost - discount + breakfast;

            if (guests > 4)
                surcharge = subtotal * 0.05;

            double total = subtotal + surcharge;

            details.Items.Clear();
            details.Items.Add("Guest Name: " + name);
            details.Items.Add("Age: " + age);
            details.Items.Add("Room: " + room);
            details.Items.Add("Nights: " + nights);
            details.Items.Add("Guests: " + guests);
            details.Items.Add("Room Cost: $" + roomCost);
            details.Items.Add("Breakfast: $" + breakfast);
            details.Items.Add("Discount: $" + discount);
            details.Items.Add("Surcharge: $" + surcharge);
            details.Items.Add("Total: $" + total);
            details.Items.Add("Booking Approved!");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void Clear_Click(object sender, EventArgs e)
        {
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtage.Clear();
            txtnumberNigth.Clear();
            txtnumberGuest.Clear();

            details.Items.Clear();

            rbStandard.Checked = false;
            rbNormal.Checked = false;
            rbHight.Checked = false;
            chkbreakfast.Checked = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
        }
    }
}