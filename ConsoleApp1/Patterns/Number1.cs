using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Patterns
{
    class Number1
    {
        static void Main(string[] args)
        {
            for (int r = 1; r <= 5; r++)
            {
                for (int c = 1; c <= r; c++)
                    Console.Write(c);
                Console.WriteLine();
            }
           
        }
    }
}
