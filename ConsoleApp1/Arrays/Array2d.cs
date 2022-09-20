using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Arrays
{
    class Array2d
    {
        static void Main(string[] args)
        {
            int[,] a = new int[3, 2];
            for(int r=0;r<a.GetLength(0);r++)
            {
                Console.WriteLine("enter:"+a.GetLength(1)+"elements of row:"+r);
                for(int c=0;c<a.GetLength(1);c++)
                {
                    a[r, c] = int.Parse(Console.ReadLine());

                }
            }
            for (int r = 0; r < a.GetLength(0); r++)
            {
                for (int c = 0; c < a.GetLength(0); c++)
                {
                    Console.Write(a[r,c]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
