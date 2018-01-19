using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo2Week3
{
    public partial class Form1 : Form
    {
           public Form1()
        {
            InitializeComponent();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            decimal hrs, payrates,  totalDec, totalJan, payAmt, payAmtDec, payAmtJan, payTotal ;

            hrs = decimal.Parse(txtHours.Text);
            totalDec = decimal.Parse(txtDecHours.Text);
            totalJan = decimal.Parse(txtHoursJan.Text);
            payrates = decimal.Parse(txtPayRate.Text);
           


            if (hrs > 45)
            {
                payAmt = (payrates * (hrs - 45) * 2m) + (payrates * 15 * 1.5m) + (payrates * 30);
            }

            else if (hrs <= 30)
            {
                payAmt = (payrates * hrs);
            }
            else
            {
                payAmt = (payrates * 15 * 1.5m) + (payrates * 30);
            }

            if (totalDec > 10)
            {
                MessageBox.Show("Enter with a value until 10 hours");
            }
            else if (totalJan > 10)
            {
                MessageBox.Show("Enter with a value until 10 hours");
            }
                payAmtDec = payrates * 2 * totalDec;
                payAmtJan = payrates * 3 * totalJan;



            //MessageBox.Show("The pay amount is  " + payAmt.ToString("c"));
            payTotal = payAmt + payAmtDec + payAmtJan;
            MessageBox.Show("The pay amount is  " + payTotal.ToString("c"));

        }
    }
}
