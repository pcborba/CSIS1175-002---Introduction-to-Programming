using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CruiseII
{
    public partial class frmCruise : Form
    {
        public frmCruise()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtLast.Text = "Borba";
            txtFirst.Text = "Paulo";
            txtID.Text = "300268640";
            DateTime sailingDate = dtpSailingDate.Value.AddDays(10);
            dtpSailingDate.Text = sailingDate.ToString("d");
            chkDining.Checked = false;
            chkWiFi.Checked = false;
            chkExcursion.Checked = false;
            radInside.Checked = true;
            txtPassenger.Text = "2";
            rad5days.Checked = true;
            lstResult.Items.Clear();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string invoice = txtLast.Text.Substring(0, 1).ToUpper() + txtFirst.Text.Substring(0, 1).ToUpper() + txtID.Text.Substring(4, 5).ToUpper();
            string fmt = "{0,-23}{1,15}";
            int passenger = int.Parse(txtPassenger.Text);
            DateTime sailingDate = dtpSailingDate.Value;
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
                cabinAmt = 100m*duration*passenger;
            }
            if (radOutside.Checked)
            {
                cabinAmt = 130m * duration * passenger;
            }
            if (radBalcony.Checked)
            {
                cabinAmt = 200m * duration * passenger;
            }
            if (radSuite.Checked)
            {
                cabinAmt = 350m * duration * passenger;
            }

            if (chkDining.Checked)
            {
                diningAmt = 50m * passenger * duration;
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

            lstResult.Items.Clear();

            lstResult.Items.Add(string.Format(fmt, "Invoice number", invoice));
            lstResult.Items.Add(string.Format(fmt, "Number of passenger", passenger.ToString()));
            lstResult.Items.Add(string.Format(fmt, "Sailing date", sailingDate.ToString("d")));
            lstResult.Items.Add(string.Format(fmt, "Ending date", sailingDate.AddDays(duration).ToString("d")));
            lstResult.Items.Add(string.Format(fmt, "Cabin amount", cabinAmt.ToString("c")));

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

            totalAmt = cabinAmt + diningAmt + wifiAmt + excursionAmt;

            lstResult.Items.Add("");
            lstResult.Items.Add(string.Format(fmt, "Total amount", totalAmt.ToString("c")));


        }
    }
}
