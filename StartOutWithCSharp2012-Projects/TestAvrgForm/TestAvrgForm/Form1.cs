using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestAvrgForm
{
    public partial class frmTestAverage : Form
    {
        public frmTestAverage()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                double test1, test2, test3, average;


                test1 = double.Parse(txtBoxTest1.Text);
                test2 = double.Parse(txtBoxTest2.Text);
                test3 = double.Parse(txtBoxTest3.Text);

                average = (test1 + test2 + test3) / 3;

                lblAverage.Text = average.ToString("n2");
            }

            catch (Exception er)
            {
                MessageBox.Show( er.Message);
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxTest1.Text = "";
            txtBoxTest2.Text = "";
            txtBoxTest3.Text = "";
            lblAverage.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
