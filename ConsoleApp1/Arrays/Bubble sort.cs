using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Arrays
{
    class Bubble_sort
    {
        static void Main(string[] args)
        {
            int[] a = { 10, 3, 45, 78, 34, 22, 88, 4 };
           
                
            for(int j=0;j<a.Length-1;j++)
            {
                if(a[j]>a[j+1])
                {
                    int t = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = t;
                }
            }
            for(int i=0;i<a.Length;i++)
            Console.WriteLine(a[i]+"");
            Console.WriteLine();
        }
    }
}
