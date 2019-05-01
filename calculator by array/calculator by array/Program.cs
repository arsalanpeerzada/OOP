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
            calculator a = new calculator();
            
           
            Console.WriteLine( a.plus(2,2,2,2,2,2,2,2));
        }
    }

    class calculator
    {

        private double result;

        public double plus(params double [] arr)
        {

            for (int i = 0; i <arr.Length; i++)
            {
                result +=arr[i];
            }

            return result;

        }
    }
}
