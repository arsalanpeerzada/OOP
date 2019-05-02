using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace switch_part_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());


            int b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.Write("tru\n");
            }
            else if (a < b)
            {
                Console.Write("tru\n");
            }

            else if (a >= b)
            {
                Console.Write("tru\n");
            }
            else if (a <= b)
            {
                Console.Write("tru\n");
            }
            else if (a != b)

                Console.Write("tru\n");

            else if (a == b)
            {
                Console.Write("tru \n");
            }
        }
    }
}
