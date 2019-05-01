using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_No_1__10_Classes_
{
    class EvenOdd
    {
        int Num;
        public void EVEN(int x)
        {
            Num = x;
            if (Num % 2 == 0)
            {
                Console.WriteLine("EVEN");
            }
            else
            {
                Console.WriteLine("ODD");
            }
            
        }
    }
}
