using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.OOPS
{
    class Overloading
    {
        
        public void area(int l,int w)
        {
            int a= l * w;
            Console.WriteLine("Area=" +a);
        }
        public void area(int s)
        {
           int a  = s * s;
            Console.WriteLine("Area of Square="+a);
        }
        public void area(float r)
        {
            float a = 3.14f* r * r;
            Console.WriteLine("Area of circle="+a);
        }
        static void Main(string[] args)
        {

            Overloading o1 = new Overloading();
            o1.area(3, 4);
            o1.area(4);
            o1.area(6.5f);

        }

        }
 
}
