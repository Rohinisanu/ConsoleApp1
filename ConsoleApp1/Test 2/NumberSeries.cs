using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Test_2
{
    class NumberSeries
    {
        static void Main(string[] args)
        {
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
            
            }
        }
    }

