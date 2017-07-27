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
    public partial class S3 : Form
    {
        string a;
        genepic firstform;
        gendramatic secondform;
        genliric thirdform;
        public S3()
        {
            InitializeComponent();
            firstform = new genepic ();
            secondform = new gendramatic();
            thirdform = new genliric();
        }

        private void epic_Click(object sender, EventArgs e)
        {
            this.Size = new Size(358, 501);
            Hide();
            firstform.ShowDialog();
            Show();
        }

        private void sageata_Click(object sender, EventArgs e)
        {
            this.Size = new Size(358, 501);
            Show();
            Close();
        }

        private void S3_Load(object sender, EventArgs e)
        {

        }

        private void dramatic_Click(object sender, EventArgs e)
        {
            this.Size = new Size(358, 501);
            Hide();
            secondform.ShowDialog();
            Show();
        }

        private void liric_Click(object sender, EventArgs e)
        {
            this.Size = new Size(358, 501);
            Hide();
            thirdform.ShowDialog();
            Show();
        }

        private void programa_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1245, 501);
            richTextBox1.Size = new Size(861, 399);
            a = null;
            richTextBox1.ResetText();
            string[] text = System.IO.File.ReadAllLines("Programa.txt");
            foreach (string s in text)
            {
                a = a + s;
                a = a + "\n";
            }
            richTextBox1.Text = a; 
        }

        private void siglaa_Click(object sender, EventArgs e)
        {

        }

        private void com_epic_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1000, 501);
            richTextBox1.Size = new Size(600, 399);
            a = null;
            richTextBox1.ResetText();
            string[] text = System.IO.File.ReadAllLines("Structura comentariului-gen epic.txt");
            foreach (string s in text)
            {
                a = a + s;
                a = a + "\n";
            }
            richTextBox1.Text = a; 
        }

        private void pers_epic_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1000, 501);
            richTextBox1.Size = new Size(600, 399);
            a = null;
            richTextBox1.ResetText();
            string[] text = System.IO.File.ReadAllLines("Structura caracterizare de personaj.txt");
            foreach (string s in text)
            {
                a = a + s;
                a = a + "\n";
            }
            richTextBox1.Text = a; 
        }

        private void com_dramatic_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1000, 501);
            richTextBox1.Size = new Size(600, 399);
            a = null;
            richTextBox1.ResetText();
            string[] text = System.IO.File.ReadAllLines("Structura comentariului-gen dramatic.txt");
            foreach (string s in text)
            {
                a = a + s;
                a = a + "\n";
            }
            richTextBox1.Text = a; 
        }

        private void pers_dramatic_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1000, 501);
            richTextBox1.Size = new Size(600, 399);
            a = null;
            richTextBox1.ResetText();
            string[] text = System.IO.File.ReadAllLines("Structura caracterizare de personaj.txt");
            foreach (string s in text)
            {
                a = a + s;
                a = a + "\n";
            }
            richTextBox1.Text = a; 
        }

        private void com_liric_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1000, 501);
            richTextBox1.Size = new Size(600, 399);
            a = null;
            richTextBox1.ResetText();
            string[] text = System.IO.File.ReadAllLines("Structura comentariului-gen liric.txt");
            foreach (string s in text)
            {
                a = a + s;
                a = a + "\n";
            }
            richTextBox1.Text = a; 
        }
    }
}
