using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FullName
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFull_Click(object sender, EventArgs e)
        {
            lblFull.Text = fullName(txtFirst.Text, txtMidle.Text, txtLast.Text);
        }

        private string fullName (string first, string midle, string last)
        {
            return first + " " + midle + " " + last;
        }
    }
}
