using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joke
{
    public partial class frmPiada : Form
    {
        public frmPiada()
        {
            InitializeComponent();
        }

        private void btnPiada_Click(object sender, EventArgs e)
        {
            lblResposta.Text = "Como se come um elefante?";
        }

        private void btnResposta_Click(object sender, EventArgs e)
        {
            lblResposta.Text = "Dando uma colherada por vez";
        }
    }
}
