using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Test_2
{
    class Evenodd
    {
        static void Main(string[] args)
        {
            for (int i= 1;i<=50;i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                else if (i % 2 != 0)
                {
                    Console.WriteLine(i * i);
                }
            }
        }
    }
}
