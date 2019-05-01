using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace quiz_1_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Numbers to Get highest:   ");

            int length = Int32.Parse( Console.ReadLine());
            int[] input = new int[length];
            for (int i = 0; i < length; i++)
            {
                input[i] = Convert.ToInt32(Console.ReadLine());
            }

            Arsalan _max = new Arsalan();
            _max.max(input,length);
        }

        class Arsalan
        {
            
            public void max(int [] _input,int _length)
            {
                int result=0;
                for (int j = 0; j < _length-1; j++)
                {
                    if (_input[j]<_input[j+1])
                    {
                        result = _input[j+1 ];
                    }
                }
                Console.WriteLine(result);
            }
        }
    }
}
