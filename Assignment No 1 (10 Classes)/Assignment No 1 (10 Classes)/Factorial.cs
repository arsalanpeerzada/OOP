using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_No_1__10_Classes_
{
    class Factorial
    {
        int a;
        public void Fac(int b)
        {
            a = b;
            int c;
            int d = b;

            for (c = 1; c < b; c++)
            {
                d = d * c;
            }
            Console.WriteLine(d);
        }
    }
}
