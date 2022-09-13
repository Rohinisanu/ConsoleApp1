using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Arrays
{
    class Arrayint
    {
        static void Main(string[] args)
        {
            int[] b = new int[5];
            Console.WriteLine("Enter 5 Elements");
            for(int i=0;i<5;i++)
            {
                b[i] = int.Parse(Console.ReadLine());
            }
            for(int i=0;i<5;i++)
            {
                Console.WriteLine(b[i]);
            }
        }
    }
    
}
