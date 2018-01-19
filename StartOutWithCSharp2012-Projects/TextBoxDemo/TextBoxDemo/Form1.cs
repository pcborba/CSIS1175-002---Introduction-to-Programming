using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBoxDemo
{
    public partial class frmTxtBox : Form
    {
        public frmTxtBox()
        {
            InitializeComponent();
        }

        private void btnReadInput_Click(object sender, EventArgs e)
        {
            lblOutput.Text = txtName.Text;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
