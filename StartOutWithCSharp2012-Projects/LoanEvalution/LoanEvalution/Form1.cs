using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoanEvalution
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSalary.Text = "";
            txtYears.Text = "";
            lblDecision.Text = "";
            lblDecision.Visible = false;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {

            try
            { 

            double salary;
            int years;

            salary = double.Parse(txtSalary.Text);
            years = int.Parse(txtYears.Text);

            if (salary < 40000)
            {
                lblDecision.Text = "Your Salary is not enough to get a loan";
                lblDecision.Visible = true;
            }
            else if (years < 2)
            {
                lblDecision.Text = "You have not enough to time in your current job to get a loan";
                lblDecision.Visible = true;
            }
            else
            {
                lblDecision.Text = "Congrats you will get a loan";
                lblDecision.Visible = true;
            }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
