using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo2Week10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnToss_Click(object sender, EventArgs e)
        {
            Coin yourCoin = new Coin();
            for (int i = 0; i <=4; i++)
            {
                yourCoin.Toss();
                lstResult.Items.Add(yourCoin.getSide());
            }
        }

        private void btnPet_Click(object sender, EventArgs e)
        {
            Pet myDog = new Demo2Week10.Pet();
            Pet yourCat = new Demo2Week10.Pet();

            myDog.PetName = "Fido";
            MessageBox.Show("My pet is called " + myDog.PetName);
            MessageBox.Show("YOur pet is called " + yourCat.PetName);
        }

        private void btnAvg_Click(object sender, EventArgs e)
        {
            Quiz myQuiz = new Quiz(120,90,10,60);

            lstResult.Items.Add("Best avg is " + myQuiz.Avg());
        }
    }
}
