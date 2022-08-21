using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Test_2
{
    class SpyNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int product = 1;
            while (n > 0)
            {
                int r = n % 10;
                sum = sum + r; 
                  n = n / 10;
                product = product * r;
              
            }
            if (sum == product)
            {
                Console.WriteLine("Spy Number");
            }
            else
            {
                Console.WriteLine("Not spy number");
            }
        }
    }
}