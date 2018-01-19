using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TotalPayment
{
    public partial class frmPayment : Form
    {
        public frmPayment()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            decimal hourReg, hourDec, hourJan, payRate, payAmt;

            hourReg = decimal.Parse(txtReg.Text);
            hourDec = decimal.Parse(txtDec.Text);
            hourJan = decimal.Parse(txtJan.Text);
            payRate = decimal.Parse(txtPayrate.Text);
           

            if (hourDec > 10)
            {
                MessageBox.Show("You can´t work more than 10 hours per day, this hours from december will not be computed");
                hourDec = 0m;
            }
            
            if (hourJan > 10)
            {
                MessageBox.Show("You can´t work more than 10 hours per day, this hours from january  will not be computed");
                hourJan = 0m;
            }
            

            
            if (hourReg > 45)
            {
                payAmt = (payRate * 2m * (hourReg - 45))+(payRate * 1.5m * 15)+(payRate * 30) + (hourDec*2.5m) + (hourJan*3m);
            }
            else if (hourReg <30)
            {
                payAmt = (payRate * hourReg) + (hourDec * 2.5m) + (hourJan * 3m);
            }
            else
            {
                payAmt = (payRate * 1.5m * (hourReg - 30)) + (payRate * 30) + (hourDec * 2.5m) + (hourJan * 3m);
            }

            

            txtPayAmt.Text = payAmt.ToString("c2");

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
