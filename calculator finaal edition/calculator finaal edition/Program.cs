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
            calculator x = new calculator();
            Console.WriteLine("Enter a function to perform\n 1 for addition  \n 2 for subtraction \n 3 for division \n 4 for mul");
            string input = Console.ReadLine();

            Console.WriteLine("write first number");
            double a, b, result;
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            b = double.Parse(Console.ReadLine());
            

            if (input == "1" || input == "one")
            {
                result = x.add(a, b);
                Console.WriteLine("{0}+{1}={2}", a, b, result);
            }

            if (input == "2" || input == "two")
            {
                result = x.sub(a, b);
                Console.WriteLine("{0}-{1}={2}", a, b, result);
            }

            if (input == "3" || input == "three")
            {
                result = x.divide(a, b);
                Console.WriteLine("{0}/{1}={2}", a, b, result);
            }

            if (input == "4" || input == "four")
            {
                result = x.mul(a, b);
                Console.WriteLine("{0}*{1}={2}", a, b, result);
            }
            Console.ReadLine();

        }

    }
}

