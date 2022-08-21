using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class MyPattern
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rows,columns");
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            for (int k = 1; k <= r; k++)
            {
                for (int i = 1; i <= c; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
