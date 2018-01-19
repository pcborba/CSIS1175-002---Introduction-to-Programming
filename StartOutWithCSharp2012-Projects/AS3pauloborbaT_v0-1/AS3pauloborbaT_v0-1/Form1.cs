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

namespace AS3pauloborbaT_v0_1
{
    public partial class frmAssignment3 : Form
    {
        public frmAssignment3()
        {
            InitializeComponent();
        }

        string[] iD = new string[99];
        string[] customerName = new string[99];
        int count = 0;
        string custName ="";

        private void btnResult_Click(object sender, EventArgs e)
        {
            string[] dbData = File.ReadAllLines("c:\\temp\\AS3data.csv");
            string fmt = "{0,-21}{1,9}{2,13:d}{3,15}{4,25}{5,15}{6,12:n2}{7,12:c}";
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

            bool firstReg = true;
            string prevId = "";
            double subtotal = 0, total = 0;

            foreach (var reg in myQuery)
            {
                Rental myRent = new Rental(reg.bikeT, reg.access, reg.insur, double.Parse(reg.hrs));
                findCustomer(reg.id, ref custName);

                if (firstReg==true)
                {
                    firstReg = false;
                    prevId = reg.id;
                    lstResult.Items.Add(string.Format(fmt, "Customer Name & ID", "Inv #", "Rental Date", "Bike Type", "Accessories", "Insured", "Hours", "Charge"));
                    lstResult.Items.Add(string.Format(fmt, custName+reg.id, reg.inv, reg.rentD, myRent.BikeType, myRent.Accessories, myRent.Insurance, reg.hrs, myRent.Charge));
                    subtotal = subtotal + myRent.Charge;
                }
                else
                {
                    if(prevId==reg.id)
                    {
                        lstResult.Items.Add(string.Format(fmt, "", reg.inv, reg.rentD, myRent.BikeType, myRent.Accessories, myRent.Insurance, reg.hrs, myRent.Charge));
                        subtotal = subtotal + myRent.Charge;
                    }
                    else
                    {
                        prevId = reg.id;
                        lstResult.Items.Add(string.Format(fmt, "", "", "", "", "", "", "", "---------"));
                        lstResult.Items.Add(string.Format(fmt, "", "", "", "", "", "Sub-Total", "", subtotal));
                        lstResult.Items.Add("");
                        total = total + subtotal;
                        subtotal = 0;
                        lstResult.Items.Add(string.Format(fmt, custName + reg.id, reg.inv, reg.rentD, myRent.BikeType, myRent.Accessories, myRent.Insurance, reg.hrs, myRent.Charge));
                        subtotal = subtotal + myRent.Charge;
                    }
                }
            }
            lstResult.Items.Add(string.Format(fmt, "", "", "", "", "", "", "", "---------"));
            lstResult.Items.Add(string.Format(fmt, "", "", "", "", "", "Sub-Total", "", subtotal));
            lstResult.Items.Add("");
            total = total + subtotal;
            lstResult.Items.Add(string.Format(fmt, "", "", "", "", "", "Grand-Total", "", total));


        }

        private void frmAssignment3_Load(object sender, EventArgs e)
        {
            StreamReader customer = File.OpenText("c:\\temp\\AS3customers.csv");
            string[] custData;
            while (!customer.EndOfStream)
            {
                custData = customer.ReadLine().Split(',');
                iD[count] = custData[1];
                customerName[count] = custData[0];
                count++;
            }
            customer.Close();
        }

        private void findCustomer(string id, ref string name)
        {
            for (int i = 0; i < count; i++)
            {
                if(id==iD[i])
                {
                    name = customerName[i] + " ";
                }
            }
        }
    }
}
