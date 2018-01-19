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


namespace avgfile
{
    public partial class frmAvgCalc : Form
    {
        public frmAvgCalc()
        {
            InitializeComponent();
        }

        private void btnAvg_Click(object sender, EventArgs e)
        {
            avgCalc();

        }

        private void avgCalc()
        {
            StreamReader fileQuiz = File.OpenText("c:\\temp\\studentQuiz.txt");


            string[] quiz = new string[4];
            string fmt = "{0,-20}{1,10}{2,10}{3,10}{4,10}{5,25:n2}";
            double smaller = 0;
            double smalleravg = 0;
            double avg = 0;
            double[] avgColect = new double[4];
            double avgGeneral = 0;

            lstResult.Items.Clear();
            lstResult.Items.Add(string.Format(fmt, "Student", "Q1", "Q2", "Q3", "Q4", "Best Avg 3 of 4"));
            
            for (int i = 0; fileQuiz.EndOfStream != true; i++)
            {
                quiz[i] = fileQuiz.ReadLine();

                if (double.Parse(quiz[i].Split(' ')[1]) < double.Parse(quiz[i].Split(' ')[2]))
                {
                    smaller = double.Parse(quiz[i].Split(' ')[1]);
                }
                else
                {
                    smaller = double.Parse(quiz[i].Split(' ')[2]);
                }

                if (double.Parse(quiz[i].Split(' ')[3]) < smaller)
                {
                    smaller = double.Parse(quiz[i].Split(' ')[3]);
                }
                if (double.Parse(quiz[i].Split(' ')[4]) < smaller)
                {
                    smaller = double.Parse(quiz[i].Split(' ')[4]);
                }

                avg = ((double.Parse(quiz[i].Split(' ')[1]) + double.Parse(quiz[i].Split(' ')[2]) + double.Parse(quiz[i].Split(' ')[3]) + double.Parse(quiz[i].Split(' ')[4]) - smaller) / 3);

                lstResult.Items.Add(string.Format(fmt, quiz[i].Split(' ')[0], quiz[i].Split(' ')[1], quiz[i].Split(' ')[2], quiz[i].Split(' ')[3], quiz[i].Split(' ')[4], avg));
                avgColect[i] = avg;
            }

            if (avgColect[0] < avgColect[1])
            {
                smalleravg = avgColect[0];
            }
            else
            {
                smalleravg = avgColect[1];
            }

            if (avgColect[2] < smalleravg)
            {
                smalleravg = avgColect[2];
            }

            if (avgColect[3] < smalleravg)
            {
                smalleravg = avgColect[3];
            }

            avgGeneral = (avgColect[0] + avgColect[1] + avgColect[2] + avgColect[3] - smalleravg) / 3;

            lstResult.Items.Add(" ");
            lstResult.Items.Add("The best general avg among students is =>  " + avgGeneral);

            fileQuiz.Close();

        }




    }
}
