using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.StringAssignment
{
    class CountWord
    {
    
        public static int Countstring(string s, string s1)
        {
            int count = 0; int i = 0;
            while ((i = s.IndexOf("am", i)) != -1)
            {
                i = i + s1.Length;
                i++;
                count++;

            }
            return count;
        }
   

        static void Main(string[] args)
        {
            Console.WriteLine("enter string");
            string s2 = Console.ReadLine();
            Console.WriteLine(Countstring(s2, "am"));
        }
    }

}
