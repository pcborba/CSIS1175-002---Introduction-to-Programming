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

namespace AS3pauloborba_v0_2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            string[] dbCustomers = File.ReadAllLines("c:\\temp\\AS3customers.csv");
            string[] dbData = File.ReadAllLines("c:\\temp\\AS3Data.csv");
            string fmt = "{0,-21}{1,8}{2,14:d}{3,15}{4,27}{5,12}{6,6}{7,12:c}";


            var myQuery = from aa in dbData
                          let col = aa.Split(',')
                          let custId = int.Parse(col[0])
                          let inv = col[1]
                          let rentD = DateTime.Parse(col[2])
                          let bikeT = col[3]
                          let access = col[4]
                          let insur = col[5]
                          let hours = Double.Parse(col[6])
                          orderby custId, rentD
                          select new
                          {
                              custId,
                              inv,
                              rentD,
                              bikeT,
                              access,
                              insur,
                              hours,
                          };

            bool firstReg = true;
            int prevId = 0;
            double subTotal = 0;
            double total = 0;

            foreach (var reg in myQuery)
            {
                Rental myRental = new Rental(reg.bikeT, reg.access, reg.insur, reg.hours);
                if (firstReg == true)
                {
                    lstResult.Items.Clear();
                    lstResult.Items.Add(string.Format(fmt, "Customer Name & ID", "Inv #", "Rental Date", "Bike Type", "Accessories", "Insured", "Hrs", "Charge"));
                    firstReg = false;
                    prevId = reg.custId;
                    for(int i = 0; i < dbCustomers.Length; i++)
                    {
                        string[] custInfo = dbCustomers[i].Split(',');
                        if (reg.custId==int.Parse(custInfo[1]))
                        {
                            lstResult.Items.Add(string.Format(fmt, custInfo[0]+" "+reg.custId, reg.inv, reg.rentD, myRental.BikeType, myRental.Accessories, myRental.Insurrance, reg.hours, myRental.Charge));
                        }
                    }
                    subTotal = subTotal + myRental.Charge;
                }
                else
                {
                    if (prevId==reg.custId)
                    {
                        lstResult.Items.Add(string.Format(fmt, " ", reg.inv, reg.rentD, myRental.BikeType, myRental.Accessories, myRental.Insurrance, reg.hours, myRental.Charge));
                        subTotal = subTotal + myRental.Charge;
                    }
                    else
                    {
                        total = total + subTotal;
                        lstResult.Items.Add(string.Format(fmt, "", "", "", "", "", "", "", "---------"));
                        lstResult.Items.Add(string.Format(fmt, "", "", "", "", "", "Sub-Total", "", subTotal));
                        lstResult.Items.Add("");
                        subTotal = 0;
                        prevId = reg.custId;
                        for (int i = 0; i < dbCustomers.Length; i++)
                        {
                            string[] custInfo = dbCustomers[i].Split(',');
                            if (reg.custId == int.Parse(custInfo[1]))
                            {
                                lstResult.Items.Add(string.Format(fmt, custInfo[0] + " " + reg.custId, reg.inv, reg.rentD, myRental.BikeType, myRental.Accessories, myRental.Insurrance, reg.hours, myRental.Charge));
                            }
                        }
                        subTotal = subTotal + myRental.Charge;
                    }
                }
            }
            total = total + subTotal;
            lstResult.Items.Add(string.Format(fmt, "", "", "", "", "", "", "", "---------"));
            lstResult.Items.Add(string.Format(fmt, "", "", "", "", "", "Sub-Total", "", subTotal));
            lstResult.Items.Add("");
            lstResult.Items.Add(string.Format(fmt, "", "", "", "", "", "Grand Total", "", total));
        }
    }
}
