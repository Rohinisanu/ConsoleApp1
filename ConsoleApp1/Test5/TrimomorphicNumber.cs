using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Test5
{
    class TrimomorphicNumber
    {
        public bool isTrimomorphic(int n)
        {
            int square = n * n;
            while (n > 0)
            {
                if (n % 10 != square % 10)
                {
                    return false;
                }
                else
                    n = n / 10;
                square = square / 10;
            }
            return true;
                

            }

        static void Main(string[] args)
        {
            TrimomorphicNumber T = new TrimomorphicNumber();
            Console.WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());
            bool b = T.isTrimomorphic(n);
            if (b)
            { 
            Console.WriteLine("Trimomorphic Number");
        }
            else
                Console.WriteLine("Not a Trimomorphic Number");
        }

    }
}
