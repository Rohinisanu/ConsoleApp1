﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class EvenorOdd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num =Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("Even Number");
            }
            else
            {
                Console.WriteLine("Odd Number");
            }

        }
    }
}
