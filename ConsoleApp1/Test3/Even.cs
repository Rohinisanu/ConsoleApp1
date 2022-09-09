using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Test3
{
    class Even
    {
        public bool isEven(int n)
        {




            if (n % 2 == 0)
                return true;
            else
        
            return false;
        }

        static void Main(string[] args)
        {
            Even e = new Even();
            Console.WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());
            bool b= e.isEven(n);
            Console.WriteLine(b);
        }
    }

}