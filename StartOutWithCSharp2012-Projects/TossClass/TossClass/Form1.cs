using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TossClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnToss_Click(object sender, EventArgs e)
        {
            Coin myCoin = new Coin();
            lstResult.Items.Clear();


            for (int i = 0; i < 5; i++)
            {
                myCoin.Toss();
                lstResult.Items.Add("The face is " + myCoin.getSideUp());

            }
        }


        private void btnMethodFlip_Click(object sender, EventArgs e)
        {
            Coin myCoin = new TossClass.Coin();
            myCoin.Toss();
            flipCoin(myCoin);
            lstResult.Items.Add("The side is =>" + myCoin.getSideUp());
            
        }

        private void flipCoin(Coin asdf)
        {
            asdf.getSideUp();
        }

        private void btnPet_Click(object sender, EventArgs e)
        {
            Pet myDog = new Pet();
            myDog.name = "Jayjay";
            myDog.weight = "60";

            Pet myBird = new Pet();
            myBird.name = "Tweet";

            lstResult.Items.Add("My pet is Dog called " + myDog.name);
            lstResult.Items.Add("My Dog weights " + myDog.weight + " lb");
            lstResult.Items.Add(myDog.fullCharacteristics);
            lstResult.Items.Add("----");
            lstResult.Items.Add("My pet is Bird called " + myBird.name);
            lstResult.Items.Add("My Bird weights " + myBird.weight +" lb");
            lstResult.Items.Add(myBird.fullCharacteristics);

        }
    }
}
