using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RangeCheck
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

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int value;
            value = int.Parse(txtValue.Text);

            if (value>0 && value<10)
            {
                MessageBox.Show("OK");
            }
            else
            { 
            MessageBox.Show("Não OK");
            }
        }
    }
}
