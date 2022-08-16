using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Percentage
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Math Marks");
            int M = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Physics Marks");
            int P = int.Parse(Console.ReadLine());
           Console.WriteLine("Enter the English Marks");
            int E = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Hindi Marks");
            int H = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Marathi Marks");
            int m = int.Parse(Console.ReadLine());
            int Percentage = (M + P + E + H + m) / 5;
            Console.WriteLine("Percentage of five subject marks is=" +Percentage);

        }
      
    }
}
