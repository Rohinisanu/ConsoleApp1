using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Arrays
{
    class Alternate
    {
        static void Main(string[] args)
        {
            int[] a = { 4, 5, 6, 8, 9 };
            int[] b = { 5, 9, 8, 7, 6 };
            int[] c = { a.Length + b.Length };
            int k = 0;
            for(int i=0;i<c.Length;i++)
            {
                c[k] = a[i];
                k++;
                c[k] = b[i];
            }
        }
    }
}
