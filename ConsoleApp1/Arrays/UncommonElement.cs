using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Arrays
{
    class UncommonElement
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 2, 1, 1 };
            int[] b = { 1, 6, 7, 8, 2, 4 };

            for (int i = 0; i < a.Length; i++)
            {
                int c = 0;
                for (int j = 0; j < b.Length; j++)
                {
                    if (a[i] == b[i])
                        c++;
                }
                if (c == 0)
                    Console.WriteLine(a[i]);
            }
            for (int i = 0; i < b.Length; i++)
            {
                int c = 0;
                for (int j = 0; j < a.Length; j++)
                {
                    if (a[j] == b[i])
                        c++;
                }
                if (c == 0)
                    Console.WriteLine(b[i]);
            }

        }

    }
}

