using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirthDateStrFrm
{
    public partial class frmBirth : Form
    {
        public frmBirth()
        {
            InitializeComponent();
        }

        private void btnShowDate_Click(object sender, EventArgs e)
        {
            string output;

            output = txtDayofWeek.Text + ", " + txtMonth.Text + " " + txtDayOfMonth.Text + ", " + txtYear.Text;

            lblDateOutput.Text = output;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDayofWeek.Text = "";
            txtMonth.Text = "";
            txtDayOfMonth.Text = "";
            txtYear.Text = "";

            lblDateOutput.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
