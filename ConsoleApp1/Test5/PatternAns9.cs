using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Test5
{
    class PatternAns9
    {
        static void Main(string[] args)
        {
            for(int r=1;r<=4;r++)
            {
                for (int c=1;c<=r;c++)
                    Console.Write(r);
                Console.WriteLine(" ");
            }
        }
    }
}
