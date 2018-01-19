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

namespace demo2Week11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cboCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            //create an object called myCustomer that is based
            //on the Customer class
            //passing the selectd item on the combobox to the 
            //class constructor
            Customer myCustomer = 
                new Customer(cboCustomer.SelectedItem.ToString());

            MessageBox.Show(myCustomer.getID);
            MessageBox.Show(myCustomer.getFullName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader inFile = File.OpenText(
                "c:\\temp\\staffinfo.csv");
            string[] info;
            string fmt = "{0,-10}{1,10}{2,10}{3,12}{4,6}{5,10}";
            while(inFile.EndOfStream!=true)
            {
                info = inFile.ReadLine().Split(',');
                lstResult.Items.Add(string.Format(fmt,
                    info[0], info[1], info[2], info[3], 
                    info[4], info[5]));
            }
            inFile.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //using LINQ for file processing
            string[] myStaff=File.ReadAllLines("c:\\temp\\staffinfo.csv");

            //creating a query called myQuery
            var myQuery = from eachRow in myStaff
                          let col = eachRow.Split(',')
                          let id = col[0]
                          let firstName = col[1]
                          let lastName = col[2]
                          let dob = DateTime.Parse(col[3])
                          let degree = col[4]
                          let college = col[5]
                          orderby dob descending
                          select new
                          {
                              id,
                              firstName,
                              lastName,
                              dob,
                              degree,
                              college
                          };

            lstResult.Items.Clear();
            string fmt = "{0,-10}{1,10}{2,10}{3,12:d}{4,6}{5,10}";

            foreach(var record in myQuery)
            {
                lstResult.Items.Add(string.Format(fmt,
                    record.id, record.firstName, record.lastName,
                    record.dob, record.degree, record.college));
            }


        }
    }
}
