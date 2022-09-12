using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Test5
{
    class Area
    {
        int s;
        int r;
        int w, l;
        double area1, area2, area3;
       public void input()
        {
            Console.WriteLine("Enter a side,radius,width,length");
            s = int.Parse(Console.ReadLine());
            r = int.Parse(Console.ReadLine());
            w = int.Parse(Console.ReadLine());
            l = int.Parse(Console.ReadLine());
           
        }
         public void calculate()
        {
            area1 = 3.14 * r * r;
            area2 = s * s;
            area3 = w * l;
            
        }
        public void display()
        {
            Console.WriteLine("Area of circle="+area1+"Area of square="+area2+"Area of rectangle="+area3);
        }
        static void Main(string[] args)
        {
            Area a = new Area();
            a.input();
            a.calculate();
            a.display();

        }
    }
}
