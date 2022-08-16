using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Switch
{
    class Evenodd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("1.Even\n 2.odd");
            Console.WriteLine("Enter a choice");
            int choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    if(num%2==0)
                    Console.WriteLine("even");
                    else
                        Console.WriteLine("odd");
                    break;
                case 2: Console.WriteLine("odd");
                    break;
                    
               
                  
                    
                    
                   
                   
                   
               
            }
        }
    }
}
