using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace for_loop_2
{
    class Program
    {
        static void Main(string[] args)
        {

            string c;
            Console.WriteLine("input name");
            c = Console.ReadLine();

            for (int i = 0; i < 10; i++)
            {
               // Console.WriteLine(c);
                Console.WriteLine("name is : " + c);
                
            }
           
        }
    }
}
