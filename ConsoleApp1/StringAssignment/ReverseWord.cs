using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.StringAssignment
{
    class ReverseWord
    {
        public static string Reverse(string s)
        {
            string reverse = " ";
            for(int i=s.Length-1;i>=0;i--)
            {
                reverse = reverse + s[i];

            }
            return reverse;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence");
            string s = Console.ReadLine();
            string[] a = s.Split();
            foreach(string word in a)
            {
                string r = Reverse(word);
                Console.Write(r+" ");
            }
        }
    }
}
