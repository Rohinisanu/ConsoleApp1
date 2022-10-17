using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Interview_Qusetions
{
    class FibboneousSeries
    {
        static int fibbo(int n)
        {
            int a = 0;int b = 1; int sum = 0, c = 0;
            for(int i=1;i<=n;i++)
            {
                sum = a + b;
                c = a;
                a = b;
                b = sum;
            }
            return c;
          
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());
            int i = fibbo(n);
            Console.WriteLine(i);
        }
      
    }
}
