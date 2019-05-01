using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_No_1__10_Classes_
{
    class RightTriangle
    {
        int Row;
        public void RIG(int a)
        {
            Row = a;
            for (int b = 1; b <= Row; b++)
            {
                for (int c = Row; c > b; c--)
                {
                    Console.Write(" ");

                }
                for (int i = 1; i <= b; i++)
                {

                    Console.Write('*');

                }
                Console.WriteLine();
            }
        }
    }
}
