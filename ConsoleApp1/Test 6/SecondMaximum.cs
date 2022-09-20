using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Test_6
{
    class SecondMaximum
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 5, 8, 70, 64, 52, 78, 55};
            for (int i = 0; i < a.Length; i++)
            {
               
                Console.WriteLine(a[i] + "");
            }
            int max = int.MinValue;
            int secondmax = int.MinValue;
            for (int i = 0; i < a.Length; i++)
            {
                if (max < a[i])
                {
                    secondmax = max;
                    max = a[i];
                }
                else if (secondmax < a[i] && a[i] != 0)
                {
                    secondmax = a[i];

                }
                
            }
            Console.WriteLine(secondmax);
        }
    }
}

