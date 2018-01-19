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

namespace WorkWithFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            try
            {
                string countryName;
                StreamReader inputFile;

                inputFile = File.OpenText("countries.txt");

                lstCountries.Items.Clear();

                while (!inputFile.EndOfStream)
                {
                    countryName = inputFile.ReadLine();
                    lstCountries.Items.Add(countryName);
                }
                inputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAcu_Click(object sender, EventArgs e)
        {
            decimal incBalance = 0m, amtBalance = 0m;
            StreamReader inputfile = File.OpenText("sales.txt");

            string fmt = "{0,-20 }{1,10}";

            lstCountries.Items.Clear();

            while (!inputfile.EndOfStream)
            {
                incBalance = decimal.Parse(inputfile.ReadLine());
                lstCountries.Items.Add(string.Format(fmt, "Value add  ", incBalance.ToString("c2")));
                amtBalance = amtBalance + incBalance;
                
            }

            lstCountries.Items.Add("");
            lstCountries.Items.Add(string.Format(fmt, "Total value add  ", amtBalance.ToString("c2")));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter outputfile;

            openFileDialog1.InitialDirectory = "C:\\temp";



            if (openFileDialog1.ShowDialog() == DialogResult.OK) 
            {

                outputfile = File.CreateText(openFileDialog1.FileName+".txt");

            }
            else
            {
                

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string countryName;

                StreamReader inputfile;

                inputfile = File.OpenText("countries.txt");

                while (!inputfile.EndOfStream)
                {
                    countryName = inputfile.ReadLine();
                    lstCountries.Items.Add(countryName);
                }
                inputfile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
