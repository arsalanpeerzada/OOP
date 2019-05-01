using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace assignment
{
    partial class Program
    {
        string depname;
        string location;

        public void department()
        {
           Console.WriteLine();
           Console.WriteLine();
           Console.WriteLine("\t \t \t \t"+"Add Employee");
           Console.WriteLine();
           Console.WriteLine("\t \t"+"Enter Department Name");
           Console.Write("\t \t");
           depname = Console.ReadLine();
           Console.WriteLine("\t \t"+"Enter Department Location");
           Console.Write("\t \t");
           location = Console.ReadLine();
        }

        public void showdep()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t \t" + "Department Name " + ":\t" + ":\t" + depname);
            Console.WriteLine("\t \t" + "Department Location" + ":\t" + ":\t" + location);
        }

    }
}
