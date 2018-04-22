using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PT1
{
    public partial class Form1 : Form
    {
        public static String Fname, Lname, Gender = "",Branch = "",AOI;
        public static Double Price = 2000;

        public Form1()

        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void checkBox4_CheckedChanged(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e)
        {
         
        //User Name
            Fname = textBox1.Text;
            Lname = textBox2.Text;

                    //Gender
            bool x = radioButton1.Checked;
            if (x)
                Gender = radioButton1.Text;
            else
                Gender = radioButton2.Text;
            
        //Branch
            if (radioButton3.Checked)
                Branch = radioButton3.Text;
            else if (radioButton4.Checked)
                Branch = radioButton4.Text;
            else
                Branch = radioButton5.Text;
            
        //Area of Interest
            AOI = comboBox1.ToString();
            
        //Additional Features
            if (checkBox1.Checked)
                Price = Price + 1000;
            if (checkBox2.Checked)
                Price = Price + 200;
            if (checkBox3.Checked)
                Price = Price + 200;
            if (checkBox4.Checked)
                Price = Price + 100;
            
            Form2 f1 = new Form2();
            f1.Show();



        }
    }
}
