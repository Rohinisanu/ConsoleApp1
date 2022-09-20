using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Arrays
{
    class Negativenumber
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            int neg = 0;
            for(int i=0;i<a.Length;i++)
            {
                if(a[i]<0)
                {
                    neg++;
                    Console.WriteLine(a[i]);
                }
            }
            Console.WriteLine("Count of negative number="+neg);
        }
    }
}
