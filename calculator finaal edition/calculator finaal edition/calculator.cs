using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class calculator
    {
        double result;

        public double add(double a, double b)
        {
            result = a + b;

            return result;
        }

        public double sub(double a, double b)
        {
            result = a - b;

            return result;

        }
        public double divide(double a, double b)
        {
            result = a / b;

            return result;
        }
        public double mul(double a, double b)
        {
            result = a * b;

            return result;
        }
    }
}
