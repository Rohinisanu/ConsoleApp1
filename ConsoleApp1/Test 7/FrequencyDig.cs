using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Test_7
{
    class FrequencyDig
    {
        static int frequencyDig(long n, int d)
        {
            int c = 0;
            while(n>0)
            {
                int r = (int)n % 10;
                if (r == d)
                    c++;
                n = n / 10;
            }
            return c;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a mobile number");
            long mono = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter a digit");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine(frequencyDig(mono,d));
        }
    }
}
