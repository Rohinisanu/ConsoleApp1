using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Arrays
{
    class InsertElement
    {
        static void Main(string[] args)
        {
            int[] a = new int[20];
            Console.WriteLine("Enter the elements");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter size of an array");
            for(int i=0;i<s;i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter new data to be added");
            int data = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter position where data is to be insert");
            int pos = int.Parse(Console.ReadLine());
            if (pos > s)
                Console.WriteLine("Invalid Position");
            else if (pos == s)
                a[s] = data;
            else
            {
                int j = s - 1;
                while(j>=pos)
                {
                    a[j + 1] = a[j];
                    j--;


                }
                Console.WriteLine(a[pos]);
            }
        }

    }
}
