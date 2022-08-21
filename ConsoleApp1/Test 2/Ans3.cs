using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Test_2
{
    class Ans3
    {
        static void Main(string[] args)
        {
            int i = 1; int k = 1;
            while(i++<=5)
            {
                k *= i;
            }
            Console.WriteLine("k=" +k+"i=" +i);
        }
    }
}
