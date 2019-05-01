using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace assignment
{
    partial class Program
    {
        public Program()
        {
            int a;

            department();
            employe();
            details();
            info();
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("\t \t"); Console.WriteLine("Employe Record Added");
            Console.Write("\t \t"); Console.WriteLine("Press Enter To Show the Record");
            Console.ReadLine();


            showdep();
            showemp();
            showdetails();
            showinfo();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Do You Want To Continue ? Press 1 for Yes , 2 for No");
            a = Convert.ToInt32(Console.ReadLine());

            if (a == 1)
            {
                new Program();
            }
            else
            {
              
            }

        }

        static void Main(string[] args)
        {
            new Program();
        }
    }
}

