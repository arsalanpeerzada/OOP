using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace constructor_1
{
    public class StudentData
    {
        private int stuID;
        private string stuName;
        private int stuAge;

        public StudentData(int a)
        {
            //Default constructor
            stuID = 100;
            stuName = "New Student";
            stuAge = 18;
        }
        public StudentData(int num1, string str, int num2)
        {
            //Parameterized constructor
            stuID = num1;
            stuName = str;
            stuAge = num2;
        }

        public void print()
        {
            Console.WriteLine("Student ID:  "+stuID);
            Console.WriteLine("Student Name:  "+stuName);
            Console.WriteLine("Student Age:  "+stuAge);
 
        }

        //Getter and setter methods
        public int getStuID()
        {
            return stuID;
        }
        public void setStuID(int stuID)
        {
            this.stuID = stuID;
        }
        public string getStuName()
        {
            return stuName;
        }
        public void setStuName(string stuName)
        {
            this.stuName = stuName;
        }
        public int getStuAge()
        {
            return stuAge;
        }
        public void setStuAge(int stuAge)
        {
            this.stuAge = stuAge;
        }


        public static void Addition(int _a,int _b)
        {
            Console.WriteLine(_a+_b);
 
        }
    }

}

