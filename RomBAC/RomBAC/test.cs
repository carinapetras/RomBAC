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
    public partial class test : Form
    {
        int  s=0, s1, s2, s3;
        public test()
        {
            
            InitializeComponent();
           // s = 0;
            
        }

        private void test_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                s++;
                s1++;
                radioButton2.ForeColor = Color.Green;
            }
            if (radioButton8.Checked == true)
            {
                s++;
                s1++;
                radioButton8.ForeColor = Color.Green;
            }
            if (radioButton9.Checked == true)
            {
                s++;
                s1++;
                radioButton9.ForeColor = Color.Green;
            }
            if (radioButton16.Checked == true)
            {
                s++;
                s2++;
                radioButton16.ForeColor = Color.Green;
            }
            if (radioButton18.Checked == true)
            {
                s++;
                s2++;
                radioButton18.ForeColor = Color.Green;
            }
            if (radioButton23.Checked == true)
            {
                s++;
                s2++;
                radioButton23.ForeColor = Color.Green;
            }
            if (radioButton25.Checked == true)
            {
                s++;
                s3++;
                radioButton25.ForeColor = Color.Green;
            }
            if (radioButton30.Checked == true)
            {
                s++;
                s3++;
                radioButton30.ForeColor = Color.Green;
            }
            if (radioButton36.Checked == true)
            {
                s++;
                s3++;
                radioButton36.ForeColor = Color.Green;
            }
            if (radioButton39.Checked == true)
            {
                s++;
                s3++;
                radioButton39.ForeColor = Color.Green;
            }
            if (radioButton1.Checked == true)
            {
                radioButton1.ForeColor = Color.Red;
            }
            if (radioButton3.Checked == true)
            {
                radioButton3.ForeColor = Color.Red;
            }
            if (radioButton4.Checked == true)
            {
                radioButton4.ForeColor = Color.Red;
            }
            if (radioButton5.Checked == true)
            {
                radioButton5.ForeColor = Color.Red;
            }
            if (radioButton6.Checked == true)
            {
                radioButton6.ForeColor = Color.Red;
            }
            if (radioButton7.Checked == true)
            {
                radioButton7.ForeColor = Color.Red;
            }
            if (radioButton10.Checked == true)
            {
                radioButton10.ForeColor = Color.Red;
            }
            if (radioButton11.Checked == true)
            {
                radioButton11.ForeColor = Color.Red;
            }
            if (radioButton12.Checked == true)
            {
                radioButton12.ForeColor = Color.Red;
            }
            if (radioButton13.Checked == true)
            {
                radioButton13.ForeColor = Color.Red;
            }
            if (radioButton14.Checked == true)
            {
                radioButton14.ForeColor = Color.Red;
            }
            if (radioButton15.Checked == true)
            {
                radioButton15.ForeColor = Color.Red;
            }
            if (radioButton17.Checked == true)
            {
                radioButton17.ForeColor = Color.Red;
            }
            if (radioButton19.Checked == true)
            {
                radioButton19.ForeColor = Color.Red;
            }
            if (radioButton20.Checked == true)
            {
                radioButton20.ForeColor = Color.Red;
            }
            if (radioButton21.Checked == true)
            {
                radioButton21.ForeColor = Color.Red;
            }
            if (radioButton22.Checked == true)
            {
                radioButton22.ForeColor = Color.Red;
            }
            if (radioButton24.Checked == true)
            {
                radioButton24.ForeColor = Color.Red;
            }
            if (radioButton26.Checked == true)
            {
                radioButton26.ForeColor = Color.Red;
            }
            if (radioButton27.Checked == true)
            {
                radioButton27.ForeColor = Color.Red;
            }
            if (radioButton28.Checked == true)
            {
                radioButton28.ForeColor = Color.Red;
            }
            if (radioButton29.Checked == true)
            {
                radioButton29.ForeColor = Color.Red;
            }
            if (radioButton31.Checked == true)
            {
                radioButton31.ForeColor = Color.Red;
            }
            if (radioButton32.Checked == true)
            {
                radioButton32.ForeColor = Color.Red;
            }
            if (radioButton33.Checked == true)
            {
                radioButton33.ForeColor = Color.Red;
            }
            if (radioButton34.Checked == true)
            {
                radioButton34.ForeColor = Color.Red;
            }
            if (radioButton35.Checked == true)
            {
                radioButton35.ForeColor = Color.Red;
            }
            if (radioButton37.Checked == true)
            {
                radioButton37.ForeColor = Color.Red;
            }
            if (radioButton38.Checked == true)
            {
                radioButton38.ForeColor = Color.Red;
            }
            if (radioButton40.Checked == true)
            {
                radioButton40.ForeColor = Color.Red;
            }

            if (s1 != 3 && s2 == 3 && s3 == 4) 
                MessageBox.Show("Aţi răspuns corect la " + Convert.ToInt32(s) + " întrebări. \n\rMențiune: Mai învață pentru subiectul I.");
            
            else if (s1 != 3 && s2 != 3 && s3 == 4)
                MessageBox.Show("Aţi răspuns corect la " + Convert.ToInt32(s) + " întrebări. \n\rMențiune: Mai învață pentru subiectul I și subiectul al II-lea.");
            else if(s1 != 3 && s2 != 3 && s3 != 4)
                MessageBox.Show("Aţi răspuns corect la " + Convert.ToInt32(s) + " întrebări. \n\rMențiune: Mai învață pentru subiectul I, subiectul al II-lea și subiectul al III-lea.");
            else if (s1 == 3 && s2 != 3 && s3 == 4)
                MessageBox.Show("Aţi răspuns corect la " + Convert.ToInt32(s) + " întrebări. \n\rMențiune: Mai învață pentru subiectul al II-lea");
            else if (s1 == 3 && s2 != 3 && s3 != 4)
                MessageBox.Show("Aţi răspuns corect la " + Convert.ToInt32(s) + " întrebări. \n\rMențiune: Mai învață pentru subiectul al II-lea și subiectul al III-lea.");
            else if (s1 == 3 && s2 == 3 && s3 != 4)
                MessageBox.Show("Aţi răspuns corect la " + Convert.ToInt32(s) + " întrebări. \n\rMențiune: Mai învață pentru subiectul al III-lea.");
            }
    //    if(radioButton4.Checked) 
    //{
    //    s1= s1+1;
    //    s= s+1;
    //    radioButton4.ForeColor= Color.Green;
    //}
        //private void radioButton1_CheckedChanged(object sender, EventArgs e)
        //{

        //}

        //private void radioButton3_CheckedChanged(object sender, EventArgs e)
        //{

        //}

        //private void radioButton2_CheckedChanged(object sender, EventArgs e)
        //{

        //}

        //private void radioButton4_CheckedChanged(object sender, EventArgs e)
        //{
        //}
    }
}
