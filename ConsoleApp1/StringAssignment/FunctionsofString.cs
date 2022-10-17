using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.StringAssignment
{
    class FunctionsofString
    {
        static void Main(string[] args)
        {
            string s = "Sanvi";
            string s1 = s.ToUpper();
            string s2 = "Rohini".ToLower();
            Console.WriteLine(s);
                Console.WriteLine(s1) ;
            Console.WriteLine(s2);
            Console.WriteLine(s.Length);
            Console.WriteLine(s[0]);
            Console.WriteLine(s[1]);
            Console.WriteLine(s[3]);
        }
    }
}
