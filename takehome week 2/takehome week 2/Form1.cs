using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace takehome_week_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(textBox2.Text)<18)
            {
                string catagory = "minor";
                MessageBox.Show("Name:" + textBox1.Text + "Email:" + textBox3.Text + "Phone Number:" + textBox4.Text + "You are an " + catagory);
            }
            else if(Convert.ToInt32(textBox2.Text) >= 18)
            {
                string catagory1 = "adult";
                MessageBox.Show("Name:" + textBox1.Text + "Email:" + textBox3.Text + "Phone Number:" + textBox4.Text + "You are an " + catagory1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }
    }
}
