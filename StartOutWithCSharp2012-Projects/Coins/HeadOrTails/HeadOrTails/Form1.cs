using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeadOrTails
{
    public partial class frmHeadOrTails : Form
    {
        public frmHeadOrTails()
        {
            InitializeComponent();
        }

        private void btnHead_Click(object sender, EventArgs e)
        {
            picTail.Visible = false;
            picHead.Visible = true;
        }

        private void btnTail_Click(object sender, EventArgs e)
        {
            picHead.Visible = false;
            picTail.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            picHead.Visible = false;
            picTail.Visible = false;
            int toss;
            Random ran = new Random();

            toss = ran.Next(2);

            if (toss == 0)
            {
                picHead.Visible = true;
            }
            else
            {
                picTail.Visible = true;
            }

            

        }
    }
}
