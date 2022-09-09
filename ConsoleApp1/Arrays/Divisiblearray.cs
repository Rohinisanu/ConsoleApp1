using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Arrays
{
    class Divisiblearray
    {
        static void Main(string[] args)
        {
            int[] a = { 10, 20, 30, 50, 60 };

            for (int i = 0; i < a.Length; i++)
            {

                Console.WriteLine("Enter the elements");
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

