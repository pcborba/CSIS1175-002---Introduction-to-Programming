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

            HashSet<string> lstFulfill = new HashSet<string>();

            for (int i = 0; l_Canada.EndOfStream != true; i++)
            {
                stl1[i] = l_Canada.ReadLine();
                lstFulfill.Add(stl1[i]);
            }

            for (int i = 0; l_CanadaBranch.EndOfStream != true; i++)
            {
                stl2[i] = l_CanadaBranch.ReadLine();
                lstFulfill.Add(stl2[i]);
            }

            for (int i = 0; l_Expoline.EndOfStream != true; i++)
            {
                stl3[i] = l_Expoline.ReadLine();
                lstFulfill.Add(stl3[i]);
            }

            for (int i = 0; l_ExpolineBranch.EndOfStream != true; i++)
            {
                stl4[i] = l_ExpolineBranch.ReadLine();
                lstFulfill.Add(stl4[i]);
            }

            for (int i = 0; l_Millenium.EndOfStream != true; i++)
            {
                stl5[i] = l_Millenium.ReadLine();
                lstFulfill.Add(stl5[i]);
            }

            foreach (string n in lstFulfill)
            {
                lstStart.Items.Add(n);
                lstEnd.Items.Add(n);
            }
            

        }
        private void btnRoute_Click(object sender, EventArgs e)
        {
            lstRoute.Items.Clear();


            //string fmt = "{0,-20}{1,10}";
            string start = "", end = "", startL = ""/* , endL = "", startSn = "", endSn = "", startSnum = "", endSnum = ""*/;
            //string cS = "";
            //string cE = "";

            string[] cL1 = { "1", "Waterfront", "Bridgeport" };
            string[] cL2 = { "2", "Bridgeport" };
            string[] cL3 = { "3", "Waterfront", "Commercial–Broadway", "Columbia" };
            string[] cL4 = { "4", "Columbia", "Lougheed Town Centre", "Production Way–University" };
            string[] cL5 = { "5", "Commercial–Broadway", "Lougheed Town Centre", "Production Way–University" };

            List<string> sSlist = new List<string>();
            List<int> sSlistSnumber = new List<int>();
            List<int> sSlistNumber = new List<int>();
            List<string> eSlist = new List<string>();
            List<int> eSlistSnumber = new List<int>();
            List<int> eSlistNumber = new List<int>();

            start = lstStart.SelectedItem.ToString();
            end = lstEnd.SelectedItem.ToString();

            for (int i = 0; i < stl1.Length; i++)
            {
                if (stl1[i] == start)
                {
                    sSlist.Add(stl1[i]);
                    sSlistSnumber.Add(Array.IndexOf(stl1, start));
                    sSlistNumber.Add(1);
                }
            }

            for (int i = 0; i < stl2.Length; i++)
            {
                if (stl2[i] == start)
                {
                    sSlist.Add(stl2[i]);
                    sSlistSnumber.Add(Array.IndexOf(stl2, start));
                    sSlistNumber.Add(2);
                }
            }

            for (int i = 0; i < stl3.Length; i++)
            {
                if (stl3[i] == start)
                {
                    sSlist.Add(stl3[i]);
                    sSlistSnumber.Add(Array.IndexOf(stl3, start));
                    sSlistNumber.Add(3);
                }
            }

            for (int i = 0; i < stl4.Length; i++)
            {
                if (stl4[i] == start)
                {
                    sSlist.Add(stl4[i]);
                    sSlistSnumber.Add(Array.IndexOf(stl4, start));
                    sSlistNumber.Add(4);
                }
            }

            for (int i = 0; i < stl5.Length; i++)
            {
                if (stl5[i] == start)
                {
                    sSlist.Add(stl5[i]);
                    sSlistSnumber.Add(Array.IndexOf(stl5, start));
                    sSlistNumber.Add(5);
                }
            }

            for (int i = 0; i < stl1.Length; i++)
            {
                if (stl1[i] == end)
                {
                    eSlist.Add(stl1[i]);
                    eSlistSnumber.Add(Array.IndexOf(stl1, end));
                    eSlistNumber.Add(1);
                }
            }

            for (int i = 0; i < stl2.Length; i++)
            {
                if (stl2[i] == end)
                {
                    eSlist.Add(stl2[i]);
                    eSlistSnumber.Add(Array.IndexOf(stl2, end));
                    eSlistNumber.Add(2);
                }
            }

            for (int i = 0; i < stl3.Length; i++)
            {
                if (stl3[i] == end)
                {
                    eSlist.Add(stl3[i]);
                    eSlistSnumber.Add(Array.IndexOf(stl3, end));
                    eSlistNumber.Add(3);
                }
            }

            for (int i = 0; i < stl4.Length; i++)
            {
                if (stl4[i] == end)
                {
                    eSlist.Add(stl4[i]);
                    eSlistSnumber.Add(Array.IndexOf(stl4, end));
                    eSlistNumber.Add(4);
                }
            }
            for (int i = 0; i < stl5.Length; i++)
            {
                if (stl5[i] == end)
                {
                    eSlist.Add(stl5[i]);
                    eSlistSnumber.Add(Array.IndexOf(stl5, end));
                    eSlistNumber.Add(5);
                }
            }

            int counter = 0;
            int spos = 0;
            int dpos = 0;
            string [] sL = new string [2];
            string[] eL = new string[2];

            for (int i=0; i < sSlistNumber.Count; i++)
            {
                sL[i] = sSlistNumber[i].ToString();
                spos = sSlistSnumber[i];
                MessageBox.Show(sSlistNumber[i].ToString());
            }
            for (int i = 0; i < eSlistNumber.Count; i++)
            {
                eL[i] = eSlistNumber[i].ToString();
                dpos = eSlistSnumber[i];
                MessageBox.Show(eSlistNumber[i].ToString());
            }

            var inter = sL.Intersect(eL);
            //int smaller = 100;
            foreach (string n in inter)
            {
                if (n == null)
                {
                    for (int i =0; i < sSlistNumber.Count; i++)
                    {

                        startL = Array.IndexOf(cL1, sSlistNumber[i]).ToString();
                        foreach (string a in cL1)
                        {
                            
                            dpos = Array.IndexOf(cL1, a);

                            if (dpos > spos)
                            {

                                while (spos != dpos)
                                {
                                    lstRoute.Items.Add(stl1[spos]);
                                    spos++;
                                    counter++;
                                }
                                lstRoute.Items.Add(stl1[spos]);
                            }
                            else
                            {
                                while (spos != dpos)
                                {
                                    lstRoute.Items.Add(stl1[spos]);
                                    spos--;
                                    counter++;
                                }
                                lstRoute.Items.Add(stl1[spos]);
                            }



                        }



                    }
                }
                for (int c = 0; c < sSlistNumber.Count; c++)
                {
                    if (sSlistNumber[c] == 1)
                    {
                        if (n != "-1")
                        {
                            if (dpos > spos)
                            {

                                while (spos != dpos)
                                {
                                    lstRoute.Items.Add(stl1[spos]);
                                    spos++;
                                    counter++;
                                }
                                lstRoute.Items.Add(stl1[spos]);
                            }
                            else
                            {
                                while (spos != dpos)
                                {
                                    lstRoute.Items.Add(stl1[spos]);
                                    spos--;
                                    counter++;
                                }
                                lstRoute.Items.Add(stl1[spos]);
                            }
                        }
                    }
                }
            }
                    



                    /*
                    for (int c = 0; c < sSlistNumber.Count; c++)
                    {
                        if (sSlistNumber[c] == 1)
                        {
                            foreach (string n in inter)
                            {
                                if (n != "-1")
                                {
                                    if (dpos > spos)
                                    {

                                        while (spos != dpos)
                                        {
                                            lstRoute.Items.Add(stl1[spos]);
                                            spos++;
                                            counter++;
                                        }
                                        lstRoute.Items.Add(stl1[spos]);
                                    }
                                    else
                                    {
                                        while (spos != dpos)
                                        {
                                            lstRoute.Items.Add(stl1[spos]);
                                            spos--;
                                            counter++;
                                        }
                                        lstRoute.Items.Add(stl1[spos]);
                                    }
                                }
                            }

                            if (sSlistNumber[c] == 2)
                            {
                                foreach (string n in inter)
                                {
                                    if (n != "-1")
                                    {
                                        if (dpos > spos)
                                        {

                                            while (spos != dpos)
                                            {
                                                lstRoute.Items.Add(stl2[spos]);
                                                spos++;
                                                counter++;
                                            }
                                            lstRoute.Items.Add(stl2[spos]);
                                        }
                                        else
                                        {
                                            while (spos != dpos)
                                            {
                                                lstRoute.Items.Add(stl2[spos]);
                                                spos--;
                                                counter++;
                                            }
                                            lstRoute.Items.Add(stl2[spos]);
                                        }
                                    }
                                }
                            }

                            if (sSlistNumber[c] == 3)
                            {
                                foreach (string n in inter)
                                {
                                    if (n != "-1")
                                    {
                                        if (dpos > spos)
                                        {

                                            while (spos != dpos)
                                            {
                                                lstRoute.Items.Add(stl3[spos]);
                                                spos++;
                                                counter++;
                                            }
                                            lstRoute.Items.Add(stl3[spos]);
                                        }
                                        else
                                        {
                                            while (spos != dpos)
                                            {
                                                lstRoute.Items.Add(stl3[spos]);
                                                spos--;
                                                counter++;
                                            }
                                            lstRoute.Items.Add(stl3[spos]);
                                        }
                                    }
                                }
                            }

                            if (sSlistNumber[c] == 4)
                            {
                                foreach (string n in inter)
                                {
                                    if (n != "-1")
                                    {
                                        if (dpos > spos)
                                        {

                                            while (spos != dpos)
                                            {
                                                lstRoute.Items.Add(stl4[spos]);
                                                spos++;
                                                counter++;
                                            }
                                            lstRoute.Items.Add(stl4[spos]);
                                        }
                                        else
                                        {
                                            while (spos != dpos)
                                            {
                                                lstRoute.Items.Add(stl4[spos]);
                                                spos--;
                                                counter++;
                                            }
                                            lstRoute.Items.Add(stl4[spos]);
                                        }
                                    }
                                }
                            }

                            if (sSlistNumber[c] == 5)
                            {
                                foreach (string n in inter)
                                {
                                    if (n != "-1")
                                    {
                                        if (dpos > spos)
                                        {

                                            while (spos != dpos)
                                            {
                                                lstRoute.Items.Add(stl5[spos]);
                                                spos++;
                                                counter++;
                                            }
                                            lstRoute.Items.Add(stl5[spos]);
                                        }
                                        else
                                        {
                                            while (spos != dpos)
                                            {
                                                lstRoute.Items.Add(stl5[spos]);
                                                spos--;
                                                counter++;
                                            }
                                            lstRoute.Items.Add(stl5[spos]);
                                        }
                                    }
                                }
                            }

                        }



                        for (int i = 0; i < sSlist.Count; i++)
                        {
                            lstRoute.Items.Add(string.Format(fmt, sSlist[i]+" "+sSlistSnumber[i], " "+sSlistNumber[i]));
                        }

                        lstRoute.Items.Add("----8888------");

                        for (int i = 0; i < eSlist.Count; i++)
                        {
                            lstRoute.Items.Add(string.Format(fmt, eSlist[i] + " " + eSlistSnumber[i], " " + eSlistNumber[i]));
                        }   


                        //startL = 

                        //int smaller = 100;

                        /*
                        int counter = 0;

                        int sl = 0;
                        int el = 0;


                        for (int i = 0; i < sSlistNumber.Count;i++)
                        {
                            sl = sSlistNumber[i];
                            el = eSlistNumber[i];
                            if (sl==el)
                                {
                                spos = sSlistSnumber[i];
                                dpos = eSlistSnumber[i];


                                if (dpos > spos)
                                {

                                    while (spos != dpos)
                                    {
                                        lstRoute.Items.Add(stl1[spos]);
                                        spos++;
                                        counter++;
                                    }
                                    lstRoute.Items.Add(stl1[spos]);
                                }
                                else
                                {
                                    while (spos != dpos)
                                    {
                                        lstRoute.Items.Add(stl1[spos]);
                                        spos--;
                                        counter++;
                                    }
                                    lstRoute.Items.Add(stl1[spos]);
                                }
                                }
                            else
                            {

                            }
                        }




                        List<string[]> con = new List<string[]>() { cL1, cL2, cL3, cL4, cL5};



                        //MessageBox.Show("Connection s " + cS + "Connection e " + cE);*/




         }
    }
}

