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

        string[][] stationlist = new string[5][];
        string[] lineName = { "-- Canada Line --", "-- Canada Line Airport Branch --", "-- Millennium --", "-- Expo Line --", "-- Expo Line Branch Lougheed --" };
        string station;


        private void frmStytrain_Load(object sender, EventArgs e)
        {
            stationlist[0] = new string[13];
            stationlist[1] = new string[4];
            stationlist[2] = new string[17];
            stationlist[3] = new string[20];
            stationlist[4] = new string[5];
            
            StreamReader l_Canada = File.OpenText("c:\\temp\\_CanadaLine.txt");
            StreamReader l_CanadaBranch = File.OpenText("c:\\temp\\_CanadaLine_Airport_branch.txt");
            StreamReader l_Millenium = File.OpenText("c:\\temp\\_Millennium_Line.txt");
            StreamReader l_Expoline = File.OpenText("c:\\temp\\_Expo_Line.txt");
            StreamReader l_ExpolineBranch = File.OpenText("c:\\temp\\_Expo_Line_Lougheed_branch.txt");
            
            for (int i = 0;  l_Canada.EndOfStream!=true; i++)
            {
                if (i>9)
                {
                    station = i + "_" + l_Canada.ReadLine();
                }
                else
                { 
                    station = i + "__" + l_Canada.ReadLine();
                }
                stationlist[0][i] = station;
            }

            for (int i = 0; l_CanadaBranch.EndOfStream != true; i++)
            {
                if (i > 9)
                {
                    station = i + "_" + l_CanadaBranch.ReadLine();
                }
                else
                {
                    station = i + "__" + l_CanadaBranch.ReadLine();
                }
                    stationlist[1][i] = station;
            }

            for (int i = 0; l_Millenium.EndOfStream != true; i++)
            {
                if (i > 9)
                {
                    station = i + "_" + l_Millenium.ReadLine();
                }
                else
                {
                    station = i + "__" + l_Millenium.ReadLine();
                }
                    stationlist[2][i] = station;    
            }

            for (int i = 0; l_Expoline.EndOfStream != true; i++)
            {
                if (i > 9)
                {
                    station = i + "_" + l_Expoline.ReadLine();
                }
                else
                {
                    station = i + "__" + l_Expoline.ReadLine();
                }
                stationlist[3][i] = station;
            }

            for (int i = 0; l_ExpolineBranch.EndOfStream != true; i++)
            {
                if (i > 9)
                {
                    station = i + "_" + l_ExpolineBranch.ReadLine();
                }
                else
                {
                    station = i + "__" + l_ExpolineBranch.ReadLine();
                }
                stationlist[4][i] = station;
            }

            for (int i = 0; i < stationlist.Length; i++)
            {
                string[] innerArray = stationlist[i];
                for (int j=0; j<innerArray.Length; j++ )
                {
                    if (lstEnd.Items.Contains(innerArray[j].Substring(3)))
                    {
                        lstEnd.Items.Remove(innerArray[j].Substring(3));
                    }
                    lstEnd.Items.Add(innerArray[j].Substring(3));
                    if (lstStart.Items.Contains(innerArray[j].Substring(3)))
                    {
                        lstStart.Items.Remove(innerArray[j].Substring(3));
                    }
                    lstStart.Items.Add(innerArray[j].Substring(3));
                }
                
            }

            

            /*for (int i = 0; i < stationlist.Length; i++)
            {
                string[] innerArray = stationlist[i];
                lstRoute.Items.Add(lineName[i]);
                for (int j = 0; j < innerArray.Length; j++)
                {
                    lstRoute.Items.Add(innerArray[j]);
                }

            }*/
            label1.Text = lstRoute.Items.Count.ToString();
            //MessageBox.Show(lstStart.Contains(lineName[]));

        }

        private void btnRoute_Click(object sender, EventArgs e)
        {

            lstRoute.Items.Clear();
            /*int startLinePt = 0, endLinePt = 0, startPt = 0, endPt = 0;*/

            if (lstStart.Text == lstEnd.Text)
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

            
            MessageBox.Show(lstEnd.SelectedItem.ToString());


        }

        private void lstRoute_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void lstEnd_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = lstEnd.SelectedIndex.ToString();            
        }
    }

        

        
    }

