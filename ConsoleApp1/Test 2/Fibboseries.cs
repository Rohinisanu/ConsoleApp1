using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Test_2
{
    class Fibboseries
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 1, n3, i, num = 20;
            Console.WriteLine(n1+""+n2+"");
            for(i=2;i<num;i++)
            {
                n3 = n1 + n2;
                Console.WriteLine(n3+"");
                n1 = n2;
                n2 = n3;
               
            }
        }
    }
}
