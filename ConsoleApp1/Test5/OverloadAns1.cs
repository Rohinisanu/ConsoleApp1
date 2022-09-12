using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Test5
{
    class OverloadAns1
    {
        public void Number(int num, int d)
        {
            int count = 0;

            while (num >= 0)
            {
                int x = num % 10;
                if (x == d)
                {
                    count++;
                }
                num = num / 10;
            }
            Console.WriteLine("Frequncy of digit=" + d + "=" + count);

        }

        public void Number(int n1)
        {
            int sum = 0;
            while (n1 >= 0)
            {
                int x = n1 % 10;
                if (x % 2 == 0)
                {
                    sum = sum + x;
                }
                Console.WriteLine(sum);
            }
        }
            static void Main(string[] args)
            {
                OverloadAns1 o1 = new OverloadAns1();
                o1.Number(2565685, 5);
                o1.Number(29865);
            }
        }
    }

