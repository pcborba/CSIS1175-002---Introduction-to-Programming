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

namespace Demo2Week12_I
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

            // Contains method

            if (code.Contains('G'))
            {
                desc = " GNST you can just enroll to this course";
                txtDesc.Text = desc;
            }
            else
            {
                if (code.Contains('C'))
                {
                    desc = desc + " CSIS, ";
                }
                if (code.Contains('A'))
                {
                    desc = desc + " ACCT, ";
                }
                if (code.Contains('B'))
                {
                    desc = desc + " BUSN, ";
                }


                len = desc.Length;
                txtDesc.Text = desc.Substring(0, len - 2);

            }
            


           
        }

        private void btnChar_Click(object sender, EventArgs e)
        {
            string name = "Simon";
            MessageBox.Show("The first letter is "+name[3]);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] myFile = File.ReadAllLines("c:\\temp\\LINQControlBreak.csv");

            var myQuery = from myData in myFile
                          let col = myData.Split(',')
                          let name = col[0]
                          let course = col[1]
                          let term = col[2]
                          let grade = col[3]
                          orderby name, term.Substring(1), term[0] descending, course 
                          select new
                          {
                              name,
                              course,
                              term,
                              grade
                          };
            string fmt = "{0,-20}{1,10}{2,10}{3,10}";
            bool firstRec = true;
            string prevName = "";


            foreach (var rec in myQuery)
            {
                if (firstRec==true)
                {
                    prevName = rec.name;
                    lstResult.Items.Add(string.Format(fmt, "Name", "Term", "Course", "Grade"));
                    lstResult.Items.Add(string.Format(fmt, rec.name, rec.course, rec.term, rec.grade));
                    firstRec = false; //force the rest of the program
                }
                else
                {
                    if (prevName == rec.name)
                    {
                        lstResult.Items.Add(string.Format(fmt, "  ", rec.course, rec.term, rec.grade));
                    }
                    else
                    {
                        lstResult.Items.Add(" ");
                        lstResult.Items.Add(string.Format(fmt, rec.course, rec.course, rec.term, rec.grade));
                        prevName = rec.name;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] myFile = File.ReadAllLines("c:\\temp\\LINQControlBreakData.csv");
            var myQuery = from myData in myFile
                          let col = myData.Split(',')
                          let name = col[0]
                          let id = int.Parse(col[1])
                          let depDate = DateTime.Parse(col[2])
                          let depAmt = int.Parse(col[3])
                          orderby id
                          select new
                          {
                              name,
                              id,
                              depDate,
                              depAmt
                          };
            lstResult.Items.Clear();
            string fmt = "{0,-20}{1,6}{2,16:d}{3,16:c}";
            bool firstRec = true;
            int previousID = 0;
            double amt=0, totalAmt=0; 
            
            foreach (var rec in myQuery)
            {

                if(firstRec==true)
                {
                    lstResult.Items.Add(string.Format(fmt, rec.name, rec.id, rec.depDate, rec.depAmt));
                    firstRec = false;
                    previousID = rec.id;
                    amt = rec.depAmt + amt;
                    totalAmt = totalAmt + rec.depAmt;
                }
                else
                {

                    if (previousID==rec.id)
                    {
                        lstResult.Items.Add(string.Format(fmt, " ", rec.id, rec.depDate, rec.depAmt));
                        amt = rec.depAmt + amt;
                        totalAmt = totalAmt + rec.depAmt;
                    }
                    else
                    {
                        lstResult.Items.Add("sub-total " + amt.ToString("c"));
                        lstResult.Items.Add("");
                        lstResult.Items.Add(string.Format(fmt, rec.name, rec.id, rec.depDate, rec.depAmt));
                        amt = rec.depAmt; //reset the subtotal to the new record
                        totalAmt = totalAmt + rec.depAmt;
                        previousID = rec.id;
                    }
                }
            }
            lstResult.Items.Add("sub-total " + amt.ToString("c"));
            lstResult.Items.Add("");
            lstResult.Items.Add("total " + totalAmt.ToString("c"));

        }
    }
}
