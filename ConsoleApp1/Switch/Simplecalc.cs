using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Switch
{
    class Simplecalc
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a first number");
            int num1= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a second number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("1.+ \n2. - \n3. * \n4. / ");
            Console.WriteLine("Enter above operator no");
            int op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    Console.WriteLine(num1 + num2);
                    break;
                case 2:
                    Console.WriteLine(num1 - num2);
                    break;
                case 3:
                    Console.WriteLine(num1 * num2);
                    break;
                case 4:
                    Console.WriteLine(num1 / num2);
                    break;

            }

               
               
        }
    }
}
