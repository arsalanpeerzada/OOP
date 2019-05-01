using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Name:  ");
            string input = Console.ReadLine();

            Console.Write("Enter Father Name:  ");
            string input2 = Console.ReadLine();
                
            Console.Write("Enter Age:  ");
            int input3 = Convert.ToInt32(Console.ReadLine());

            Quiz obj = new Quiz();

            obj.Question(input,input2,input3);
        }
    }

    class Quiz
    {
        string name ="Arsalan";
        string fatherName= "Sabir";
        int age=19;

        public void Question(string a, string b, int c)
        {
            if (name==a && fatherName==b && age== c)
            {
                Console.WriteLine("Ok! Welcome To NewWorld");
            }
            else
            {
                Console.WriteLine("Sorry!  Wrong Answer");
            }
        }
   
    }
}
