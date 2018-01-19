using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo2Week4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private void btnClick(object sender, EventArgs e)
        //{
        //   Button btn = sender as Button;
            //MessageBox.Show(btn.Text);
        //    btn.Text = "X";
        // }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            //declaring a decimal variable and assign
            //the value from textRate textbox with
            //conversion
            decimal rate = decimal.Parse(txtRate.Text);
            int days = int.Parse(txtDays.Text); //rental duration
            //declare a decimal variable called result
            //compute the answer
            decimal result = rate * days;

            //declare a discount %, default to zero
            decimal disc = 0;

            //BCAA 10%, Govt 5%
            if (radBCAA.Checked)
            {
                disc = 0.1m;
            }
            else if (radGovt.Checked)
            {
                disc = 0.05m;
            }

            //define the discount amt
            decimal dicountAmt = result * disc;

            //define insurance amt, no disc
            decimal insureAmt = 0;
            if (chkInsurance.Checked)
            { insureAmt = result * .15m; }

            //define insurance amt, no disc
            decimal gpsAmt = 0;
            if (chkGPS.Checked)
            { gpsAmt = days * 5m; }

            //define and compute the amt, to disc
            decimal netAmt = result - dicountAmt + insureAmt + gpsAmt;



            //define a string variable for the format of the
            //listbox with 2 cols, col 0 has -25 char width
            //col 1 has 10 char, :c2 is currency form with 2
            //decimal points
            string fmt = "{0, -25}{1,10:c2}";
            //fmt1 has not currency format on col 1
            string fmt1 = "{0, -25}{1,10}";

            //clear the listbox contents first
            lstRental.Items.Clear();


            lstRental.Items.Add(string.Format(fmt1, "Rental duration", days));
            lstRental.Items.Add(string.Format(fmt, "Daily Rate", rate));

            if(dicountAmt == 0)
                lstRental.Items.Add(string.Format(fmt, "Discoun Amount", "N/A"));
            else
                lstRental.Items.Add(string.Format(fmt, "Discoun Amount", dicountAmt));


            lstRental.Items.Add(string.Format(fmt, "Insurance costs", insureAmt));
            lstRental.Items.Add(string.Format(fmt, "GPS cost", gpsAmt));


            //display a blank line first
            lstRental.Items.Add("");
            lstRental.Items.Add(string.Format(fmt, "Rental amount", netAmt));



        }


        private void btnAvg_Click(object sender, EventArgs e)
        {
            //define a quiz results
            decimal q1 = decimal.Parse(txtQ1.Text);
            decimal q2 = decimal.Parse(txtQ2.Text);
            decimal q3 = decimal.Parse(txtQ3.Text);
            decimal q4 = decimal.Parse(txtQ4.Text);

            //compute the average
            decimal avg = (q1 + q2 + q3 + q4) / 4;

            //define a smaller one
            decimal smaller;

            if (q1 < q2)
            { smaller = q1; }
            else { smaller = q2; }

            if (q3 < smaller)
            { smaller = q3; }

            if (q4 < smaller)
            { smaller = q4; }

            //define avg of the best 3 out of 4
            decimal bestAvg = (q1 + q2 + q3 + q4 - smaller) / 3;

            txtBavg.Text = bestAvg.ToString("n");




            //

            txtAvg.Text = avg.ToString("n");

        }
    }
}
