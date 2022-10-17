using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Test_7
{
    class Series5times
    {
        static void Main(string[] args)
        {
            int a;
            for(int i=0;i<6;i++)
            {
                for(int j=0;j<=5;j++)
                {
                    a = j * j * j + j;
                    Console.WriteLine(a+"");
                }
                Console.WriteLine();
            }
        }
    }
}
