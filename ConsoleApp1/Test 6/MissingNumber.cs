using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Test_6
{
    class MissingNumber
    {
       static int getMissingNo(int[]a,int n)
        {
            int total = (n + 1) * (n + 2) / 2;
            for (int i = 0; i < n; i++)
                total = total - a[i];
            return total;

        }
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 6, 7 };
            int N = 5;
            int miss = getMissingNo(a, N);
            Console.WriteLine("Missing Number:"+miss);

        }
    }
}
