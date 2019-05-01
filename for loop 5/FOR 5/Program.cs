using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FOR_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int mul;
            int a;
            for (a = 1; a <= 2; a++)
            {
                int b;
                for (b = 1; b <= 2; b++)
                {
                    mul = a * b;
                    Console.WriteLine("a={0} b={1} RESULT{2}", a, b, mul);
                }


            }
            Console.ReadLine();
        }
    }
}
