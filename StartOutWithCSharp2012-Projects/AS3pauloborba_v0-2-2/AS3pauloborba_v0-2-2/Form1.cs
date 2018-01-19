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

namespace AS3pauloborba_v0_2_2
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
            string[] dbData = File.ReadAllLines("c:\\temp\\AS3data.csv");
            string fmt = "{0,-21}{1,8}{2,14:d}{3,15}{4,27}{5,12}{6,6}{7,12:c}";

            var myQuery = from rows in dbData
                          let col = rows.Split(',')
                          let custId = int.Parse(col[0])
                          let inv = col[1]
                          let rentD = DateTime.Parse(col[2])
                          let bikeT = col[3]
                          let access = col[4]
                          let insur = col[5]
                          let hours = double.Parse(col[6])
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

            int prevId = 0;
            bool firstReg = true;
            double subTotal=0, total=0;

            lstResult.Items.Clear();
            foreach (var reg in myQuery)
            {
                Rental myRent = new Rental(reg.bikeT, reg.access, reg.insur, reg.hours);
                if (firstReg==true)
                {
                    lstResult.Items.Add(string.Format(fmt, "Customer Name & ID", "Inv #", "Rental Date", "Bike Type", "Accessories", "Insured", "Hrs", "Charge"));
                    firstReg = false;
                    prevId = reg.custId;
                    for (int i =0; i<dbCustomers.Length;i++)
                    {
                        string[] custInfo = dbCustomers[i].Split(',');
                        if(reg.custId==int.Parse(custInfo[1]))
                        {
                            lstResult.Items.Add(string.Format(fmt, custInfo[0] + " " + reg.custId, reg.inv, reg.rentD, myRent.BikeType, myRent.Accessories, myRent.Insurance, reg.hours, myRent.Charge));
                        }
                    }
                    subTotal = subTotal + myRent.Charge;
                }
                else
                {
                    if(reg.custId==prevId)
                    {
                        lstResult.Items.Add(string.Format(fmt, " ", reg.inv, reg.rentD, myRent.BikeType, myRent.Accessories, myRent.Insurance, reg.hours, myRent.Charge));
                        subTotal = subTotal + myRent.Charge;
                    }
                    else
                    {
                        lstResult.Items.Add(string.Format(fmt, "", "", "", "", "", "", "", "---------"));
                        lstResult.Items.Add(string.Format(fmt, "", "", "", "", "", "Sub-total", "", subTotal));
                        lstResult.Items.Add("");
                        total = total + subTotal;
                        subTotal = 0;
                        prevId = reg.custId;
                        for (int i = 0; i < dbCustomers.Length; i++)
                        {
                            string[] custInfo = dbCustomers[i].Split(',');
                            if (reg.custId == int.Parse(custInfo[1]))
                            {
                                lstResult.Items.Add(string.Format(fmt, custInfo[0] + " " + reg.custId, reg.inv, reg.rentD, myRent.BikeType, myRent.Accessories, myRent.Insurance, reg.hours, myRent.Charge));
                            }
                        }
                        subTotal = subTotal + myRent.Charge;
                    }
                }
            }
            lstResult.Items.Add(string.Format(fmt, "", "", "", "", "", "", "", "---------"));
            lstResult.Items.Add(string.Format(fmt, "", "", "", "", "", "Sub-total", "", subTotal));
            lstResult.Items.Add("");
            total = total + subTotal;
            lstResult.Items.Add(string.Format(fmt, "", "", "", "", "", "Grand total", "", total));
        }
    }
}
