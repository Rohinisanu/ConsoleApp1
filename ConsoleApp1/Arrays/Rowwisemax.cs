using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Arrays
{
    class Rowwisemax
    {
        static void Main(string[] args)
        {
            int[,] a = new int[3, 2];
            for (int r = 0; r < a.GetLength(0); r++)
            {
                for (int c = 0; c < a.GetLength(1); c++)
                {
                    a[r, c] = int.Parse(Console.ReadLine());
                }
            }
                    int max = a[0, 0];
                    for(int r=0;r<a.GetLength(0);r++)
                    {

                     for(int c=0;c<a.GetLength(1);c++)
                     {
                    if (a[r, c] > max)
                        max = a[r, c];

                     }
                    }
            Console.WriteLine("Maximum="+max);
            }

        }
    }

