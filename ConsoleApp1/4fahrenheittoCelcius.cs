using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class _4fahrenheittoCelcius
    {
        static void Main(string[] args)
        {
           float f, c, k,C;
            f = 42;
            c = 32;
            k = 5 / 9.0f;
            C=(f-32)* k;
            Console.WriteLine("Fahrenheit to Celcius Conversion is=" +C);
        }
    }
}
