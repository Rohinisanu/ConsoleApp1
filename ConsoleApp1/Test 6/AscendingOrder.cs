using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Test_6
{
    class AscendingOrder
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 5, 6, 4, 3 };
            int j; int k;
            {
                for (int i = 0; i < a.Length - 1; i++)
                {
                    for (j = i + 1; j < a.Length; j++)
                    {
                        if (a[j] < a[i])
                        {
                            k = a[i];
                            a[i] = a[j];
                            a[j] = k;

                        }
                    }
                }
                for (int i = 0; i < a.Length; i++)

                    Console.WriteLine("Ascending Order=" + a[i]);
            }
        }
    }
}

