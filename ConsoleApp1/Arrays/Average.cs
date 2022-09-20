using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Arrays
{
    class Average
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size");
            int s = int.Parse(Console.ReadLine());
            int[] a = new int[s];
            Console.WriteLine("Enter the element of array");
            for (int i = 0; i < a.Length; i++) 
            {
                a[i] = int.Parse(Console.ReadLine());

            }
            int sum = 0;
            int avg = 0;
            for(int i=0;i<a.Length;i++)
            {
                sum = sum + a[i];
            }
            avg = sum / a.Length;
            Console.WriteLine("average of array element="+avg);
        }
    }
}
