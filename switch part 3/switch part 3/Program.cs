using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace switch_part_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //nested switch 
            int a = 100;
            int b = 200;

            switch (a)
            {
                case 100:
                    Console.WriteLine("This is part of outer switch ");
                    switch (b)
                    {
                        case 200:
                            Console.WriteLine("This is part of inner switch ");
                            break;
                    }
                    break;
            }
            Console.WriteLine("Exact value of a is : {0}", a);
            Console.WriteLine("Exact value of b is : {0}", b);
            Console.ReadLine();
        }
    }
}
