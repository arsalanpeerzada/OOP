using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_No_1__10_Classes_
{
    class MathFunctions
    {
        int a;
        int b;

        public void add(int c, int d)
        {
            a = c;
            b = d;
            int total = a + b;
            Console.WriteLine(total);    
        }
        public void sub(int c, int d)
        {
            a = c;
            b = d;
            int total = a - b;
            Console.WriteLine(total);
        }
        public void mul(int c, int d)
        {
            a = c;
            b = d;
            int total = a * b;
            Console.WriteLine(total);
        }
        public void div(int c, int d)
        {
            a = c;
            b = d;
            int total = a / b;
            Console.WriteLine(total);
        }
    }
}
