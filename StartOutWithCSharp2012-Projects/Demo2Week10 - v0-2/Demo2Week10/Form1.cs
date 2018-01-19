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

namespace Demo2Week10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

 
        private void btnAvg_Click(object sender, EventArgs e)
        {
            double v1 = double.Parse(txtQ1.Text);
            double v2 = double.Parse(txtQ2.Text);
            double v3 = double.Parse(txtQ3.Text);
            double v4 = double.Parse(txtQ4.Text);

            Quiz myQuiz = new Quiz(v1,v2, v3, v4);

            lblResult.Text="Best avg is " + myQuiz.Avg().ToString("n2");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader infile = File.OpenText("quiz.txt");

            double[] quiz = new double[4];

            for (int i = 0; !infile.EndOfStream; i++ )
            {
                quiz[i] = double.Parse(infile.ReadLine());
            }

            txtQ1.Text = quiz[0].ToString();
            txtQ2.Text = quiz[1].ToString();
            txtQ3.Text = quiz[2].ToString();
            txtQ4.Text = quiz[3].ToString();

            Quiz myQuiz = new Quiz(quiz[0], quiz[1], quiz[2], quiz[3]);

            lblResult.Text = "Best avg is " + myQuiz.Avg().ToString("n2");
        }
    }
}
