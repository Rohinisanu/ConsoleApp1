using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Leapyear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a year");
            int y = int.Parse(Console.ReadLine());
            if (y % 4 == 0)
            {
                Console.WriteLine("Leap Year");
            }
            else
            {
                Console.WriteLine("Not a leap year");
            }
        }
    }
}
