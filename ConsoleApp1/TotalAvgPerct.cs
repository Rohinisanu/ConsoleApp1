using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class TotalAvgPerct
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
            int total = (M + P + E + H + m);
            float avg = (M + P + E + H + m) / 5f;
            float Percentage = ((M + P + E + H + m) / 500f) * 100f;
            Console.WriteLine("Total Marks=" +total);
            Console.WriteLine("Average Marks=" +avg);
            Console.WriteLine("Percentage of five subject marks is=" + Percentage);
        }
    }
}
