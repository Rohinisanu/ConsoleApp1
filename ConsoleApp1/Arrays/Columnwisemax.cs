using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Arrays
{
    class Columnwisemax
    {
        static void Main(string[] args)
        {
            int[,] a = new int[2, 3];
            for (int r = 0; r < a.GetLength(0); r++) 
            {
                for (int c = 0; c < a.GetLength(1); c++)
                {
                    a[r, c] = int.Parse(Console.ReadLine());

                }
            }
            for(int c=0;c<a.GetLength(1);c++)
            {
                int max = a[0, c];
                for(int r=0;r<a.GetLength(0);r++)
                {
                    if (max < a[r, c])
                        max = a[r, c];
                }
                Console.WriteLine("In column:"+c+"max="+max);
            }
        }
    }
}
