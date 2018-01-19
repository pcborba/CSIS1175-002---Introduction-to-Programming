using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountSimul
{
    public partial class frmAccSimul : Form
    {
        private BankAccount account = new BankAccount(1000);

        public frmAccSimul()
        {
            InitializeComponent();
        }

        private void frmAccSimul_Load(object sender, EventArgs e)
        {
            lblBalance.Text = account.balance.ToString("c2");
        }
        private void btnDep_Click(object sender, EventArgs e)
        {
            decimal amount;
            if (decimal.TryParse(txtDep.Text, out amount))
            {
                account.deposit(amount);
                lblBalance.Text = account.balance.ToString("c2");
                txtDep.Text = "";
            }
            else
            {
                MessageBox.Show("Please insert a valid amount");
            }
        }

        private void btnWith_Click(object sender, EventArgs e)
        {
            decimal amount;
            if (decimal.TryParse(txtWith.Text, out amount))
            {
                account.withdrawal(amount);
                lblBalance.Text = account.balance.ToString("c2");
                txtWith.Text = "";
            }
            else
            {
                MessageBox.Show("Please insert a valid amount");
            }
        }
    }
}
