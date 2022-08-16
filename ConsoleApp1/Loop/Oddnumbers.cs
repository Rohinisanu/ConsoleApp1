using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Loop
{
    class Oddnumbers
    {
        static void Main(string[] args)
        {
            for(int i=15;i<=35;i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
                }
        }
    }
}
