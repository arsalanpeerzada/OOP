using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace method_4
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        class OverLoad
        {
            public void add(int i, int j)
            {
                Console.WriteLine("Integer addition");
            }

            public void add(int i, double j)
            {
                Console.WriteLine("Integer and double addition");
            }

            public void add(double i, double j)
            {
                Console.WriteLine("Double & Double Addition");
            }

        }
    }
}