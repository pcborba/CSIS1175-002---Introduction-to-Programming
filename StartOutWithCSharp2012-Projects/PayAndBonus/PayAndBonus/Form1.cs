using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayAndBonus
{
    public partial class Form1 : Form
    {

        private const decimal CONTRIB_RATE = 0.05m;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            decimal grossPay = 0m, bonus = 0m, contributions = 0m;

            if (InputIsValid(ref grossPay, ref bonus))
            {
                contributions = (grossPay + bonus) * CONTRIB_RATE;
                lblContribution.Text = contributions.ToString("c");
            }
        }

        private bool InputIsValid (ref decimal pay, ref decimal bonus)
        {
            bool inputGood = true;

            if (decimal.TryParse(txtGrossPay.Text, out pay))
            {
                if (decimal.TryParse(txtBonus.Text, out bonus))
                {
                    inputGood = true;
                }
                else
                {
                    MessageBox.Show("Bonus amount is invalid.");
                }
            }
            else
            {
                MessageBox.Show("GrossPay amount is invalid.");
            }

            return inputGood;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
