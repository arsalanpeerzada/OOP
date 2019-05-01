using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FirstOOPFormApplication
{
    public partial class Form1 : Form
    {
        string a1; 
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a;
            a1 = "Khan Sahab"; 
            a = "Ayub Latif";
            MessageBox.Show(a1); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //a1 = "Altaf Bhai";
            //MessageBox.Show(a1); 
            Program.good = textBox1.Text;
            Form f1;
            f1 = new Form2();
            f1.Show();
            this.Hide(); 
        }
    }
}
