using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberMsgBox
{
    public partial class frmNumbers : Form
    {
        public frmNumbers()
        {
            InitializeComponent();
        }

        private void pic1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1");
        }

        private void pic2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("2");
        }

        private void pic3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("3");
        }

        private void pic4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("4");
        }

        private void pic5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("5");
        }
    }
}
