using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace for_loop_10___remainder_
{
    class Program
    {
        static void Main(string[] args)
        {
            int remainder = 0;
            for (int i = 0; i < 100; i++)
            {
                remainder = i % 2;
                if (remainder == 0)
                {

                    Console.WriteLine(" {0} even", i);
                }
                else
                {
                    Console.WriteLine(" {0} ood", i);
                }

            }
        }
    }
    // remainder
}

