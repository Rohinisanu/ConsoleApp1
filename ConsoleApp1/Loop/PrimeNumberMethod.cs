using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Loop
{
    class PrimeNumberMethod
    {
        public bool isPrime(int num)
        {
            for(int i=2;i<=num/2;i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            PrimeNumberMethod n = new PrimeNumberMethod();
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            bool b1 = n.isPrime(num);
            Console.WriteLine(b1);
        }
    }
}
