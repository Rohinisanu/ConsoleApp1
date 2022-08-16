using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class PositiveorNegative
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            if (num >= 0)
            {
                Console.WriteLine("Number is Positvive");
            }
            else
            {
                Console.WriteLine("Number is Negative");
            }
        }
    }
}
