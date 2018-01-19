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

namespace NorthAmerica
{
    public partial class frmNorth : Form
    {
        public frmNorth()
        {
            InitializeComponent();
        }

        private void GetFileName (out string selectedFile)
        {
            if(openFile.ShowDialog() == DialogResult.OK)
            {
                selectedFile = openFile.FileName;
            }
            else
            {
                selectedFile = "";
            }
        }        

        private void GetCountries (string fileName)
        {
            try
            {
                string countryname;

                StreamReader inputFile;

                inputFile = File.OpenText(fileName);

                lstCountries.Items.Clear();
                while (inputFile.EndOfStream != true)
                {
                    countryname = inputFile.ReadLine();
                    lstCountries.Items.Add(countryname);
                }
                inputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            string filename;

            GetFileName(out filename);
            GetCountries(filename);
        }
    }
}
