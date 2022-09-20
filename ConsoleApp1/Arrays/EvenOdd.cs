using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Arrays
{
    class EvenOdd
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 4, 15, 18, 19, 21, 55, 44, 46 };
            int e = 0;
            int o = 0;
            int[] even = new int[e];
            int[] odd = new int[o];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                    e++;
                else
                    o++;
                e = 0; o = 0;
            }
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    even[e] = a[i];

                }
                else
                {
                    odd[o] = a[i];
                    Console.WriteLine(even[e]+""+odd[o]);
                }
            }
                
        }
    }
}
