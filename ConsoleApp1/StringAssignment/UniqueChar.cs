using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.StringAssignment
{
    class UniqueChar
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string s = Console.ReadLine();
            string s2 = "";
            foreach(char ch in s)
            {
                if (!s2.Contains(ch))
                    s2 = s2 + ch;

            }
            Console.WriteLine(s2);
        }
    }
}
