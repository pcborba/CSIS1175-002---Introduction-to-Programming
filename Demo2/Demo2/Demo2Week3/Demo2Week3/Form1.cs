using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo2Week3
{
    public partial class Form1 : Form
    {
        //both myOtherName and myName are private
        //field string type and are accessible within
        //Form1 only

        string myOtherName = "Sarah";
        private string myName = "Nelson";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMsg_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to CSIS1175 "+txtName.Text);

            //show msg in a text box

            txtResult.Text = "Wecome to CSIS1175 " + txtName.Text;
        }

        private void btnVariable_Click(object sender, EventArgs e)
        {
            //create a string variable and assign a name to it
            //called myName
            string myName;

            //initialize myName with the word CSIS1175
            myName = "CSIS1175";

            //create a string called myOtherName and initialize 
            //it with the word C# programming at the same time

            string myOtherName = "C# Programming";

            //concatenate string variables
            MessageBox.Show(myName + " " + myOtherName);

            //replace the text property of txtResult with
            //the content of the variable myOtherName
            txtResult.Text = myOtherName;
        }

        private void btnComputer_Click(object sender, EventArgs e)
        {
            //create numeric variables var1, var2 and result
            //double precision type

            double var1, var2, result;


            //get the value from the textboxes
            //convert the text into double precision value first

            var1 = double.Parse(txtVar1.Text);
            var2 = double.Parse(txtVar2.Text);

            result = var1 * var2;
            MessageBox.Show("The result is " + result.ToString("c"));
            //display the resulta in a textbox
            txtNewResult.Text = result.ToString("c");
        }

        private void btnNewCalc_Click(object sender, EventArgs e)
        {
            decimal var1, var2, result;
            try
            {
                var1 = decimal.Parse(txtVar1.Text);
                var2 = decimal.Parse(txtVar2.Text);
                result = var1 / var2;
                MessageBox.Show(result.ToString("n"));
                txtNewResult.Text = result.ToString("n");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //myName is a local string variable
            //accessible within button1_Click event only
            string myName = "Paulo";
            MessageBox.Show(myName);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(myName);
            myName = "Ray Yu";
            MessageBox.Show(myName);
        }

        private void btnDateTime_Click(object sender, EventArgs e)
        {
            //declare newDate as a DateTime variable
            //assign 2017,1,18 as the initial value to it
            DateTime newDate = new DateTime(2017, 1, 18);
            MessageBox.Show(newDate.ToString("d"));

            //add 2 days to Jan 18
            MessageBox.Show(newDate.AddDays(2).ToString("d"));

            //declare today as a DateTime variable and assign
            //the current day and time to it
            DateTime today = DateTime.Now;
            MessageBox.Show("Today is " + today.ToString("d"));


        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            decimal hrs, payrates, payAmt;

            hrs = decimal.Parse(txtHours.Text);
            payrates = decimal.Parse(txtPayRate.Text);

            //1.5x applies to hrs after 30hrs
            //check if the hrs is more than 30
            if (hrs>30)
            {
                payAmt = payrates * 30 + payrates * 1.5m * (hrs - 30);
            }
            else //if the hrs <=30
            {
                payAmt = payrates * hrs;

            }
            

            MessageBox.Show("The pay amount is  " + payAmt.ToString("c"));
        }
    }
}
