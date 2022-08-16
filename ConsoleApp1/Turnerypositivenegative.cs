using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Turnerypositivenegative
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            string result = num > 0 ? "num is Positive" : "num is Negative";
            Console.WriteLine(result);
        }
    }
}
