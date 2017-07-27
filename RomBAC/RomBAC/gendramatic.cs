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
    public partial class gendramatic : Form
    {
        string a, b; 
        
        public gendramatic()
        {
            InitializeComponent();
            
        }

        private void sageata_Click(object sender, EventArgs e)
        {
            this.Size = new Size(313, 453);

            if (richTextBox2.Visible == true)
            {
                richTextBox1.Visible = false;
                richTextBox2.Visible = false;
            }
            else
            {
                Show();
                Close();
            }
            
        }

        private void pCaragiale_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1023, 747);

            richTextBox1.Visible = true;
            richTextBox2.Visible = true;

            a = null;
            //richTextBox1.ResetText();
            string[] text = System.IO.File.ReadAllLines("O scrisoare pierduta.txt");
            foreach (string s in text)
            {
                a = a + s;
                a = a + "\n";
            }
            richTextBox1.Text = a;

            b = null;
            richTextBox2.ResetText();
            string[] text1 = System.IO.File.ReadAllLines("Ion Luca Caragiale.txt");
            foreach (string s in text1)
            {
                b = b + s;
                b = b + "\n";
            }
            richTextBox2.Text = b;

            
        }

        private void gendramatic_Load(object sender, EventArgs e)
        {

        }
    }
}
