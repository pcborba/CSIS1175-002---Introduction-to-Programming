using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OverTimePayroll
{
    public partial class frmPayroll : Form
    {
        public frmPayroll()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHoursWorked.Text = "";
            txtPayrate.Text = "";
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                decimal payrate, grosspayrate;
                double hoursworked;

                payrate = decimal.Parse(txtPayrate.Text);
                hoursworked = double.Parse(txtHoursWorked.Text);

                if (hoursworked > 40)
                {
                    grosspayrate = (40 * payrate) + (((decimal)hoursworked - 40) * payrate * 1.5m);
                }
                else
                {
                    grosspayrate = (decimal)hoursworked * payrate;
                }

                lblGrossPay.Text = grosspayrate.ToString("c2");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
