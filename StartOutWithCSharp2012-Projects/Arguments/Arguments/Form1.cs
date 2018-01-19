using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arguments
{
    public partial class frmArgument : Form
    {
        public frmArgument()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DisplayValue(int value)
        {
            MessageBox.Show(value.ToString());
        }

        private void btnDemo1_Click(object sender, EventArgs e)
        {
            DisplayValue(int.Parse("1"));
        }

        private void btnDemo2_Click(object sender, EventArgs e)
        {
            for (int count = 0; count < 5; count++ )
            {
                DisplayValue(count);
            }
        }

        private void btnDemo3_Click(object sender, EventArgs e)
        {
            DisplayValue(3 * 4);
        }
    }
}
