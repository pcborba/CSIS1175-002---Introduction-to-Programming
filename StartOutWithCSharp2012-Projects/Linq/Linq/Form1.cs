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

namespace Linq
{
    public partial class frmLinq : Form
    {
        public frmLinq()
        {
            InitializeComponent();
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            string fmt = "{0,-20}{1,15}{2,15}{3,15:d}{4,15}{5,15}";
            string[] myData = File.ReadAllLines("c:\\temp\\StaffInfo.csv");

            var myQuery = from abc in myData
                          let col = abc.Split(',')
                          let id = col[0]
                          let first = col[1]
                          let last = col[2]
                          let dob = DateTime.Parse(col[3])
                          let degree = col[4]
                          let college = col[5]
                          orderby dob ascending
                          select new
                          {
                              id,
                              first,
                              last,
                              dob,
                              degree,
                              college,
                          };

            foreach (var n in myQuery)
            {
                lstResult.Items.Add(string.Format(fmt, n.id, n.first, n.last, n.dob, n.degree, n.college));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] myData = File.ReadAllLines("c:\\temp\\LINQControlBreak.csv");
            string fmt = "{0,-20}{1,10}{2,10}{3,10}";

            var myQuery = from abc in myData
                          let col = abc.Split(',')
                          let name = col[0]
                          let course = col[1]
                          let term = col[2]
                          let grade = col[3]
                          orderby name, term.Substring(1), term[0] descending, course, grade
                          select new
                          {
                              name,
                              term,
                              course,
                              grade,
                          };

            lstResult.Items.Clear();

            bool firstReg = true;
            string prevName = "";

            foreach (var v in myQuery)
            {


                
                if (firstReg==true)
                {
                    lstResult.Items.Add(string.Format(fmt, "Name", "Term", "Course", "Course"));
                    lstResult.Items.Add(string.Format(fmt, v.name, v.term, v.course, v.grade));
                    prevName = v.name;
                    firstReg = false;

                }
                else
                {
                    if(prevName == v.name)
                    {
                        lstResult.Items.Add(string.Format(fmt, "", v.term, v.course, v.grade));

                    }
                    else
                    {
                        lstResult.Items.Add("");
                        lstResult.Items.Add(string.Format(fmt, v.name, v.term, v.course, v.grade));
                        prevName = v.name;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] myData = File.ReadAllLines("c:\\temp\\LINQControlBreakData.csv");

            string fmt = "{0,-20}{1,8}{2,15:d}{3,15:c}";

            var myQuery = from n in myData
                          let col = n.Split(',')
                          let name = col[0].Split(' ')
                          let id = int.Parse(col[1])
                          let date = DateTime.Parse(col[2])
                          let bill = Decimal.Parse(col[3])
                          orderby id, date
                          select new
                          {
                              name,
                              id,
                              date,
                              bill,
                          };

            bool firstName = true;
            int prevId = 0;
            decimal subtotal = 0m;
            decimal total = 0m;

            lstResult.Items.Clear();

            foreach (var aa in myQuery)
            {
                if (firstName==true)
                {
                    lstResult.Items.Add(string.Format(fmt, "Name", "Customer id", "Date", "Bill"));
                    lstResult.Items.Add(string.Format(fmt, aa.name[1]+","+aa.name[0], aa.id, aa.date, aa.bill));
                    firstName = false;
                    prevId = aa.id;
                    subtotal = subtotal + aa.bill;
                }
                else
                {
                    if(prevId == aa.id)
                    {
                        lstResult.Items.Add(string.Format(fmt, "", aa.id, aa.date, aa.bill));
                        subtotal = subtotal + aa.bill;
                    }
                    else
                    {
                        lstResult.Items.Add("Sub-total "+ subtotal.ToString("c"));
                        total = total + subtotal;
                        lstResult.Items.Add("");
                        subtotal = 0m;

                        lstResult.Items.Add(string.Format(fmt, aa.name[1] + "," + aa.name[0], aa.id, aa.date, aa.bill));
                        subtotal = subtotal + aa.bill;
                        prevId = aa.id;
                    }
                }
            }
            total = total + subtotal;
            lstResult.Items.Add("Sub-total " + subtotal.ToString("c"));
            lstResult.Items.Add("");
            lstResult.Items.Add("Total " + total.ToString("c"));
        }
    }
}
