using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FieldDemoApp
{
    public partial class Form1 : Form
    {
        private string familiaNome = "Douglas";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowName_Click(object sender, EventArgs e)
        {
            MessageBox.Show(familiaNome);
            
        }

        private void btnNameChris_Click(object sender, EventArgs e)
        {

            familiaNome = "Chris";
            MessageBox.Show(familiaNome);
        }

        private void btnNameCarmem_Click(object sender, EventArgs e)
        {
            familiaNome = "Carmem";
            MessageBox.Show(familiaNome);
        }

    }
}
