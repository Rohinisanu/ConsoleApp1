using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ThreeDigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            string num = (Console.ReadLine());
            if (num.Length >= 3)
                Console.WriteLine("Number is three digit");
            else
                Console.WriteLine("Number is not three digit");



        
        }
    }
}
