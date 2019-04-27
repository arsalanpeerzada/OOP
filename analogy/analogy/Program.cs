using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace analogy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("           Anagrams");
            Console.Write("First Word:   ");
            string input = Console.ReadLine();
            Console.Write("Second Word:  ");
            string input2 = Console.ReadLine();

            Rock ic = new Rock();
            ic.anagram(input, input2);

        }

        class Rock
        {
            public void anagram(string _input,string _input2)
            {
                for (int i = 0; i < _input.Length; i++)
                {
                    for (int j = 0; j < _input2.Length; j++)
                    {
                        if (_input[i] == _input2[j])
                        {
                            Console.WriteLine("Anagram word #{0} = {1} ", i, _input[i]);

                        }
                    }
                }
            }
        }
    }
}
