using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Car;


namespace Car
{
    public partial class Form1 : Form
    {
        private Car myCar = new Car(1978, "Ford Mustang");
        
        public Form1()
        {
            InitializeComponent();
            lblDescription.Text = myCar.make()+" "+myCar.year().ToString();
            lblWarning.Text = "";
        }


        private void picAccel_Click(object sender, EventArgs e)
        {
            lblWarning.Text = myCar.warningalert;
            myCar.accelerate(5);
            myCar.speed.ToString();
            picAccel.Height = 135;
            picAccel.Width = 75;
            picAccel.Height = 140;
            picAccel.Width = 80;
            picBreak.Height = 150;
            picBreak.Width = 150;

            lblSpeedometer.Text = myCar.speed.ToString();
        }

        private void picBreak_Click(object sender, EventArgs e)
        {
            myCar.breaking(5);
            myCar.speed.ToString();
            picBreak.Height = 135;
            picBreak.Width = 135;
            picBreak.Height = 140;
            picBreak.Width = 140;
            picAccel.Height = 150;
            picAccel.Width = 90;

            lblSpeedometer.Text = myCar.speed.ToString();
        }
    }
}
