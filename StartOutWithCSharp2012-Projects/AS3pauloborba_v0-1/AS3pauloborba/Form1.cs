//CSIS1175-002 - Muhammad Hassan Haider Student ID 300273535 - Paulo Cesar Borba Student ID 300268640
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

namespace AS3pauloborba
{
    public partial class frmAssignment3 : Form
    {
        public frmAssignment3()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            string[] dbCustomers = File.ReadAllLines("c:\\temp\\as3customers.csv");
            string[] dbData = File.ReadAllLines("c:\\temp\\as3data.csv");

            string fmt = "{0,-15}{1,6}{2,18:d}{3,14}{4,25}{5,19}{6,5:n}{7,12:c}";


            var myQuery = from v in dbData
                          let col = v.Split(',')
                          let custId = int.Parse(col[0])
                          let invoice = int.Parse(col[1])
                          let rentDate = DateTime.Parse(col[2])
                          let bikeT = col[3]
                          let access = col[4]
                          let insur = col[5]
                          let rentHour = double.Parse(col[6])
            
                          orderby custId, rentDate, insur
                          select new
                          {
                              custId,
                              invoice,
                              rentDate,
                              bikeT,
                              access,
                              insur,
                              rentHour
                          };

            bool firstReg = true;
            int previousId = 0;
            double subTotal = 0;
            double total = 0;
            

            lstResult.Items.Add(string.Format(fmt, "Customers Name & Id", "Inv #", "Rental Date", "Bike type", "Accessories", "Insured", "Hrs", "Charge"));
            foreach (var aa in myQuery)
            {
                if (firstReg==true)
                {
                    Rental myRental = new Rental(aa.rentDate, aa.bikeT, aa.access, aa.insur, aa.rentHour);
                    lstResult.Items.Add(string.Format(fmt, aa.custId, aa.invoice, aa.rentDate, myRental.Biket, myRental.Access, myRental.Insur, aa.rentHour, myRental.Amount));
                    firstReg = false;
                    subTotal = subTotal + double.Parse(myRental.Amount);
                    previousId = aa.custId;

                }
                else
                {
                    if(previousId==aa.custId)
                    {
                        Rental myRental = new Rental(aa.rentDate, aa.bikeT, aa.access, aa.insur, aa.rentHour);
                        lstResult.Items.Add(string.Format(fmt, "", aa.invoice, aa.rentDate, myRental.Biket, myRental.Access, myRental.Insur, aa.rentHour, myRental.Amount));
                        subTotal = subTotal + double.Parse(myRental.Amount);
                    }
                    else
                    {
                        lstResult.Items.Add(string.Format(fmt, "", "", "", "", "", "", "", "---------"));
                        lstResult.Items.Add(string.Format(fmt, "", "", "", "", "", "Sub-total", "", subTotal));
                        total = total + subTotal;
                        lstResult.Items.Add("");
                        previousId = aa.custId;
                        Rental myRental = new Rental(aa.rentDate, aa.bikeT, aa.access, aa.insur, aa.rentHour);
                        subTotal = 0;
                        subTotal = subTotal + double.Parse(myRental.Amount);
                        lstResult.Items.Add(string.Format(fmt, aa.custId, aa.invoice, aa.rentDate, myRental.Biket, myRental.Access, myRental.Insur, aa.rentHour, myRental.Amount));
                    }
                }
            }
            total = total + subTotal;
            lstResult.Items.Add(string.Format(fmt, "", "", "", "", "", "", "", "---------"));
            lstResult.Items.Add(string.Format(fmt, "", "", "", "", "", "Sub-total", "", subTotal));
            lstResult.Items.Add("");
            lstResult.Items.Add(string.Format(fmt, "", "", "", "", "", "Grand-total", "", total));

        }
    }
}
