using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        
        {
            account abc = new account();
            abc.deposit();
            abc.windrow();
        }
        class account
        {
            int acc_bal = 10000;
            public void deposit()
            {
                Console.WriteLine(acc_bal);
                Console.WriteLine("What amt u want to enter");
                int amt = Convert.ToInt32( Console.ReadLine());
                acc_bal = acc_bal + amt;
                Console.WriteLine(acc_bal);
            }
            public void windrow()
            {
                Console.WriteLine(acc_bal);
                Console.WriteLine("What amt u remove");
                int amt = Convert.ToInt32( Console.ReadLine());
                acc_bal = acc_bal - amt;
                Console.WriteLine(acc_bal);
            }

            
        
    


        }
    }
}
