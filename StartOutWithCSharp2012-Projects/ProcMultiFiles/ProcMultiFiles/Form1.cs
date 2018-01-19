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

namespace ProcMultiFiles
{
    public partial class frmPrcMultiFiles : Form
    {
        public frmPrcMultiFiles()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            StreamReader inputFile = File.OpenText("CustomersRentals.txt");
            string fmt = "{0,-12}{1,12}{2,16}{3,16}";
            string[] customerRental;
            string[] customerId = cboCustomers.SelectedItem.ToString().Split(' ');
            int count = 0;
            string gps = "";
            string insurance = "";

            lstDisplay.Items.Clear();
            lstDisplay.Items.Add(string.Format(fmt, "Start Date", "Return Date", "Insurance", "GPS"));
            lstDisplay.Items.Add(" ");

            while (!inputFile.EndOfStream)
            {
                customerRental = inputFile.ReadLine().Split(',');

                //MessageBox.Show(customerRental[0]);
                //MessageBox.Show(customerId[2]);

                if (customerRental[0] == customerId[2])
                {
                    if (customerRental[3] == "I")
                    {
                        gps = "Insurance needed";
                    }
                    else
                    {
                        gps = "No Insurance";
                    }

                    if (customerRental[4] == "I")
                    {
                        insurance = "GPS required";
                    }
                    else
                    {
                        insurance = "No GPS";
                    }

                    DateTime returnDate = DateTime.Parse(customerRental[1]);
                    lstDisplay.Items.Add(string.Format(fmt, customerRental[1], returnDate.AddDays(int.Parse(customerRental[2])).ToString("MM/dd/yyyy"), gps, insurance));
                    count++;
                }
            }

            if (count==0)
            {
                lstDisplay.Items.Clear();
                lstDisplay.Items.Add("Sorry, no rental record found!!");
            }
        }

        private void frmPrcMultiFiles_Load(object sender, EventArgs e)
        {
            StreamReader inputFile = File.OpenText("Customers.txt");

            while (!inputFile.EndOfStream)
            {
                string[] customersID = inputFile.ReadLine().Split(',');
                cboCustomers.Items.Add(customersID[0]+" "+customersID[1]);
            }
        }
    }
}
