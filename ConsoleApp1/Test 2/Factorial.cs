using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Test_2
{
    class Factorial
    {
        static void Main(string[] args)
        {
            int fact=1;
            Console.WriteLine("Enter a number");
             int n=int.Parse(Console.ReadLine());
            for(int i=1;i<=n;i++)
            {
                fact = fact *i;
            }
            Console.WriteLine(fact);

        }
    }
}
