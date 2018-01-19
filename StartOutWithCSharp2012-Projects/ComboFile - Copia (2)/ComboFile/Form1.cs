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

namespace ComboFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader inputFile = File.OpenText("c:\\temp\\customers.txt");
            string[] customerID;

            while (!inputFile.EndOfStream)
            {
                customerID = inputFile.ReadLine().Split(',');
                comboBox1.Items.Add(customerID[0] + " " + customerID[1]);
            }
            inputFile.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            StreamReader inputFile = File.OpenText("c:\\temp\\CustomersRentals.txt");
            string[] customID;
            string[] customIDrentals;
            string fmt = "{0,-15}{1,10}{2,10}{3,10}{4,10}";

            listBox1.Items.Clear();
            listBox1.Items.Add(string.Format(fmt, "Cust ID", "Begin Date", "Duration", "GPS", "Duration"));

            int count = 0;

            while (!inputFile.EndOfStream)
            {
                customIDrentals = inputFile.ReadLine().Split(',');
                customID = comboBox1.SelectedItem.ToString().Split(' ');

                if (customID[2] == customIDrentals[0])
                {
                    listBox1.Items.Add(string.Format(fmt, customIDrentals[0], customIDrentals[1], customIDrentals[2], customIDrentals[3], customIDrentals[4]));
                    count++;
                }
                
            }

            if (count == 0)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("There is no register for this customer");
            }


        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            StreamReader inputFile = File.OpenText("c:\\temp\\week5data1.txt");
            string fmt = "{0,-20}{1,15}{2,15}{3,15}{4,15}{5,15}";

            listBox1.Items.Clear();
            listBox1.Items.Add(string.Format(fmt, "Student", "Q1", "Q2", "Q3", "Q4", "Avg 3 out of 4"));

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

                listBox1.Items.Add(string.Format(fmt, student[0], q1.ToString("n2"), q2.ToString("n2"), q3.ToString("n2"), q4.ToString("n2"), avg.ToString("n2")));
            }

            

            listBox1.Items.Add("");
            listBox1.Items.Add("");
            listBox1.Items.Add("Overall average is  "+(amount/count).ToString("n2"));
        }
    }
}
            
        

