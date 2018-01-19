using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace station
{
    public partial class frmStytrain : Form
    {
        public frmStytrain()
        {
            InitializeComponent();
        }

        string[] stationlist = new string[7];
        private void frmStytrain_Load(object sender, EventArgs e)
        {
            StreamReader stationfile = File.OpenText("c:\\temp\\sampleRichmond.txt");
            
            string station;
            
            int x = 0;

            while (stationfile.EndOfStream!=true)
            {
                station = stationfile.ReadLine();
                lstStart.Items.Add(station);
                lstEnd.Items.Add(station);
                stationlist[x] = station;
                x++;
            }


        }

        private void btnRoute_Click(object sender, EventArgs e)
        {
            lstRoute.Items.Clear();
            string start = lstStart.Text, end = lstEnd.Text;
            int startPt = 0, endPt = 0;

            if (start == end)
            {
                MessageBox.Show("Please select different origin and destiny station");
            }
            else
            {
                if (lstStart.SelectedItem == null)
                {
                    MessageBox.Show("Please select a origin station");
                }
                if (lstEnd.SelectedItem == null)
                {
                    MessageBox.Show("Please select a destiny station");
                }
            }

            for (int x = 0; x < 7; x++)
            {
                if (lstStart.Text == stationlist[x])
                {
                    startPt = x;
                }
                if (lstEnd.Text == stationlist[x])
                {
                    endPt = x;
                }
            }

            if (startPt < endPt)
            {
                for (int y = startPt; y <= endPt; y++)
                {
                    lstRoute.Items.Add(stationlist[y]);
                }
            }
            else
            { 
                for (int yy = startPt; yy >= endPt; yy--)
                {
                    lstRoute.Items.Add(stationlist[yy]);
                }
            }
        }

        private void lstStart_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int x =0; x<7;x++)
            {
                if (lstStart.Text == stationlist[x])
                {
                    label1.Text = x.ToString();
                }
            }
        }
    }
}
