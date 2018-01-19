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

namespace CompareString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal number;
            if (decimal.TryParse(txtInput.Text, out number))
            {
                MessageBox.Show("Success!");
            }
            else
            {
                MessageBox.Show("Enter a valid decimal.");
            }              
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                lblLstSelection.Text = "você selecionou ==>" + listBox1.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Você precisa selecionar uma das opções de salada de fruta");
                lblLstSelection.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = -1;
            lblLstSelection.Text = "";

        }

        private void btnNames_Click(object sender, EventArgs e)
        {

            string[] listBB;
            
            lblLstSelection.Text = "";
            MessageBox.Show(listBox1.Items.Count.ToString());
            
            listBox1.Items.Clear();
            listBox1.Items.Add("João");
            listBox1.Items.Add("Paulo");
            listBox1.Items.Add("Antonio");

        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            int count = 6;

            while (count <= 5)
            {
                MessageBox.Show("Hello");
                count += 1;
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            const decimal interestRate = 0.005m;

            listBox2.Items.Clear();
            decimal balance = decimal.Parse(txtStartingBalance.Text);
            int months = int.Parse(txtMonths.Text);
            int count = 1;
            string fmt = "{0,-15}{1,5}{2,15}";

            while (count <= months)
                    {
                        balance = balance + (balance * interestRate);
                        count++;
                listBox2.Items.Add(string.Format(fmt,"Balance on month  ", count.ToString() +" => " , balance.ToString("c2")));
                    }
                    lblEndingBalance.Text = balance.ToString("c2");
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            for (int kmph = 60; kmph <= 130; kmph = kmph+10)
            {
                lstSquare.Items.Add(kmph + "KM per hour is equal to " + kmph * 0.6214 + "MPH" );
            }

            

        }

        private void btnCreWri_Click(object sender, EventArgs e)
        {

            try
            {
                            
            StreamWriter outputfile;
            outputfile = File.CreateText("paulo.txt");

            for (int count = 0; count <= 10; count++)
                { 
                    outputfile.WriteLine(count);
                }
                MessageBox.Show("Feito");
                outputfile.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StreamWriter outputfile;
            outputfile = File.AppendText("paulo.txt");

            outputfile.WriteLine(txtAppend.Text);
            txtAppend.Text = "";

            outputfile.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StreamReader inputfile;
            inputfile = File.OpenText("paulo.txt");

            string result;

            result = inputfile.ReadLine();
            MessageBox.Show(result);
            result = inputfile.ReadLine();
            MessageBox.Show(result);
            result = inputfile.ReadLine();
            MessageBox.Show(result);
            result = inputfile.ReadLine();
            MessageBox.Show(result);
            result = inputfile.ReadLine();
            MessageBox.Show(result);
            result = inputfile.ReadLine();
            MessageBox.Show(result);
            result = inputfile.ReadLine();
            MessageBox.Show(result);
            result = inputfile.ReadLine();
            MessageBox.Show(result);
            result = inputfile.ReadLine();
            MessageBox.Show(result);
      

        }

    }
}
