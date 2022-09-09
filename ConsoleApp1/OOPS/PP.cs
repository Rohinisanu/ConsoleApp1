using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.OOPS
{
     class PP
    {
        public virtual void m1()
        {
            Console.WriteLine("Hello");
        }
    }
    class PC : PP
    {
     sealed public override void m1()
        {
            Console.WriteLine("Hello");
        }
    }
    class CC : PC
    {
        public void m2()
        {
            Console.WriteLine("Hello mam");
            
        }
    }
    class Test1
    {
        static void Main(string[] args)
        {
           CC c = new CC();
            c.m1();
            PP p = new CC();
            p.m1();
        }

    }
         
    }

