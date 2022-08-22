using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Patterns
{
    class Number
    {
        static void Main(string[] args)
        {
            for(int r=5;r>=1;r--)
            {
                for(int c=5;c>=r;c--)
                    Console.Write(r);
            }
            Console.WriteLine();
        }
    }
}
