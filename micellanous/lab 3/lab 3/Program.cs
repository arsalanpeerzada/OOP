using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number A");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Number B");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Number C");
            int c = Convert.ToInt32(Console.ReadLine());

            My_Class me = new My_Class();
            me.greater(a,b,c);
        }


        class My_Class
        {
            public void greater(int _a, int _b, int _c)
            {
                if (_a>_b && _c<_a)
                {
                    Console.WriteLine(_a);   
                }
                else if (_a < _b && _b > _c)
                {
                    Console.WriteLine(_b);
                }
                else if (_c > _b && _c > _a)
                {
                    Console.WriteLine(_c);
                }

            }
        }
    }
}
