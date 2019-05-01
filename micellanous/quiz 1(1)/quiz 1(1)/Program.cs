using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace quiz_1_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to chk Even or Odd:   ");
            int input = Convert.ToInt32(Console.ReadLine());

            Quiz next = new Quiz();
            next.even_odd(input);
        }

        class Quiz
        {
            public void even_odd(int _input )
            {
                if (_input%2==0)
                {
                    Console.WriteLine("Number is Even ");
                }
                else if (_input%2!=0)
                {
                    Console.WriteLine("Number is Odd");
                }
            }
        }
    }
}
