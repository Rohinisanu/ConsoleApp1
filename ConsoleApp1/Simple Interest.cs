using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Simple_Interest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Principal Amount");
            int P = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Time Period");
            int T = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Rate");
            int R= int.Parse(Console.ReadLine());
            int Interest = P * T * R / 100;
            Console.WriteLine("Simple Interest is=" +Interest);

            
        }
    }
}
