using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.StringAssignment
{
    class VowelsinString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a name");
            string s = Console.ReadLine();
            for(int i=0;i<s.Length;i++)
            {
                Console.WriteLine(s[i]);
            }
            for(int i=s.Length-1;i>=0;i--)
                { 
                Console.WriteLine(s[i]);
        }
        int v = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u')
                {
                    v++;

                }
                Console.WriteLine("Vowels in name=" + v);
        }   }
    }
}
