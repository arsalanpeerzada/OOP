using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("calculator");

            Console.WriteLine("write number");

            Console.WriteLine("to solve fomula (a+b)*c");


            Console.WriteLine("a=");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("b=");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("c=");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("result z=");
            int z = ((a + b) * c);
            Console.WriteLine(z);


        }
    }
}
