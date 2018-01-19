using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cards
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (lstCards.SelectedIndex != -1)
            {
                ShowCard(lstCards.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Please select a card");
            }
        }

        private void ShowCard (string card)
        {
            switch(card)
            {
                case "Ace of Spades":
                    ShowAceSpades();
                    break;
                case "10 of Hearts":
                    ShowTenHearts();
                    break;
                case "King of Clubs":
                    ShowKingClubs();
                    break;
            }
        }

        private void ShowAceSpades()
        {
            picAce.Visible = true;
            pic10.Visible = false;
            picKing.Visible = false;
        }

        private void ShowTenHearts()
        {
            picAce.Visible = false;
            pic10.Visible = true;
            picKing.Visible = false;
        }

        private void ShowKingClubs()
        {
            picAce.Visible = false;
            pic10.Visible = false;
            picKing.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
