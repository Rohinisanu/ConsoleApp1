using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Loop
{
    class Magicnum
    {
        static void Main(string[] args)
        {
            int magicnum = 45;
            while(true)
            {
                Console.WriteLine("Enter a number");
                int num = int.Parse(Console.ReadLine());
                if(num>magicnum)
                {
                    Console.WriteLine("Number is greater try again.........");
                    continue;
                 }
                else if(num<magicnum)
                {
                    Console.WriteLine("Number is less try again............");
                    continue;
                }
                else
                {
                    Console.WriteLine("Guess number is correct.............");
                    break;
                }
            }
        }
    }
}
