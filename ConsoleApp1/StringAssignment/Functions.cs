using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.StringAssignment
{
    class Functions
    {
        static void Main(string[] args)
        {
            string s = "Sanvi Gite";
            int idx = s.IndexOf('a');
            int idx1 = s.LastIndexOf('a');
            int idx2 = s.IndexOf('a', 2);
            string t = s.Trim();
            string s1 = s.Substring(2);
            string s2 = s.Substring(1, 3);
            int i = 2;
            string s3 = s.Substring(0, i) + s.Substring(i + 1);
            Console.WriteLine(idx1);
            Console.WriteLine(idx);
            Console.WriteLine(idx2);
            Console.WriteLine(t);
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
        }

        
    }
    class Demo
    {
        static void Main(string[] args)
        {
            string s = "my name is Rohini";
            char[] a = s.ToCharArray();
            string[] sarr = s.Split();
            Console.WriteLine(a);
            Console.WriteLine(sarr);
        }
    }
}
