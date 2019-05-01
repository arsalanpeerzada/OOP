using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace constructor_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //This object creation would call the default constructor
            StudentData myobj = new StudentData(87);
            Console.WriteLine("Student Name is: " + myobj.getStuName());
            Console.WriteLine("Student Age is: " + myobj.getStuAge());
            Console.WriteLine("Student ID is: " + myobj.getStuID());


            /*This object creation would call the parameterized
             * constructor StudentData(int, String, int)*/
            StudentData myobj2 = new StudentData(7272, "Arsalan", 54);
            myobj2.print();

            int a = 6;
            int b = 8;

            StudentData.Addition(a, b);


        }
    }
}
