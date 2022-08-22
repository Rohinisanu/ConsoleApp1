using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Patterns
{
    class Alphabet
    {
        static void Main(string[] args)
        {
            for(char r='E'; r>='A'; r--)
            {
                for (char c = 'A'; c <= r; c++)
                    Console.Write(c);
                Console.WriteLine();
            }
            
                
            
     }
    }
}
