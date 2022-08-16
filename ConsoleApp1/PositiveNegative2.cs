using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class PositiveNegative2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int a = int.Parse(Console.ReadLine());
            if (a > 0)
            {
                Console.WriteLine("Positive Number");
            }
            else if (a < 0)
            {
                Console.WriteLine("Negative");
            }
            else
            {
                Console.WriteLine("Zero");
            }
        }
    }
}
