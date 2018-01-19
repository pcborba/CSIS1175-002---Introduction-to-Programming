using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassByRef
{
    public partial class frmPass : Form
    {
        public frmPass()
        {
            InitializeComponent();
        }

        private void SetToZero(ref int number)
        {
            number = 0;
        }
        private void btnGo_Click(object sender, EventArgs e)
        {
            int x = 100, y = 101, z = 102;

            lstOutput.Items.Clear();
            lstOutput.Items.Add("x is set to "+x);
            lstOutput.Items.Add("y is set to " + y);
            lstOutput.Items.Add("z is set to " + z);

            SetToZero(ref x);
            SetToZero(ref y);
            SetToZero(ref z);
            lstOutput.Items.Add("");
            lstOutput.Items.Add("x is set to " + x);
            lstOutput.Items.Add("y is set to " + y);
            lstOutput.Items.Add("z is set to " + z);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
