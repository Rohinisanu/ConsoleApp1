using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Interview_Qusetions
{
    class ArithmeticProgression
    {
        public static void AP(int a,int d,int n)
        {
           
            for (int i = 1; i <= n; i++)
               
            
            a = a + d;
            Console.WriteLine(a);
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter nth term");
            int n = int.Parse(Console.ReadLine());
            AP(a,d,n);

        }
    }
    class AP
    {
       static public int ArithProgr(int a2, int a3, int n)
        {
            int d = a3 - a2;
            for (int i = 4; i < n; i++)
            {
                a3 = a3 + d;
            }
            return a3;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int a2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int a3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter nth term");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(ArithProgr(a2,a3,n));
        }

    }
}
