using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cruise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtLastName.Text = "Borba";
            txtFirstName.Text = "Paulo";
            txtID.Text = "300268640";
            DateTime startDate = DateTime.Today.AddDays(10);
            dtpSailingDate.Value = startDate;
            chkWiFi.Checked = false;
            chkDining.Checked = false;
            chkExcursion.Checked = false;
            radInside.Checked = true;
            rad5days.Checked = true;
            txtPassenger.Text = "2";
            lstResult.Items.Add("");
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string invoiceNumber = txtLastName.Text.Substring(0, 1).ToUpper() + txtFirstName.Text.Substring(0, 1).ToUpper() + txtID.Text.Substring(4, 5);
            string fmt = "{0,-25}{1,25}";
            int passenger = int.Parse(txtPassenger.Text);
            int duration = 0;
            decimal cabinAmt = 0m, diningAmt = 0m, wifiAmt = 0m, excursionAmt = 0m, totalAmt = 0m;

            if (rad5days.Checked)
            {
                duration = 5;
            }
            if (rad7days.Checked)
            {
                duration = 7;
            }
            if (rad11days.Checked)
            {
                duration = 11;
            }

            if (radInside.Checked)
            {
                cabinAmt = 100 * passenger* duration;
            }
            if (radOutside.Checked)
            {
                cabinAmt = 130 * passenger * duration;
            }
            if (radBalcony.Checked)
            {
                cabinAmt = 200 * passenger * duration;
            }
            if (radSuite.Checked)
            {
                cabinAmt = 350 * passenger * duration;
            }

            if (chkDining.Checked)
            {
                diningAmt = duration * passenger * 50m;
            }

            if (chkWiFi.Checked)
            {
                if (duration == 5)
                {
                    wifiAmt = 35m;
                }
                if (duration == 7)
                {
                    wifiAmt = 40m;
                }
                if (duration == 11)
                {
                    wifiAmt = 50.5m;
                }
            }

            if (chkExcursion.Checked)
            {
                excursionAmt = 200m * passenger;
            }

            totalAmt = cabinAmt + diningAmt + wifiAmt + excursionAmt;

            lstResult.Items.Clear();

            lstResult.Items.Add(string.Format(fmt, "Invoice number", invoiceNumber));
            lstResult.Items.Add(string.Format(fmt, "Number of passengers", passenger));
            lstResult.Items.Add(string.Format(fmt, "Sailing Date", dtpSailingDate.Value.ToString("d")));
            lstResult.Items.Add(string.Format(fmt, "Ending Date", dtpSailingDate.Value.AddDays(duration).ToString("d")));
            lstResult.Items.Add(string.Format(fmt, "Cabin amount", cabinAmt.ToString("c")));

            if (chkDining.Checked==false)
            {
                lstResult.Items.Add(string.Format(fmt, "Dining amount", "NA"));
            }
            else
            {
                lstResult.Items.Add(string.Format(fmt, "Dining amount", diningAmt.ToString("c")));
            }

            if (chkWiFi.Checked == false)
            {
                lstResult.Items.Add(string.Format(fmt, "Wi-Fi amount", "NA"));
            }
            else
            {
                lstResult.Items.Add(string.Format(fmt, "Wi-Fi amount", wifiAmt.ToString("c")));
            }

            if (chkExcursion.Checked == false)
            {
                lstResult.Items.Add(string.Format(fmt, "Excursion amount", "NA"));
            }
            else
            {
                
                lstResult.Items.Add(string.Format(fmt, "Excursion amount", excursionAmt.ToString("c")));
            }

            lstResult.Items.Add("");
            lstResult.Items.Add(string.Format(fmt, "Total amount", totalAmt.ToString("c")));
        }
    }
}
