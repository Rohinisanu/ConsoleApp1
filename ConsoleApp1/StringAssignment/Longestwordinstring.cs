using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.StringAssignment
{
    class Longestwordinstring
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string s = Console.ReadLine();
            string[] a = s.Split();
            string smax = a[0];
            for(int i=1;i<a.Length;i++)
            {
                if(a[i].Length>smax.Length)
                {
                    smax = a[i];
                }
            }
            Console.WriteLine(smax);
        }
    }
}
