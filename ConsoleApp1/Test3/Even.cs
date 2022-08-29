using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Test3
{
    class Even
    {
        public bool isEeven(int n)
        {

            while (n > 0)
            {

                if (n % 2 == 0)
                    return true;
            }
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