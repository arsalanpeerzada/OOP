using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_No_1__10_Classes_
{
    class Table
    {
        int a;
        public void Tab(int b)
        {
            a = b;
            for (int c = 1; c <= 10; c++)
            {
                Console.WriteLine(a + "*" + c + "=" + c * a);
            }
        }
    }
}
