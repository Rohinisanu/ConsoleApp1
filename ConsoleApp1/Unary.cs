using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Unary
    {
        static void Main(string[] args)
        {
            int x = 4;
            Console.WriteLine(x++ + ++x - ++x + --x + x-- - x++ + x-- - x++ - --x + x++);
        }
    }
}
