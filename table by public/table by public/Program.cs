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
            //  Table x = new Table();
            Console.WriteLine("write table");
            double table = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("write range");
            double range = Convert.ToDouble(Console.ReadLine());

            Table.tablegnerator(table, range);


        }
    }
    class Table
    {


        public static void tablegnerator(double tablevalue, double range)
        {
            double result;
            for (int a = 1; a <= range; a++)
            {
                result = tablevalue * a;
                Console.WriteLine("{0} * {1} = {2} ", tablevalue, a, result);
            }
        }

    }
}

