using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nested_if_else_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, pas;
            Console.WriteLine("name");
            name = Console.ReadLine();
            Console.WriteLine("pas");
            pas = Console.ReadLine();
            if (name == "asad")
            {
                if (pas == "6712")
                {
                    Console.WriteLine("welcome ");
                }
                else
                {
                    Console.WriteLine("pas is incorect");
                }
            }
            else
            {
                Console.WriteLine("name or pas is incorect");
            }
        }
    }
}
