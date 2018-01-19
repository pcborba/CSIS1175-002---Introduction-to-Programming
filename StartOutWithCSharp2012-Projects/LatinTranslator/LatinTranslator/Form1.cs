using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatinTranslator
{
    public partial class latintransForm : Form
    {
        public latintransForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            leftLabel.Visible = true;
            leftLabel.Text = "Sinister";
            centerLabel.Text = "";
            rightLabel.Text = "";
        }

        private void centerButton_Click(object sender, EventArgs e)
        {
            centerLabel.Visible = true;
            leftLabel.Text = "";
            centerLabel.Text = "Medium";
            rightLabel.Text = "";
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            rightLabel.Visible = true;
            leftLabel.Text = "";
            centerLabel.Text = "";
            rightLabel.Text = "Dexter";
        }
    }
}
