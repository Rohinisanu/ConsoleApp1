using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Loop
{
    class Simplecalc
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a fisrt number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a second number");
            int num2 = int.Parse(Console.ReadLine());
            char ch;
            do
            {
                Console.WriteLine("Enter a choice");
                Console.WriteLine("1.Addition\n2. Subtraction\n3. Multiplication\n4. Division");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Addition=" + (num1 + num2));
                        break;
                    case 2:
                        Console.WriteLine("Subtraction=" + (num1 - num2));
                        break;
                    case 3: Console.WriteLine("Multiplication=" + (num1 * num2));
                        break;
                    case 4:
                        Console.WriteLine("Division=" + (num1 % num2));
                        break;
                }
                Console.WriteLine("Do you want to continue............");
                ch = Convert.ToChar(Console.ReadLine());
            }
            while (ch == 'y' || ch == 'Y');
        }
            }
        }
    

