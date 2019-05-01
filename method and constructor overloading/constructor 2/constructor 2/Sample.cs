using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace constructor_2
{
    class Sample
    {
        public string param1, param2;

        public Sample()     
        {
            param1 = "Hi";
            param2 = "I am Default Constructor";
        }
        public Sample(string x, string y)     
        {
            param1 = x;
            param2 = y;
        }
    }
}

