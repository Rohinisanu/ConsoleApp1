using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Arrays
{
    class PositionofNumber
    {
        static void Main(string[] args)
        {
            int[] a = { 23, 56, 78, 90, 44, 689 };
            Console.WriteLine("Enter the element to search");
            int search = int.Parse(Console.ReadLine());
            int pos = -1;
            for(int i=0;i<a.Length;i++)
            {
                if(a[i]==search)
                {
                    Console.WriteLine("Element present at position="+i);
                    pos = 1;
                }
            }
            if(pos==-1)
                Console.WriteLine("Element is not present");
                        
        }
    }
}
