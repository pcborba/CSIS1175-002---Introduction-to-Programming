using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxiFare
{
    public partial class frmTaxi : Form
    {
        Fare myFare;
        public frmTaxi()
        {
            InitializeComponent();
            radN.Checked = true;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            calcFare();
        }

        private void calcFare()
        {
            lstResult.Items.Clear();
            double dist;
            string fmt = "{0,-20 }{1,10:c2}";

            if(double.TryParse(txtDist.Text, out dist))
            {
                myFare = new Fare(dist, (int)numSuit.Value, radBc.Checked, (int)numTip.Value);

                lstResult.Items.Add(string.Format(fmt, "Base fare ", myFare.BaseFare));
                if (radBc.Checked==true)
                {
                    lstResult.Items.Add(string.Format(fmt, "Discount ", myFare.DiscFare));
                }
                else
                {
                    lstResult.Items.Add(string.Format(fmt, "Discount ", "NA"));
                }
                
                lstResult.Items.Add(string.Format(fmt, "Luggage fare ", myFare.LugageFare));
                lstResult.Items.Add(string.Format(fmt, "Subtotal amt ", myFare.SubTotalFare));
                lstResult.Items.Add(string.Format(fmt, "Tip amt ", myFare.TipFare));
                lstResult.Items.Add("");
                lstResult.Items.Add("");
                lstResult.Items.Add(string.Format(fmt, "Total amt ", myFare.TotalFare));
            }
            else
            {
                MessageBox.Show("Please insert a valid distance to estimate the fare");
            }
            


        }
    }
}
