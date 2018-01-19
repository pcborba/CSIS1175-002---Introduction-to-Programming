using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo2Week7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            ShowID();
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            txtInvoice.Text = getInvoice(txtName.Text, txtID.Text);
        }

        private string getInvoice (string name, string id)
        {
            //to show how your method return the result
            string[] customer = name.Split(' ');
            string CID;
            CID = customer[0].Substring(0, 1) + customer[1].Substring(0, 1) + id.Substring(6);

            return CID.ToUpper();
        }

        private void ShowID()
        {
            //to show how your method do not return the result
            string[] name;
            string init;
            name = txtName.Text.Split(' ');
            init = name[0].Substring(0, 1) + name[1].Substring(0, 1);
            string customerID;
            customerID = init + txtID.Text.Substring(5);
            MessageBox.Show(customerID.ToUpper());
        }

        private void btnAvg_Click(object sender, EventArgs e)
        {
            txtS1Avg.Text = getAvg(txtS1Q1.Text, txtS1Q2.Text, txtS1Q3.Text, txtS1Q4.Text);
            txtS2Avg.Text = getAvg(txtS2Q1.Text, txtS2Q2.Text, txtS2Q3.Text, txtS2Q4.Text);
            txtS3Avg.Text = getAvg(txtS3Q1.Text, txtS3Q2.Text, txtS3Q3.Text, txtS3Q4.Text);
            txtS4Avg.Text = getAvg(txtS4Q1.Text, txtS4Q2.Text, txtS4Q3.Text, txtS4Q4.Text);
        }

        private string getAvg(string Q1, string Q2, string Q3, string Q4)
        {
            int V1 = int.Parse(Q1);
            int V2 = int.Parse(Q2);
            int V3 = int.Parse(Q3);
            int V4 = int.Parse(Q4);

            int smaller = 0;
            decimal avg = 0m;

            if (V1 < V2)
            {
                smaller = V1;
            }
            else
            {
                smaller = V2;
            }

            if (V3 < smaller)
            {
                smaller = V3;
            }
            if (V4 < smaller)
            {
                smaller = V4;
            }

            avg = (V1 + V2 + V3 + V4 - smaller) / 3;
            return avg.ToString();

        }

        private void btnSresult_Click(object sender, EventArgs e)
        {
            string fmt = "{0,-20}{1,10:c}";
            lstResult.Items.Clear();
            decimal amount =0, totalAmt = 0;
            getTotal(cboTask1.Text, txtRate1.Text, txtJob1.Text, ref amount);
            totalAmt = totalAmt + amount;
            getTotal(cboTask2.Text, txtRate2.Text, txtJob2.Text, ref amount);
            totalAmt = totalAmt + amount;
            getTotal(cboTask3.Text, txtRate3.Text, txtJob3.Text, ref amount);
            totalAmt = totalAmt + amount;
            getTotal(cboTask4.Text, txtRate4.Text, txtJob4.Text, ref amount);
            totalAmt = totalAmt + amount;

            lstResult.Items.Add("");
            lstResult.Items.Add(string.Format(fmt, "Total amt", totalAmt));
                //MessageBox.Show(cboTask1.Text);
        }

        private decimal getTotal(string task, string rate, string job, ref decimal amt )
        {
            string fmt = "{0,-20}{1,10:c}";
            decimal jobRate = decimal.Parse(rate);
            int jobs = int.Parse(job);
            amt = jobs * jobRate;
            

            lstResult.Items.Add(string.Format(fmt, task, amt));
            return amt;
        }
    }
}
