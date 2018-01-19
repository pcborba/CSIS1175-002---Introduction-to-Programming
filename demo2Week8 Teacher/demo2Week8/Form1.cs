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

namespace demo2Week8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // stationList can be asscessible 
        // throughout the entire program
        string[] stationList = new string[7];
        private void button1_Click(object sender, EventArgs e)
        {
            string[] names = new string[4];
            names[0] = "Simon";
            names[1] = "Ray";
            names[2] = "Nelson";
            names[3] = "Sarah";

            /* for(int x = 0;x<=3;x++)
             {
                 lstNames.Items.Add(names[x]);
             }
             */
            int x = 0;
            while(x <=3)
            {
                lstNames.Items.Add(names[x]);
                x++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader inFile = File.OpenText("c:\\temp\\samplerichmond.txt");
            string[] stationList = new string[6];
            int x = 0;  //pointer for the array element
            while (inFile.EndOfStream!=true)
            {
                stationList[x] = inFile.ReadLine();
                lstNames.Items.Add(stationList[x]);
                x++;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StreamReader inFile = File.OpenText("c:\\temp\\quizscores.txt");
            int[] scores = new int[12];
            int x =  0;
            int max=0, min=100;
            while (inFile.EndOfStream!=true)
            {
                scores[x] = int.Parse(inFile.ReadLine());
                x++;
            }
            for (int xx =0; xx<=11; xx++)
            {
                if (scores[xx]> max)
                { max = scores[xx]; }

                if (scores[xx] < min)
                {
                    min = scores[xx];
                }
            }
            MessageBox.Show("Max is " + max);
            MessageBox.Show("Min is " + min);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] names = new string[4];
            names[0] = "Simon";
            names[1] = "Ray";
            names[2] = "Nelson";
            names[3] = "Sarah";

            foreach(string name in names)
            {
                lstNames.Items.Add(name);
            }
            //resize the array to have 2 elements only

            names = new string[5];
            foreach (string newname in names)
            {
                //crash because of the null value
                lstNames.Items.Add(newname);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string station;
            int x = 0; //pointer for the array
            StreamReader inFile = File.OpenText("c:\\temp\\samplerichmond.txt");
            while(inFile.EndOfStream!=true)
            {
                station = inFile.ReadLine();
                lstStart.Items.Add(station);
                lstEnd.Items.Add(station);
                stationList[x] = station;
                x++;  //increase the pointer
            }
            inFile.Close();
          
        }

        private void btnRoute_Click(object sender, EventArgs e)
        {
            int startPt = 0, endPt = 0;
            if (lstStart.Text == lstEnd.Text)
            {
                MessageBox.Show("Please pick a different station");
            }
            for (int x =0; x <=6; x++)
            {
                if(lstStart.Text == stationList[x])
                {
                    startPt = x;
                }
                if (lstEnd.Text == stationList[x])
                {
                    endPt = x;
                }
            }
            lstRoute.Items.Clear();
            MessageBox.Show(startPt.ToString());
            if (startPt < endPt)
            {
                for (int y = startPt; y <= endPt; y++)
                {
                    lstRoute.Items.Add(stationList[y]);
                }
            }
           else  //startPt > endPt
            {
                for (int yy = startPt; yy>= endPt; yy--)
                {
                    lstRoute.Items.Add(stationList[yy]);
                }
            }
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //string[] names = new string[5];
            List<string> names = new List<string>() { "Simon","Ray"};

            foreach(string name in names)
            {
                lstNames.Items.Add(name);
            }

            lstNames.Items.Add(" ");
            names.Add("Victor");
            names.Add("Sarah");

            foreach (string newname in names)
            {
                lstNames.Items.Add(newname);
            }

            names.Remove("Ray");

            lstNames.Items.Add(" ");
          

            foreach (string newname in names)
            {
                lstNames.Items.Add(newname);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            List<int> values = new List<int>() { 9, 3, 5, 6, 10, 2 };
            MessageBox.Show("max is " + values.Max());
            MessageBox.Show("min is " + values.Min());
            MessageBox.Show(values.Sum() + " is the total");

        }
    }
}
