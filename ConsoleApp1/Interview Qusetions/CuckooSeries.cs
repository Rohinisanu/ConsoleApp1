using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Interview_Qusetions
{
    class CuckooSeries
    {
        static public int isCuckoo(int n)
        {
            int a = 0;int b = 1;
            for(int i=1;i<n;i++)
            {
                int c = 1 * b + 2 * a + 3;
                a = b;
                b = c;

            }
            return a;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter term");
            int term = int.Parse(Console.ReadLine());
            Console.WriteLine(isCuckoo(term));
        }
    }
}
