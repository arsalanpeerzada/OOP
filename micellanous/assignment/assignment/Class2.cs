using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace assignment
{
    partial class Program
    {
        int id;
        string name;
        string contact;
        string designation;

        public void employe()
        {
            Console.WriteLine("\t \t" + "Enter Employee ID");
            Console.Write("\t \t");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\t \t" + "Enter Employee Name");
            Console.Write("\t \t");
            name = Console.ReadLine();
            Console.WriteLine("\t \t" + "Enter Employee Contact");
            Console.Write("\t \t");
            contact = Console.ReadLine();
            Console.WriteLine("\t \t" + "Enter Employee Designation");
            Console.Write("\t \t");
            designation = Console.ReadLine();
        }

        public void showemp()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t \t" + "Employee ID" + "\t \t" + ":\t" + id);
            Console.WriteLine("\t \t" + "Employee Name" + "\t \t" + ":\t" + name);
            Console.WriteLine("\t \t" + "Employe Contact" + "\t \t" + ":\t" + contact);
            Console.WriteLine("\t \t" + "Employee Designation" + "\t" + ":\t" + designation);
        }
    }
}
