using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Arrays
{
    class Count
    {
        static void Main(string[] args)
        {
            int[] b = new int[10];
            Console.WriteLine("Enter a elements");
            for(int i=0;i<10;i++)
            {
                b[i] = int.Parse(Console.ReadLine());
            }
            int e = 0;
            int o = 0;
            for (int i=0;i<10;i++)
            {
                if(b[i]%2==0)
                {
                    Console.WriteLine("Even no=" +b[i]);
                    e++;
                }
                else
                {
                    o++;
                }
            }
        }
    }
}
