using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace customized_constructur
{
    class Program
    {
        static void Main(string[] args)
        {
            Account obj = new Account(7272,"Arsalan",10000);
            obj.printAccount();

            Account obj1 = new Account(7081, "Hamas", 5000);
            obj1.printAccount();
        }
    }
}
