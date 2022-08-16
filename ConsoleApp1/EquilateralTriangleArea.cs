using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class EquilateralTriangleArea
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a side value");
            float side = float.Parse(Console.ReadLine());
            float root= (float)Math.Sqrt(3) / 4;
            float area = root * side * side;
            Console.WriteLine("Area of Equilateral Triangle is=" +area);


        }
    }
}
