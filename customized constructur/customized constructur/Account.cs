using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace customized_constructur
{
    public class Account
    {
        int AccountID;
        string AccountName;
        int AccountBalance;

        public Account(int _a, string _b, int _c)
        {
            AccountID = _a;
            AccountName = _b;
            AccountBalance = _c;
            Console.WriteLine("Account Object created");
        }
        public void printAccount()
        {
            Console.WriteLine("Account ID:  "+AccountID.ToString());
            Console.WriteLine("Account Name:  " + AccountName.ToString());
            Console.WriteLine("Account Balance:  " + AccountBalance.ToString());
        }
    }
    
}
