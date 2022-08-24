using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Patterns
{
    class Number2
    {
        static void Main(string[] args)
        {
            int n = 5;
            for(int r=1;r<=n;r++)
            {
                for(int space=1;space<=n-r;space++)
                {
                    Console.Write(" ");
                }
                for (int c = 1; c <= r; c++)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
            }

        }
    }
}
