using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class NumberDivisibility
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int num = int.Parse(Console.ReadLine());
            if (num % 5 == 0)
            {
                Console.WriteLine("Number is divisible by 5");
            }
            else if (num % 11 == 0)
            {
                Console.WriteLine("Number is divisible by 11");
            }
            else
            {
                Console.WriteLine("Number is not divisible");
            }


        }
    }
}
