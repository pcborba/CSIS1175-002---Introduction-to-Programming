using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoClass1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMsg_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to C# Programming");
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            btnMsg.BackColor = Color.Blue;
            this.BackColor = Color.Beige;
        }

        private void btnImg_Click(object sender, EventArgs e)
        {
            // \\ means \
            picFish.ImageLocation = "c:\\temp\\lighthouse.jpg";
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            picFish.ImageLocation="c:\\temp\\jellyfish.jpg";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtName.Text + ", welcome to CSIS1175");
        }
    }
}
