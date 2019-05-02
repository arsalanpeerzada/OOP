using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("enter a number either 1  or 2 or 5");
            int a;
            a = Int32.Parse(Console.ReadLine());


            //Console.WriteLine("enter a number 2 ");
            //int b = Int32.Parse(Console.ReadLine());


            if (a == 1)
            {
                Console.WriteLine("hello world");
            }
            else
            {
                if (a == 2)
                {
                    Console.WriteLine("hello moto");
                }
                else if (a == 5)
                {
                    Console.WriteLine("usama");
                }

                else
                {
                    Console.WriteLine("go to hell");
                }
            }

        }
    }
}
