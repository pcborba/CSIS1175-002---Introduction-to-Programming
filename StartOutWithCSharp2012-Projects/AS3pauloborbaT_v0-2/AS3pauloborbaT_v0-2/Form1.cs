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

namespace AS3pauloborbaT_v0_2
{
    public partial class Form1 : Form
    {

        string[] IDs = new string[99];
        string[] dbCustomer = new string[99];
        string custName = "";
        int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            string[] dbData = File.ReadAllLines("c:\\temp\\AS3data.csv");
            string fmt = "{0,-22}{1,9}{2,15:d}{3,15}{4,28}{5,9}{6,15:n2}{7,15:c}";
            string prevId = "";
            bool firstReg = true;
            double total = 0, subTotal = 0;

            var myQuery = from rows in dbData
                          let col = rows.Split(',')
                          let id = col[0]
                          let inv = col[1]
                          let rentD = DateTime.Parse(col[2])
                          let bikeT = col[3]
                          let access = col[4]
                          let insur = col[5]
                          let hrs = col[6]
                          orderby int.Parse(id), rentD
                          select new
                          {
                              id,
                              inv,
                              rentD,
                              bikeT,
                              access,
                              insur,
                              hrs,
                          };

            foreach(var reg in myQuery)
            {
                Rental myRent = new Rental(reg.bikeT, reg.access, reg.insur, double.Parse(reg.hrs));
                findName(reg.id, ref custName);

                if (firstReg==true)
                {
                    firstReg = false;
                    lstResult.Items.Add(string.Format(fmt, "Customer Name & ID", "Inv #", "Rental Date", "Bike Type", "Accessories", "Insurance", "Hours", "Charge"));
                    lstResult.Items.Add(string.Format(fmt, custName + reg.id, reg.inv, reg.rentD, myRent.BikeType, myRent.Accessories, myRent.Insurance, reg.hrs, myRent.Charge));
                    subTotal = myRent.Charge;
                    prevId = reg.id;
                }
                else
                {
                    if(prevId==reg.id)
                    {
                        lstResult.Items.Add(string.Format(fmt, "", reg.inv, reg.rentD, myRent.BikeType, myRent.Accessories, myRent.Insurance, reg.hrs, myRent.Charge));
                        subTotal = subTotal + myRent.Charge;
                    }
                    else
                    {
                        total = total + subTotal;
                        lstResult.Items.Add(string.Format(fmt, "", "", "", "", "", "", "", "---------"));
                        lstResult.Items.Add(string.Format(fmt, "", "", "", "", "", "Sub-Total", "", subTotal));
                        lstResult.Items.Add("");
                        prevId = reg.id;
                        subTotal = 0;
                        lstResult.Items.Add(string.Format(fmt, custName + reg.id, reg.inv, reg.rentD, myRent.BikeType, myRent.Accessories, myRent.Insurance, reg.hrs, myRent.Charge));
                        subTotal = subTotal + myRent.Charge;
                    }
                }
            }
            total = total + subTotal;
            lstResult.Items.Add(string.Format(fmt, "", "", "", "", "", "", "", "---------"));
            lstResult.Items.Add(string.Format(fmt, "", "", "", "", "", "Sub-Total", "", subTotal));
            lstResult.Items.Add("");
            lstResult.Items.Add(string.Format(fmt, "", "", "", "", "", "Grand-Total", "", total));

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader inFile = File.OpenText("c:\\temp\\AS3customers.csv");
            string[] custData;
            while (!inFile.EndOfStream)
            {
                custData = inFile.ReadLine().Split(',');
                IDs[count] = custData[1];
                dbCustomer[count] = custData[0];
                count++;
            }
            inFile.Close();
        }

        private void findName(string id, ref string name)
        {
            for(int i=0; i<count; i++)
            {
                if(id == IDs[i])
                {
                    name = dbCustomer[i]+" ";
                }
            }
        }
    }
}
