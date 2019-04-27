using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace salary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Person's Salary:     ");
            double salary = Convert.ToDouble(Console.ReadLine());

            if (salary<15000)
            {
                Person obj = new Person();
                obj.a(salary);   
            }
            else if (salary >= 15000 || salary < 25000)
            {
                Person obj = new Person();
                obj.a(salary);   
            }
            else if (salary >= 25000 || salary < 35000)
            {
                Person obj = new Person();
                obj.c(salary);
            }
            else if (salary >= 35000)
            {
                Person obj = new Person();
                obj.d(salary);
            }


        }

    }
    class Person
    {
        public void a(double _salary)
        {
            double result = ((30 *_salary)/100);
            Console.WriteLine(result);
            Console.WriteLine("New Salary: {0} + {1} = {2}",result,_salary,result+_salary);
            Console.ReadLine();

        }
        public void b(double _salary)
        {
            double result = ((20 * _salary) / 100);
            Console.WriteLine(result);
            Console.WriteLine("New Salary: {0} + {1} = {2}", result, _salary, result + _salary);
            Console.ReadLine();
        }
        public void c(double _salary)
        {

            double result = ((10 * _salary) / 100);
            Console.WriteLine(result);
            Console.WriteLine("New Salary: {0} + {1} = {2}", result, _salary, result + _salary);
            Console.ReadLine();
        }
        public void d(double _salary)
        {

            double result = _salary;
            Console.WriteLine(result);
            Console.WriteLine("New Salary: {0} + {1} = {2}", result, _salary, result + _salary);
            Console.ReadLine();
        }
    }
}

