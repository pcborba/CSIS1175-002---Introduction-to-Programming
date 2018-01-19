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

namespace AS3pauloborbaT_v0_7
{

    public partial class frmAssignment3 : Form
    {
        string[] IDs = new string[99];
        string[] customers = new string[99];
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
            while(dbCustomer.EndOfStream!=true)
            {
                    custData = dbCustomer.ReadLine().Split(',');
                    IDs[count] = custData[1];
                    customers[count] = custData[0];
                    count++;
            }
            dbCustomer.Close();
        }

        private void findName (string id, ref string name)
        {
            for (int i = 0; i < count; i++)
            {
                if (id == IDs[i])
                {
                    custName = customers[i]+ " ";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] dbData = File.ReadAllLines("c:\\temp\\AS3data.csv");
            string fmt = "{0,-20}{1,6}{2,13:d}{3,18}{4,26}{5,13}{6,14:n1}{7,12:c}";
            string prevId = "";
            bool firstReg = true;
            double total = 0, subTotal = 0;

            var myQuery = from row in dbData
                          let col = row.Split(',')
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

            foreach (var reg in myQuery)
            {
                findName(reg.id, ref custName);

                if(firstReg==true)
                {
                    firstReg = false;
                    prevId = reg.id;
                    lstResult.Items.Add(string.Format(fmt, "Cust name & ID", "Inv #", "Rental Date", "Bike Type", "Accessories", "Insurance", "Hours", "Charge"));
                    lstResult.Items.Add(string.Format(fmt, custName+ reg.id, reg.inv, reg.rentD, reg.bikeT,reg.access, reg.insur, reg.hrs, "Charge"));
                }
                else
                {
                    if(prevId==reg.id)
                    {

                    }
                    else
                    {

                    }
                }

            }

        }
    }
}
