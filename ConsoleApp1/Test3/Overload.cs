using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Test3
{
    class Overload
    {
        void num_calc(int num,char ch)
        {
            int sum;
            if (ch == 's')
            {
                sum = num * num;
                Console.WriteLine("Square:"+sum);


            }
            else
            {
                sum = num * num * num;
                Console.WriteLine("Cube="+sum);
                 
            }
           
        }
        void num_calc(int a,int b,char ch)
        {
            int sum;
            if (ch == 'p')
                sum = a * b;
            else
                sum = a + b;


        }
        static void Main(string[] args)
        {
            Overload o1 = new Overload();
            o1.num_calc(12, 's');
            o1.num_calc(10, 20, 'p');
        }
    }
}
