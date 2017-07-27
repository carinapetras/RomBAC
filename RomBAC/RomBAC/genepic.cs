using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RomBAC
{
    public partial class genepic : Form
    {
        
        string a,b;
        

        public genepic()
        {
            InitializeComponent();
   
        }

        private void pPreda_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
            richTextBox2.Visible = true;

            pPreda.Visible = false;
            pSlavici.Visible = false;
            pPetrescu.Visible = false;
            pCalinescu.Visible = false;
            pRebreanu.Visible = false;

            a = null;
            richTextBox1.ResetText();
            string[] text = System.IO.File.ReadAllLines("Morometii.txt");
            foreach (string s in text)
            {
                a = a + s;
                a = a + "\n";
            }
            richTextBox1.Text = a;

            b = null;
            richTextBox2.ResetText();
            string[] text1 = System.IO.File.ReadAllLines("Marin Preda.txt");
            foreach (string s in text1)
            {
                b = b + s;
                b = b + "\n";
            }
            richTextBox2.Text = b;

            pCreanga.Image = Image.FromFile("preda.png");
        }

        private void pSlavici_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
            richTextBox2.Visible = true;

            pPreda.Visible = false;
            pSlavici.Visible = false;
            pPetrescu.Visible = false;
            pCalinescu.Visible = false;
            pRebreanu.Visible = false;

            a = null;
            richTextBox1.ResetText();
            string[] text = System.IO.File.ReadAllLines("Moara cu noroc.txt");
            foreach (string s in text)
            {
                a = a + s;
                a = a + "\n";
            }
            richTextBox1.Text = a;

            b = null;
            richTextBox2.ResetText();
            string[] text1 = System.IO.File.ReadAllLines("Ioan Slavici.txt");
            foreach (string s in text1)
            {
                b = b + s;
                b = b + "\n";
            }
            richTextBox2.Text = b;

            pCreanga.Image = Image.FromFile("slavici.png");

        }

        private void pRebreanu_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
            richTextBox2.Visible = true;

            pPreda.Visible = false;
            pSlavici.Visible = false;
            pPetrescu.Visible = false;
            pCalinescu.Visible = false;
            pRebreanu.Visible = false;

            a = null;
            richTextBox1.ResetText();
            string[] text = System.IO.File.ReadAllLines("Ion.txt");
            foreach (string s in text)
            {
                a = a + s;
                a = a + "\n";
            }
            richTextBox1.Text = a;

            b = null;
            richTextBox2.ResetText();
            string[] text1 = System.IO.File.ReadAllLines("Liviu Rebreanu.txt");
            foreach (string s in text1)
            {
                b = b + s;
                b = b + "\n";
            }
            richTextBox2.Text = b;

            pCreanga.Image = Image.FromFile("rebreanu.png");

        }
        
        private void pSadoveanu_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
            richTextBox2.Visible = true;

            pPreda.Visible = false;
            pSlavici.Visible = false;
            pPetrescu.Visible = false;
            pCalinescu.Visible = false;
            pRebreanu.Visible = false;

            a = null;
            richTextBox1.ResetText();
            string[] text = System.IO.File.ReadAllLines("Baltagul.txt");
            foreach (string s in text)
            {
                a = a + s;
                a = a + "\n";
            }
            richTextBox1.Text = a;

            b = null;
            richTextBox2.ResetText();
            string[] text1 = System.IO.File.ReadAllLines("Mihail Sadoveanu.txt");
            foreach (string s in text1)
            {
                b = b + s;
                b = b + "\n";
            }
            richTextBox2.Text = b;

            pCreanga.Image = Image.FromFile("sadoveanu.png");

        }

        private void pPetrescu_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
            richTextBox2.Visible = true;

            pPreda.Visible = false;
            pSlavici.Visible = false;
            pPetrescu.Visible = false;
            pCalinescu.Visible = false;
            pRebreanu.Visible = false;

            a = null;
            richTextBox1.ResetText();
            string[] text = System.IO.File.ReadAllLines("Ultima noapte de dragoste.txt");
            foreach (string s in text)
            {
                a = a + s;
                a = a + "\n";
            }
            richTextBox1.Text = a;

            b = null;
            richTextBox2.ResetText();
            string[] text1 = System.IO.File.ReadAllLines("Camil Petrescu.txt");
            foreach (string s in text1)
            {
                b = b + s;
                b = b + "\n";
            }
            richTextBox2.Text = b;

            pCreanga.Image = Image.FromFile("petrescu.png");

        }

        private void pCalinescu_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
            richTextBox2.Visible = true;

            pPreda.Visible = false;
            pSlavici.Visible = false;
            pPetrescu.Visible = false;
            pCalinescu.Visible = false;
            pRebreanu.Visible = false;

            a = null;
            richTextBox1.ResetText();
            string[] text = System.IO.File.ReadAllLines("Enigma Otiliei.txt");
            foreach (string s in text)
            {
                a = a + s;
                a = a + "\n";
            }
            richTextBox1.Text = a;

            b = null;
            richTextBox2.ResetText();
            string[] text1 = System.IO.File.ReadAllLines("George Calinescu.txt");
            foreach (string s in text1)
            {
                b = b + s;
                b = b + "\n";
            }
            richTextBox2.Text = b;

            pCreanga.Image = Image.FromFile("calinescu.png");

        }

        private void pCreanga_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
            richTextBox2.Visible = true;

            pPreda.Visible = false;
            pSlavici.Visible = false; 
            pPetrescu.Visible = false;
            pCalinescu.Visible = false;
            pRebreanu.Visible = false;

            a = null;
            richTextBox1.ResetText();
            string[] text = System.IO.File.ReadAllLines("Povestea lui Harap.txt");
            foreach (string s in text)
            {
                a = a + s;
                a = a + "\n";
            }
            richTextBox1.Text = a;

            b = null;
            richTextBox2.ResetText();
            string[] text1 = System.IO.File.ReadAllLines("Ion Creanga.txt");
            foreach (string s in text1)
            {
                b = b + s;
                b = b + "\n";
            }
            richTextBox2.Text = b;

        }

        private void sageata_Click_1(object sender, EventArgs e)
        {
            if(richTextBox2.Visible==true)
            {
                richTextBox1.Visible = false;
                richTextBox2.Visible = false;

                pPreda.Visible = true;
                pSlavici.Visible = true;
                pPetrescu.Visible = true;
                pCalinescu.Visible = true;
                pRebreanu.Visible = true;
                pCreanga.Image = Image.FromFile("creanga.png");
            }
            else
            {

                Show();
                Close();
            }
        }

        private void genepic_Load(object sender, EventArgs e)
        {

        }
    }
}
