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

namespace assignment3solution
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] IDs = new string[99]; //assume you have 100 customers
        string[] Names = new string[99]; // assume you have 100 customers
        int count = 0; //count the # of customers

        private void BTNresult_Click(object sender, EventArgs e)
        {
            string fmt = "{0,-20}{1,8}{2,12:d}{3,16}{4,30}{5,10}{6,7:n}{7,12:c2}";

            string[] myFile = File.ReadAllLines("c:\\temp\\as3data.csv");
            var myQuery = from myData in myFile
                          let col = myData.Split(',')
                          let id = col[0]
                          let invoice = col[1]
                          let invDate = DateTime.Parse(col[2])
                          let bikeType = col[3]
                          let accType = col[4]
                          let insType = col[5]
                          let hrs = decimal.Parse(col[6])
                          orderby int.Parse(id), invDate
                          select new { id, invoice, invDate, bikeType, accType, insType, hrs };
           
            //convert id to string type in orderby statement, not in the let statement

            LSTresult.Items.Clear();

            string prevID = "";
            bool firstRec = true;
            string custName = "";
            decimal subTotal = 0, grandTotal = 0;

            foreach (var rec in myQuery)
            {
                getName(rec.id, ref custName);

                Rental myRental = new Rental(rec.bikeType, rec.accType, rec.insType, rec.hrs);

                if(firstRec)
                {
                    firstRec = false;
                    prevID = rec.id;
                    LSTresult.Items.Add(string.Format(fmt,
                  custName + rec.id, rec.invoice, rec.invDate, myRental.bType, myRental.aType, myRental.iType, rec.hrs, myRental.Amt));
                    subTotal = myRental.Amt;
                    grandTotal = myRental.Amt;

                }
                else
                {
                    if(prevID==rec.id)
                    {
                        LSTresult.Items.Add(string.Format(fmt,
                  "", rec.invoice, rec.invDate, myRental.bType, myRental.aType, myRental.iType, rec.hrs, myRental.Amt));
                        subTotal = subTotal + myRental.Amt;
                        grandTotal = grandTotal + myRental.Amt;
                    }
                    else
                    {
                        LSTresult.Items.Add("sub-total is " + subTotal.ToString("c"));
                        LSTresult.Items.Add("");
                        subTotal = myRental.Amt;
                        grandTotal = grandTotal + myRental.Amt;
                        prevID = rec.id;
                        LSTresult.Items.Add(string.Format(fmt,
                  custName + rec.id, rec.invoice, rec.invDate, myRental.bType, myRental.aType, myRental.iType, rec.hrs, myRental.Amt));


                    }
                }
            }
            LSTresult.Items.Add("sub-total is " + subTotal.ToString("c"));
            LSTresult.Items.Add("grand-total is " + grandTotal.ToString("c"));


        }

        private void getName(string id, ref string name)
        {
            for (int x = 0; x<count;x++)
            {
                if (id==IDs[x])
                {
                    name = Names[x] + " ";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader inFile = File.OpenText("c:\\temp\\as3customers.csv");
            string[] customer;
            while (inFile.EndOfStream!=true)
            {
                customer = inFile.ReadLine().Split(',');
                Names[count] = customer[0];
                IDs[count] = customer[1];
                count++;
            }
            inFile.Close();
        }
    }
}
