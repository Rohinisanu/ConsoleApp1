using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Arrays
{
    class Divisiblearray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a size");
            int s = int.Parse(Console.ReadLine());
            int[] a = new int[s];

            for (int i = 0; i < a.Length; i++)
            {

                
                a[i] = int.Parse(Console.ReadLine());

            }

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 5 == 0)
                {
                    a[i] = a[i] + 5;
                    Console.WriteLine("Divisible by 5" + a[i]);

                }
            }

        }
    }
}

