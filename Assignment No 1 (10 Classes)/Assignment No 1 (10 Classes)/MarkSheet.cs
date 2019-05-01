using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_No_1__10_Classes_
{
    class MarkSheet
    {
        string Name;
        string UniversityName;
        int Sid;

        public void RES(string a, string b, int c)
        {
            Name = a;
            UniversityName = b;
            Sid = c;
            Console.WriteLine("NAME:" + Name + "\n" + "UNIVERSITY NAME:" + UniversityName + "\n" + "SID:" + Sid);

            Console.WriteLine("Enter The Marks Of Object Oriented Programming");
            int w = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Marks Of Programming Fundamental");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Marks Of Data Structure");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Marks Of Database Management System");
            int Z = Convert.ToInt32(Console.ReadLine());
            int A = w + x + y + Z;
            Console.WriteLine("your total marks is\n" + A);
            int B = (A * 100) / 400;
            Console.WriteLine("YOUR PERCENTAGE IS\n" + B);

            if (B < 60)
            {
                Console.WriteLine("YOUR GRADE IS FAIL");
            }
            else if (B >= 60 && B <= 66)
            {
                Console.WriteLine("YOUR GRADE IS C");
            }
            else if (B >= 67 && B <= 72)
            {
                Console.WriteLine("YOUR GRADE IS C+");
            }
            else if (B >= 73 && B <= 78)
            {
                Console.WriteLine("YOUR GRADE IS B");
            }
            else if (B >= 79 && B <= 82)
            {
                Console.WriteLine("YOUR GRADE IS B+");
            }
            else
            {
                Console.WriteLine("YOUR GRADE IS A");
            }
        }
    }
}
