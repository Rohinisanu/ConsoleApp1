using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class MaximumNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 3rd number");
            int num3 = int.Parse(Console.ReadLine());
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("Num1 is Greater");
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("Num2 is Greater");
            }
            else
            {
                Console.WriteLine("Num3 is Greater");
            }
            


        }
    }
}
