using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Loop
{
    class PrimeNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int num = int.Parse(Console.ReadLine());
            bool isPrime = true;
            {
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                    }
                }
                if (isPrime == true)
                {
                    Console.WriteLine("prime");

                }
                else
                {
                    Console.WriteLine("not prime");
                }
            }

        }
    }
}
