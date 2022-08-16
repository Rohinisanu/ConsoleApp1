using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Float
    {
        static void Main(string[] args)
        {
            float a = 16.4f;
            int b = 12;
            float c;
            c = a * (b + a) / (a - b);
            Console.WriteLine("Result is="+c);
            Console.ReadLine();
        }
    }
}
