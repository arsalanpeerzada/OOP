using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        static void Main(string[] args)
        {

            // Create a new Student object:
            Student s = new Student();

            // Setting code, name and the age of the student
            s.Code = "001";
            s.Name = "Zara";
            s.Age = 12;


            Console.WriteLine("Student Info: {0}", s.Age);
            //let us increase age
           // s.Age += 1;
          

           // Console.WriteLine("Student Info: {0}", s.return_values());

            Console.Read
        }


   public static void abc()
    {
        Console.WriteLine(  "asad");
    }
    }


    class Student
    {

        private string code = "N.A";
        private string name = "not known";
        private int age = 0;



   
        // Declare a Code property of type string:
        public string Code
        {
            get
            {

                return code;
            }
            set
            {
                code = value;
            }
        }

        // Declare a Name property of type string:
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        // Declare a Age property of type int:
        public int Age
        {
            get
            {


                Console.WriteLine("in get");
                if (age <= 10)
                    return age;
                return 0;
                
            }


            set
            {
                age = value;
            }
        }



        public  string return_values()
        {
            return "Code = " + Code + ", Name = " + Name + ", Age = " + Age;
        }


    }

}
