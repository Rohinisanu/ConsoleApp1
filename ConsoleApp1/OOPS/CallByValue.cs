using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.OOPS
{
    class CallByValue
    {
        static public void m1(int a, int b)
        {
            int t = a;
            a = b;
            b = t;
        
        }
        static void Main(string[] args)
        {
            int x = 50;
            int y = 100;
            m1(x, y);
            Console.WriteLine($"x={x},y={y}");
        }
    }

}
class CallByReference
{
    static public void m1(ref int a,ref int b)
    {
        int t = a;
        a = b;
        b = t;
    }
    static void Main(string[] args)
    {
        int x = 90;
        int y = 200;
        m1(ref x, ref y);
        Console.WriteLine($"x={x}.y={y}");
        

    }
}
class Out
{
    static public void m2(int a,int b,out int sum,out int prod)
    {
        sum = a + b;
        prod = a * b;
    }
    static void Main(string[] args)
    {
        int x = 10, y = 20;
        int add, mul;
        m2(10, 20, out add ,out mul);
    }
}
