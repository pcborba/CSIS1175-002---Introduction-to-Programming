using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CupToOnces
{
    public partial class frmConvert : Form
    {
        public frmConvert()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double cups, onces;

            if(txtCups.Text=="")
            {
                MessageBox.Show("Informe os dados");
            }
            else
            {
                cups = double.Parse(txtCups.Text);
                onces = convert(cups);
                lblOnces.Text = onces.ToString();
            }

            
        }



        private void btnEven_Click(object sender, EventArgs e)
        {
            int number;

            number = int.Parse(txtCups.Text);
            if(isEven(number)==true)
            {
                MessageBox.Show("number " + number + " is even");
            }
            else
            {
                MessageBox.Show("number " + number + " is odd");
            }
        }

        private bool isEven(int number)
        {
            bool numberEven;

            if (number % 2 == 0)
            {
                numberEven = true;
            }
            else
            {
                numberEven = false;
            }

            return numberEven;
        }
        private double convert(double cups)
        {
            return cups * 8;
        }
    }
}
