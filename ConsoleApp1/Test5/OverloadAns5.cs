using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Test5
{
    class OverloadAns5
    {
        void num_calc(int num, char ch)
        {
            int sum;
            if (ch == 's')
            {
                sum = num * num;
               


            }
            else
            {
                sum = num * num * num;
                

            }
            Console.WriteLine(sum);

        }
        void num_calc(int a, int b, char ch)
        {
            int sum;
            if (ch == 'p')
                sum = a * b;
            else
                sum = a + b;

            Console.WriteLine(sum);
        }
        static void Main(string[] args)
        {
            OverloadAns5 o1 = new OverloadAns5();
            o1.num_calc(12, 's');
            o1.num_calc(10, 20, 'p');
        }
    }
}
