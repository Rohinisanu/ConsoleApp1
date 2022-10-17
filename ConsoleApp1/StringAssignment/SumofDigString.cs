using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.StringAssignment
{
    class SumofDigString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence");
            string s = Console.ReadLine();
            int sum = 0;
            for(int i=0;i<s.Length;i++)
            {
                if (s[i]>'0' && s[i]<'9')
                {

                    sum = sum + s[i]-48;
                }
        
            }
            Console.WriteLine(sum);
        }
    }
}
