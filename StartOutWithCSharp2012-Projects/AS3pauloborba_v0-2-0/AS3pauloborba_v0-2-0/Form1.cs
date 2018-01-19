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

namespace AS3pauloborba_v0_2_0
{
    public partial class frmAssignment3 : Form
    {
        public frmAssignment3()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            string[] dbCustormer = File.ReadAllLines("c:\\temp\\AS3customers.csv");
            string[] dbData = File.ReadAllLines("c:\\temp\\AS3data.csv");
            string fmt = "{0,-20}{1,8}{2,14:d}{3,15}{4,28}{5,12}{6,6}{7,12:c}";

            var myQuery = from row in dbData
                          let col = row.Split(',')
                          let custId = int.Parse(col[0])
                          let invoice = int.Parse(col[1])
                          let rentD = DateTime.Parse(col[2])
                          let bikeT = col[3]
                          let access = col[4]
                          let insur = col[5]
                          let hours = double.Parse(col[6])
                          orderby custId, rentD
                          select new
                          {
                              custId,
                              invoice,
                              rentD,
                              bikeT,
                              access,
                              insur,
                              hours,
                          };
            double subtotal = 0;
            double total = 0;
            bool firstReg = true;
            int prevId = 0;
            string custName = "";

            lstResult.Items.Clear();
            
            foreach (var r in myQuery)
            {
                Rental myRent = new Rental(r.access, r.bikeT, r.insur, r.hours);
                if (firstReg==true)
                {
                    prevId = r.custId;
                    firstReg = false;
                    lstResult.Items.Add(string.Format(fmt, "Customer Name & ID", "Inv #", "Rental Date", "Bike Type", "Accessories", "Insured", "Hrs", "Charge"));
                    for (int i =0; i < dbCustormer.Length; i++)
                    {
                        string[] custInfo = dbCustormer[i].Split(',');
                        if (custInfo[1]==r.custId.ToString())
                        {
                            custName = custInfo[0];
                        }
                    }
                    lstResult.Items.Add(string.Format(fmt, custName+" "+r.custId, r.invoice, r.rentD, myRent.Bike, myRent.Accessory, myRent.Insurance, r.hours, myRent.Charge));
                    subtotal = subtotal + myRent.Charge;
                }
                else
                {
                    if (prevId==r.custId)
                    {
                        lstResult.Items.Add(string.Format(fmt,"", r.invoice, r.rentD, myRent.Bike, myRent.Accessory, myRent.Insurance, r.hours, myRent.Charge));
                        subtotal = subtotal + myRent.Charge;
                    }
                    else
                    {
                        lstResult.Items.Add(string.Format(fmt, "", "", "", "", "", "", "", "---------"));
                        lstResult.Items.Add(string.Format(fmt, "", "", "", "", "", "Sub-total", "", subtotal));
                        lstResult.Items.Add("");
                        total = total + subtotal;
                        subtotal = 0;
                        prevId = r.custId;
                        for (int i = 0; i < dbCustormer.Length; i++)
                        {
                            string[] custInfo = dbCustormer[i].Split(',');
                            if (custInfo[1] == r.custId.ToString())
                            {
                                custName = custInfo[0];
                            }
                        }
                        lstResult.Items.Add(string.Format(fmt, custName + " " + r.custId, r.invoice, r.rentD, myRent.Bike, myRent.Accessory, myRent.Insurance, r.hours, myRent.Charge));
                        subtotal = subtotal + myRent.Charge;
                    }
                }
            }
            total = total + subtotal;
            lstResult.Items.Add(string.Format(fmt, "", "", "", "", "", "", "", "---------"));
            lstResult.Items.Add(string.Format(fmt, "", "", "", "", "", "Sub-total", "", subtotal));
            lstResult.Items.Add("");
            lstResult.Items.Add(string.Format(fmt, "", "", "", "", "", "Total", "", total));
        }
    }
}
