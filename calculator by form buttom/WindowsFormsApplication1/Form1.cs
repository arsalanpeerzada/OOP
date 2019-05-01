using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int first_val, second_val, result;
        string oper;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a;
            a = "1";
            textBox1.Text = textBox1.Text + a;
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a;
            a = "2";
            textBox1.Text = textBox1.Text + a;
            


        }

        private void button3_Click(object sender, EventArgs e)
        {
            string a;
            a = "3";
            textBox1.Text = textBox1.Text + a;
          

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string a;
            a = "4";
            textBox1.Text = textBox1.Text + a;
            

        }

        private void button8_Click(object sender, EventArgs e)
        {
            string a;
            a = "5";
            textBox1.Text = textBox1.Text + a;
            

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string a;
            a = "6";
            textBox1.Text = textBox1.Text + a;
           

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string a;
            a = "7";
            textBox1.Text = textBox1.Text + a;
          

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string a;
            a = "8";
            textBox1.Text = textBox1.Text + a;
         

        }

        private void button12_Click(object sender, EventArgs e)
        {
            string a;
            a = "9";
            textBox1.Text = textBox1.Text + a;
            

        }

        private void button11_Click(object sender, EventArgs e)
        {
            string a;
            a = "0";
            textBox1.Text = textBox1.Text + a;
         

        }

        private void button10_Click(object sender, EventArgs e)
        {
            first_val = Convert.ToInt32(textBox1.Text);
            oper = " + ";
            textBox1.Text = " ";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            first_val = Convert.ToInt32(textBox1.Text);
            oper = " - ";
            textBox1.Text = " ";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            first_val = Convert.ToInt32(textBox1.Text);
            oper = " * ";
            textBox1.Text = " ";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            first_val = Convert.ToInt32(textBox1.Text);
            oper = " / ";
            textBox1.Text = " ";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            second_val = Convert.ToInt32(textBox1.Text);
            textBox1.Text = " ";
            if ( oper == " + ")
            {
                result = first_val + second_val;
                textBox1.Text = result.ToString();
                
            }
            if (oper == " - ")
            {
                result = first_val - second_val;
                textBox1.Text = result.ToString();

            }
            if (oper == " * ")
            {
                result = first_val * second_val;
                textBox1.Text = result.ToString();

            }
            if (oper == " / ")
            {
                result = first_val / second_val;
                textBox1.Text = result.ToString();

            }
           
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
