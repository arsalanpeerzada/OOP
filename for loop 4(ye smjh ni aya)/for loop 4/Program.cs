using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace for_loop_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input range");
            int range;
            range = Convert.ToInt32(Console.ReadLine());
            int result = inverse_loop.inverse(range);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
    class inverse_loop
    {
        public static int inverse(int range)
        {
            int i;
            for (i = range; i >= 0; i--)
            {


            }
            return i;

        }
    }
}
