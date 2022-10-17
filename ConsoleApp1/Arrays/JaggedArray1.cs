using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Arrays
{
    class JaggedArray1
    {
        static void Main(string[] args)
        {
            int[][] a = new int[2][];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                Console.WriteLine("Enter no of columnsin row" + i);
                int col = int.Parse(Console.ReadLine());
                a[i] = new int[col];
            }
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    a[i][j] = int.Parse(Console.ReadLine());
                }

            }
        
            for(int i=0;i<a.GetLength(0);i++)
            {
                for(int j=0;j<a[i].Length;j++)
                {
                    Console.WriteLine(a[i][j]+" ");
                    
                }
                Console.WriteLine();
            }
        }
       
    }
}
