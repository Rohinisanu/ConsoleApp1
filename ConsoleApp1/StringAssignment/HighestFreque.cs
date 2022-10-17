﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.StringAssignment
{
    class HighestFreque
    {
        static bool isAlreadyPresent(string s, int current)
        {
            for (int i = 0; i < current; i++)
            {
                if (s[i] == s[current])
                    return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a name");
            string name = Console.ReadLine();
            int max = 0;
            char cmax=' ';
            for (int k = 0; k < name.Length; k++)
            {
                
                    if (isAlreadyPresent(name, k) == false)
                    {
                        int c = 0;
                        for (int j = 0; j < name.Length; j++)
                        {
                            if (name[k] == name[j])
                            {
                                c++;
                            }
                        }
                        if(max<c)
                        {
                            cmax = name[k];
                            max = c;
                        }
                        //Console.WriteLine("Frequency of" + name[k] + "is" + c);
                    }
                
            }
             Console.WriteLine("Highest frqcy character is " + cmax + " and count" + max);
        }

    }
}
