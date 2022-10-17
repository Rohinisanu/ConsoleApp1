using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.StringAssignment
{
    class StringDemo
    {
        static void Main(string[] args)
        {
            string s = "Shanaya";
            s = s.Replace('a', 'b');
            s = s.Replace("a", "");
            string ss = "red apple red rose red water";
            ss = s.Replace("red", "blue");
            Console.WriteLine(s);
            Console.WriteLine(ss);
        }
    }
    class Anagram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two strings");
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            char[] c1 = s1.ToCharArray();
            char[] c2 = s2.ToCharArray();
            Array.Sort(c1);
            Array.Sort(c2);
            string s3 = new string(c1);
            string s4 = new string(c2);
            if (s3 == s4)
                Console.WriteLine("Its a Analgram");
            else
                Console.WriteLine("Not Analgram");
        }   
    }
}
