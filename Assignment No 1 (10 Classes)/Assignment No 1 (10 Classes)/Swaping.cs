using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_No_1__10_Classes_
{
    class Swaping
    {
        int Number;
        int Number1;

        public void Interchange(int a, int b)
        {
            Number = a;
            Number1 = b;

            Number = Number1 + Number;
            Number1 = Number - Number1;
            Number = Number - Number1;

            Console.WriteLine("NUMBER:" + Number + "\n" + "NUMBER1:" + Number1);
        }
            
    }
}
