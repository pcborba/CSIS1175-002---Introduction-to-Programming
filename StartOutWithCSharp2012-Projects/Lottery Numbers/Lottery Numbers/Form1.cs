using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lottery_Numbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            const int size = 5;
            int[] numRam = new int[size];

            Random rand = new Random();

            for (int x = 0; x < numRam.Length; x++)
            {
                numRam[x] = rand.Next(100);
            }

            textBox1.Text = numRam[0].ToString();
            textBox2.Text = numRam[1].ToString();
            textBox3.Text = numRam[2].ToString();
            textBox4.Text = numRam[3].ToString();
            textBox5.Text = numRam[4].ToString();

        }
    }
}
