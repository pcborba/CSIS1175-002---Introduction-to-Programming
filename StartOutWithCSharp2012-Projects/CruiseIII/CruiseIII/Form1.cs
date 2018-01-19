using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CruiseIII
{
    public partial class frmCruise : Form
    {
        public frmCruise()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Settings the default values to the form
            txtLastName.Text = "Borba";
            txtFirstName.Text = "Paulo";
            txtID.Text = "300268640";
            // Declaring a datetime var to hold the reseted Sailing date, that must be
            // the today's date + 10 days
            DateTime sailingDate = dtpSailingDate.Value.AddDays(10);
            dtpSailingDate.Text = sailingDate.ToString();
            radInside.Checked = true;
            rad5d.Checked = true;
            txtPassenger.Text = "2";
            lstResult.Items.Clear();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
                //Declaring a string var to hold the invoice, collecting just the part o the information
                //required from each source var and formating all the letters to upper case
                string invoice = txtLastName.Text.Substring(0, 1).ToUpper() + txtFirstName.Text.Substring(0, 1).ToUpper() + txtID.Text.Substring(4, 5);
                //Declaring a string var to format the data presented on the list box
                string fmt = "{0,-20}{1,32}";
                //Declaring a int var to hold the duration of the trip
                int duration = 0;
                //Declaring decimal var to hold the amounts
                decimal cabinAmt = 0m, diningAmt = 0m, wifiAmt = 0m, excursionAmt = 0m, totalAmt = 0m;


                //Identifying the duration of the trip and setting the value to the appropriate var
                if (rad5d.Checked)
                {
                    duration = 5;
                }
                if (rad7d.Checked)
                {
                    duration = 7;
                }
                if (rad11d.Checked)
                {
                    duration = 11;
                }

                //Identifying the type of the cabe and setting the amount to pay for it
                if (radInside.Checked)
                {
                    cabinAmt = int.Parse(txtPassenger.Text) * 100m * duration;
                }
                if (radOutside.Checked)
                {
                    cabinAmt = int.Parse(txtPassenger.Text) * 130m * duration;
                }
                if (radBalcony.Checked)
                {
                    cabinAmt = int.Parse(txtPassenger.Text) * 200m * duration;
                }
                if (radSuite.Checked)
                {
                    cabinAmt = int.Parse(txtPassenger.Text) * 350m * duration;
                }

                //Identifying if customer select option Dining and setting the cost
                if (chkDining.Checked)
                {
                    diningAmt = int.Parse(txtPassenger.Text) * 50m * duration;
                }

                //Identifying if customer select option WiFi and setting the cost
                if (chkWiFi.Checked)
                {
                    if (rad5d.Checked)
                    {
                        wifiAmt = 35m;
                    }
                    if (rad7d.Checked)
                    {
                        wifiAmt = 40m;
                    }
                    if (rad11d.Checked)
                    {
                        wifiAmt = 50.5m;
                    }
                }
                //Identifying if customer select option Excursion and setting the cost
                if (chkExcursion.Checked)
                {
                    excursionAmt = int.Parse(txtPassenger.Text) * 200m;
                }
            


                //Cleaing listbox to show just the new results
                lstResult.Items.Clear();


                //Add the values to the list box
                lstResult.Items.Add(string.Format(fmt, "Invoice number", invoice));
                lstResult.Items.Add(string.Format(fmt, "Number of passengers", int.Parse(txtPassenger.Text)));
                lstResult.Items.Add(string.Format(fmt, "Sailing date", dtpSailingDate.Value.ToString("d")));
                lstResult.Items.Add(string.Format(fmt, "Ending date", dtpSailingDate.Value.AddDays(duration).ToString("d")));
                lstResult.Items.Add(string.Format(fmt, "Cabin amount", cabinAmt.ToString("c")));

                //Printing the NA or the amount for Dining, WiFi and Excursion
                if (chkDining.Checked)
                {
                    lstResult.Items.Add(string.Format(fmt, "Dining amount", diningAmt.ToString("c")));
                }
                else
                {
                    lstResult.Items.Add(string.Format(fmt, "Dining amount", "NA"));
                }

                if (chkWiFi.Checked)
                {
                    lstResult.Items.Add(string.Format(fmt, "Wi-Fi amount", wifiAmt.ToString("c")));
                }
                else
                {
                    lstResult.Items.Add(string.Format(fmt, "Wi-Fi amount", "NA"));
                }

                if (chkExcursion.Checked)
                {
                    lstResult.Items.Add(string.Format(fmt, "Excursion amount", excursionAmt.ToString("c")));
                }
                else
                {
                    lstResult.Items.Add(string.Format(fmt, "Excursion amount", "NA"));
                }

                //Adding a blank line to better visualize the total
                lstResult.Items.Add("");

                //Sum all the itens to the amount var
                totalAmt = cabinAmt + diningAmt + wifiAmt + excursionAmt;

                //Printing on list box the total amount
                lstResult.Items.Add(string.Format(fmt, "Total amount", totalAmt.ToString("c")));

        }

       
    }
}
