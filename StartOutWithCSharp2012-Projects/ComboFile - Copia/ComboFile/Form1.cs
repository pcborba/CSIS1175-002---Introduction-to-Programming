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
            string fmt = "{0,-15}{1,15}{2,12}{3,8}{4,5}";

            listBox1.Items.Clear();
            listBox1.Items.Add(string.Format(fmt, "Cust ID", "Begin Date", "Duration", "GPS", "Duration"));

            customIDrentals = inputFile.ReadLine().Split(',');
            customID = comboBox1.SelectedItem.ToString().Split(' ');

            do 

     
    }
}
            
        

