using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Arrays
{
    class AlternateMerge
    {
        static void Main(string[] args)
        {
            int[] a = { 12, 4, 5, -5, 8, -12, 6, -9, 10 };

            int[] b = new int[a.Length];
            int p = 0, n = 0;
            int k = 0;
            while (k < a.Length)
            {
                while (p < a.Length && a[p] < 0)
                {
                    p++;
                }
                if (p < a.Length)
                {
                    b[k] = a[p];
                    k++;
                    p++;
                }
                while (n < a.Length && a[n] > 0)
                    n++;
                if (n < a.Length)
                {
                    b[k] = a[n];
                    k++;
                    n++;
                }
            }
            for (int i = 0; i < b.Length; i++)
                Console.WriteLine(b[i]);

        }

        }
    }
