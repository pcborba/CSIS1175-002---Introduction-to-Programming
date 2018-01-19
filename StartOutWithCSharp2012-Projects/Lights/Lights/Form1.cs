using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lights
{
    public partial class frmLights : Form
    {
        public frmLights()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            if(picOn.Visible==true)
            {
                switchLightOff();
            }else
            {
                switchLightOn();
            }

        }

        private void switchLightOn ()
        {
            picOn.Visible = true;
            picOff.Visible = false;
            lblState.Text = "ON";
        }

        private void switchLightOff()
        {
            picOn.Visible = false;
            picOff.Visible = true;
            lblState.Text = "OFF";
        }
    }
}
