using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo2Week10
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
            for (int x = 0; x <= 4; x++)
            {
                yourCoin.flip();
                lstResult.Items.Add(yourCoin.getSide());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pet myDog = new Pet();
            Pet yourCat = new Pet();

            myDog.PetName = "Fido";
           
            MessageBox.Show("my pet is called " + myDog.PetName);
            MessageBox.Show("your pet is called " + yourCat.PetName);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Quiz myQuiz = new Quiz(30, 90, 10, 60);
            MessageBox.Show("the best avg is " + myQuiz.Avg());
        }
    }
}
