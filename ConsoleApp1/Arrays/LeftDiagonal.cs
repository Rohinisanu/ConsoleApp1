using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Arrays
{
    class LeftDiagonal
    {
        static void Main(string[] args)
        {
            int[,] a = new int[3, 3];
            for (int r = 0; r < a.GetLength(0); r++)
            {
                for (int c = 0; c < a.GetLength(1); c++)
                {
                    a[r, c] = int.Parse(Console.ReadLine());
                }
            }
           
            for (int r = 0; r < a.GetLength(0); r++)

                for (int c = 0; c < a.GetLength(1); c++)
                {
                    if (r==c)
                    {
                        Console.WriteLine(a[r,c]);
                    }
                    else

                        Console.WriteLine(" ");
                }
           
            Console.WriteLine();
        }
    }
}