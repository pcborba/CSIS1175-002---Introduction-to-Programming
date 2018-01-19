using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registration
{
    public partial class frmReg : Form
    {
        Fee myFee = new Fee();
        public frmReg()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int lower = 0, upper = 0;

            if (radDom.Checked==false && radInt.Checked==false)
            {
                MessageBox.Show("Please select a student status, domestic or internationl");
                radInt.Checked = true;
            }
            else
            {
                if (int.TryParse(txtLower.Text, out lower))
                {
                    if (int.TryParse(txtUpper.Text, out upper))
                    {
                        calcCost(radDom.Checked, lower, upper);
                    }
                    else
                    {
                        MessageBox.Show("Please insert a valid integer number to upper level");
                        txtUpper.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Please insert a valid integer number to lower level");
                    txtLower.Focus();
                }
            }
        }

        private void calcCost(bool student, int lower, int upper)
        {
            if (student == true)
            {
                myFee.regCost(radDom.Checked, lower, upper);
                MessageBox.Show(myFee.regAmtcost.ToString());
            }
            else
            {
                myFee.regCost(radDom.Checked, lower, upper);
                MessageBox.Show(myFee.regAmtcost.ToString());
            }
        }
            
    }
}
