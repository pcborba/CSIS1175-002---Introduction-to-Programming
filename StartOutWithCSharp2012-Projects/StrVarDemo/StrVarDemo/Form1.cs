using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StrVarDemo
{
    public partial class frmStrVarDemo : Form
    {
        public frmStrVarDemo()
        {
            InitializeComponent();
        }

        private void btnShowName_Click(object sender, EventArgs e)
        {
            string fullName;

            fullName = txtFirstName.Text + " " + txtLastName.Text;

            lblFullName.Text = fullName;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
