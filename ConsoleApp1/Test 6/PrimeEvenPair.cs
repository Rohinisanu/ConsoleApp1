using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Test_6
{
    class PrimeEvenPair
    {
        static bool isPrime(int[] a, int n)
        {
            for (int i = 0; i < n/2; i++)
            {
                if (a[i] % i!= 0)
                    return true;
            }
            return false;
        }
        static bool isEven(int[] a, int n)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                    return true;

            }

            return false;
        }
        static void Main(string[] args)
        {

            int[] a = { 1, 5, 9, 7, 3, 6, 8, 13, 2, 4 };

            for (int i = 0; i < a.Length; i++)
            {
                if (isPrime(a, i) == false)
                {
                   
                    int c = 0;
                    for (int j = 0; j < a.Length; j++)
                    {
                        if (isEven(a, i) == false)
                        {
                            a[i] = a[j];
                            c++;
                        }
                    }
                    
                    Console.WriteLine(a[i]);
                }


            }

        }
    }
}

