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

namespace ArrayFileCreate
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        const int size = 8;
        int[] numbers = new int[size];

        private void Form1_Load(object sender, EventArgs e)
        {
            FileLer();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            FileCriar();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            FileLer();
        }

        private void FileLer()
        {
            try
            {
                lstContent.Items.Clear();
                lstContentABC.Items.Clear();
                
                StreamReader Arq = File.OpenText("Arquivo.txt");
                int station;

                for ( int x =0; x < numbers.Length; x++)
                {
                    numbers[x] = int.Parse(Arq.ReadLine());
                    lstContent.Items.Add(numbers[x]);
                    lstContentABC.Items.Add(numbers[x]);
                    station = x;
                }

                Arq.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FileCriar()
        {

            try
            {
                int[] numbers = new int[size];
                Random rand = new Random();
                
                for( int num=0; num < numbers.Length; num++)
                {
                    numbers[num] = rand.Next(28);
                }

                StreamWriter novoArquivo = File.CreateText("Arquivo.txt");

                for (int x=0; x< numbers.Length; x++)
                {
                    novoArquivo.WriteLine(numbers[x]);
                }
                    novoArquivo.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            preencher();

        }

        private void preencher()
        {
            int[] score = new int[size];
            score[0] = 10;
            score[1] = 10;
            score[2] = 10;
            score[3] = 10;
            score[4] = 10;
            score[5] = 10;
            score[6] = 10;
            score[7] = 10;

            int amtScore = 0;
            for (int x = 0; x < score.Length; x++)
            {
                lstContent.Items.Add(score[x]);
                amtScore = amtScore + score[x];
            }

            lstContent.Items.Add("");
            lstContent.Items.Add("Amount score "+amtScore );
            lstContent.Items.Add("______________");

            setTozero(score);

            for (int x = 0; x < score.Length; x++)
            {
                lstContent.Items.Add(score[x]);
            }
        }
        private void setTozero (int[] score)
        {
            for (int x = 0; x< score.Length; x++)
            {
                score[x] = 0;
            }
            return;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string start= lstContent.Text, end= lstContentABC.Text;
            StreamReader inFile = File.OpenText("arquivo.txt");
            int[] station = new int[size];
            
            if (start == end)
            {
                MessageBox.Show("Please select different origin and destiny"+"start "+start+"end "+end);
            }




        }


    }
}
