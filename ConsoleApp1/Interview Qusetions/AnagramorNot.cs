using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Interview_Qusetions
{
    class AnagramorNot
    {
        public static string IsAnagram(string s1, string s2)
        {
            if (s1.Length == s2.Length)
            {
                foreach (Char ch in s1)
                {
                    int idx = s2.IndexOf(ch);
                    if (idx != -1)
                        s2 = s2.Substring(0, idx) + s2.Substring(idx + 1);
                  

                }
               
            }

            return s2;


        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a  1st word");
            string s1 = Console.ReadLine();
            Console.WriteLine("Enter a 2nd word");
            string s2 = Console.ReadLine();
            string s = IsAnagram(s1, s2);

            if (s.Length == 0)
            {
                Console.WriteLine("Anagram");
            }
            else
                Console.WriteLine("Not Anagram");





        }
    }
    class CoPrime1
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a = int.Parse(Console.ReadLine());
            int c = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0 && a % i == 0)
                {
                    Console.WriteLine(i);
                    c++;
                }


            }
            if (c == 1)
            {
                Console.WriteLine(c);
            }



        }
    }
    class Coprime
    {
       static  bool isCoPrime(int a, int b)
        {
            int gcd = 1;
            for (int i = 1; i < a && i < b; i++)
            {
                if (a % i == 0 && b % i == 0)
                    gcd = i;

            }
            if (gcd == 1)
                return true;
            else 
                return false;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());
            for(int i=1;i<n;i++)
            {
                if(isCoPrime(i,n))
                    Console.WriteLine("Coprime");
                else
                    Console.WriteLine("Not Coprime");
            }

        }

    }
}
    

