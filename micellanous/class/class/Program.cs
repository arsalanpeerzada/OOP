using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace @class
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Calculator c1 = new Calculator();
            c1.Divide(num1,num2);
        }

        class Calculator
        {
            

            public int multiply(int _num1, int _num2)
            {
                int result = _num1 * _num2;
                Console.WriteLine(result);
                return result;
            }
            public int Divide(int _a, int _b)
            {
                int _result = _a / _b;
                Console.WriteLine(_result);
                return _result;
            }

        }
    }


    
}
