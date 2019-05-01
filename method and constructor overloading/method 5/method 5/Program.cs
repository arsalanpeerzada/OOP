using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace method_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Method OverLoading");
            int Cube = OverLoading.volume(5);
            double Cylinder = OverLoading.volume(6.6,8);
            long cuboid = OverLoading.volume(5, 7, 9);

        }

        class OverLoading
        {
            // volume of a cube
            public static int volume(int s)
            {
                return s * s * s;
            }

            // volume of a cylinder
            public static double volume(double r, int h)
            {
                return 3.14 * r * r * h;
            }

            // volume of a cuboid
            public static long volume(long l, int b, int h)
            {
                return l * b * h;
            }
        }
    }
}