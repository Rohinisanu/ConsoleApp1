using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Arrays
{
    class CopyArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a size");
            int s = int.Parse(Console.ReadLine());
            int[] a = new int[s];
            int[] b = new int[s];
            Console.WriteLine("Enter elements of an array");
            for(int i=0;i<a.Length;i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            for(int i=0;i<b.Length;i++)
            {
                b[i] = a[i];
            }
            for(int i=0;i<a.Length;i++)
            {
                Console.WriteLine(a[i]);

            }
            for(int i=0;i<b.Length;i++)
            {
                Console.WriteLine(b[i]);
            }
            
        }
    }
}
