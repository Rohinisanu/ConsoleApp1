using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.OOPS
{
    class Overriding
    {
        class Parent
        {
            public void m1()
            {
                Console.WriteLine("Call me");
            }
        }
        class Child:Parent
        {
            public  void m2()
            {
                Console.WriteLine("Call me");
            }
        }
        class Result
        {
            static void Main(string[] args)
            {
                Parent p1 = new Parent();
                p1.m1();
            }
           
           

        }
    }

}
