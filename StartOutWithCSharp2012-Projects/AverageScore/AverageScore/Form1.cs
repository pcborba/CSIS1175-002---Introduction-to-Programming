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

namespace AverageScore
{
    public partial class frmAverage : Form
    {
        public frmAverage()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            StreamReader inputFile = File.OpenText("week5data1.txt");
            string fmt = "{0,-20}{1,18}{2,18}{3,18}{4,18}{5,18}";

            lstAverage.Items.Clear();
            lstAverage.Items.Add(string.Format(fmt, "Student", "Q1", "Q2", "Q3", "Q4", "Avg 3 out of 4"));
            lstAverage.Items.Add("");

            int count = 0;
            double amount = 0;

            while (!inputFile.EndOfStream)
            {
                string[] student = inputFile.ReadLine().Split(',');
                double q1, q2, q3, q4, avg;
                q1 = double.Parse(student[1]);
                q2 = double.Parse(student[2]);
                q3 = double.Parse(student[3]);
                q4 = double.Parse(student[4]);


                double smaller = q1;

                if (smaller > q2)
                {
                    smaller = q2;
                }
                if (smaller > q3)
                {
                    smaller = q3;
                }
                if (smaller > q4)
                {
                    smaller = q4;
                }

                //MessageBox.Show(smaller.ToString());

                avg = ((q1 + q2 + q3 + q4) - smaller) / 3;

                amount = amount + avg;
                count++;

                lstAverage.Items.Add(string.Format(fmt, student[0], q1.ToString("n2"), q2.ToString("n2"), q3.ToString("n2"), q4.ToString("n2"), avg.ToString("n2")));
            }



            lstAverage.Items.Add("");
            lstAverage.Items.Add("");
            lstAverage.Items.Add("Overall average is  " + (amount / count).ToString("n2"));
        }
    }
    }

