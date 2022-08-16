using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class AlphDigitSpch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a char");
            char ch = Convert.ToChar(Console.ReadLine());
            if (ch >= 'A' && ch <= 'Z')
            {
                Console.WriteLine("Alphabet");
            }
            else if (ch >= 'a' && ch <= 'z')
            {
                Console.WriteLine("Alphabet");
            }
            else if (ch >= '0' && ch <= '9')
            {
                Console.WriteLine("Digit");
            }
            else
            {
                Console.WriteLine("Symbol");
            }
        }
    }
}
