using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace for_loop_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //for input names..
            string name = " ";
            string second_name = " ";
            Console.WriteLine("input three names");
            for (int i = 0; i < 3; i++)
            {
                
                name = Console.ReadLine();

                second_name += name + "\n";

            }

            for (int i = 0; i < 1; i++)
            {

                Console.WriteLine(second_name);
            }

        }
    }
}
