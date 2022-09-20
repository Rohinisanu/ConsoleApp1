using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Arrays
{
    class ClosestValue
    {
        static void Main(string[] args)
        {
            int[] a = { 23, 45, 2, 14, 10 };
            int nearest = 5;
            int min = int.MaxValue;
            for(int i=0;i<a.Length;i++)
            {
                if(Math.Abs(nearest-a[i])<Math.Abs(a[i]-min))
                {
                    min = a[i];
                }
            }
            Console.WriteLine("Nearest value="+min);
        }
    }
}
