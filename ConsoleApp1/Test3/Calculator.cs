using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Test3
{
    class Calculator
    {
        int a, b, c;
        public void readdata()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
         }
        public int add()
        {
            c = a + b;
            return c;
        }
        public void sub()
        {
            c = b - a;
            Console.WriteLine("Subtraction="+c);
        }
        public int mul()
        {
            c = a * b;
            return c;
            
        }
         public void div()
        {
            c = a / b;
            Console.WriteLine("Division= +c");
        }
        static void Main(string[] args)
        {
            Calculator c1 = new Calculator();
            c1.readdata();
          int sum= c1.add();
            c1.sub();
          int mul=c1.mul();
            c1.div();
            Console.WriteLine(sum+" " +mul);
        }

    }
}
