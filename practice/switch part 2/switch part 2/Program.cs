using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace switch_part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            
           /* local variable definition */
            Console.WriteLine("input grade");
            char grade = Convert.ToChar(Console.ReadLine());

            switch (grade)
            {
                case 'A':
                    Console.WriteLine("Excellent!");
                    break;
                case 'a':
                    Console.WriteLine("Excellent!");
                    break;
                case 'C':
                    Console.WriteLine("Well done");
                    break;
                case 'c':
                    Console.WriteLine("Well done");
                    break;
                case 'D':
                    Console.WriteLine("You passed");
                    break;
                case 'd':
                    Console.WriteLine("You passed");
                    break;
                case 'F':
                    Console.WriteLine("Better try again");
                    break;
                case 'f':
                    Console.WriteLine("Better try again");
                    break;
                default:
                    Console.WriteLine("Invalid grade");
                    break;
            }
            Console.WriteLine("Your grade is =  {0}", grade);
            Console.ReadLine();
            //////////////////////////////
        }
    }
}
