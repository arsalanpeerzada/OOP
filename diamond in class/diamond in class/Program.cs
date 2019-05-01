using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace diamond_in_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number to make a Diamond:  ");
            int a = Convert.ToInt32(Console.ReadLine());

            Diamond latest = new Diamond();
            latest.diamond(a);

        }

        class Diamond
        {
            public void diamond(int numberOfRow)
            {

                int numberOfSpaces = numberOfRow - 1;
                int numberOfStars = numberOfRow - numberOfSpaces;

                for (int i = 0; i < numberOfRow; i++)
                {
                    for (int j = 0; j < numberOfSpaces; j++)
                    {
                        Console.Write(' ');
                    }
                    numberOfSpaces--;

                    for (int k = 0; k < numberOfStars; k++)
                    {
                        Console.Write('*');
                    }
                    numberOfStars = numberOfStars + 2;
                    Console.WriteLine();

                }
            }
        }
    }
}
