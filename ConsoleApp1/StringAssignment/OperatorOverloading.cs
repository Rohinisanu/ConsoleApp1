using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.StringAssignment
{
    class OperatorOverloading
    {
        static void Main(string[] args)
        {
            string s = "Aarav";
            string s1 = "Aarav";
            Console.WriteLine(s==s1);
            Console.WriteLine(Object.ReferenceEquals(s,s1));
            string s3 = new string("Om");
            string s4 = new string("Om");
            Console.WriteLine(s3==s4);
            Console.WriteLine(Object.ReferenceEquals(s3,s4));
           





        }
    }
}
