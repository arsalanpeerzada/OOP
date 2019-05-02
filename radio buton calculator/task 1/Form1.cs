using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace task_1
{
    public partial class Form1 : Form
    {
        int a, b, c;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            a = Convert.ToInt16(textBox1.Text);
            b = Convert.ToInt16(textBox2.Text);
            if (radioButton1.Checked)
            {
                c = a + b;
            }
            else if (radioButton2.Checked)
            {
                c = a - b;
            }
            else if (radioButton3.Checked)
            {
                c = a * b;
            }
            else if (radioButton4.Checked)
            {
                c = a / b;
            }
            else
            
            {
                MessageBox.Show("invlid operator selected");

            }
            label4.Text = c.ToString();

        }
    }
}
