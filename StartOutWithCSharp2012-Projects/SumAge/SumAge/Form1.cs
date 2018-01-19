using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SumAge
{
    public partial class frmSumAge : Form
    {
        public frmSumAge()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int age1, age2, sumAge;

            if (txtMyage.Text == "" && txtBestAge.Text == "")
            {
               MessageBox.Show("Informe os dados primeiro");
            }
            else
            {
                age1 = int.Parse(txtMyage.Text);
                age2 = int.Parse(txtBestAge.Text);
                sumAge = ageSum(age1, age2);
                lblCombined.Text = sumAge.ToString();
            }
        }

        private int ageSum (int age1, int age2)
        {
            return age1 + age2;
        }
    }
}
