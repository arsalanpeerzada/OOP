using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace constructor_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Sample obj = new Sample();
               
            Sample obj1= new Sample("Welcome", "World");   

            Console.WriteLine(obj.param1 + ", " + obj.param2);
            Console.WriteLine(obj1.param1 + " to " + obj1.param2);
            Console.ReadLine();
        }
    }
}
