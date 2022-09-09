using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Test_4
{
    class TwinPrime
    {
        bool isPrime(int n)
        {
            int c = 0;
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % 10 == 0)
                {
                    c++;
                    break;
                }
            }
            if (c == 0)
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            TwinPrime t = new TwinPrime();
            Console.WriteLine("Enter a first number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a second number");
            int b = int.Parse(Console.ReadLine());
            bool b1 = t.isPrime(a);
            bool b2 = t.isPrime(b);
            if (b1 == true && b2 == true)
            {
                if (a - b == 2 || b - a == 2)
                {

                    Console.WriteLine(b1);
                    Console.WriteLine(b2);
                }

            }
        }
    }
}
