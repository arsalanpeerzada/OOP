using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace celsius_to_farhenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter C for Celsius & F for Farhenheit Temperature:  ");
            char input = Convert.ToChar(Console.ReadLine().ToLower());

            if (input=='c')
            {
                Console.Write("Input Celsius:     ");
                int C = Convert.ToInt32(Console.ReadLine());

                toCelsius obj = new toCelsius();
                obj.Celcius(C);   
            }
            else if(input=='f')
            {
                Console.Write("Input Farhenheit:   ");
                int F = Convert.ToInt32(Console.ReadLine());

                toFarhenheit obj=new toFarhenheit();
                obj.Farhenhiet(F);
            }
            
        }

        class toCelsius
        {
            public void Celcius(int _C)
            {
                int result = (_C * 9 / 5) + 32;
                Console.WriteLine(result+" C");

                Console.ReadLine();
            }
        }

        class toFarhenheit
        {
            public void Farhenhiet(int _F)
            {
                int result = (_F - 32) * 5 / 9;
                Console.WriteLine(result+" F");

                Console.ReadLine();
            }
        }
    }
}
