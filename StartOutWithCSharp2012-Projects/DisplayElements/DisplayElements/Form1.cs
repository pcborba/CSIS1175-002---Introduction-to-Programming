﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisplayElements
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            const int size = 3;
            string[] names = new string[size];


            names[0] = txtN1.Text;
            names[1] = txtN2.Text;
            names[2] = txtN3.Text;

            MessageBox.Show(names[0] + " " + names[1] + " " + names[2] + " ");
        }
    }
}
