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
        string[] stl1 = new string[13];
        string[] stl2 = new string[4];
        string[] stl3 = new string[20];
        string[] stl4 = new string[5];
        string[] stl5 = new string[17];

        //string[] connections = new string[36];

        public frmStytrain()
        {
            InitializeComponent();
        }

        private void frmStytrain_Load(object sender, EventArgs e)
        {
            StreamReader l_Canada = File.OpenText("c:\\temp\\_CanadaLine.txt");
            StreamReader l_CanadaBranch = File.OpenText("c:\\temp\\_CanadaLine_Airport_branch.txt");
            StreamReader l_Expoline = File.OpenText("c:\\temp\\_Expo_Line.txt");
            StreamReader l_ExpolineBranch = File.OpenText("c:\\temp\\_Expo_Line_Lougheed_branch.txt");
            StreamReader l_Millenium = File.OpenText("c:\\temp\\_Millennium_Line.txt");
            StreamReader l_Connections = File.OpenText("c:\\temp\\_connections.txt");

            for (int i = 0; l_Canada.EndOfStream != true; i++)
            {
                stl1[i] = l_Canada.ReadLine();
                if (lstEnd.Items.Contains(stl1[i]))
                {
                    lstEnd.Items.Remove(stl1[i]);
                }
                lstEnd.Items.Add(stl1[i]);
                if (lstStart.Items.Contains(stl1[i]))
                {
                    lstStart.Items.Remove(stl1[i]);
                }
                lstStart.Items.Add(stl1[i]);
            }

            for (int i = 0; l_CanadaBranch.EndOfStream != true; i++)
            {
                stl2[i] = l_CanadaBranch.ReadLine();
                if (lstEnd.Items.Contains(stl2[i]))
                {
                    lstEnd.Items.Remove(stl2[i]);
                }
                lstEnd.Items.Add(stl2[i]);
                if (lstStart.Items.Contains(stl2[i]))
                {
                    lstStart.Items.Remove(stl2[i]);
                }
                lstStart.Items.Add(stl2[i]);
            }

            for (int i = 0; l_Expoline.EndOfStream != true; i++)
            {
                stl3[i] = l_Expoline.ReadLine();
                if (lstEnd.Items.Contains(stl3[i]))
                {
                    lstEnd.Items.Remove(stl3[i]);
                }
                lstEnd.Items.Add(stl3[i]);
                if (lstStart.Items.Contains(stl3[i]))
                {
                    lstStart.Items.Remove(stl3[i]);
                }
                lstStart.Items.Add(stl3[i]);
            }

            for (int i = 0; l_ExpolineBranch.EndOfStream != true; i++)
            {
                stl4[i] = l_ExpolineBranch.ReadLine();
                if (lstEnd.Items.Contains(stl4[i]))
                {
                    lstEnd.Items.Remove(stl4[i]);
                }
                lstEnd.Items.Add(stl4[i]);
                if (lstStart.Items.Contains(stl4[i]))
                {
                    lstStart.Items.Remove(stl4[i]);
                }
                lstStart.Items.Add(stl4[i]);
            }

            for (int i = 0; l_Millenium.EndOfStream != true; i++)
            {
                stl5[i] = l_Millenium.ReadLine();
                if (lstEnd.Items.Contains(stl5[i]))
                {
                    lstEnd.Items.Remove(stl5[i]);
                }
                lstEnd.Items.Add(stl5[i]);
                if (lstStart.Items.Contains(stl5[i]))
                {
                    lstStart.Items.Remove(stl5[i]);
                }
                lstStart.Items.Add(stl5[i]);
            }
        }
        private void btnRoute_Click(object sender, EventArgs e)
        {
            lstRoute.Items.Clear();
            

            string fmt = "{0,-20}{1,10}";
            string start = "", end = "", startL = "", endL = "", startSn = "", endSn = "", startSnum = "", endSnum = "";
            string cS = "";
            string cE = "";

            string[] cL1 = {"0", "Waterfront", "Bridgeport"};
            string[] cL2 = { "1", "Bridgeport" };
            string[] cL3 = { "2", "Waterfront", "Commercial–Broadway", "Columbia" };
            string[] cL4 = { "3", "Columbia", "Lougheed Town Centre", "Production Way–University" };
            string[] cL5 = { "4", "Commercial–Broadway", "Lougheed Town Centre", "Production Way–University" };


            start = lstStart.SelectedItem.ToString();
            end = lstEnd.SelectedItem.ToString();


            for (int i = 0; i < stl1.Length; i++)
            {
                if (stl1[i] == start)
                {
                    startL = "1";
                    startSn = stl1[i];
                    startSnum = Array.IndexOf(stl1, start).ToString();
                }
            }

            for (int i = 0; i < stl2.Length; i++)
            {
                if (stl2[i] == start)
                {
                    startL = "2";
                    startSn = stl2[i];
                    startSnum = Array.IndexOf(stl2, start).ToString();
                }
            }

            for (int i = 0; i < stl3.Length; i++)
            {
                if (stl3[i] == start)
                {
                    startL = "3";
                    startSn = stl3[i];
                    startSnum = Array.IndexOf(stl3, start).ToString();
                }
            }

            for (int i = 0; i < stl4.Length; i++)
            {
                if (stl4[i] == start)
                {
                    startL = "4";
                    startSn = stl4[i];
                    startSnum = Array.IndexOf(stl4, start).ToString();
                }
            }

            for (int i = 0; i < stl5.Length; i++)
            {
                if (stl5[i] == start)
                {
                    startL = "5";
                    startSn = stl5[i];
                    startSnum = Array.IndexOf(stl5, start).ToString();
                }
            }

            for (int i = 0; i < stl1.Length; i++)
            {
                if (stl1[i] == end)
                {
                    endL = "1";
                    endSn = stl1[i];
                    endSnum = Array.IndexOf(stl1, end).ToString();
                }
            }

            for (int i = 0; i < stl2.Length; i++)
            {
                if (stl2[i] == end)
                {
                    endL = "2";
                    endSn = stl2[i];
                    endSnum = Array.IndexOf(stl2, end).ToString();
                }
            }

            for (int i = 0; i < stl3.Length; i++)
            {
                if (stl3[i] == end)
                {
                    endL = "3";
                    endSn = stl3[i];
                    endSnum = Array.IndexOf(stl3, end).ToString();
                }
            }

            for (int i = 0; i < stl4.Length; i++)
            {
                if (stl4[i] == end)
                {
                    endL = "4";
                    endSn = stl4[i];
                    endSnum = Array.IndexOf(stl4, end).ToString();
                }
            }
            for (int i = 0; i < stl5.Length; i++)
            {
                if (stl5[i] == end)
                {
                    endL = "5";
                    endSn = stl5[i];
                    endSnum = Array.IndexOf(stl5, end).ToString();
                }
            }

            lstRoute.Items.Add(string.Format(fmt, startSn + "  ", endSn));

            MessageBox.Show("Start  " + startL + "  " + startSn + "  " + startSnum);
            MessageBox.Show("End  " + endL + "  " + endSn + "  " + endSnum);


            /*int counter = 0;
            int smallcounter = 100;
            string shortroute = "";

            for (int i = 0; i < connec.Length; i++)
            {
                for (int j = 0; j < connec[i].Length; j++)
                {
                    if (startL == connec[i][j])
                    {
                        cS = connec[i][j];
                    }
                }
            }

            for (int i = 0; i < connec.Length; i++)
            {
                for (int j = 0; j < connec[i].Length; j++)
                {
                    if (endL == connec[i][j])
                    {
                        cE = connec[i][j];
                    }
                }
            }
            */


            List<string[]> con = new List<string[]>() { cL1, cL2, cL3, cL4, cL5};



            //MessageBox.Show("Connection s " + cS + "Connection e " + cE);




        }
     }
}

