using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace avr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                txtBox1.Text = "";
                txtBox2.Text = "";
                txtBox3.Text = "";

                double score1, score2, score3, average;

                score1 = double.Parse(txtBox1.Text);
                score2 = double.Parse(txtBox1.Text);
                score3 = double.Parse(txtBox1.Text);

                average = (score1 + score2 + score3) / 3;

                if (average > 95)
                {
                    MessageBox.Show("Congratulation");
                }

                lblAverage.Text = average.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBox1.Text = "";
            txtBox2.Text = "";
            txtBox3.Text = "";
        }
    }
}
