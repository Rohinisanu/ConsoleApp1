using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Test_4
{
    class BinaryN
    {
        public bool isBinary(int num)
        {
            int c = 0;
            while (num > 0)
            {
                int r = num % 10;
                c++;
                if (c % 2 == 1)
                {
                    if (r > 1)
                    {
                        return false;
                    }
                }
                num = num / 10;
            }
            return true;

        }
        static void Main(string[] args)
        {
            BinaryN b = new BinaryN();
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            bool res = b.isBinary(num);
            if (res)
            {
                Console.WriteLine("Binary number");
            }
            else
            {
                Console.WriteLine("Not binary");
            }
        }
    }
}
    

