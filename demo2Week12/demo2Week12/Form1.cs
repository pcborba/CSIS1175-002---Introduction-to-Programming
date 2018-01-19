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


namespace demo2Week12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrograms_Click(object sender, EventArgs e)
        {
            int len = 0; //length of the string
            string code = txtCode.Text;
            string desc = "";
            //Contains method

            if (code.Contains('G'))
            { desc = "GNST, "; }

            if (code.Contains('A'))
            { desc = "ACCT, "; }

            if (code.Contains('B'))
            { desc = desc + "BUSN, "; }
            if (code.Contains('C'))
            { desc = desc + "CSIS, "; }

            len = desc.Length;
            desc = desc.Substring(0, len - 2);
            txtDesc.Text = desc;     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = "Simon";
            MessageBox.Show("init is " + name[3]);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] myFile = File.ReadAllLines("c:\\temp\\linqcontrolbreak.csv");
            var myQuery = from myData in myFile
                          let col = myData.Split(',')
                          let name = col[0]
                          let course = col[1]
                          let term = col[2]
                          let grade = col[3]
                          orderby name, term.Substring(1), term[0] descending ,course
                          select new { name, course, term, grade };
            string fmt = "{0,-10}{1,10}{2,10}{3,10}";
            lstResult.Items.Clear();
            bool firstRec = true;
            string prevName = "";
            foreach(var rec in myQuery)
            {
                if(firstRec)
                {
                    lstResult.Items.Add(string.Format(fmt,
                       "Name", "Course", "Term", "Grade"));
                    lstResult.Items.Add(string.Format(fmt,
                         rec.name, rec.course, rec.term, rec.grade));
                    prevName = rec.name;
                    firstRec = false; //force the rest of the program
                    //going to line 76
                }
                else
                {
                    if(prevName==rec.name)
                    {
                        lstResult.Items.Add(string.Format(fmt,
                             "", rec.course, rec.term, rec.grade));

                    }
                    else
                    { //control break occurs here
                        lstResult.Items.Add("");
                        lstResult.Items.Add(string.Format(fmt,
                             rec.name, rec.course, rec.term, rec.grade));
                        prevName = rec.name; 

                    }

                }

              
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] myFile = File.ReadAllLines("c:\\temp\\linqcontrolbreakdata.csv");
            var myQuery = from myData in myFile
                          let col = myData.Split(',')
                          let name = col[0]
                          let id = int.Parse(col[1])
                          let depDate = DateTime.Parse(col[2])
                          let amt = int.Parse(col[3])
                          orderby id, depDate
                          select new { name, id, depDate, amt };
            lstResult.Items.Clear();
            string fmt = "{0,-20}{1,6}{2,16:d}{3,16:c}";
            bool firstRec = true;
            int prevID = 0;
            int subTotal = 0,grandTotal = 0;
            lstResult.Items.Add(string.Format(fmt, "Name",
                "ID", "Dep Date", "Amt"));
            foreach (var rec in myQuery)
            {
                if (firstRec)
                {
                    lstResult.Items.Add(string.Format(fmt, rec.name, rec.id, rec.depDate, rec.amt));
                    firstRec = false;
                    prevID = rec.id;
                    subTotal = rec.amt;
                    grandTotal = rec.amt;
                }
                else
                {
                    if (prevID == rec.id)
                    {
                        lstResult.Items.Add(string.Format(fmt, "","", rec.depDate, rec.amt));
                        subTotal = subTotal + rec.amt;
                        grandTotal = grandTotal + rec.amt;

                    }
                    else
                    {
                        lstResult.Items.Add("sub-total " + subTotal.ToString("c"));
                        lstResult.Items.Add("");
                        lstResult.Items.Add(string.Format(fmt, rec.name, rec.id, rec.depDate, rec.amt));
                        prevID = rec.id;
                        subTotal = rec.amt; //reset the subtotal to the new record
                        grandTotal = grandTotal + rec.amt;

                    }
                }
            }
           lstResult.Items.Add("sub-total " + subTotal.ToString("c"));
            lstResult.Items.Add("");
            lstResult.Items.Add("grand-total " + grandTotal.ToString("c"));


        }
    }
}
