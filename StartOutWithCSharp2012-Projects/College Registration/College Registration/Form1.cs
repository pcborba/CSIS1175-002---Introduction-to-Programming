using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace College_Registration
{
    public partial class frmCollege : Form
    {
        public frmCollege()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            Fee myFee = new Fee();
            if (radDom.Checked==true)
            {
                myFee.regCost(radDom.Checked, int.Parse(txtLower.Text), int.Parse(txtUpper.Text));
                MessageBox.Show(myFee.regAmtcost.ToString());
            }
        }
    }
}
