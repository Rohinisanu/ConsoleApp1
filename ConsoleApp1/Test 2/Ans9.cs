﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Test_2
{
    class Ans9
    {
        static void Main(string[] args)
        {
            for (int i = 5; i > 0; i--)
            {
                int mysteryInt = 100;
                mysteryInt -= i;
                Console.WriteLine(mysteryInt);
            }
            
        }
    }
}
