using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Test_7
{
    class Wordfrequency
    {
        static bool Ispresent(int i, string nm, string[] s)
        {
            for (int j = 0; j < i; j++)
            {
                if (s[j] == nm)
                {
                    return true;

                }
            }
            return false;

        }


        static void CountWord(string str)
        {
            string[] a = str.Split(' ');
            for (int i = 0; i < a.Length; i++)
            {
                int c = 1;
                if (Ispresent(i, a[i], a) == false)
                {
                    for (int j = i + 1; j < a.Length; j++)
                    {
                        if (a[i] == a[j])
                            c++;

                    }
                    Console.WriteLine($"{a[i]}freq is: " + c);
                }

            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the sentence");
            string s = Console.ReadLine();
            CountWord(s);
        }
        
    }
    
}