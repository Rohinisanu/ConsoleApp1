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
            for(int i=0;i<a.Length;i++)
            {
                c[k] = a[i];
                k++;
                c[k] = b[i];
                k++;
            }
            for (int i = 0; i < c.Length; i++) ;
            //Console.WriteLine(c[i]);
        }
    }
    class AlternateLength
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4 };
            int[] b = { 5, 6, 7, 8, 9, 10 };
            int[] c = new int[a.Length + b.Length];
            int k = 0;
            for (int i = 0; i < c.Length;) 
            {
                if (k < a.Length && k < b.Length)
                {
                    c[i] = a[k];
                    i++;
                    c[i] = b[k];
                    i++;

                }
                else if (k < b.Length)
                {
                    c[i] = b[k];
                    i++;

                }
                else if (k < a.Length)
                {
                    c[i] = a[k];
                    i++;
                }
                k++;
            }
                for (int i = 0; i < c.Length; i++) 
            
                Console.WriteLine(c[i]);
            
        }

    }

}

