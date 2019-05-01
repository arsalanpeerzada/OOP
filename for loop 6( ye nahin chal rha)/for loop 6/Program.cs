using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace for_6
{
    class Program
    {
        static void Main(string[] args)
        {

            double result = 1;
            double c = 1;
            double sum = 0;
            double s;
            Console.WriteLine("enter number till you want the factorial");
            s= Convert.ToInt16(Console.ReadLine());
            for (int i = 2; i <= s; i++)
            {

                result = i * result;
                c += sum / result;
                Console.WriteLine(result + "  " + c);
                sum = sum + 1;
                // sum = result + sum;
            }

            Console.WriteLine(result + "" + c);
        }
    }
}
