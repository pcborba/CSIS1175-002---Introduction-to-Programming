using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalePrice
{
    public partial class frmSalePrice : Form
    {
        public frmSalePrice()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            decimal originalPrice;
            decimal discount;
            decimal salesPrice;

            originalPrice = decimal.Parse(txtOriginalPrice.Text);
            discount = decimal.Parse(txtDiscount.Text)/100;

            salesPrice = originalPrice - originalPrice * (decimal)discount;

            lblPrice.Text = salesPrice.ToString();

            MessageBox.Show(salesPrice.ToString("c"));
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
