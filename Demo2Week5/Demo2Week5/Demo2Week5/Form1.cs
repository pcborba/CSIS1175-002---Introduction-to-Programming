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

namespace Demo2Week5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pic.ImageLocation == "c:\\temp\\Lighthouse.jpg")
            {
                pic.ImageLocation = "c:\\temp\\Jellyfish.jpg";
            }
            else
            {
                pic.ImageLocation = "c:\\temp\\Lighthouse.jpg";
            }
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            //create an object called ranNum that is based 
            //on the Random Class
            Random ranNum = new Random();

            //count # of times
            int counter = 0;

            //continue to go through the loop until
            //counter is equal to 5
            while(counter < 5)
            {
                //generate a random number from 0 to 99
                lstNumber.Items.Add(ranNum.Next(100)+1);//add plus 1 I can asure that we won't have # 0

                //add 1 to counter to avoid an 
                //endless loop
                counter += 1;
            }

            //generate a random number from 0 to 99
            //lstNumber.Items.Add(ranNum.Next(100));


        }

        private void btnForLoop_Click(object sender, EventArgs e)
        {
            Random ranNum = new Random();
            for (int counter = 0; counter < 5; counter++)
            {
                lstNumber.Items.Add(ranNum.Next(6) + 1);
            }
            

        }

        private void btnDoLoop_Click(object sender, EventArgs e)
        {
            Random ranNum = new Random();
            int counter = 0;
            do
            {
                lstNumber.Items.Add(ranNum.Next(6) + 1);
                counter += 1;
            } while (counter < 5) ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //create an object called inFile that is based
            //on the StreamReader class. Opent Text file
            //that is stored in c:\temp. The name of the
            //text file is called simplesname.txt
            StreamReader inFile = File.OpenText("c:\\temp\\simpleNames.txt");

            //if there are still data in the input file
            //do what is inside the while loop
            while (inFile.EndOfStream!=true)
            {
                //read one line at a time and show
                //the content on the listbox
                listBox1.Items.Add(inFile.ReadLine());
            }

            //close the file
            inFile.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            StreamReader inFile = File.OpenText("c:\\temp\\simpleNames.txt");

            //declare a string array without specific
            //size. The array is called names
            string[] names;

            string fmt = "{0,-10}{1,10}";

            int count = 0;

            while (inFile.EndOfStream != true)
            {
                //read in one line, split line
                //based on the space character
                names = inFile.ReadLine().Split(' ');
                
                //names[0] is the first column of 
                //the line read in
                listBox1.Items.Add(string.Format(fmt, names[0], names[1]));
                count += 1; //increase the counter               
            }

            //close the file
            inFile.Close();
            listBox1.Items.Add(" ");
            listBox1.Items.Add(" Total number of names: " + count);
            

        }

        private void button3_Click(object sender, EventArgs e)
        {

            //open the file simplesnamemarks and compute the average mark

            decimal quiz;
            decimal totalscore = 0;
            int count=0;
            string fmt = "{0,-8}{1,12}{2,5}";
            string[] column;
            StreamReader inputFIle = File.OpenText("c:\\temp\\simpleNamesMarks.txt");
            listBox1.Items.Clear();
            while (inputFIle.EndOfStream != true)
            {
                column = inputFIle.ReadLine().Split(' ');
                listBox1.Items.Add(string.Format(fmt, column[0],column[1],column[2]));
                quiz = decimal.Parse(column[2]);
                totalscore += quiz;
                count += 1;
                        
            }
            inputFIle.Close();
            listBox1.Items.Add("");
            listBox1.Items.Add("The avg is " + totalscore / count);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            decimal quiz;
            decimal totalscore = 0;
            int count = 0;
            string fmt = "{0,-8}{1,12}{2,5}";
            string[] column;
            StreamReader inputFIle = File.OpenText("c:\\temp\\simpleNamesMarks.txt");
            listBox1.Items.Clear();
            while (inputFIle.EndOfStream != true)
            {
                column = inputFIle.ReadLine().Split(' ');
                listBox1.Items.Add(string.Format(fmt, column[0], column[1], column[2]));
                quiz = decimal.Parse(column[2]);
                totalscore += quiz;
                count += 1;

            }
            inputFIle.Close();
            listBox1.Items.Add("");
            listBox1.Items.Add("The avg is " + totalscore / count);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] names;
            StreamReader inFile = File.OpenText("c:\\temp\\customers.txt");
            listBox1.Items.Clear();
            while (inFile.EndOfStream != true) 
            {
                names = inFile.ReadLine().Split(',');
                cboCustomer.Items.Add(names[0] + " " + names[1]);
            }

            inFile.Close();
        }

        private void cboCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {

            
            string[] column;
            string customerID;
            column = cboCustomer.SelectedItem.ToString().Split(' ');
            customerID = column[2];
            MessageBox.Show("The selected ID " + customerID);
            string[] rental;
            string fmt = "{0,-14:d}{1,14}{2,10}{3,10}";

            StreamReader inFile = File.OpenText("c:\\temp\\CustomersRentals.txt");
            listBox1.Items.Clear();
            while (inFile.EndOfStream!=true)
            {
                rental = inFile.ReadLine().Split(',');
                //search on the file for the matching
                //customer id

                if(customerID==rental[0])
                {
                    listBox1.Items.Add(string.Format(fmt, rental[1], rental[2], rental[3], rental[4]));
                }
            }
            inFile.Close();
           
            

        }
    }
}
