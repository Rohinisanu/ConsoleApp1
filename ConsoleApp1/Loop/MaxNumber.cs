using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Loop
{
    class MaxNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a nuber");
            int num = int.Parse(Console.ReadLine());
            int max = 0;
            while (num != 0)
            {
            
                int r = num % 10;
                if (max < r)
                {
                    max = r;
                }
                num = num / 10;

                }
            Console.WriteLine(max);
            }
            }
        }
    

