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
            Class1 a = new Class1();
            a.mo();
            Console.ReadLine();
        }
    }
    class Class1
    {

       const float pi=3.14f;

       private float circumtences(float radius)
       {
           
           float circum = 2 * pi * (radius *radius);
           return circum;
        
       }

       public void mo()
       {
           float a;
           float radius;
           Console.WriteLine("input radius");
           radius=Convert.ToInt32(Console.ReadLine());

           Console.WriteLine(pi);
           a= circumtences(radius);


           
       }

    }
}
