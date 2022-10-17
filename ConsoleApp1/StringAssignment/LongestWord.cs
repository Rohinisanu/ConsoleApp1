using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.StringAssignment
{
    class LongestWord
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence");
            string s1 = Console.ReadLine();
            string[] s2 = s1.Split();
            string word = "";
            int c = 0;
            foreach(String s in s2)
            {
                if(s.Length>c)
                {
                    word = s;
                    c = s.Length;
                }
            }
            Console.WriteLine(word);
          
            
        }
    }
}
