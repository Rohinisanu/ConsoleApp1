using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Test3
{
    class Palindrome
    {
        public bool isPalindrome(int n)
        {
         
          int copynum = n;int sum = 0;
            while(n>0)
            {
               int r = n % 10;
                sum = (sum * 10) + r;
                n = n / 10;

            }
            if (copynum == sum)
                return true;
            else
                return false;
             }
      static void Main(string[] args)
        {
            Palindrome p = new Palindrome();
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            bool b = p.isPalindrome(num);
            Console.WriteLine(b);

        }
        }
    }

