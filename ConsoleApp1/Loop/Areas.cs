using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Loop
{
    class Areas
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a side of triangle");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a side of square");
            int s1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter a radius of circle");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter width of rectangle");
            int w = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter length of rectangle");
            int l = int.Parse(Console.ReadLine());
            double area = 3.14 * r * r;
            double area1 = w * l;
            float area2 = (float)Math.Sqrt(3) / 4;
            double area3 = s1 * s1;
            char ch = 'y';
            do
            {
                Console.WriteLine("Enter a choice");
                Console.WriteLine("1.triangle area\n2. square area\n3. circle area\n4.rectangle area ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine(area);
                        break;
                    case 2:
                        Console.WriteLine(area1);
                        break;
                    case 3:
                        Console.WriteLine(area2);
                        break;
                    case 4:
                        Console.WriteLine(area3);
                        break;


                }
                Console.WriteLine("Do you want to continue..........");
                ch = Convert.ToChar(Console.ReadLine());
            } while (ch == 'y' || ch == 'Y');
            
}

    }
    }
    
    
