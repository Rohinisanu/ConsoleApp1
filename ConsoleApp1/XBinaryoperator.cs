using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class XBinaryoperator
    {
        static void Main(string[] args)
        {
            int a = 5, b = 4, c = 3;
            int x = a++ + b * ++c;
            int x1 = b * 5 / a + b++ + b;
             Console.WriteLine(x);
            Console.WriteLine("a=" +a +"b=" +b +"c="+c);
            Console.WriteLine(x1);
            Console.WriteLine("a=" +a +"b=" +b +"c="+c);
            

        }
    }
}
