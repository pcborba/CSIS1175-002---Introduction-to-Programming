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

namespace Demo2Week11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cboCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Create an object called myCustomer that is based
            //on the Customer class
            //passing the selected item on the combobox to the
            //class constructor
            Customer myCustomer = new Customer(cboCustomer.SelectedItem.ToString());
            MessageBox.Show(myCustomer.getID);
            MessageBox.Show(myCustomer.getFullName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstResult.Items.Clear();
            StreamReader inFile = File.OpenText("c:\\temp\\StaffInfo.csv");
            string fmt = "{0,-10}{1,10}{2,10}{3,12}{4,6}{5,10}";

            string[] info;

            while(!inFile.EndOfStream)
            {
                info = inFile.ReadLine().Split(',');
                lstResult.Items.Add(string.Format(fmt, info[0], info[1], info[2], info[3], info[4], info[5]));
            }
            inFile.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fmt = "{0,-10}{1,10}{2,10}{3,12:d}{4,6}{5,10}";
            //using LINQ for file processing
            string[] myStaff = File.ReadAllLines("c:\\temp\\StaffInfo.csv");
            //creating a query called myQuery
            var myQuery = from abcEachRow in myStaff
                          let colunas = abcEachRow.Split(',')
                          let id = colunas[0]
                          let firstName = colunas[1]
                          let lastName = colunas[2]
                          let birthDate = DateTime.Parse(colunas[3])
                          let degree = colunas[4]
                          let college = colunas[5]
                          orderby birthDate descending
                          select new
                          {
                              id, firstName, lastName, birthDate, degree, college };
            lstResult.Items.Clear();
            
            foreach(var _12 in myQuery)
            {
                lstResult.Items.Add(string.Format(fmt, _12.id, _12.firstName, _12.lastName, _12.birthDate, _12.degree, _12.college));
            }
        }
    }
}
