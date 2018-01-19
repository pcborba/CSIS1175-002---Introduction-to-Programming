using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheCat
{
    public partial class theCatForm : Form
    {
        public theCatForm()
        {
            InitializeComponent();
        }

        private void catPictureBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Meow");
        }
    }
}
