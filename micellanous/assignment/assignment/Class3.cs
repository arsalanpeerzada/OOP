using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace assignment
{
    partial class Program
    {
        string address;
        string date;
        string salary;

        public void info()
        {
            Console.WriteLine("\t \t" + "Enter Address");
            Console.Write("\t \t");
            address = Console.ReadLine();
            Console.WriteLine("\t \t" + "Enter HireDate");
            Console.Write("\t \t");
            date = Console.ReadLine();
            Console.WriteLine("\t \t" + "Enter Salary");
            Console.Write("\t \t");
            salary = Console.ReadLine();
        }

        public void showinfo()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t \t" + "Address" + "\t \t \t" + ":\t" + address);
            Console.WriteLine("\t \t" + "Hiring Date" + "\t \t" + ":\t" + date);
            Console.WriteLine("\t \t" + "Salary" + "\t \t \t" + ":\t" + salary);
        }
    }
}
