using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.OOPS
{
    class VarDynamic
    {
        const int n = 100;
        static void Main(string[] args)
        {
            var a = "200";
            a = "Rohini";
            Console.WriteLine(a);
            dynamic b;
            b = 10;
            b = 400;
            Console.WriteLine(b);
            const double pie = 3.14;
            Console.WriteLine(pie);
            Console.WriteLine(VarDynamic.n);

        }
    }
}
