using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Test3
{
    class PrimeNumber
    {
        public bool isPrime(int n)
        {
            for (int i = 2; i <= n / 2; i++)
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
            for(int j=2;j<=500;j++)
            {
                int c = 0;
                for(int k=1;k<=j;k++)
                {
                    if(j%k==0)
                    {
                        c++;
                    }
                }
                if(c==2)
                {
                    Console.WriteLine(j);
                }
            }
        }
        
    }

}
                   