using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Test_7
{
    class FirstNonrepeatedchar
    {
        public static char FirstNonrepeatedChar(string s)
        {
            bool isRepeated = false;
            char[] chars = s.ToCharArray();
            for(int i=0;i<chars.Length;i++)
            {
                isRepeated = false;
                for(int j=0;j<chars.Length;j++)
                {
                    if((i!=j)&&(chars[i]==chars[j]))
                    {
                        isRepeated = true;
                        break;
                    }
                }
                if(isRepeated==false)
                {
                    return chars[i];
                }
            }
            return ' ';
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence");
            string s = Console.ReadLine();
            for(int i=0;i<s.Length;i++)
            {
                Console.WriteLine(FirstNonrepeatedChar(s));
            }
        }
         
        
    }
}
