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
    public partial class Form2 : Form
    {
        S3 firstform;
        string a;
        public Form2()
        {
            InitializeComponent();
            firstform= new S3 ();
        }

        private void siglaa_Click(object sender, EventArgs e)
        {
           
         }

        private void subiect3_Click(object sender, EventArgs e)
        {
            Hide();
            firstform.ShowDialog();
            Show();
            this.Size = new Size(374, 477);	
        }

        private void sageata_Click(object sender, EventArgs e)
        {
            Show();
            Close();
            this.Size = new Size(374, 477);
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void subiect1_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1288, 477);
            richTextBox1.ResetText();
            a = null;
            string[] text = System.IO.File.ReadAllLines("SI.txt");
            foreach (string s in text)
            {
                a = a + s;
                a = a + "\n";
            }
            richTextBox1.Text = a;
        }
        
        
        private void subiect2_Click(object sender, EventArgs e)
        {
            richTextBox1.ResetText();
            a = null;
            this.Size = new Size(1288, 477);
            string[] text = System.IO.File.ReadAllLines("SII.txt");
            foreach (string s in text)
            {
                a = a + s;
                a = a + "\n";
            }
            richTextBox1.Text = a;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
       
    }
}
