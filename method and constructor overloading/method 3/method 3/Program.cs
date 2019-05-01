using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace method_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string set = Stringss.Word();
            string set1 = Stringss.Word("Hamas", "Sir Ayub");
            
        }

        class Stringss
        {
            public static string Word()
            {
                string name = "Arsalan";
                Console.WriteLine(name);
                return name;
 
            }
            public static string Word(string _a,string _b)
            {
                string _c = _a + _b;
                Console.WriteLine(_c);
                return _c;
                
            }
            
        }
    }

}
