using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Swap
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int b = int.Parse(Console.ReadLine());
            a = a + b;
            b = a - b;
            a= a - b;
            Console.WriteLine("Swapping of two numbers=" +a+" +b+" +a );

        }
    }
}
