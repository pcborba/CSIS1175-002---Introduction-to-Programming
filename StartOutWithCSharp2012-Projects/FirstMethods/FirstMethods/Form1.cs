using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FirstMethods
{
    public partial class Methods : Form
    {
        public Methods()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is the btnShow_Click method.");
            DisplayMessage();
            MessageBox.Show("Back is the btnShow_Click method.");
        }

        private void DisplayMessage()
        {
            MessageBox.Show("This is the Displya Message Method");
        }
    }
}
