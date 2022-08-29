using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Test3
{
    class Rectangle
    {
        int length, breadth, area, perimeter;
        void input()
        {
            Console.WriteLine("enter length,breadth");
            length = int.Parse(Console.ReadLine());
            breadth = int.Parse(Console.ReadLine());
        }
        void calculate()
        {
            area = length * breadth;
            perimeter = 2 * (length + breadth);
        }
        void dislpay()
        {
            Console.WriteLine("area=" + area + "perimeter=" + perimeter);
        }
    
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            r1.input();
            r1.calculate();
            r1.display();

        }
         
    }
}
