using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace boolian
{
    class Program
    {
        static void Main(string[] args)
        {
            //bolian
            bool m;
            int a = Convert.ToInt16(Console.ReadLine());
            int b = Convert.ToInt16(Console.ReadLine());
            m = (a < b);
            Console.WriteLine(m);
            m = (a > b);
            Console.WriteLine(m);
            m = (a <= b);
            Console.WriteLine(m);
            m = (a != b);
            Console.WriteLine(m);
            m = (a == b);
            Console.WriteLine(m);
        }
    }
}
