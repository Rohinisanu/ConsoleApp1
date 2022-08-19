using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class TeenagerorNot
    {
        static void Main(string[] args)
        {
            int Age;
            Console.WriteLine("Enter a present year");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a birth year");
            int by = int.Parse(Console.ReadLine());
            Age = y - by;
            if(Age<=18)
            {
                Console.WriteLine("Teenager");
            }
            else
            {
                Console.WriteLine("Not Teenager");
            }

        }
    }
}
