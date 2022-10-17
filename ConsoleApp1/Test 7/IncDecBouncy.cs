using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Test_7
{
    class IncDecBouncy
    {
       static public void isInc(int n)
        {
            int next = n % 10;int prev;
           bool isIncreasing = true;
            bool isDecreasing = true;
            while (n > 0)
            {
                prev = n % 10;
                if (prev < next)
                {
                    isDecreasing = false;
                }
                if (prev > next)
                    isIncreasing = false;

                next = prev;
                n = n / 10;
            }
            if(isIncreasing)
                Console.WriteLine("Increasing");
            else if(isDecreasing)
                Console.WriteLine("Decreasing");
            else
                Console.WriteLine("Bouncy");
         

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());
            isInc(n);
                 
         
        }

    }
}
