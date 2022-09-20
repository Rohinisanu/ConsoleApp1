using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Arrays
{
    class Duplicate
    {
        static bool isAlreadyPresent(int[] a, int current)
        {
            for (int i = 0; i < current; i++)
            {
                if (a[i] == a[current])
                    return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 1, 1, 2, 8, 2, 3 };
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i] + "");
            Console.WriteLine();

            int duplicate = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (isAlreadyPresent(arr, i) == true)
                {
                    duplicate++;
                     Console.WriteLine(duplicate);
                }
            }
        }
    }
}
