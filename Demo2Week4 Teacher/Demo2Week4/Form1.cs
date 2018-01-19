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

        private void btnClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            //MessageBox.Show(btn.Text);
            btn.Text = "X";
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            //declaring a decimal variable and assign
            //the value from the txtRate textbox with
            //conversion
            decimal Rate = decimal.Parse(txtRate.Text);
            int days = int.Parse(txtDays.Text);  //rental duration

            //declare a discount %, default to zero
            decimal disc = 0;

            //BCAA 10%, Govt 5%
            if (radBCAA.Checked)
            { disc = .1m; }
            else
                if (radGovt.Checked)
                    { disc = .05m; }
            

            //declare a decimal var called result and 
            //compute the answer
            decimal result = Rate * days;

            //define the discount Amt
            decimal discAmt = result * disc;

         
            //define insurance amt, no disc
            decimal insureAmt = 0;
            if (chkInsurance.Checked)
            { insureAmt = result * .15m; }

            //define GPS rental amt, no disc
            decimal gpsAmt = 0;
            if (chkGPS.Checked)
            { gpsAmt = days * 5; }

            //define and compute the net amt
            decimal netAmt = result - discAmt + insureAmt+gpsAmt;


            //define a string var for the format of the 
            //listbox with 2 cols, col 0 has 30 char width
            //col 1 has 10 char, :c2 currency format with 2 
            //decimal points
            String fmt = "{0,-30}{1,10:c2}";
            //fmt1 has no currency format on col 1
            String fmt1 = "{0,-30}{1,10}";

            //clear the listbox contents first
            lstRental.Items.Clear();

            lstRental.Items.Add(string.Format(fmt1, "Rental duration", days));
            lstRental.Items.Add(string.Format(fmt, "Daily Rate", Rate));

            if (discAmt == 0)
            {
                lstRental.Items.Add(string.Format(fmt, "Discount Amt", "NA"));
            }
            else
            { lstRental.Items.Add(string.Format(fmt, "Discount Amt", discAmt)); }

            lstRental.Items.Add(string.Format(fmt, "Insurance Amt", insureAmt));
            lstRental.Items.Add(string.Format(fmt, "GPS Amt", gpsAmt));


            //display a blank line first
            lstRental.Items.Add("");

            lstRental.Items.Add(string.Format(fmt, "Rental Net Amt", netAmt));



        }

        private void btnAvg_Click(object sender, EventArgs e)
        {
            //define quiz results
            decimal q1 = decimal.Parse(txtQ1.Text);
            decimal q2 = decimal.Parse(txtQ2.Text);
            decimal q3 = decimal.Parse(txtQ3.Text);
            decimal q4 = decimal.Parse(txtQ4.Text);

            //compute the average
            decimal avg = (q1 + q2 + q3 + q4) / 4;

            //define a smaller one
            decimal smaller ;

            if (q1 < q2)
            { smaller = q1; }
            else
            { smaller = q2; }

            if (q3 < smaller)
            { smaller = q3; }

            if (q4 < smaller)
            { smaller = q4; }

            //defind avg of the best 3 out of
            //4
            decimal bestAvg = (q1 + q2 + q3 + q4 - smaller) / 3;

            txtBestAvg.Text = bestAvg.ToString("n");


            txtAvg.Text = avg.ToString("n");
            
        }
    }
}
