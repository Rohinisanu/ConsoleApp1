using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Tunaryevenodd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            string result = num % 2 == 0 ? "num is even" : "num is odd";
            Console.WriteLine(result);
        }
    }
}
