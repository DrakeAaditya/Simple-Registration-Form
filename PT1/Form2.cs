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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Form1 f1 = new Form1();
            label1.Text = Form1.Fname;
            label2.Text = Form1.Lname;
            label3.Text = Form1.Branch;
            label4.Text = Form1.Gender;
            label5.Text = Form1.AOI;
            label6.Text = Form1.Price.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
