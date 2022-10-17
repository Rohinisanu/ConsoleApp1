using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.StringAssignment
{
    class Palindrome
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name");
            string s = Console.ReadLine();
            string reverse = "";
            for(int i=s.Length-1;i>=0;i--)
            {
                reverse = reverse + s[i];
            }
            if (reverse==s)
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("Not Palindrome");
        }
    }
}
