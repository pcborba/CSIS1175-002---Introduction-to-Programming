using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CellPhone
{
    public partial class frmCellPhone : Form
    {
        public frmCellPhone()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            createEqpt();
        }

        private void createEqpt()
        {
            if (txtBrand.Text == "" || txtModel.Text == "" || txtPrice.Text == "")
            {
                MessageBox.Show("Please set the values to the new equipment before create it");
            }
            else
            {
                CellPhone newEqpt = new CellPhone();

                newEqpt.brand = txtBrand.Text;
                newEqpt.model = txtModel.Text;
                newEqpt.price = decimal.Parse(txtPrice.Text);

                lblBrand.Text = newEqpt.brand;
                lblModel.Text = newEqpt.model;
                lblPrice.Text = newEqpt.price.ToString("c2");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
