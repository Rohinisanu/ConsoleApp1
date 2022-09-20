using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Test_6
{
    class UniquePairSum
    {
        
        static void Main(string[] args)
        {
            int[] a = { 2, 4, 3, 5, 6, -2, 4, 7, 8, 9 };
            int sum = 7;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                    if (a[i] + a[j] == sum)
                    {
                       
                        Console.WriteLine(a[i]);
                    }
            }
         
        }
    }
}
