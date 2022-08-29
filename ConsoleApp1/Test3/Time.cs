using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Test3
{
    class Time
    {
        int hour,min, sec;
        void set_time()
        {
            Console.WriteLine("Enter hour,min,sec");
            int hour = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            int sec = int.Parse(Console.ReadLine());
            
        }
        void show_time()
        {
            Console.WriteLine(hour+ ":"+min+ ":"+sec);
        }
        static void Main(string[] args)
        {
            Time t1 = new Time();
            t1.set_time();
            t1.show_time();
            

        }

    }
}
