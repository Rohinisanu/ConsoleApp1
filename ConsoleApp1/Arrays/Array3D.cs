using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Arrays
{
    class Array3D
    {
        static void Main(string[] args)
        {
            int[,,] a = new int[3, 2, 2];
            for(int r=0;r<a.GetLength(0);r++)
            {
                for(int c=0;c<a.GetLength(1);c++)
                    for(int k=0;k<a.GetLength(2);k++)
                    {
                        a[r, c, k] = int.Parse(Console.ReadLine());

                    }

            }
            for(int r=0;r<a.GetLength(0);r++)
            {
                for(int c=0;c<a.GetLength(1);c++)
                    for(int k=0;k<a.GetLength(2);k++)
                    {
                        Console.Write(a[r, c,k] + " ");
                    }
                Console.WriteLine();
            }
        }
    }
}
