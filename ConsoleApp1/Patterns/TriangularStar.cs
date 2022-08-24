using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Patterns
{
    class TriangularStar
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a lines");
            int lines = int.Parse(Console.ReadLine());
            for (int r = 1; r <= lines; r++)
            {
                for (int space = 1; space < lines - 1; space++)
                {
                    Console.Write(" ");
                }
                for (int c = 1; c <= 2 * r - 1; c++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();


            }

        }

        }
    }

