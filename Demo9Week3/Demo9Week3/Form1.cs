using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo9Week3
{
    public partial class Form1 : Form
    {
        //declare a field called myName
        private string myName = "Nelson";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //declare a string variable called myName
            //and initialized in the same line of code
            //myName is a local variable 
            string myName = "Simon Li";

            //e.g. to declare multiple variables and 
            //initialize at the same time
            // string Name1 = "Simon", Name2 = "Victor";

            MessageBox.Show(myName);

            //reset myName to Ray Yu
            myName = "Ray Yu";
        }

        private void button2_Click(object sender, EventArgs e)
        {
           MessageBox.Show(myName);
            myName = "Sarah";
        }

        private void btnDateTime_Click(object sender, EventArgs e)
        {
            //declare myDate as a DateTime type variable
            //initialize it with the current system date and
            //time
            DateTime myDate = DateTime.Now;

            MessageBox.Show("Today is " + myDate.ToShortDateString());

            //adding 2 days into myDate and put
            //the result in newDate
            DateTime newDate = myDate.AddDays(2);
            MessageBox.Show("New date is " + newDate.ToShortDateString());

            //get the days from the textbox and initialized 
            //the variable NoOfDays

            int NoOfDays = int.Parse(txtDays.Text);
            newDate = myDate.AddDays(NoOfDays);
            MessageBox.Show("Here is the new date " + newDate.ToShortDateString());
        }

        private void btnPayroll_Click(object sender, EventArgs e)
        {
            //declare decimal variables and initialize
            //them from the correspondnig textboxes
            decimal rate = decimal.Parse(txtRate.Text);
            decimal hours = decimal.Parse(txtHrs.Text);

            //declare decimal var called payment
            decimal payment;

            //assume: >35 hrs, hrs paid 1.5x
            if (hours>35)
            {
                payment = rate * 35 + rate * 1.5m * (hours - 35);
            }
            else //regular rate because less than 35 hrs worked
            { payment = rate * hours; }

            //show the result in the textbox
            txtPayment.Text = payment.ToString("c");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //default NA to be selected at the
            //time the form is loaded
            //insurance checked
            radNA.Checked = true;
            chkInsurance.Checked = true;
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            decimal discount = 0;
            //get rental rate from the textbox
            decimal rentalRate = decimal.Parse(txtRentalRate.Text);

            //get the # of days rented
            int rentalDays = int.Parse(txtRentalDays.Text);

            //compute the rental amt before discount
            decimal rentalAmt = rentalRate * rentalDays;

            //both insurance and gps amts are defaulted to zero
            //find out if insurance is needed and the amt
            decimal insuranceAmt = 0;

            if (chkInsurance.Checked == true)
            { insuranceAmt = .15m * rentalAmt; }

            //find out the gps rental amt
            decimal gpsAmt = 0;
            if (chkGPS.Checked ==true)
            { gpsAmt = 5 * rentalDays; }

           //determine the discount %

            if (radBCAA.Checked==true)
            { discount = 0.1m; }
            else
            { if (radGovt.Checked == true)
                { discount = .05m ; } 
            }

            decimal discountAmt = 0;
            discountAmt = discount * rentalAmt;

            decimal totalAmt = 0;
            totalAmt = rentalAmt - discountAmt + insuranceAmt + gpsAmt;
            //creaet a formatting string for the
            //listbox, determine how many cols in 
            //the box and the width of each col
            //col 0 is 30 char wide
            //col 1 is 10 char wide with 2 decimals, currency format
            //-sign is to align on the left
            string fmt = "{0,-30}{1,10:c2}";

            lstInvoice.Items.Clear();
            lstInvoice.Items.Add(string.Format(fmt, "Rental amt", rentalAmt));
            lstInvoice.Items.Add(string.Format(fmt, "Discount amt", discountAmt));
            lstInvoice.Items.Add(string.Format(fmt, "Insurance amt", insuranceAmt));
            lstInvoice.Items.Add(string.Format(fmt, "GPS amt", gpsAmt));
            lstInvoice.Items.Add("");
            lstInvoice.Items.Add(string.Format(fmt, "Total amt", totalAmt));


        }
    }
}
