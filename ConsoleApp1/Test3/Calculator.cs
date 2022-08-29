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
        public void add()
        {
            c = a + b;

        }
        public void sub()
        {
            c = b - a;
            Console.WriteLine("Subtraction="+c);
        }
        public void mul()
        {
            c = a * b;
            Console.WriteLine("Multiplication="+c);
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
            c1.add();
            c1.sub();
            c1.mul();
            c1.div();
            
        }

    }
}
