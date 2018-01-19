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

namespace AS3pauloborbaT_v0_6
{
    public partial class frmAssignment3 : Form
    {
        string[] IDs = new string[99];
        string[] custumersNames = new string[99];
        string custName = "";
        int count = 0;
        public frmAssignment3()
        {
            InitializeComponent();
        }

        private void frmAssignment3_Load(object sender, EventArgs e)
        {
            StreamReader dbCustomer = File.OpenText("c:\\temp\\AS3customers.csv");
            string[] custData;
            while(!dbCustomer.EndOfStream)
            {
                custData = dbCustomer.ReadLine().Split(',');
                IDs[count] = custData[1];
                custumersNames[count] = custData[0];
                count++;
            }
            dbCustomer.Close();
        }

        private void findCustName(string id, ref string name)
        {
            for (int i = 0; i < count; i++)
            {
                if (id == IDs[i])
                {
                    name = custumersNames[i]+" ";
                }
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string[] dbData = File.ReadAllLines("c:\\temp\\AS3data.csv");
            string fmt = "{0,-20}{1,7}{2,14:d}{3,18}{4,26}{5,13}{6,9:n1}{7,13:c}";
            string prevID = "";
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
                findCustName(reg.id, ref custName);
                Rental myRent = new Rental(reg.bikeT, reg.access, reg.insur, double.Parse(reg.hrs));
                if(firstReg==true)
                {
                    firstReg = false;
                    prevID = reg.id;
                    lstResult.Items.Add(string.Format(fmt, "Customer name & ID", "Inv #", "Rental Date", "Bike Type", "Accessories", "Insurance", "Hours", "Charge"));
                    lstResult.Items.Add(string.Format(fmt, custName+reg.id, reg.inv, reg.rentD, myRent.BikeType, myRent.Accessories, myRent.Insurance, reg.hrs, myRent.Charge));
                    subTotal = myRent.Charge;
                }
                else
                {
                    if(prevID == reg.id)
                    {
                        lstResult.Items.Add(string.Format(fmt, "", reg.inv, reg.rentD, myRent.BikeType, myRent.Accessories, myRent.Insurance, reg.hrs, myRent.Charge));
                        subTotal = subTotal + myRent.Charge;
                    }
                    else
                    {
                        total = total + subTotal;
                        prevID = reg.id;
                        lstResult.Items.Add(string.Format(fmt, "", "", "", "", "", "", "", "---------"));
                        lstResult.Items.Add(string.Format(fmt, "", "", "", "", "", "Sub-total", "", subTotal));
                        lstResult.Items.Add("");
                        subTotal = 0;
                        lstResult.Items.Add(string.Format(fmt, custName + reg.id, reg.inv, reg.rentD, myRent.BikeType, myRent.Accessories, myRent.Insurance, reg.hrs, myRent.Charge));
                        subTotal = subTotal + myRent.Charge;
                    }
                }
            }
            total = total + subTotal;
            lstResult.Items.Add(string.Format(fmt, "", "", "", "", "", "", "", "---------"));
            lstResult.Items.Add(string.Format(fmt, "", "", "", "", "", "Sub-total", "", subTotal));
            lstResult.Items.Add("");
            lstResult.Items.Add(string.Format(fmt, "", "", "", "", "", "", "", "---------"));
            lstResult.Items.Add(string.Format(fmt, "", "", "", "", "", "Grand-total", "", total));

        }
    }
}
