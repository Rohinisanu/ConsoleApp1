using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Usernumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());
            if(n%5==0)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
        
    }
}
