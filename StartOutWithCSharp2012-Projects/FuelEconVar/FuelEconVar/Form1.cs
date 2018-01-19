using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelEconVar
{
    public partial class frmFuelEconomy : Form
    {
        public frmFuelEconomy()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            { 

            double miles;
            double gallons;
            double mpg;

                //miles = double.Parse(txtMiles.Text);
                //gallons = double.Parse(txtGallons.Text);
                //mpg = miles / gallons;

                if (double.TryParse(txtMiles.Text, out miles))
                {
                    if (double.TryParse(txtGallons.Text, out gallons))
                    {
                        mpg = miles / gallons;
                        //lblMPG.Text = mpg.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Enter a valid double number to gallons");
                        txtGallons.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Enter a valid double number to miles");
                    txtMiles.Focus();
                }

                //lblMPG.Text = mpg.ToString();
                
            }

            catch (Exception PB)
            {
                MessageBox.Show(PB.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
