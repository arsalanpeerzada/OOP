using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace method_2
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public class MethodOverloadingDemo
        {

            public void getEmpName(int EmpId)
            {
                EmpId = 7272;
            }

            public void getEmpName(string EmpName)
            {
                EmpName = "Arsalan";
            }

            public void getEmpName(int empId, string empName)
            {
                empId = 7081;
                empName = "Hamas";
            }

            public void getEmpName(DateTime dob, string empName)
            {
                Console.WriteLine(dob);
                empName = "Arsalan";
            }
        }

    }
}
