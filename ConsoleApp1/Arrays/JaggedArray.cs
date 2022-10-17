using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Arrays
{
    class JaggedArray
    {
        static void Main(string[] args)
        {
            int[][] a = new int[3][];
            a[0] = new int[2];
            a[1] = new int[3];
            a[2] = new int[4];
            Console.WriteLine(a[0].Length);
            Console.WriteLine(a[1].Length);
           for(int i=0;i<a.GetLength(0);i++)
            {
                for(int j=0;j<a[i].Length;j++)
                {
                    a[i][j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    Console.WriteLine(a[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
