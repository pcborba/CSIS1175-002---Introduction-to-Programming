using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresidentialTriviaFo
{
    public partial class presidentialForm : Form
    {
        public presidentialForm()
        {
            InitializeComponent();
        }

        private void presidentialForm_Load(object sender, EventArgs e)
        {

        }

        private void answerLabel_Click(object sender, EventArgs e)
        {

        }

        private void showAnswerButton_Click(object sender, EventArgs e)
        {
            answerLabel.Text = "Theodore Roosevelt";
        }
    }
}
