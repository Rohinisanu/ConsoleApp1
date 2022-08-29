using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Test3
{
    class PrimeNumber
    {
        public bool isPrime(int n)
        {
            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            PrimeNumber p = new PrimeNumber();
            Console.WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());
            bool b = p.isPrime(n);
            Console.WriteLine(b);
        }
    }
}
