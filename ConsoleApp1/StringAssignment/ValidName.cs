using System;

namespace ConsoleApp1.StringAssignment
{
    class ValidName
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a name");
            string s = Console.ReadLine();
            bool isValid = true;
            foreach (char ch in s)
            {
                if (ch > 'A' && ch < 'Z' || ch > 'a' && ch < 'z')
                {
                    if (char.IsLetter(ch) == false)
                    {
                        isValid = false;
                        break;
                    }

                    if (isValid)
                    {
                        Console.WriteLine("Valid Name");
                    }
                    else
                    {
                        Console.WriteLine("Not valid");
                    }
                }
            }

        }
    }

}