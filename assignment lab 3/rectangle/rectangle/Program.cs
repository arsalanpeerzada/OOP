using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Length:  ");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Breadth:  ");
            int breadth = Convert.ToInt32(Console.ReadLine());

            Rectangle obj = new Rectangle();
            obj.Cal(length, breadth);
        }

        class Rectangle
        {
            public void Cal(int _l,int _b)
            {
                int result = _l * _b;
                Console.WriteLine("Rectangle:  "+result);

            }
        }
    }
}
