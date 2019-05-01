using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace constructor_3
{
    class Program
    {
        static void Main(string[] args)
        {
            ConstOverloading obj = new ConstOverloading(12);
            Console.WriteLine(obj.getRollNum());

        }
    }
}
