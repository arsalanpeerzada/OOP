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
            Console.Write(@"Enter Number 1:Add
2: Subtract 
3: Multiply
4: Divide
");
            int input = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter 1st Number:   ");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 2nd Number:   ");
            int start2 = Convert.ToInt32(Console.ReadLine());

            Calculator obj =new Calculator();

            if (input==1)
            {
                obj.Add(start2, start);
            }
            else if (input==2)
            {
                obj.Subtract(start2, start);   
            }
            else if (input == 3)
            {
                obj.Multiply(start2, start);
            }
            else if (input == 4)
            {
                obj.Divide(start2, start);
            }
            else
            {
                Console.WriteLine("Wrong Input");
            }


        }
    }

    class Calculator
    {
        int rest;

        public void Add(int c, int d)
        {
            rest = c + d;
            Console.WriteLine(rest);
        }

        public void Subtract(int c, int d)
        {
            rest = c - d;
            Console.WriteLine(rest);
        }
        public void Multiply (int c, int d)
        {
            rest = c * d;
            Console.WriteLine(rest);
        }
        public void Divide(int c, int d)
        {
            rest = c / d;
            Console.WriteLine(rest);
        }

    }
}
