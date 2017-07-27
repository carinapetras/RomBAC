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
    public partial class genliric : Form
    {
        string a, b;

        public genliric()
        {
            InitializeComponent();
        }

        private void sageata_Click(object sender, EventArgs e)
        {
            this.Size = new Size(906, 717);

            if (richTextBox2.Visible == true)
            {
                richTextBox1.Visible = false;
                richTextBox2.Visible = false;

                pArghezi.Visible = true;
                pBacovia.Visible = true;
                pBarbu.Visible = true;
                pBlaga.Visible = true;
                pEminescu.Image = Image.FromFile("eminescu.png");
            }
            else
            {

                Show();
                Close();
            }
        }

        private void genliric_Load(object sender, EventArgs e)
        {

        }

        private void pEminescu_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1023, 747);

            richTextBox1.Visible = true;
            richTextBox2.Visible = true;

            pArghezi.Visible = false;
            pBacovia.Visible = false;
            pBarbu.Visible = false;
            pBlaga.Visible = false;
            
            a = null;
            richTextBox1.ResetText();
            string[] text = System.IO.File.ReadAllLines("Luceafarul.txt");
            foreach (string s in text)
            {
                a = a + s;
                a = a + "\n";
            }
            richTextBox1.Text = a;

            b = null;
            richTextBox2.ResetText();
            string[] text1 = System.IO.File.ReadAllLines("Mihai Eminescu.txt");
            foreach (string s in text1)
            {
                b = b + s;
                b = b + "\n";
            }
            richTextBox2.Text = b;
        }

        private void pBacovia_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1023, 747);
            pEminescu.Image = Image.FromFile("bacovia.png");

            richTextBox1.Visible = true;
            richTextBox2.Visible = true;

            pArghezi.Visible = false;
            pBacovia.Visible = false;
            pBarbu.Visible = false;
            pBlaga.Visible = false;

            a = null;
            richTextBox1.ResetText();
            string[] text = System.IO.File.ReadAllLines("Plumb.txt");
            foreach (string s in text)
            {
                a = a + s;
                a = a + "\n";
            }
            richTextBox1.Text = a;

            b = null;
            richTextBox2.ResetText();
            string[] text1 = System.IO.File.ReadAllLines("George Bacovia.txt");
            foreach (string s in text1)
            {
                b = b + s;
                b = b + "\n";
            }
            richTextBox2.Text = b;
        }

        private void pArghezi_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1023, 747);
            pEminescu.Image = Image.FromFile("arghezi.png");

            richTextBox1.Visible = true;
            richTextBox2.Visible = true;

            pArghezi.Visible = false;
            pBacovia.Visible = false;
            pBarbu.Visible = false;
            pBlaga.Visible = false;

            a = null;
            richTextBox1.ResetText();
            string[] text = System.IO.File.ReadAllLines("Flori de mucigai.txt");
            foreach (string s in text)
            {
                a = a + s;
                a = a + "\n";
            }
            richTextBox1.Text = a;

            b = null;
            richTextBox2.ResetText();
            string[] text1 = System.IO.File.ReadAllLines("Tudor Arghezi.txt");
            foreach (string s in text1)
            {
                b = b + s;
                b = b + "\n";
            }
            richTextBox2.Text = b;

        }

        private void pBlaga_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1023, 747);
            pEminescu.Image = Image.FromFile("blaga.png");

            richTextBox1.Visible = true;
            richTextBox2.Visible = true;

            pArghezi.Visible = false;
            pBacovia.Visible = false;
            pBarbu.Visible = false;
            pBlaga.Visible = false;

            a = null;
            richTextBox1.ResetText();
            string[] text = System.IO.File.ReadAllLines("Eu nu strivesc.txt");
            foreach (string s in text)
            {
                a = a + s;
                a = a + "\n";
            }
            richTextBox1.Text = a;

            b = null;
            richTextBox2.ResetText();
            string[] text1 = System.IO.File.ReadAllLines("Lucian Blaga.txt");
            foreach (string s in text1)
            {
                b = b + s;
                b = b + "\n";
            }
            richTextBox2.Text = b;

        }

        private void pBarbu_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1023, 747);
            pEminescu.Image = Image.FromFile("barbu.png");

            richTextBox1.Visible = true;
            richTextBox2.Visible = true;

            pArghezi.Visible = false;
            pBacovia.Visible = false;
            pBarbu.Visible = false;
            pBlaga.Visible = false;

            a = null;
            richTextBox1.ResetText();
            string[] text = System.IO.File.ReadAllLines("Riga Crypto si lapona Enigel.txt");
            foreach (string s in text)
            {
                a = a + s;
                a = a + "\n";
            }
            richTextBox1.Text = a;

            b = null;
            richTextBox2.ResetText();
            string[] text1 = System.IO.File.ReadAllLines("Ion Barbu.txt");
            foreach (string s in text1)
            {
                b = b + s;
                b = b + "\n";
            }
            richTextBox2.Text = b;

        }
    }
}
