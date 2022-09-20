using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Arrays
{
    class Reverse
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            Console.WriteLine("Enter 10 elements");
            for(int i=0;i<10;i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            
            Console.WriteLine("Reverse");
            for(int i=9;i>=0;i--)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}
