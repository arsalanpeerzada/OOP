using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Assignment_Scientific_Calculator
{
    public partial class Form1 : Form
    {
        int a, b, c, d;
        char optr;
        string K, M;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string v;
            v = "1";
            textbox1.Text = textbox1.Text + v;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string v;
            v = "2";
            textbox1.Text = textbox1.Text + v;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string v;
            v = "3";
            textbox1.Text = textbox1.Text + v;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string v;
            v = "4";
            textbox1.Text = textbox1.Text + v;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string v;
            v = "5";
            textbox1.Text = textbox1.Text + v;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string v;
            v = "6";
            textbox1.Text = textbox1.Text + v;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string v;
            v = "7";
            textbox1.Text = textbox1.Text + v;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string v;
            v = "8";
            textbox1.Text = textbox1.Text + v;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string v;
            v = "9";
            textbox1.Text = textbox1.Text + v;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string v;
            v = "10";
            textbox1.Text = textbox1.Text + v;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            optr = '+';
            a = Convert.ToInt16(textbox1.Text);
            textbox1.Text = " ";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            optr = '-';
            a = Convert.ToInt16(textbox1.Text);
            textbox1.Text = " ";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            optr = '/';
            a = Convert.ToInt16(textbox1.Text);
            textbox1.Text = " ";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            optr = '*';
            a = Convert.ToInt16(textbox1.Text);
            textbox1.Text = " ";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            int i = 0;
            char E = '\0';
            int Decimal = 0;
            int l = textbox1.Text.Length-1;
            if (d != 1)
            {
                for (i = 0; i <= l; i++)
                {
                    E = textbox1.Text[i];
                    if (E == '.')
                    {
                        Decimal = 1;
                    }
                }

                if (Decimal != 1)
                {
                    textbox1.Text = textbox1.Text + Convert.ToString(".");
                }
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textbox1.Clear();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            long Factorial = 1;
            for (int i = 1; i <= Convert.ToInt32(textbox1.Text); i++)
            {
                Factorial = Factorial * i;
            }
            textbox1.Text = Convert.ToString(Factorial);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textbox1.Text = (1 / Convert.ToDouble(textbox1.Text)).ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            double F, J;
            J = Convert.ToDouble(textbox1.Text);
            F = Math.Sqrt(J);
            textbox1.Text = Convert.ToString(F);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            K = textbox1.Text;
            int N = K.Length;
            for (int i = 0; i < N - 1; i++)
            {
                M += K[i];
            }
            textbox1.Text = M;
            M = " ";
        }

        private void button22_Click(object sender, EventArgs e)
        {
             if (textbox1.Text.Length != 0)
             {
                 double l;
                 l = Math.Log(Convert.ToDouble(textbox1.Text));
                 textbox1.Text = Convert.ToString(l);
                 d = 1;             
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (textbox1.Text.Length != 0)
            {
                double l;
                l = Math.Log10(Convert.ToDouble(textbox1.Text));
                textbox1.Text = Convert.ToString(l);
                d = 1;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textbox1.Text.Length != 0)
            {
                double l;
                l = Math.Exp(Convert.ToDouble(textbox1.Text));
                textbox1.Text = Convert.ToString(l);
                d = 1;
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {
            textbox1.Text = Math.PI.ToString();
            d = 1;
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            if (textbox1.Text.Length != 0)
            {
                double l;
                l = Math.Sin(Convert.ToDouble(textbox1.Text));
                textbox1.Text = Convert.ToString(l);
                d = 1;
            }
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            if (textbox1.Text.Length != 0)
            {
                double l;
                l = Math.Cos(Convert.ToDouble(textbox1.Text));
                textbox1.Text = Convert.ToString(l);
                d = 1;
            }
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            if (textbox1.Text.Length != 0)
            {
                double l;
                l = Math.Tan(Convert.ToDouble(textbox1.Text));
                textbox1.Text = Convert.ToString(l);
                d = 1;
            }
        }

        private void btnInvSin_Click(object sender, EventArgs e)
        {
            if (textbox1.Text.Length != 0)
            {
                double l;
                l = Math.Asin(Convert.ToDouble(textbox1.Text));
                textbox1.Text = Convert.ToString(l);
                d = 1;
            }
        }

        private void btnInvCos_Click(object sender, EventArgs e)
        {
            if (textbox1.Text.Length != 0)
            {
                double l;
                l = Math.Acos(Convert.ToDouble(textbox1.Text));
                textbox1.Text = Convert.ToString(l);
                d = 1;
            }
        }

        private void btnInvTan_Click(object sender, EventArgs e)
        {
            if (textbox1.Text.Length != 0)
            {
                double l;
                l = Math.Atan(Convert.ToDouble(textbox1.Text));
                textbox1.Text = Convert.ToString(l);
                d = 1;
            }
        }

        private void btnSinh_Click(object sender, EventArgs e)
        {
            if (textbox1.Text.Length != 0)
            {
                double l;
                l = Math.Sinh(Convert.ToDouble(textbox1.Text));
                textbox1.Text = Convert.ToString(l);
                d = 1;
            }
        }

        private void btnCosh_Click(object sender, EventArgs e)
        {
            if (textbox1.Text.Length != 0)
            {
                double l;
                l = Math.Cosh(Convert.ToDouble(textbox1.Text));
                textbox1.Text = Convert.ToString(l);
                d = 1;
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (textbox1.Text.Length != 0)
            {
                double l;
                l = Math.Tanh(Convert.ToDouble(textbox1.Text));
                textbox1.Text = Convert.ToString(l);
                d = 1;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            b = Convert.ToInt16(textbox1.Text);
            textbox1.Text = " ";


            if (optr == '+')
            {
                c = a + b;
                textbox1.Text = c.ToString();
            }
            else if (optr == '-')
            {
                c = a - b;
                textbox1.Text = c.ToString();
            }
            else if (optr == '*')
            {
                c = a * b;
                textbox1.Text = c.ToString();
            }
            else if (optr == '/')
            {
                c = a / b;
                textbox1.Text = c.ToString();
            }
        }
    }
}
