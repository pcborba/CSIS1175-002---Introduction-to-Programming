using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobilePlan
{
    public partial class frmMobilePlan : Form
    {

        Plan myPlan = new Plan();

        public frmMobilePlan()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            createPlan();
        }

        private void createPlan()
        {
            lstResult.Items.Clear();
            string fmt = "{0, -20}{1,15:c2}";
            int min = 0;
            string dataPlan = "";

            if (rad1gb.Checked == false && rad2gb.Checked == false && rad4gb.Checked == false && radNd.Checked == false || txtMin.Text == "")
            {
                MessageBox.Show("Please select at least one type of Data Plan and the quantity of minutes to contract monthly");
                rad1gb.Checked = true;
                txtMin.Text = "100";
                txtMin.Focus();
            }
            else
            {
                if (int.TryParse(txtMin.Text, out min))
                { 
                    if (rad1gb.Checked)
                    {
                        dataPlan = "1";
                    }
                    if (rad2gb.Checked)
                    {
                        dataPlan = "2";
                    }
                    if (rad4gb.Checked)
                    {
                        dataPlan = "4";
                    }
                    if (radNd.Checked)
                    {
                        dataPlan = "n";
                    }

                    myPlan.PlanOption(min, dataPlan);

                    if (dataPlan == "1")
                    {
                        lstResult.Items.Add(string.Format(fmt, "Data Plan: 1 GB", myPlan.PlanDataCost));
                    }
                    if (dataPlan == "2")
                    {
                        lstResult.Items.Add(string.Format(fmt, "Data Plan: 2 GB", myPlan.PlanDataCost));
                    }
                    if (dataPlan == "4")
                    {
                        lstResult.Items.Add(string.Format(fmt, "Data Plan: 4 GB", myPlan.PlanDataCost));
                    }
                    if (dataPlan == "n")
                    {
                        lstResult.Items.Add(string.Format(fmt, "Data Plan: No Data", "NA"));
                    }

                    lstResult.Items.Add(string.Format(fmt, min + "talk mins ", myPlan.PlanMinCost));
                    lstResult.Items.Add(string.Format(fmt, "Total Amt ", myPlan.PlanMinCost+myPlan.PlanDataCost));
                }
                else
                {
                    MessageBox.Show("Please insert a valid integer number for minutes");
                }
            }
        }
    }
}
