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
            }

            for (int i = 0; l_CanadaBranch.EndOfStream != true; i++)
            {
                stl2[i] = l_CanadaBranch.ReadLine();
            }

            for (int i = 0; l_Expoline.EndOfStream != true; i++)
            {
                stl3[i] = l_Expoline.ReadLine();
            }

            for (int i = 0; l_ExpolineBranch.EndOfStream != true; i++)
            {
                stl4[i] = l_ExpolineBranch.ReadLine();
            }

            for (int i = 0; l_Millenium.EndOfStream != true; i++)
            {
                stl5[i] = l_Millenium.ReadLine();
            }

           
            for (int i = 0; i < stl1.Length; i++)
            {
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

            for (int i = 0; i < stl2.Length; i++)
            {
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

            for (int i = 0; i < stl3.Length; i++)
            {
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

            for (int i = 0; i < stl4.Length; i++)
            {
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

            for (int i = 0; i < stl5.Length; i++)
            {
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
            string start = "", end = "";
            string[] posStartline = new string[5];
            string[] posStartSation = new string[5];
            string[] posEndline = new string[5];
            string[] posEndStation = new string[5];

            string[] connectionsLs = new string[5];
            string[] connectionsSs = new string[5];
            string[] connectionsLe = new string[5];
            string[] connectionsSe = new string[5];

            start = lstStart.SelectedItem.ToString();
            end = lstEnd.SelectedItem.ToString();


            if(Array.IndexOf(stl1, start)!=-1)
            {
                posStartSation[0] = Array.IndexOf(stl1, start).ToString();
                posStartline[0] = "1";
                lstRoute.Items.Add(string.Format(fmt, "Line  " + posStartline[0], " Station  " + posStartSation[0]));
            }
            if (Array.IndexOf(stl2, start) != -1)
            {
                posStartSation[1] = Array.IndexOf(stl2, start).ToString();
                posStartline[1] = "2";
                lstRoute.Items.Add(string.Format(fmt, "Line  " + posStartline[1], " Station  " + posStartSation[1]));
            }
            if (Array.IndexOf(stl3, start) != -1)
            {
                posStartSation[2] = Array.IndexOf(stl3, start).ToString();
                posStartline[2] = "3";
                lstRoute.Items.Add(string.Format(fmt, "Line  " + posStartline[2], " Station  " + posStartSation[2]));
            }    
            if (Array.IndexOf(stl4, start) != -1)
            {
                posStartSation[3] = Array.IndexOf(stl4, start).ToString();
                posStartline[3] = "4";
                lstRoute.Items.Add(string.Format(fmt, "Line  " + posStartline[3], " Station  " + posStartSation[3]));
            }
            if (Array.IndexOf(stl5, start) != -1)
            {
                posStartSation[4] = Array.IndexOf(stl5, start).ToString();
                posStartline[4] = "5";
                lstRoute.Items.Add(string.Format(fmt, "Line  " + posStartline[4], " Station  " + posStartSation[4]));
            }
            
            

            lstRoute.Items.Add("_______________");

            

            if (Array.IndexOf(stl1, end) != -1)
            {
                posEndStation[0] = Array.IndexOf(stl1, end).ToString();
                posEndline[0] = "1";
                lstRoute.Items.Add(string.Format(fmt, "Line  " + posEndline[0], " Station  " + posEndStation[0]));
            }
            if (Array.IndexOf(stl2, end) != -1)
            {
                posEndStation[1] = Array.IndexOf(stl2, end).ToString();
                posEndline[1] = "2";
                lstRoute.Items.Add(string.Format(fmt, "Line  " + posEndline[1], " Station  " + posEndStation[1]));

            }
            if (Array.IndexOf(stl3, end) != -1)
            {
                posEndStation[2] = Array.IndexOf(stl3, end).ToString();
                posEndline[2] = "3";
                lstRoute.Items.Add(string.Format(fmt, "Line  " + posEndline[2], " Station  " + posEndStation[2]));
            }
            if (Array.IndexOf(stl4, end) != -1)
            {
                posEndStation[3] = Array.IndexOf(stl4, end).ToString();
                posEndline[3] = "4";
                lstRoute.Items.Add(string.Format(fmt, "Line  " + posEndline[3], " Station  " + posEndStation[3]));
            }
            if (Array.IndexOf(stl5, end) != -1)
            {
                posEndStation[4] = Array.IndexOf(stl5, end).ToString();
                posEndline[4] = "5";
                lstRoute.Items.Add(string.Format(fmt, "Line  " + posEndline[4], " Station  " + posEndStation[4]));
            }

           
   

            lstRoute.Items.Add("-----");
            lstRoute.Items.Add(string.Format(fmt,  posStartline[0],  posStartSation[0]));
            lstRoute.Items.Add(string.Format(fmt,  posStartline[1],  posStartSation[1]));
            lstRoute.Items.Add(string.Format(fmt,  posStartline[2],  posStartSation[2]));
            lstRoute.Items.Add(string.Format(fmt,  posStartline[3],  posStartSation[3]));
            lstRoute.Items.Add(string.Format(fmt,  posStartline[4],  posStartSation[4]));
            lstRoute.Items.Add("-----");
            lstRoute.Items.Add(string.Format(fmt, posEndline[0], posEndStation[0]));
            lstRoute.Items.Add(string.Format(fmt, posEndline[1], posEndStation[1]));
            lstRoute.Items.Add(string.Format(fmt, posEndline[2], posEndStation[2]));
            lstRoute.Items.Add(string.Format(fmt, posEndline[3], posEndStation[3]));
            lstRoute.Items.Add(string.Format(fmt, posEndline[4], posEndStation[4]));

        }
     }
}


