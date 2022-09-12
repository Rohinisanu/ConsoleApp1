using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Test5
{
    class Alphabet1
    {
        public void isCheck(char ch)
        {
         if(ch>='A' && ch<='Z')
            {
                Console.WriteLine("Uppercase Character");
            }
         else if(ch>='a'&& ch<='z')
            {
                Console.WriteLine("Lowercase Character");
            }
        }
        static void Main(string[] args)
        {
            Alphabet1 a1 = new Alphabet1();
            Console.WriteLine("Enter a Character");
            char ch = Convert.ToChar(Console.ReadLine());
            a1.isCheck(ch);

        }

    }
}
