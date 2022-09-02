using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.OOPS
{
    class Staticdemo
    {
         int a=10;
        static int c = 20;
        
        public static void m1()
        {
            Console.WriteLine("in m1");
        }
        public static void m2()
        {
            Console.WriteLine("in static m2");
            Console.WriteLine(c);
        }
        public static void m3()
        {
            Console.WriteLine(c);
        }
    }
}
