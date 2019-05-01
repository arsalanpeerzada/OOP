using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace for_loop_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("write table");
            double table = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("write range");
            double range = Convert.ToDouble(Console.ReadLine());

            Table.gettable(table, range);


        }
    }
    class Table
    {


        private static void tablegnerator(double tablevalue, double range)
        {
            double result;
            for (int a = 1; a <= range; a++)
            {
                result = tablevalue * a;
                Console.WriteLine("{0} * {1} = {2} ", tablevalue, a, result);
            }
        }
        public static void gettable(double tablevalue, double range)
        {
            tablegnerator(tablevalue, range);
        }
    }
}

        