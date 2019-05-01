using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number of RoWS:   ");
            int rows = Convert.ToInt32(Console.ReadLine());
            int n = rows;
            for (int i = 0; i < rows; i++)
            {
                //for (int j = 0; j <= i; j++)
                //{
                //    Console.Write("*");
                //}
                //Console.WriteLine(" ");

                for (int k = 0; k <n ; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                n--;
            }
            //for (int i = 0; i < rows; i++)
            //{

            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine(" ");
            //}
            Console.ReadLine();
        }
    }
}
