//Section #CSIS1175-002, PAULO CESAR BORBA, Student ID 300268640

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PauloBorba
{
    public partial class frmCruiseManager : Form
    {
                      
        public frmCruiseManager()
        {
            InitializeComponent();
            //Setting the sailing date to be equal system's date
            dtpSailingDate.Text = DateTime.Today.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            //Defining the default data values and sets when costumer click Reset Data button
            txtLastName.Text = "Borba";
            txtFirstName.Text = "Paulo";
            txtID.Text = "300268640";
            dtpSailingDate.Text = DateTime.Today.AddDays(10).ToString(); //add 10 days over the system date
            chkDining.Checked = false;
            chkExcursions.Checked = false;
            chkWiFi.Checked = false;
            radInside.Checked = true;
            rad5d.Checked = true;
            txtNofPassengers.Text = "2";
        

        }

        private void btnShow_Click(object sender, EventArgs e)
        {

            //Declaring decimal var to totalize the costs and
            //setting value zero initially for them 
            decimal diningAmt = 0m, wifiAmt = 0m, excursionsAmt = 0m, cabinAmt =0m, totalAmt = 0m;

            //Declaring int var to hold the duration of the trip
            int duration = 5;

            //Declaring string var to storage the Invoice Number
            //getting its value from the firs letter of last name of the
            //costumer + first letter of the first name + 5 first numbers of it id
            string invoiceNumber = txtLastName.Text.Substring(0, 1).ToUpper() + txtFirstName.Text.Substring(0, 1).ToUpper() + txtID.Text.Substring(4, 5);


            //Declaring string var to format the listbox where
            //it will be presented the summary of the buy in two
            //columns; the first will present the item name and
            //the second their values
            string fmt = "{0,-30}{1,10}";
            string fmtCurrency = "{0,-30}{1,10:c2}";

            
            
            //Identifying and setting the duration of the trip
            if (rad5d.Checked == true) 
            {
                duration = 5;
            }

            else if (rad7d.Checked == true) 
            {
                duration = 7;
            }

            else
            {
                duration = 11;
            }


            //Add cost of the dining if its checkbox is checked
            //considering the number of passengers and the duratin
            //of the trip
            if (chkDining.Checked == true)
            {
                diningAmt = 50m * decimal.Parse(txtNofPassengers.Text) * duration;
            }


            //Add cost of the wifi if its checkbox is checked, and identify
            //identify the amount of days selected at the Cruise Duration 
            //section to properly charge the fee
            if (chkWiFi.Checked == true)
            {
                if (duration == 5)
                {
                    wifiAmt = 35m;
                }
                else if (duration == 7)
                {
                    wifiAmt = 40m;
                }
                else
                {
                    wifiAmt = 50.5m;
                }
            }

            //Add cost of the excursion if its checkbox is checked
            if (chkExcursions.Checked == true)
            {
                excursionsAmt = 200m * decimal.Parse(txtNofPassengers.Text);
            }

            //Identify the cabin model to properly charge the fee
            //per passenger per day
            if (radInside.Checked == true)
            {
                cabinAmt = 100m * decimal.Parse(txtNofPassengers.Text) * duration;
            }

            else if (radOutside.Checked == true)
            {
                cabinAmt = 130m * decimal.Parse(txtNofPassengers.Text) * duration;
            }

            else if (radBalcony.Checked == true)
            {
                cabinAmt = 200m * decimal.Parse(txtNofPassengers.Text) * duration;
            }
            else
            {
                cabinAmt = 350m * decimal.Parse(txtNofPassengers.Text) * duration;
            }

            totalAmt = cabinAmt + diningAmt + wifiAmt + excursionsAmt;


            //Clean listbox content
            lstInvoice.Items.Clear();

            //declaring a variable to hold the dtpSailingDate and after agregate days to it
            DateTime sailingDate = DateTime.Parse(dtpSailingDate.Text);
            DateTime endingDate = sailingDate.AddDays(duration);

            //Add the values and results to the listbox
            lstInvoice.Items.Add(string.Format(fmt, "Invoice number", invoiceNumber));
            lstInvoice.Items.Add(string.Format(fmt, "Number of passengers", txtNofPassengers.Text.ToString()));
            lstInvoice.Items.Add(string.Format(fmt, "Sailing date", sailingDate.ToString("M/d/yyyy")));
            lstInvoice.Items.Add(string.Format(fmt, "Ending date", endingDate.ToString("M/d/yyyy")));
            lstInvoice.Items.Add(string.Format(fmtCurrency, "Cabin amount", cabinAmt));
            //Checking if costumer buy dinner to show "NA" or the amount 
            if (diningAmt == 0)
            {
                lstInvoice.Items.Add(string.Format(fmt, "Fine dining amount", "NA"));
            }
            else
            { 
            lstInvoice.Items.Add(string.Format(fmtCurrency, "Fine dining amount", diningAmt));
            }

            //Checking if costumer buy WiFi to show "NA" or the amount 
            if ( wifiAmt == 0)
            {
                lstInvoice.Items.Add(string.Format(fmt, "WiFi amount", "NA"));
            }
            else
            { 
                lstInvoice.Items.Add(string.Format(fmtCurrency, "WiFi amount", wifiAmt));
            }

            //Checking if costumer buy Excursion to show "NA" or the amount 
            if (excursionsAmt == 0)
            {
                lstInvoice.Items.Add(string.Format(fmt, "Excursion amount", "NA"));
            }
            else
            {
                lstInvoice.Items.Add(string.Format(fmtCurrency, "Excursion amount", excursionsAmt));
            }

            //Adding an additional space before the last line
            lstInvoice.Items.Add(string.Format(""));

            //Assing last line with the result
            lstInvoice.Items.Add(string.Format(fmtCurrency, "Total amount", totalAmt));

        }
    }
}
