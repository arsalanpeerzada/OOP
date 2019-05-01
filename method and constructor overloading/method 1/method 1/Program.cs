using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace method_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Method Overloading");
            SillyMath.Plus(5, 8);
            SillyMath.Plus(5, 8, 7);
            SillyMath.Plus(5, 8, 7, 4);

        }
    }
    class SillyMath
    {
        public static int Plus(int numb1, int numb2)
        {
            int numb = numb1 + numb2;
            Console.WriteLine(numb);
            return numb;

        }
        public static int Plus(int numb1, int numb2, int numb3)
        {
            int numb = numb1 + numb2 + numb3;
            Console.WriteLine(numb);
            return numb;
        }
        public static int Plus(int numb1, int numb2, int numb3, int numb4)
        {
            int numb = numb1 + numb2 + numb3 + numb4;
            Console.WriteLine(numb);
            return numb;
        }

    }
}
