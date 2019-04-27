using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace quiz_1_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number to Choose Array Length:   ");
            int Length = Convert.ToInt32(Console.ReadLine());

            int [] theArray=new int [Length];
            Console.WriteLine("Enter Array Numbers:  ");
            for (int i = 0; i < Length; i++)
            {
                theArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            Bubble obj = new Bubble();
            obj.sort(theArray);
        }

        class Bubble
        {
            public void sort(int[] _arr)
            {
                int temp = 0;

                for (int write = 0; write < _arr.Length; write++)
                {
                    for (int sort = 0; sort < _arr.Length - 1 - write; sort++)
                    {
                        if (_arr[sort] > _arr[sort + 1])
                        {
                            temp = _arr[sort + 1];
                            _arr[sort + 1] = _arr[sort];
                            _arr[sort] = temp;
                        }
                    }
                }
                Console.Write("Sorted Array:  ");
                for (int i = 0; i < _arr.Length; i++)
                    Console.Write(_arr[i] + " ");
                
                Console.ReadLine();

                //return _arr [10];
            }
        }
    }
}
