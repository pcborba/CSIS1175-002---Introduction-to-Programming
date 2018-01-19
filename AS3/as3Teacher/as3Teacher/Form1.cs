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

namespace as3Teacher
{
    public partial class frmAssignment3 : Form
    {
        public frmAssignment3()
        {
            InitializeComponent();
        }

        string[] IDs = new string[99];
        string[] Names = new string[99];
        int count = 0;
        private void btnResult_Click(object sender, EventArgs e)
        {
            //string[] dbCustomer = File.ReadAllLines("c:\\temp\\AS3customers.csv");
            string[] dbData = File.ReadAllLines("c:\\temp\\AS3data.csv");
            string fmt = "{0,-20}{1,7}{2,12:d}{3,15}{4,18}{5,15}{6,12:n}{7,12:c}";

            var myQuery = from row in dbData
                          let col = row.Split(',')
                          let id = col[0]
                          let inv = col[1]
                          let rentD = DateTime.Parse(col[2])
                          let bikeT = col[3]
                          let access = col[4]
                          let insur = col[5]
                          let hrs = double.Parse(col[6])
                          orderby id, rentD
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

            lsrResult.Items.Clear();
            string prevID = "";
            bool firstReg = true;
            string custName = "";
            double subTotal = 0, total = 0;
            
            foreach (var reg in myQuery)
            {

                Rental myRent = new Rental(reg.bikeT, reg.access, reg.insur, reg.hrs);
                getName(reg.id, ref custName);
                if (firstReg)
                {
                    lsrResult.Items.Add(string.Format(fmt, "Customer Name & ID", "Inv #", "Rental Date", "Bike Type", "Accessories", "Insurance", "Hrs", "Charge"));
                    lsrResult.Items.Add(string.Format(fmt, custName + reg.id, reg.inv, reg.rentD, myRent.BikeType, myRent.Accessories, myRent.Insurance, reg.hrs, myRent.Charge));
                    prevID = reg.id;
                    firstReg = false;
                    subTotal = myRent.Charge;
                    total = total + subTotal;
                }
                else
                {
                    if (prevID == reg.id)
                    {
                        lsrResult.Items.Add(string.Format(fmt, "", reg.inv, reg.rentD, myRent.BikeType, myRent.Accessories, myRent.Insurance, reg.hrs, myRent.Charge));
                        subTotal = myRent.Charge;
                        total = total + subTotal;
                    }
                    else
                    {
                        lsrResult.Items.Add(string.Format("", "", "", "", "", "", "", "---------"));
                        lsrResult.Items.Add(string.Format("", "", "", "", "", "Sub-Total", "", subTotal));
                        lsrResult.Items.Add("");
                        prevID = reg.id;
                        lsrResult.Items.Add(string.Format(fmt, custName + reg.id, reg.inv, reg.rentD, myRent.BikeType, myRent.Accessories, myRent.Insurance, reg.hrs, myRent.Charge));
                        subTotal = myRent.Charge;
                        total = total + subTotal;
                    }
                }
            }

        }

        private void getName(string id, ref string name)
        {
            for(int x=0; x<count;x++)
            {
                if(id==IDs[x])
                {
                    name = Names[x] + " ";
                }
            }
        }
        private void frmAssignment3_Load(object sender, EventArgs e)
        {
            StreamReader inFile = File.OpenText("c:\\temp\\as3customers.csv");
            string[] customers;
            while (!inFile.EndOfStream)
            {
                customers = inFile.ReadLine().Split(',');
                Names[count] = customers[0];
                IDs[count] = customers[1];
                count++;
            }
        }
    }
}
