using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.StringAssignment
{
    class Anagram1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 strings");
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            if(s1.Length==s2.Length)
            {
                foreach(char ch in s1)
                {
                    int idx = s2.IndexOf(ch);
                    if (idx != -1)
                        s2 = s2.Substring(0, idx) + s2.Substring(idx + 1);
                    Console.WriteLine(s2);
                }
                if(s2.Length==0)
                    Console.WriteLine("Anagram");
                else
                    Console.WriteLine("Not Anagram");
            }

        }
    }
}
