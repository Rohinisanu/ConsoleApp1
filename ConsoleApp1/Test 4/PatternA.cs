using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Test_4
{
    class PatternA
    {
        static void Main(string[] args)
        {
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % 2 == 1)
                        Console.WriteLine(j);
                    else
                        Console.Write((char)(64 + j));
                }
                Console.WriteLine();
                 }
            for (int i = 2; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                    if (i % 2 == 1)
                        Console.Write(j);
                    else
                        Console.Write((char)(64 + j));
            }
            Console.WriteLine();

        }
    }
}
