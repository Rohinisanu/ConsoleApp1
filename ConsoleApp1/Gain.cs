using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Gain
    {
        static void Main(string[] args)
        {
            double b, s, g;
            b = 27.50;
            s = 28.60;
            g = s - b;
            Console.WriteLine("Gain is=" +g);
        }
    }
}
