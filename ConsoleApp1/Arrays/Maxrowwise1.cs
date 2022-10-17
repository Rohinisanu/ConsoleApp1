using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Arrays
{
    class Maxrowwise1
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
            for(int r=0;r<a.GetLength(0);r++)
            {
                int max = a[r, 0];
                for(int c=0;c<a.GetLength(1);c++)
                {
                    if (a[r, c] > max)
                        max = a[r, c];

                }
                Console.WriteLine("on Row"+r+ "max="+max);
            }
        }
        
    }
}
