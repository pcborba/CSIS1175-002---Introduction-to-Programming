using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeCounterForm
{
    public partial class frmChgCounter : Form
    {

        private decimal total = 0.00m;
        const decimal FIVE_CENTS = 0.05m;
        const decimal TEN_CENTS = 0.10m;
        const decimal TWENTY_FIVE_CENTS = 0.25m;
        const decimal FIFTY_CENTS = 0.50m;

        public frmChgCounter()

        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pic5_Click(object sender, EventArgs e)
        {

            total += FIVE_CENTS;

            lblOutputTotal.Text = total.ToString("c2");
        }

        private void pic10_Click(object sender, EventArgs e)
        {

            total += TEN_CENTS;

            lblOutputTotal.Text = total.ToString("c2");
        }

        private void pic25_Click(object sender, EventArgs e)
        {

            total += TWENTY_FIVE_CENTS;

            lblOutputTotal.Text = total.ToString("c2");
        }

        private void pic50_Click(object sender, EventArgs e)
        {

            total += FIFTY_CENTS;

            lblOutputTotal.Text = total.ToString("c2");
        }
    }
}
