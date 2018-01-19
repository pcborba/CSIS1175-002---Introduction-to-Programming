using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCar
{
    public partial class frmRentCar : Form
    {
        public frmRentCar()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {


            DateTime DateRental = DateTime.Today.AddDays(10);
            decimal dailyRate, rental, disc, discAmt, gpsAmt, totalAmt;
            dailyRate = decimal.Parse(txtDailyRate.Text);
            int TotalDays = int.Parse(txtRentalDuration.Text);

            rental = dailyRate * TotalDays;

                               
            disc = 0;

            if (rdaBCAA.Checked)
            {
                disc = 0.1m;
            }
            else if(rdaGovt.Checked)
            {
                disc = 0.05m;
            }

            discAmt = rental * disc;

            
            decimal insAmt = 0;
            if (chkInsurance.Checked)
            {
                insAmt = 0.15m * rental;
            }

            gpsAmt = 0;
            if (chkGPS.Checked)
            {
                gpsAmt = 5m * TotalDays;
            }

            totalAmt = rental - discAmt + insAmt + gpsAmt ;              

            string fmt = "{0,-20}{1,10}";
            string fmt1 = "{0,-20}{1,10:c2}";

            lstRental.Items.Clear();

            lstRental.Items.Add(string.Format(fmt, "Rental Durantion", TotalDays));
            lstRental.Items.Add(string.Format(fmt1, "Daily Rate", dailyRate));

            if(discAmt==0)
            {
                lstRental.Items.Add(string.Format(fmt, "Total discount", "N/A"));
            }
            else
            {
                lstRental.Items.Add(string.Format(fmt1, "Total discount", discAmt));
            }

            lstRental.Items.Add(string.Format(fmt1, "Insurance cost", insAmt));
            lstRental.Items.Add(string.Format(fmt1, "GPS cost", gpsAmt));
            lstRental.Items.Add(string.Format(fmt, "Start date", DateRental.ToString("MM/dd/yyyy")));
            lstRental.Items.Add(string.Format(fmt, "Return date", DateRental.AddDays(TotalDays).ToString("MM/dd/yyyy")));

            lstRental.Items.Add("");
            lstRental.Items.Add(string.Format(fmt1, "Total amount", totalAmt));

            txtStartDate.Text= DateRental.ToString("MM/dd/yyyy");

        }

       
    }
}
