using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class SumofArray2D
    {
        static void Main(string[] args)
        {
            int[,] a = new int[2, 2];
            for(int r=0;r<a.GetLength(0);r++)
            {
                for(int c=0;c<a.GetLength(1);c++)
                {
                    a[r, c] = int.Parse(Console.ReadLine());
                }
            }
            int sum = 0;
            for(int r=0;r<a.GetLength(0);r++)
            {
                for(int c=0;c<a.GetLength(1);c++)
                {
                    sum = sum+ a[r, c];
                }
            }
            Console.WriteLine("Sum="+sum);

        }
    }
}
