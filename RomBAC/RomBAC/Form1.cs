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

namespace RomBAC
{
    public partial class Form1 : Form
    {
        Form2 secondform;
        test testform;
        string a;
        public Form1()
        {
            InitializeComponent();
            secondform= new Form2();
            testform = new test();
        }

        private void real_Click(object sender, EventArgs e)
        {
        
            this.Size = new Size(374, 477);
            Hide();
            secondform.ShowDialog();
            Show();
        }

        private void uman_Click(object sender, EventArgs e)
        {
            this.Size = new Size(374, 477);
            MessageBox.Show("Profilul uman este inactiv deocamdată.");
        }

        private void despre_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1288, 477);
            a = null;
            richTextBox1.ResetText();
            string[] text = System.IO.File.ReadAllLines("Despre.txt");
            foreach (string s in text)
            {
                a = a + s;
                a = a + "\n";
            }
            richTextBox1.Text = a;  
        }

        

        private void sfaturi_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1288, 477);
            a = null;
            richTextBox1.ResetText();
            string[] text = System.IO.File.ReadAllLines("Sfaturi pentru BAC.txt");
            foreach (string s in text)
            {
                a= a + s;
                a = a + "\n";
            }
            richTextBox1.Text = a;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void siglaa_Click(object sender, EventArgs e)
        {

        }

        private void test_Click(object sender, EventArgs e)
        {
            this.Size = new Size(374, 477);
            Hide();
            testform.ShowDialog();
            Show();
        }
    }
}
