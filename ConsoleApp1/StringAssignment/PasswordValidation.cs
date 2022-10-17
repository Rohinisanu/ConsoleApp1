using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.StringAssignment
{
    class PasswordValidation
    {
        static bool ValidatePassword(string s)
        {
            int count = 0;
            foreach (char ch in s)
            {
                if (ch >= 'a' && ch <= 'z')
                    count++;
                break;
            }
            foreach (char ch in s)
            {
                if (ch >= 'A' && ch <= 'Z')
                    count++;
            }


            string sp = "!@#$%^&*";
            foreach (char spe in sp)
            {
                if (s.IndexOf(sp) == -1)
                    return false;
            }
            return true;

        }
        static void Main(string[] args)
        {
            string s = "Abc23@yeu";
            for(int i=0;i<s.Length;i++)
            {
                bool b = ValidatePassword(s);
                
                  
                
            }
            
        }
    }
}
