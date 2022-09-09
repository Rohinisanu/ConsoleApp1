using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.OOPS
{


    interface Icecream
    {
        void eat();
    }
    interface Juice
    {
        void drink();

    }


    class Mastani : Icecream, Juice
    {
        public void eat()
        {
            Console.WriteLine("Eating Icecream");

        }
        public void drink()
        {
            Console.WriteLine("Drinking Juice");
        }
    }
    class Interface
    {
        static void Main(string[] args)
        {
            Icecream I = new Mastani();
            I.eat();
            Juice J = new Mastani();
            J.drink();
        }
    }
}

        
    

