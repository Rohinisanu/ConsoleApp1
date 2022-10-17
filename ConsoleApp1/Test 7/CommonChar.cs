using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Test_7
{
    class CommonChar
    {
     
        static void Main(string[] args)
        {
            string s1="thin sticks";
            string s2 = "thick bricks";
            s1 = s1.ToLower();
            s2 = s2.ToLower();
            StringBuilder sb = new StringBuilder();
            for(char ch='a';ch<'z';ch++)
            {
                if(s1.Contains(ch)&&s2.Contains(ch))
                {
                    sb.Append(ch);
                }
                Console.WriteLine(sb);
            }



        }


    }
}
    

