using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Patterns
{ 

    class EPatterns
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    if (i == 1 || i == 5 || i == 10 || j == 1)

                        Console.Write("*");


                    else

                        Console.Write(" ");
                }
                Console.WriteLine();
                }
            }
        }
    }

